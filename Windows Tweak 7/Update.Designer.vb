<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fUpdate))
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Addressbox = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Go = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Con = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 56)
        Me.WebBrowser1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(22, 27)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1035, 669)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("http://code.google.com/p/windows-tweak/updates/list", System.UriKind.Absolute)
        '
        'Addressbox
        '
        Me.Addressbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Addressbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Addressbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Addressbox.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Addressbox.Items.AddRange(New Object() {"http://code.google.com/p/windows-tweak/updates/list", "http://code.google.com/p/windows-tweak/wiki/WindowsTweak7Updates"})
        Me.Addressbox.Location = New System.Drawing.Point(71, 17)
        Me.Addressbox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Addressbox.Name = "Addressbox"
        Me.Addressbox.Size = New System.Drawing.Size(847, 28)
        Me.Addressbox.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 19)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 26)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Go
        '
        Me.Go.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Go.Image = CType(resources.GetObject("Go.Image"), System.Drawing.Image)
        Me.Go.Location = New System.Drawing.Point(924, 13)
        Me.Go.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Go.Name = "Go"
        Me.Go.Size = New System.Drawing.Size(114, 35)
        Me.Go.TabIndex = 3
        Me.Go.Text = "Go to"
        Me.Go.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Go.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(-1, 728)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "当前状态|Condition："
        '
        'Con
        '
        Me.Con.AutoSize = True
        Me.Con.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Con.Location = New System.Drawing.Point(165, 728)
        Me.Con.Name = "Con"
        Me.Con.Size = New System.Drawing.Size(224, 20)
        Me.Con.TabIndex = 5
        Me.Con.Text = "Error while loading condition."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(861, 729)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(177, 23)
        Me.ProgressBar1.TabIndex = 6
        '
        'fUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1042, 757)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Con)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Addressbox)
        Me.Controls.Add(Me.Go)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "fUpdate"
        Me.Text = "Update | 升级"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(1, Byte), Integer))
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Addressbox As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Go As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Con As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
