Imports System.ComponentModel

Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bgwMain.RunWorkerAsync()
    End Sub

    Private Sub bgwMain_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwMain.DoWork

        Try
            bgwMain.ReportProgress(5)
            '检查注册表中保存的RuijieSupplicant.exe路径
            Dim strPath As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\CYROFORCE\MentoRUSH", "RJPath", "none")
            If Not strPath = "none" Then
                Debug.WriteLine($"[INFO] Registery item found. Path is set to {strPath}")
                '启动锐捷
                bgwMain.ReportProgress(15)
                Process.Start(strPath)
                '等待认证
                bgwMain.ReportProgress(20)
                Dim req As New Net.WebClient
                Dim Res As String = ""
                Do
                    Try
                        res = req.DownloadString("http://d.ralf.ren/resources/portal.php")
                    Catch ex As Exception
                        res = ""
                    End Try
                Loop Until res = "success"
                bgwMain.ReportProgress(60)
                '启动MentoHUST
                Process.Start(Application.StartupPath & "\MentoHUST.exe")
                '等待MentoHUST
                bgwMain.ReportProgress(70)
                Threading.Thread.Sleep(5000)
                '关闭锐捷
                bgwMain.ReportProgress(90)
                Dim pro8021x() As Process = Process.GetProcessesByName("8021x")
                pro8021x(0).Kill()
                bgwMain.ReportProgress(100)
                Exit Sub
            End If

            '检查8021x.exe
            Dim proRJ() As Process = Process.GetProcessesByName("8021x")
            If proRJ.Length = 1 Then
                '获取并保存RuijieSupplicant.exe路径
                strPath = proRJ(0).MainModule.FileName.Replace("8021x.exe", "RuijieSupplicant.exe")
                Debug.WriteLine($"[INFO] 8021x.exe found. Path seems to be {strPath}")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\CYROFORCE")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\CYROFORCE\MentoRUSH", "RJPath", strPath)
                '等待认证
                bgwMain.ReportProgress(20)
                Dim req As New Net.WebClient
                Dim Res As String = ""
                Do
                    Try
                        Res = req.DownloadString("http://d.ralf.ren/resources/portal.php")
                    Catch ex As Exception
                        Res = ""
                    End Try
                Loop Until Res = "success"
                bgwMain.ReportProgress(60)
                '启动MentoHUST
                Process.Start(Application.StartupPath & "\MentoHUST.exe")
                '等待MentoHUST
                bgwMain.ReportProgress(70)
                Threading.Thread.Sleep(5000)
                '关闭锐捷
                bgwMain.ReportProgress(90)
                proRJ(0).Kill()
                bgwMain.ReportProgress(100)
            ElseIf proRJ.Length = 0 Then
                '没有找到8021x.exe
                '检查默认安装目录
                If IO.File.Exists("C:\Program Files\锐捷网络\Ruijie Supplicant\RuijieSupplicant.exe") Then
                    strPath = "C:\Program Files\锐捷网络\Ruijie Supplicant\RuijieSupplicant.exe"
                    Debug.WriteLine("[INFO] Exists in default installation Folder")
                    My.Computer.Registry.CurrentUser.CreateSubKey("Software\CYROFORCE")
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\CYROFORCE\MentoRUSH", "RJPath", strPath)
                    '启动锐捷
                    bgwMain.ReportProgress(15)
                    Process.Start(strPath)
                    '等待认证
                    bgwMain.ReportProgress(20)
                    Dim req As New Net.WebClient
                    Dim Res As String = ""
                    Do
                        Try
                            Res = req.DownloadString("http://d.ralf.ren/resources/portal.php")
                        Catch ex As Exception
                            Res = ""
                        End Try
                    Loop Until Res = "success"
                    bgwMain.ReportProgress(60)
                    '启动MentoHUST
                    Process.Start(Application.StartupPath & "\MentoHUST.exe")
                    '等待MentoHUST
                    bgwMain.ReportProgress(70)
                    Threading.Thread.Sleep(5000)
                    '关闭锐捷
                    bgwMain.ReportProgress(90)
                    Dim pro8021x() As Process = Process.GetProcessesByName("8021x")
                    pro8021x(0).Kill()
                    bgwMain.ReportProgress(100)
                Else
                    bgwMain.ReportProgress(0)
                End If
            End If
        Catch ex As Exception
            bgwMain.ReportProgress(1, ex.Message)
        End Try



    End Sub

    Private Sub bgwMain_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgwMain.ProgressChanged
        Select Case e.ProgressPercentage
            Case 0
                Dim ofdMain As New OpenFileDialog
                With ofdMain
                    .Title = "定位到锐捷主程序的位置"
                    .Filter = "锐捷主程序|RuijieSupplicant.exe"
                End With
                If ofdMain.ShowDialog = DialogResult.OK Then
                    Dim strPath = ofdMain.FileName
                    Debug.WriteLine($"[INFO] Path is set to {strPath}")
                End If
                MessageBox.Show("已更新锐捷主程序位置。请重新启动本程序。", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End
            Case 1
                MessageBox.Show(e.UserState, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End
            Case 5
                proMain.Value = 5
                lblStatus.Text = "查找锐捷路径..."
            Case 15
                proMain.Value = 15
                lblStatus.Text = "启动锐捷..."
            Case 20
                proMain.Value = 20
                lblStatus.Text = "等待锐捷完成认证..."
            Case 60
                proMain.Value = 60
                lblStatus.Text = "启动 MentoHUST..."
            Case 70
                proMain.Value = 70
                lblStatus.Text = "等待 MentoHUST 完成认证..."
            Case 90
                proMain.Value = 90
                lblStatus.Text = "关闭锐捷..."
            Case 100
                proMain.Value = 100
                lblStatus.Text = "完成"
        End Select
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://ralf.ren/1523")
    End Sub
End Class