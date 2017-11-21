Imports System.ComponentModel

Public Class AutoForm

    Private Sub AutoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IO.File.Exists(Application.StartupPath & "\MentoRUSH.settings") Then
            GuideForm.Show()
            Me.Close()
        End If

        bgwMain.RunWorkerAsync()
    End Sub

    Private Sub bgwMain_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwMain.DoWork

        Dim pro8021x() As Process = Process.GetProcessesByName("8021x")
        If pro8021x.Length > 0 Then
            bgwMain.ReportProgress(0, "关闭 8021x.exe...")
            pro8021x(0).Kill()
        End If

        Dim proMento() As Process = Process.GetProcessesByName("MentoHUST")
        If proMento.Length > 0 Then
            bgwMain.ReportProgress(0, "关闭 MentoHUST.exe...")
            proMento(0).Kill()
        End If

        bgwMain.ReportProgress(1, "启动锐捷...")
        bgwMain.ReportProgress(2, 20)
        Dim strRJPath As String = INIGet("General", "RJPath", "", Application.StartupPath & "\MentoRUSH.settings")
        bgwMain.ReportProgress(0, $"锐捷主程序位置：{strRJPath}")
        bgwMain.ReportProgress(0, $"启动 RuijieSupplicant.exe...")
        Shell(strRJPath, AppWinStyle.MinimizedNoFocus, False)
        Threading.Thread.Sleep(3000)

        bgwMain.ReportProgress(1, "检测网络连接...")
        bgwMain.ReportProgress(2, 40)
        Dim req As New Net.WebClient
        Dim Res As String = ""
TestInternet:
        Try
            bgwMain.ReportProgress(0, "访问 http://d.ralf.ren/resources/portal.php...")
            Res = req.DownloadString("http://d.ralf.ren/resources/portal.php")
        Catch ex As Exception
            Res = ""
            bgwMain.ReportProgress(0, $"连线失败，将于三秒后重试：{ex.Message}")
            Threading.Thread.Sleep(3000)
        End Try
        If Not Res = "success" Then
            bgwMain.ReportProgress(0, $"得到了不正确的返回结果，将于三秒后重试。")
            Threading.Thread.Sleep(3000)
            GoTo TestInternet
        End If

        bgwMain.ReportProgress(0, "得到了正确的返回结果：success")
        bgwMain.ReportProgress(0, "已建立互联网连接。")

        bgwMain.ReportProgress(1, "启动 MentoHUST...")
        bgwMain.ReportProgress(2, 60)
        bgwMain.ReportProgress(0, "启动 MentoHUST.exe...")
        Shell(Application.StartupPath & "\Assets\MentoHUST.exe", AppWinStyle.MinimizedNoFocus, False)
        Threading.Thread.Sleep(2000)

        bgwMain.ReportProgress(1, "中止锐捷主进程...")
        bgwMain.ReportProgress(2, 90)
        bgwMain.ReportProgress(0, "关闭 8021x.exe...")
        Dim proRJ() As Process = Process.GetProcessesByName("8021x")
        If proRJ.Length > 0 Then
            proRJ(0).Kill()
        End If

        bgwMain.ReportProgress(1, "完成。")
        bgwMain.ReportProgress(2, 100)
        bgwMain.ReportProgress(0, "完成。")

    End Sub

    Private Sub bgwMain_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgwMain.ProgressChanged
        Select Case e.ProgressPercentage
            Case 0
                txtInfo.Text = txtInfo.Text & e.UserState & vbCrLf
            Case 1
                lblTitle.Text = e.UserState
            Case 2
                proMain.Value = e.UserState
        End Select
    End Sub
End Class