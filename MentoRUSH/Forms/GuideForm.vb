Imports System.Management

Public Class GuideForm

    Private Structure NetworkAdapterInfo
        Dim Description As String
        Dim SettingID As String
    End Structure
    Private i As Integer = 0
    Private adapters(i) As NetworkAdapterInfo

#Region "Path"

    Private Sub btnPathBrowse_Click(sender As Object, e As EventArgs) Handles btnPathBrowse.Click
        If ofdPathRJ.ShowDialog = DialogResult.OK Then
            txtPathRJ.Text = ofdPathRJ.FileName
            If IO.File.Exists(ofdPathRJ.FileName.Replace("RuijieSupplicant.exe", "8021x.exe")) Then
                lblPathFoundStatus.Text = "✔ 在指定的位置找到了锐捷。"
                btnNext1.Enabled = True
            Else
                lblPathFoundStatus.Text = "❌ 锐捷的必需文件若非遗失，则为失效。请重新安装。"
                btnNext1.Enabled = False
            End If
        End If
    End Sub

    Private Sub GuideForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnl1.Visible = True
        pnl2.Visible = False
        pnl3.Visible = False
        pnl1.Dock = DockStyle.Fill
        If Not IO.File.Exists("C:\Program Files\锐捷网络\Ruijie Supplicant\RuijieSupplicant.exe") Then
            lblPathFoundStatus.Text = "❌ 没有在默认安装位置找到锐捷。"
            txtPathRJ.Visible = True
            btnPathBrowse.Visible = True
        Else
            btnNext1.Enabled = True
        End If
    End Sub

    Private Sub btnNext1_Click(sender As Object, e As EventArgs) Handles btnNext1.Click
        INIWrite("General", "RJPath", txtPathRJ.Text, Application.StartupPath & "\MentoRUSH.settings")

        If Not IO.File.Exists(Environment.SystemDirectory.Replace("system32", "SysWOW64") & "\wpcap.dll") Then
            If Not IO.File.Exists(Environment.SystemDirectory & "\wpcap.dll") Then
                lblPcapStatus.Text = "❌ 未安装 WinPcap。"
                btnInstallPcap.Visible = True
                btnCheckInstallation.Visible = True
                lblPcapIntro.Visible = True
            Else
                btnNext2.Enabled = True
            End If
        Else
            btnNext2.Enabled = True
        End If
        pnl1.Visible = False
        pnl2.Visible = True
    End Sub

#End Region

#Region "Pcap"

    Private Sub btnInstallPcap_Click(sender As Object, e As EventArgs) Handles btnInstallPcap.Click
        Shell(Application.StartupPath & "\Assets\WinPcap.4.1.3.exe", AppWinStyle.NormalFocus, False)
    End Sub

    Private Sub btnCheckInstallation_Click(sender As Object, e As EventArgs) Handles btnCheckInstallation.Click
        If Not IO.File.Exists(Environment.SystemDirectory.Replace("system32", "SysWOW64") & "\wpcap.dll") Then
            If Not IO.File.Exists(Environment.SystemDirectory & "\wpcap.dll") Then
                lblPcapStatus.Text = "❌ 未安装 WinPcap。"
            Else
                lblPcapStatus.Text = "✔ 已安装 WinPcap。"
                btnNext2.Enabled = True
            End If
        Else
            lblPcapStatus.Text = "✔ 已安装 WinPcap。"
            btnNext2.Enabled = True
        End If
    End Sub

    Private Sub btnNext2_Click(sender As Object, e As EventArgs) Handles btnNext2.Click
        Dim Wmi As New ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration")
        For Each WmiObj As ManagementObject In Wmi.Get
            ReDim Preserve adapters(i + 1)
            adapters(i).Description = WmiObj("Description")
            adapters(i).SettingID = WmiObj("SettingID")
            cboNetworkAdapter.Items.Add(WmiObj("Description"))
            i += 1
        Next
        pnl2.Visible = False
        pnl3.Visible = True
    End Sub

#End Region

#Region "Account"

    Private Sub cboNetworkAdapter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNetworkAdapter.SelectedIndexChanged
        If cboNetworkAdapter.Text = "" Then
            btnNext3.Enabled = False
        Else
            If txtAccount.Text = "" Then
                btnNext3.Enabled = False
                Exit Sub
            End If
            btnNext3.Enabled = True
        End If
    End Sub

    Private Sub txtAccount_TextChanged(sender As Object, e As EventArgs) Handles txtAccount.TextChanged
        If txtAccount.Text = "" Then
            btnNext3.Enabled = False
        Else
            If cboNetworkAdapter.Text = "" Then
                btnNext3.Enabled = False
                Exit Sub
            End If
            btnNext3.Enabled = True
        End If
    End Sub

    Private Sub btnStartMento_Click(sender As Object, e As EventArgs) Handles btnStartMento.Click
        Dim sw As New IO.StreamWriter(Application.StartupPath & "\Assets\Config.ini", False, System.Text.Encoding.Default)
        sw.WriteLine("[Parameters]")
        sw.WriteLine("Caption=MentoHUST / XAUT")
        sw.WriteLine("LinkURL=https://ralf.ren/mentohust")
        sw.WriteLine("LinkTip=查看教程、更新与相关下载")
        sw.WriteLine("ClientType=0")
        sw.WriteLine("DefaultAccount=Account0")
        sw.WriteLine("AccountCount=1")
        sw.WriteLine($"DefaultAdapter=\Device\NPF_{adapters(cboNetworkAdapter.SelectedIndex).SettingID}")
        sw.WriteLine("[Account0]")
        sw.WriteLine($"Username={txtAccount.Text}")
        sw.WriteLine("Password=RhkCBxwS")
        sw.WriteLine("IP=0.0.0.0")
        sw.Close()
        sw.Dispose()
        Shell(Application.StartupPath & "\Assets\MentoHUST.exe", AppWinStyle.NormalFocus, False)
    End Sub

    Private Sub btnNext3_Click(sender As Object, e As EventArgs) Handles btnNext3.Click
        If IO.File.Exists(Application.StartupPath & "\Assets\Config.ini") Then
            INIWrite("Parameters", "CertFlag", "111110080300001", Application.StartupPath & "\Assets\Config.ini")
        Else
            Dim sw As New IO.StreamWriter(Application.StartupPath & "\Assets\Config.ini", False, System.Text.Encoding.Default)
            sw.WriteLine("[Parameters]")
            sw.WriteLine("Caption=MentoHUST / XAUT")
            sw.WriteLine("LinkURL=https://ralf.ren/mentohust")
            sw.WriteLine("LinkTip=查看教程、更新与相关下载")
            sw.WriteLine("ClientType=0")
            sw.WriteLine("CertFlag=111110080300001")
            sw.WriteLine("DefaultAccount=Account0")
            sw.WriteLine("AccountCount=1")
            sw.WriteLine($"DefaultAdapter=\Device\NPF_{adapters(cboNetworkAdapter.SelectedIndex).SettingID}")
            sw.WriteLine("[Account0]")
            sw.WriteLine($"Username={txtAccount.Text}")
            sw.WriteLine("Password=RhkCBxwS")
            sw.WriteLine("IP=0.0.0.0")
            sw.Close()
            sw.Dispose()
        End If
    End Sub


#End Region

End Class

'INIGet("General", "RJPath", "", Application.StartupPath & "\MentoRUSH.settings")
