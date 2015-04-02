<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Exitbottom = New System.Windows.Forms.Button()
        Me.Getcode = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Tapi = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.Plugpath = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.respath = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Apppath = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Tabout = New System.Windows.Forms.TabPage()
        Me.RichTextBox6 = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Thelp = New System.Windows.Forms.TabPage()
        Me.OpenWebQuestion = New System.Windows.Forms.Button()
        Me.con1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TTweak = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TweakRuntime = New System.Windows.Forms.Button()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.runtimechoose = New System.Windows.Forms.CheckedListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SSchoose = New System.Windows.Forms.CheckedListBox()
        Me.TweakSS = New System.Windows.Forms.Button()
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.otherchoose = New System.Windows.Forms.CheckedListBox()
        Me.TweakOther = New System.Windows.Forms.Button()
        Me.RichTextBox5 = New System.Windows.Forms.RichTextBox()
        Me.Tdiy = New System.Windows.Forms.TabPage()
        Me.MDiy = New System.Windows.Forms.TabControl()
        Me.Diy = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SaveDIYmain = New System.Windows.Forms.Button()
        Me.DiyChoose = New System.Windows.Forms.CheckedListBox()
        Me.DiyMenu = New System.Windows.Forms.TabPage()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.SaveDiymenu = New System.Windows.Forms.Button()
        Me.DiyChooseMenu = New System.Windows.Forms.CheckedListBox()
        Me.Thome = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bakreg = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CleanDetail = New System.Windows.Forms.CheckBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Sysinfo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckVersion = New System.Windows.Forms.Button()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.Tapi.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Tabout.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Thelp.SuspendLayout()
        Me.TTweak.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Tdiy.SuspendLayout()
        Me.MDiy.SuspendLayout()
        Me.Diy.SuspendLayout()
        Me.DiyMenu.SuspendLayout()
        Me.Thome.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "正在工作 - Windows Tweak"
        Me.NotifyIcon1.BalloonTipTitle = "欢迎 | Welcome"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "正在工作 - Windows Tweak"
        Me.NotifyIcon1.Visible = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Location = New System.Drawing.Point(0, -8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(582, 163)
        Me.Panel1.TabIndex = 0
        '
        'Exitbottom
        '
        Me.Exitbottom.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Exitbottom.Location = New System.Drawing.Point(449, 405)
        Me.Exitbottom.Name = "Exitbottom"
        Me.Exitbottom.Size = New System.Drawing.Size(129, 26)
        Me.Exitbottom.TabIndex = 5
        Me.Exitbottom.Text = "Exit | 退出"
        Me.Exitbottom.UseVisualStyleBackColor = True
        '
        'Getcode
        '
        Me.Getcode.Location = New System.Drawing.Point(4, 406)
        Me.Getcode.Name = "Getcode"
        Me.Getcode.Size = New System.Drawing.Size(187, 25)
        Me.Getcode.TabIndex = 6
        Me.Getcode.Text = "Get the code | 获取源码"
        Me.Getcode.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(308, 406)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(135, 25)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Extra | 附加功能"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "rar"
        Me.SaveFileDialog1.FileName = "Windows Tweak 7 VB.net 2010 源码"
        Me.SaveFileDialog1.Filter = "RAR 压缩文档|*.rar"
        Me.SaveFileDialog1.Title = "请选择源码保存位置"
        '
        'Tapi
        '
        Me.Tapi.Controls.Add(Me.GroupBox5)
        Me.Tapi.Controls.Add(Me.Plugpath)
        Me.Tapi.Controls.Add(Me.Label12)
        Me.Tapi.Controls.Add(Me.respath)
        Me.Tapi.Controls.Add(Me.Label11)
        Me.Tapi.Controls.Add(Me.Apppath)
        Me.Tapi.Controls.Add(Me.Label10)
        Me.Tapi.Location = New System.Drawing.Point(4, 29)
        Me.Tapi.Name = "Tapi"
        Me.Tapi.Padding = New System.Windows.Forms.Padding(3)
        Me.Tapi.Size = New System.Drawing.Size(570, 367)
        Me.Tapi.TabIndex = 5
        Me.Tapi.Text = "API"
        Me.Tapi.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.WebBrowser2)
        Me.GroupBox5.Location = New System.Drawing.Point(15, 87)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(555, 270)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "开发人员指南"
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser2.Location = New System.Drawing.Point(3, 23)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.Size = New System.Drawing.Size(549, 244)
        Me.WebBrowser2.TabIndex = 0
        Me.WebBrowser2.Url = New System.Uri("http://code.google.com/p/windows-tweak/wiki/DeveloerGuide?ts=1277964043&updated=D" & _
                "eveloerGuide", System.UriKind.Absolute)
        '
        'Plugpath
        '
        Me.Plugpath.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Plugpath.Location = New System.Drawing.Point(135, 58)
        Me.Plugpath.Name = "Plugpath"
        Me.Plugpath.ReadOnly = True
        Me.Plugpath.Size = New System.Drawing.Size(427, 20)
        Me.Plugpath.TabIndex = 9
        Me.Plugpath.Text = "Error while getting path."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 55)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 20)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "插件保存路径："
        '
        'respath
        '
        Me.respath.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.respath.Location = New System.Drawing.Point(135, 32)
        Me.respath.Name = "respath"
        Me.respath.ReadOnly = True
        Me.respath.Size = New System.Drawing.Size(427, 20)
        Me.respath.TabIndex = 7
        Me.respath.Text = "Error while getting path."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 20)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "资源保存路径："
        '
        'Apppath
        '
        Me.Apppath.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Apppath.Location = New System.Drawing.Point(135, 6)
        Me.Apppath.Name = "Apppath"
        Me.Apppath.ReadOnly = True
        Me.Apppath.Size = New System.Drawing.Size(427, 20)
        Me.Apppath.TabIndex = 5
        Me.Apppath.Text = "Error while getting path."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 20)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "程序运行路径："
        '
        'Tabout
        '
        Me.Tabout.Controls.Add(Me.RichTextBox6)
        Me.Tabout.Controls.Add(Me.PictureBox1)
        Me.Tabout.Location = New System.Drawing.Point(4, 29)
        Me.Tabout.Name = "Tabout"
        Me.Tabout.Padding = New System.Windows.Forms.Padding(3)
        Me.Tabout.Size = New System.Drawing.Size(570, 367)
        Me.Tabout.TabIndex = 4
        Me.Tabout.Text = "About | 关于"
        Me.Tabout.UseVisualStyleBackColor = True
        '
        'RichTextBox6
        '
        Me.RichTextBox6.AcceptsTab = True
        Me.RichTextBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RichTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RichTextBox6.Font = New System.Drawing.Font("微软雅黑", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RichTextBox6.Location = New System.Drawing.Point(116, 6)
        Me.RichTextBox6.Name = "RichTextBox6"
        Me.RichTextBox6.ReadOnly = True
        Me.RichTextBox6.Size = New System.Drawing.Size(448, 355)
        Me.RichTextBox6.TabIndex = 5
        Me.RichTextBox6.Text = resources.GetString("RichTextBox6.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Thelp
        '
        Me.Thelp.Controls.Add(Me.OpenWebQuestion)
        Me.Thelp.Controls.Add(Me.con1)
        Me.Thelp.Controls.Add(Me.Label4)
        Me.Thelp.Controls.Add(Me.ProgressBar1)
        Me.Thelp.Controls.Add(Me.WebBrowser1)
        Me.Thelp.Location = New System.Drawing.Point(4, 29)
        Me.Thelp.Name = "Thelp"
        Me.Thelp.Padding = New System.Windows.Forms.Padding(3)
        Me.Thelp.Size = New System.Drawing.Size(570, 367)
        Me.Thelp.TabIndex = 3
        Me.Thelp.Text = "Help | 帮助支持"
        Me.Thelp.UseVisualStyleBackColor = True
        '
        'OpenWebQuestion
        '
        Me.OpenWebQuestion.Location = New System.Drawing.Point(370, 338)
        Me.OpenWebQuestion.Name = "OpenWebQuestion"
        Me.OpenWebQuestion.Size = New System.Drawing.Size(201, 26)
        Me.OpenWebQuestion.TabIndex = 4
        Me.OpenWebQuestion.Text = "无法打开？Cannot open？"
        '
        'con1
        '
        Me.con1.AutoSize = True
        Me.con1.Location = New System.Drawing.Point(48, 341)
        Me.con1.Name = "con1"
        Me.con1.Size = New System.Drawing.Size(179, 20)
        Me.con1.TabIndex = 3
        Me.con1.Text = "Error while loading text"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-4, 341)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "状态："
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(239, 341)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(129, 22)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 1
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Top
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(564, 334)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("http://code.google.com/p/windows-tweak/", System.UriKind.Absolute)
        '
        'TTweak
        '
        Me.TTweak.Controls.Add(Me.TabControl1)
        Me.TTweak.Location = New System.Drawing.Point(4, 29)
        Me.TTweak.Name = "TTweak"
        Me.TTweak.Padding = New System.Windows.Forms.Padding(3)
        Me.TTweak.Size = New System.Drawing.Size(570, 367)
        Me.TTweak.TabIndex = 2
        Me.TTweak.Text = "Tweak | 优化"
        Me.TTweak.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(4, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(567, 362)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.TweakRuntime)
        Me.TabPage5.Controls.Add(Me.RichTextBox3)
        Me.TabPage5.Controls.Add(Me.runtimechoose)
        Me.TabPage5.Location = New System.Drawing.Point(4, 29)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(559, 329)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "系统运行速度 | Runtime"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TweakRuntime
        '
        Me.TweakRuntime.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.TweakRuntime.Image = CType(resources.GetObject("TweakRuntime.Image"), System.Drawing.Image)
        Me.TweakRuntime.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.TweakRuntime.Location = New System.Drawing.Point(388, 295)
        Me.TweakRuntime.Name = "TweakRuntime"
        Me.TweakRuntime.Size = New System.Drawing.Size(168, 31)
        Me.TweakRuntime.TabIndex = 5
        Me.TweakRuntime.Text = "Save | 应用更改"
        Me.TweakRuntime.UseVisualStyleBackColor = True
        '
        'RichTextBox3
        '
        Me.RichTextBox3.AcceptsTab = True
        Me.RichTextBox3.BackColor = System.Drawing.SystemColors.Info
        Me.RichTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RichTextBox3.Font = New System.Drawing.Font("微软雅黑", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RichTextBox3.Location = New System.Drawing.Point(340, 3)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.ReadOnly = True
        Me.RichTextBox3.Size = New System.Drawing.Size(216, 290)
        Me.RichTextBox3.TabIndex = 4
        Me.RichTextBox3.Text = resources.GetString("RichTextBox3.Text")
        '
        'runtimechoose
        '
        Me.runtimechoose.FormattingEnabled = True
        Me.runtimechoose.Items.AddRange(New Object() {"当资源管理器崩溃时则自动重启资源管理器", "总是从内存中卸载无用的动态链接", "禁止win7崩溃时系统自动重启", "自动关闭停止响应的程序"})
        Me.runtimechoose.Location = New System.Drawing.Point(4, 3)
        Me.runtimechoose.Name = "runtimechoose"
        Me.runtimechoose.Size = New System.Drawing.Size(330, 290)
        Me.runtimechoose.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SSchoose)
        Me.TabPage2.Controls.Add(Me.TweakSS)
        Me.TabPage2.Controls.Add(Me.RichTextBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(559, 329)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "开关机速度优化 | Shutdown and Start up"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SSchoose
        '
        Me.SSchoose.FormattingEnabled = True
        Me.SSchoose.Items.AddRange(New Object() {"加快关闭服务等待时间", "加快关闭程序等待时间", "加快结束出错程序等待时间", "关闭预读以减少开机进程条等待时间加快启动", "启动期间禁止更新组策略以加快启动", "设置开机菜单等待时间为3秒                               (×)", "将开机磁盘扫描等待时间设为2秒                        (×)", "禁止登录后创建成功登录报告功能"})
        Me.SSchoose.Location = New System.Drawing.Point(3, 3)
        Me.SSchoose.Name = "SSchoose"
        Me.SSchoose.Size = New System.Drawing.Size(331, 290)
        Me.SSchoose.TabIndex = 7
        '
        'TweakSS
        '
        Me.TweakSS.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.TweakSS.Image = CType(resources.GetObject("TweakSS.Image"), System.Drawing.Image)
        Me.TweakSS.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.TweakSS.Location = New System.Drawing.Point(388, 295)
        Me.TweakSS.Name = "TweakSS"
        Me.TweakSS.Size = New System.Drawing.Size(168, 31)
        Me.TweakSS.TabIndex = 6
        Me.TweakSS.Text = "Save | 应用更改"
        Me.TweakSS.UseVisualStyleBackColor = True
        '
        'RichTextBox4
        '
        Me.RichTextBox4.AcceptsTab = True
        Me.RichTextBox4.BackColor = System.Drawing.SystemColors.Info
        Me.RichTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RichTextBox4.Font = New System.Drawing.Font("微软雅黑", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RichTextBox4.Location = New System.Drawing.Point(340, 3)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.ReadOnly = True
        Me.RichTextBox4.Size = New System.Drawing.Size(216, 290)
        Me.RichTextBox4.TabIndex = 5
        Me.RichTextBox4.Text = resources.GetString("RichTextBox4.Text")
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.otherchoose)
        Me.TabPage1.Controls.Add(Me.TweakOther)
        Me.TabPage1.Controls.Add(Me.RichTextBox5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(559, 329)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "其他|Other"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'otherchoose
        '
        Me.otherchoose.FormattingEnabled = True
        Me.otherchoose.Items.AddRange(New Object() {"IE以5线程下载", "win7右键""管理员取得所有权""", "加快局域网访问速度", "加快开关机机速度,自动关闭停止响应", "加快开机速度副值", "加快程序运行速度", "加快菜单显示速度", "启用大系统缓存", "命令行窗口模式", "在文件夹上可清空回收站", "开启CPU(512k)二级缓存,加速系统核心处理进程", "清除内存内不被使用的DLL文件", "禁止远程修改注册表", "管理员身份运行", "设置处理器二级缓存容量", "调整桌面图标缓存", "进入win7后自动打开数字小键盘"})
        Me.otherchoose.Location = New System.Drawing.Point(1, 3)
        Me.otherchoose.Name = "otherchoose"
        Me.otherchoose.Size = New System.Drawing.Size(333, 290)
        Me.otherchoose.TabIndex = 8
        '
        'TweakOther
        '
        Me.TweakOther.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.TweakOther.Image = CType(resources.GetObject("TweakOther.Image"), System.Drawing.Image)
        Me.TweakOther.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.TweakOther.Location = New System.Drawing.Point(388, 295)
        Me.TweakOther.Name = "TweakOther"
        Me.TweakOther.Size = New System.Drawing.Size(168, 31)
        Me.TweakOther.TabIndex = 7
        Me.TweakOther.Text = "Save | 应用更改"
        Me.TweakOther.UseVisualStyleBackColor = True
        '
        'RichTextBox5
        '
        Me.RichTextBox5.AcceptsTab = True
        Me.RichTextBox5.BackColor = System.Drawing.SystemColors.Info
        Me.RichTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RichTextBox5.Font = New System.Drawing.Font("微软雅黑", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RichTextBox5.Location = New System.Drawing.Point(340, 3)
        Me.RichTextBox5.Name = "RichTextBox5"
        Me.RichTextBox5.ReadOnly = True
        Me.RichTextBox5.Size = New System.Drawing.Size(216, 290)
        Me.RichTextBox5.TabIndex = 6
        Me.RichTextBox5.Text = resources.GetString("RichTextBox5.Text")
        '
        'Tdiy
        '
        Me.Tdiy.Controls.Add(Me.MDiy)
        Me.Tdiy.Location = New System.Drawing.Point(4, 29)
        Me.Tdiy.Name = "Tdiy"
        Me.Tdiy.Padding = New System.Windows.Forms.Padding(3)
        Me.Tdiy.Size = New System.Drawing.Size(570, 367)
        Me.Tdiy.TabIndex = 1
        Me.Tdiy.Text = "DIY | 个性化"
        Me.Tdiy.UseVisualStyleBackColor = True
        '
        'MDiy
        '
        Me.MDiy.Controls.Add(Me.Diy)
        Me.MDiy.Controls.Add(Me.DiyMenu)
        Me.MDiy.Location = New System.Drawing.Point(3, 0)
        Me.MDiy.Name = "MDiy"
        Me.MDiy.SelectedIndex = 0
        Me.MDiy.Size = New System.Drawing.Size(564, 363)
        Me.MDiy.TabIndex = 0
        '
        'Diy
        '
        Me.Diy.Controls.Add(Me.RichTextBox1)
        Me.Diy.Controls.Add(Me.SaveDIYmain)
        Me.Diy.Controls.Add(Me.DiyChoose)
        Me.Diy.Location = New System.Drawing.Point(4, 29)
        Me.Diy.Name = "Diy"
        Me.Diy.Padding = New System.Windows.Forms.Padding(3)
        Me.Diy.Size = New System.Drawing.Size(556, 330)
        Me.Diy.TabIndex = 0
        Me.Diy.Text = "Main | 主要"
        Me.Diy.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.AcceptsTab = True
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RichTextBox1.Font = New System.Drawing.Font("微软雅黑", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(342, 6)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(216, 290)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'SaveDIYmain
        '
        Me.SaveDIYmain.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.SaveDIYmain.Image = CType(resources.GetObject("SaveDIYmain.Image"), System.Drawing.Image)
        Me.SaveDIYmain.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.SaveDIYmain.Location = New System.Drawing.Point(387, 297)
        Me.SaveDIYmain.Name = "SaveDIYmain"
        Me.SaveDIYmain.Size = New System.Drawing.Size(168, 33)
        Me.SaveDIYmain.TabIndex = 1
        Me.SaveDIYmain.Text = "Save | 应用更改"
        Me.SaveDIYmain.UseVisualStyleBackColor = True
        '
        'DiyChoose
        '
        Me.DiyChoose.FormattingEnabled = True
        Me.DiyChoose.Items.AddRange(New Object() {"IE8工具栏使用大（小）图标", "Search工具", "不在IE的新标签中打开链接窗口页面              （×）", "（不）显示""超级隐藏""文件", "（禁用）分组相似任务栏按钮", "加快菜单显示速度                                           （×）", "（显示）快捷方式字样", "启动时禁止运行欢迎中心                                （×）", "在IE的新标签中打开链接窗口页面", "在win7资源管理器中（不）显示菜单栏", "在桌面上显示IE图标 ", "在桌面上显示个人文件夹", "在桌面上显示回收站", "在桌面上显示控制面板", "在桌面上显示计算机", "（禁用）启用休眠", "恢复个人下载位置", "恢复开始菜单电源按纽为睡眠", "恢复快捷方式字样", "恢复我的图片位置", "恢复我的收藏夹", "恢复我的文档位置", "恢复菜单显示速度", "（禁用）视频预览", "把IE可同时下载数目增到10                       （×）", "搜索没有索引的位置时（不）包括系统文件和压缩文件", "（隐藏）IE8菜单栏", "显示运行", "检查更新但让我选择是否下载和安装", "设置开始菜单电源按纽为关机", "跳过IE8首次运行自定义设置                     （×）"})
        Me.DiyChoose.Location = New System.Drawing.Point(2, 6)
        Me.DiyChoose.Name = "DiyChoose"
        Me.DiyChoose.Size = New System.Drawing.Size(334, 290)
        Me.DiyChoose.TabIndex = 0
        '
        'DiyMenu
        '
        Me.DiyMenu.Controls.Add(Me.RichTextBox2)
        Me.DiyMenu.Controls.Add(Me.SaveDiymenu)
        Me.DiyMenu.Controls.Add(Me.DiyChooseMenu)
        Me.DiyMenu.Location = New System.Drawing.Point(4, 29)
        Me.DiyMenu.Name = "DiyMenu"
        Me.DiyMenu.Padding = New System.Windows.Forms.Padding(3)
        Me.DiyMenu.Size = New System.Drawing.Size(556, 330)
        Me.DiyMenu.TabIndex = 1
        Me.DiyMenu.Text = "Menu | 右键菜单"
        Me.DiyMenu.UseVisualStyleBackColor = True
        '
        'RichTextBox2
        '
        Me.RichTextBox2.AcceptsTab = True
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.Info
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RichTextBox2.Font = New System.Drawing.Font("微软雅黑", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(342, 6)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(216, 290)
        Me.RichTextBox2.TabIndex = 3
        Me.RichTextBox2.Text = resources.GetString("RichTextBox2.Text")
        '
        'SaveDiymenu
        '
        Me.SaveDiymenu.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.SaveDiymenu.Image = CType(resources.GetObject("SaveDiymenu.Image"), System.Drawing.Image)
        Me.SaveDiymenu.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.SaveDiymenu.Location = New System.Drawing.Point(387, 298)
        Me.SaveDiymenu.Name = "SaveDiymenu"
        Me.SaveDiymenu.Size = New System.Drawing.Size(168, 31)
        Me.SaveDiymenu.TabIndex = 2
        Me.SaveDiymenu.Text = "Save | 应用更改"
        Me.SaveDiymenu.UseVisualStyleBackColor = True
        '
        'DiyChooseMenu
        '
        Me.DiyChooseMenu.FormattingEnabled = True
        Me.DiyChooseMenu.Items.AddRange(New Object() {"DLL文件右键(反)注册菜单", "OCX文件右键(反)注册菜单", "管理员取得所有权菜单", "右键菜单中记事本打开项", "右键的复制到和移动到键", "在此处打开命令提示符", """服务""菜单", "在""计算机""处显示控制面板菜单"})
        Me.DiyChooseMenu.Location = New System.Drawing.Point(3, 6)
        Me.DiyChooseMenu.Name = "DiyChooseMenu"
        Me.DiyChooseMenu.Size = New System.Drawing.Size(333, 290)
        Me.DiyChooseMenu.TabIndex = 0
        '
        'Thome
        '
        Me.Thome.Controls.Add(Me.GroupBox1)
        Me.Thome.Controls.Add(Me.Sysinfo)
        Me.Thome.Controls.Add(Me.GroupBox2)
        Me.Thome.Controls.Add(Me.CheckVersion)
        Me.Thome.Location = New System.Drawing.Point(4, 29)
        Me.Thome.Name = "Thome"
        Me.Thome.Padding = New System.Windows.Forms.Padding(3)
        Me.Thome.Size = New System.Drawing.Size(570, 367)
        Me.Thome.TabIndex = 0
        Me.Thome.Text = "Home | 首页"
        Me.Thome.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(562, 210)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "常用"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.bakreg)
        Me.GroupBox4.Enabled = False
        Me.GroupBox4.Location = New System.Drawing.Point(8, 111)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(549, 93)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "备份和还原|Backup and Replace"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(312, 29)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "还原上一次的备份 | Replace latest backup"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(323, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(231, 20)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Please Check For New Version."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(323, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(159, 20)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "It's Now Unavailable."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(323, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(189, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "目前不可用，请检查更新。"
        '
        'bakreg
        '
        Me.bakreg.Location = New System.Drawing.Point(12, 26)
        Me.bakreg.Name = "bakreg"
        Me.bakreg.Size = New System.Drawing.Size(312, 29)
        Me.bakreg.TabIndex = 1
        Me.bakreg.Text = "备份当前的注册表 | Creat a Backup of Reg"
        Me.bakreg.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.CleanDetail)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(549, 81)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "清理系统使用痕迹/残留项 | Clean System"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(212, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Ctrl + C 可以终止操作"
        '
        'CleanDetail
        '
        Me.CleanDetail.AutoSize = True
        Me.CleanDetail.Location = New System.Drawing.Point(7, 52)
        Me.CleanDetail.Name = "CleanDetail"
        Me.CleanDetail.Size = New System.Drawing.Size(217, 24)
        Me.CleanDetail.TabIndex = 2
        Me.CleanDetail.Text = "显示详情 | Show the Detail"
        Me.CleanDetail.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button6.Location = New System.Drawing.Point(376, 46)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(167, 28)
        Me.Button6.TabIndex = 1
        Me.Button6.Text = "高级 | More Settings"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(7, 20)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(328, 27)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "一键清除所有的项目 | All Done By One Click"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Sysinfo
        '
        Me.Sysinfo.Location = New System.Drawing.Point(153, 335)
        Me.Sysinfo.Name = "Sysinfo"
        Me.Sysinfo.Size = New System.Drawing.Size(177, 25)
        Me.Sysinfo.TabIndex = 7
        Me.Sysinfo.Text = "Sysetm Info | 系统信息"
        Me.Sysinfo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(564, 107)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Welcome | 欢迎"
        Me.GroupBox2.UseCompatibleTextRendering = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(123, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(210, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "dows 7为基础架构的。"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(123, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(417, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "方便且安全的配置您的系统。这个版本是为Win-"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(110, 102)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AllowDrop = True
        Me.Label2.AutoEllipsis = True
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(128, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(400, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "    欢迎使用Windows Tweak 7。在这里您可以"
        Me.Label2.UseCompatibleTextRendering = True
        '
        'CheckVersion
        '
        Me.CheckVersion.Location = New System.Drawing.Point(336, 334)
        Me.CheckVersion.Name = "CheckVersion"
        Me.CheckVersion.Size = New System.Drawing.Size(226, 26)
        Me.CheckVersion.TabIndex = 6
        Me.CheckVersion.Text = "Check New Version |检查更新 "
        Me.CheckVersion.UseVisualStyleBackColor = True
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.Thome)
        Me.TabControl.Controls.Add(Me.Tdiy)
        Me.TabControl.Controls.Add(Me.TTweak)
        Me.TabControl.Controls.Add(Me.Thelp)
        Me.TabControl.Controls.Add(Me.Tabout)
        Me.TabControl.Controls.Add(Me.Tapi)
        Me.TabControl.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl.HotTrack = True
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.ShowToolTips = True
        Me.TabControl.Size = New System.Drawing.Size(578, 400)
        Me.TabControl.TabIndex = 4
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.CancelButton = Me.Exitbottom
        Me.ClientSize = New System.Drawing.Size(578, 438)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Getcode)
        Me.Controls.Add(Me.Exitbottom)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Home"
        Me.Text = "Windows Tweak 7"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Tapi.ResumeLayout(False)
        Me.Tapi.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.Tabout.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Thelp.ResumeLayout(False)
        Me.Thelp.PerformLayout()
        Me.TTweak.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Tdiy.ResumeLayout(False)
        Me.MDiy.ResumeLayout(False)
        Me.Diy.ResumeLayout(False)
        Me.DiyMenu.ResumeLayout(False)
        Me.Thome.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Exitbottom As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Getcode As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents Thome As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents bakreg As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CleanDetail As System.Windows.Forms.CheckBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Sysinfo As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckVersion As System.Windows.Forms.Button
    Friend WithEvents Tdiy As System.Windows.Forms.TabPage
    Friend WithEvents MDiy As System.Windows.Forms.TabControl
    Friend WithEvents Diy As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents SaveDIYmain As System.Windows.Forms.Button
    Friend WithEvents DiyChoose As System.Windows.Forms.CheckedListBox
    Friend WithEvents DiyMenu As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents SaveDiymenu As System.Windows.Forms.Button
    Friend WithEvents DiyChooseMenu As System.Windows.Forms.CheckedListBox
    Friend WithEvents TTweak As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Thelp As System.Windows.Forms.TabPage
    Friend WithEvents OpenWebQuestion As System.Windows.Forms.Button
    Friend WithEvents con1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Tabout As System.Windows.Forms.TabPage
    Friend WithEvents Tapi As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents respath As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Apppath As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Plugpath As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents WebBrowser2 As System.Windows.Forms.WebBrowser
    Friend WithEvents TweakRuntime As System.Windows.Forms.Button
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents runtimechoose As System.Windows.Forms.CheckedListBox
    Friend WithEvents SSchoose As System.Windows.Forms.CheckedListBox
    Friend WithEvents TweakSS As System.Windows.Forms.Button
    Friend WithEvents RichTextBox4 As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TweakOther As System.Windows.Forms.Button
    Friend WithEvents RichTextBox5 As System.Windows.Forms.RichTextBox
    Friend WithEvents otherchoose As System.Windows.Forms.CheckedListBox
    Friend WithEvents RichTextBox6 As System.Windows.Forms.RichTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
