<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuideForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GuideForm))
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.btnPathBrowse = New System.Windows.Forms.Button()
        Me.txtPathRJ = New System.Windows.Forms.TextBox()
        Me.btnNext1 = New System.Windows.Forms.Button()
        Me.lblPathFoundStatus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ofdPathRJ = New System.Windows.Forms.OpenFileDialog()
        Me.pnl2 = New System.Windows.Forms.Panel()
        Me.btnCheckInstallation = New System.Windows.Forms.Button()
        Me.lblPcapIntro = New System.Windows.Forms.Label()
        Me.btnInstallPcap = New System.Windows.Forms.Button()
        Me.btnNext2 = New System.Windows.Forms.Button()
        Me.lblPcapStatus = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnl3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAccount = New System.Windows.Forms.TextBox()
        Me.cboNetworkAdapter = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnStartMento = New System.Windows.Forms.Button()
        Me.btnNext3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnl1.SuspendLayout()
        Me.pnl2.SuspendLayout()
        Me.pnl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.Controls.Add(Me.btnPathBrowse)
        Me.pnl1.Controls.Add(Me.txtPathRJ)
        Me.pnl1.Controls.Add(Me.btnNext1)
        Me.pnl1.Controls.Add(Me.lblPathFoundStatus)
        Me.pnl1.Controls.Add(Me.Label1)
        Me.pnl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.pnl1.Location = New System.Drawing.Point(0, 0)
        Me.pnl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(682, 403)
        Me.pnl1.TabIndex = 1
        '
        'btnPathBrowse
        '
        Me.btnPathBrowse.Location = New System.Drawing.Point(487, 149)
        Me.btnPathBrowse.Name = "btnPathBrowse"
        Me.btnPathBrowse.Size = New System.Drawing.Size(75, 35)
        Me.btnPathBrowse.TabIndex = 5
        Me.btnPathBrowse.Text = "查找"
        Me.btnPathBrowse.UseVisualStyleBackColor = True
        Me.btnPathBrowse.Visible = False
        '
        'txtPathRJ
        '
        Me.txtPathRJ.BackColor = System.Drawing.Color.White
        Me.txtPathRJ.Location = New System.Drawing.Point(36, 153)
        Me.txtPathRJ.Name = "txtPathRJ"
        Me.txtPathRJ.ReadOnly = True
        Me.txtPathRJ.Size = New System.Drawing.Size(445, 27)
        Me.txtPathRJ.TabIndex = 4
        Me.txtPathRJ.Text = "C:\Program Files\锐捷网络\Ruijie Supplicant\RuijieSupplicant.exe"
        Me.txtPathRJ.Visible = False
        '
        'btnNext1
        '
        Me.btnNext1.Enabled = False
        Me.btnNext1.Location = New System.Drawing.Point(565, 325)
        Me.btnNext1.Name = "btnNext1"
        Me.btnNext1.Size = New System.Drawing.Size(79, 47)
        Me.btnNext1.TabIndex = 3
        Me.btnNext1.Text = "继续"
        Me.btnNext1.UseVisualStyleBackColor = True
        '
        'lblPathFoundStatus
        '
        Me.lblPathFoundStatus.AutoSize = True
        Me.lblPathFoundStatus.Location = New System.Drawing.Point(32, 125)
        Me.lblPathFoundStatus.Name = "lblPathFoundStatus"
        Me.lblPathFoundStatus.Size = New System.Drawing.Size(220, 20)
        Me.lblPathFoundStatus.TabIndex = 2
        Me.lblPathFoundStatus.Text = "✔ 在默认安装位置找到了锐捷。"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(515, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "让我们一步步来。首先，我们需要找到锐捷。"
        '
        'ofdPathRJ
        '
        Me.ofdPathRJ.FileName = "RuijieSupplicant.exe"
        Me.ofdPathRJ.Filter = "锐捷主程序|RuijieSupplicant.exe"
        '
        'pnl2
        '
        Me.pnl2.Controls.Add(Me.btnCheckInstallation)
        Me.pnl2.Controls.Add(Me.lblPcapIntro)
        Me.pnl2.Controls.Add(Me.btnInstallPcap)
        Me.pnl2.Controls.Add(Me.btnNext2)
        Me.pnl2.Controls.Add(Me.lblPcapStatus)
        Me.pnl2.Controls.Add(Me.Label2)
        Me.pnl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl2.Location = New System.Drawing.Point(0, 0)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(682, 403)
        Me.pnl2.TabIndex = 5
        '
        'btnCheckInstallation
        '
        Me.btnCheckInstallation.Location = New System.Drawing.Point(190, 169)
        Me.btnCheckInstallation.Name = "btnCheckInstallation"
        Me.btnCheckInstallation.Size = New System.Drawing.Size(148, 38)
        Me.btnCheckInstallation.TabIndex = 10
        Me.btnCheckInstallation.Text = "刷新安装状态"
        Me.btnCheckInstallation.UseVisualStyleBackColor = True
        Me.btnCheckInstallation.Visible = False
        '
        'lblPcapIntro
        '
        Me.lblPcapIntro.AutoSize = True
        Me.lblPcapIntro.Location = New System.Drawing.Point(36, 214)
        Me.lblPcapIntro.Name = "lblPcapIntro"
        Me.lblPcapIntro.Size = New System.Drawing.Size(316, 20)
        Me.lblPcapIntro.TabIndex = 9
        Me.lblPcapIntro.Text = "WinPcap 用于建立网络隧道，是认证的必需。"
        Me.lblPcapIntro.Visible = False
        '
        'btnInstallPcap
        '
        Me.btnInstallPcap.Location = New System.Drawing.Point(36, 169)
        Me.btnInstallPcap.Name = "btnInstallPcap"
        Me.btnInstallPcap.Size = New System.Drawing.Size(148, 38)
        Me.btnInstallPcap.TabIndex = 8
        Me.btnInstallPcap.Text = "安装 WinPcap"
        Me.btnInstallPcap.UseVisualStyleBackColor = True
        Me.btnInstallPcap.Visible = False
        '
        'btnNext2
        '
        Me.btnNext2.Enabled = False
        Me.btnNext2.Location = New System.Drawing.Point(565, 325)
        Me.btnNext2.Name = "btnNext2"
        Me.btnNext2.Size = New System.Drawing.Size(79, 47)
        Me.btnNext2.TabIndex = 7
        Me.btnNext2.Text = "继续"
        Me.btnNext2.UseVisualStyleBackColor = True
        '
        'lblPcapStatus
        '
        Me.lblPcapStatus.AutoSize = True
        Me.lblPcapStatus.Location = New System.Drawing.Point(32, 125)
        Me.lblPcapStatus.Name = "lblPcapStatus"
        Me.lblPcapStatus.Size = New System.Drawing.Size(152, 20)
        Me.lblPcapStatus.TabIndex = 6
        Me.lblPcapStatus.Text = "✔ 已安装 WinPcap。"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(515, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "接下来，看看这台电脑有没有安装必需软件。"
        '
        'pnl3
        '
        Me.pnl3.Controls.Add(Me.Label6)
        Me.pnl3.Controls.Add(Me.txtAccount)
        Me.pnl3.Controls.Add(Me.cboNetworkAdapter)
        Me.pnl3.Controls.Add(Me.Label3)
        Me.pnl3.Controls.Add(Me.btnStartMento)
        Me.pnl3.Controls.Add(Me.btnNext3)
        Me.pnl3.Controls.Add(Me.Label4)
        Me.pnl3.Controls.Add(Me.Label5)
        Me.pnl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl3.Location = New System.Drawing.Point(0, 0)
        Me.pnl3.Name = "pnl3"
        Me.pnl3.Size = New System.Drawing.Size(682, 403)
        Me.pnl3.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(397, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "若认证密码不是 888888，请启动MentoHUST手动设定："
        '
        'txtAccount
        '
        Me.txtAccount.Location = New System.Drawing.Point(167, 165)
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.Size = New System.Drawing.Size(390, 27)
        Me.txtAccount.TabIndex = 12
        '
        'cboNetworkAdapter
        '
        Me.cboNetworkAdapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNetworkAdapter.FormattingEnabled = True
        Me.cboNetworkAdapter.Location = New System.Drawing.Point(167, 122)
        Me.cboNetworkAdapter.Name = "cboNetworkAdapter"
        Me.cboNetworkAdapter.Size = New System.Drawing.Size(390, 28)
        Me.cboNetworkAdapter.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "认证用户名："
        '
        'btnStartMento
        '
        Me.btnStartMento.Location = New System.Drawing.Point(36, 246)
        Me.btnStartMento.Name = "btnStartMento"
        Me.btnStartMento.Size = New System.Drawing.Size(148, 38)
        Me.btnStartMento.TabIndex = 8
        Me.btnStartMento.Text = "启动 MentoHUST"
        Me.btnStartMento.UseVisualStyleBackColor = True
        '
        'btnNext3
        '
        Me.btnNext3.Enabled = False
        Me.btnNext3.Location = New System.Drawing.Point(565, 325)
        Me.btnNext3.Name = "btnNext3"
        Me.btnNext3.Size = New System.Drawing.Size(79, 47)
        Me.btnNext3.TabIndex = 7
        Me.btnNext3.Text = "完成"
        Me.btnNext3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "选择认证用网卡："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(290, 32)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "是时候提供认证信息了。"
        '
        'GuideForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(682, 403)
        Me.Controls.Add(Me.pnl3)
        Me.Controls.Add(Me.pnl2)
        Me.Controls.Add(Me.pnl1)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(700, 450)
        Me.MinimumSize = New System.Drawing.Size(700, 450)
        Me.Name = "GuideForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MentoRUSH - 设定精灵"
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.pnl2.ResumeLayout(False)
        Me.pnl2.PerformLayout()
        Me.pnl3.ResumeLayout(False)
        Me.pnl3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNext1 As Button
    Friend WithEvents lblPathFoundStatus As Label
    Friend WithEvents txtPathRJ As TextBox
    Friend WithEvents btnPathBrowse As Button
    Friend WithEvents ofdPathRJ As OpenFileDialog
    Friend WithEvents pnl2 As Panel
    Friend WithEvents btnCheckInstallation As Button
    Friend WithEvents lblPcapIntro As Label
    Friend WithEvents btnInstallPcap As Button
    Friend WithEvents btnNext2 As Button
    Friend WithEvents lblPcapStatus As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnl3 As Panel
    Friend WithEvents txtAccount As TextBox
    Friend WithEvents cboNetworkAdapter As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnStartMento As Button
    Friend WithEvents btnNext3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
