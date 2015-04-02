Imports Microsoft.VisualBasic.FileIO
Imports System.Threading

Public Class Home
    Declare Auto Function DwmIsCompositionEnabled Lib "dwmapi.dll" Alias "DwmIsCompositionEnabled" (ByRef pfEnabled As Boolean) As Integer
    Declare Auto Function DwmExtendFrameIntoClientArea Lib "dwmapi.dll" Alias "DwmExtendFrameIntoClientArea" (ByVal hWnd As IntPtr, ByRef pMargin As Margins) As Integer
    Dim pMargins As New Margins With {.Bottom = 40}
    Dim aMargins As New Margins With {.Top = 40}
    Dim en As Boolean = False



    Public Sub delay(ByRef Interval As Double)
        Dim time As DateTime = DateTime.Now
        Dim Span As Double = Interval * 10000000 '因为时间是以100纳秒为单位。 
        While ((DateTime.Now.Ticks - time.Ticks) < Span)
            Application.DoEvents()
        End While
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim en As Boolean = False
        If System.Environment.OSVersion.Version.Major >= 6 Then  '如果是Vista系统或以上   
            DwmIsCompositionEnabled(en)  '取得是否开启了Aero效果   
            If en Then
                DwmExtendFrameIntoClientArea(Me.Handle, pMargins)
            Else
                MessageBox.Show("Desktop Composition is Disabled!Aero效果被禁用。您可以打开Aero效果获得更好的体验。")
            End If
        Else '非Vista系统上的提示   
            MessageBox.Show("Please run this on Windows 7.您必须在Windows 7上运行这个程序。")
            Me.Close()
        End If
        Apppath.Text = Application.StartupPath()
        respath.Text = Application.StartupPath() & "\res"
        Plugpath.Text = Application.StartupPath() & "\bin"
        con1.Text = "就绪。|Done."
    End Sub

    Private Sub OpenWebQuestion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OpenWebQuestion.Click
        cannotopen.Show()
    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub SaveDIYmain_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveDIYmain.Click
        Loading.Show()
        delay(5)
        Dim Thread3 As New System.Threading.Thread(AddressOf TaskSaveDiyMain)
        Thread3.Start()
        Thread3.Join()
        Loading.Hide()
        MsgBox("成功的应用了所有改变。Change all iteam(s) successfully. ")
    End Sub

    Private Sub Exitbottom_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Exitbottom.Click
        Me.Close()
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub WebBrowser1_Navigated(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        con1.Text = "就绪。|Done."
    End Sub

    Private Sub WebBrowser1_Navigating(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        con1.Text = "正在连接...|Linking..."
    End Sub

    Private Sub WebBrowser1_ProgressChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged
        ProgressBar1.Visible = True
        If (e.CurrentProgress > 0) And (e.MaximumProgress > 0) Then
            ProgressBar1.Maximum = e.MaximumProgress
            ProgressBar1.Step = e.CurrentProgress
            ProgressBar1.PerformStep()
        ElseIf (WebBrowser1.ReadyState = WebBrowserReadyState.Complete) Then
            ProgressBar1.Value = 0
            'ProgressBar1.Visible = False
        End If
    End Sub

    Private Sub Getcode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Getcode.Click
        Dim Obj_Lob As New System.Net.WebClient()
        SaveFileDialog1.ShowDialog()
        Dim savefile As String = SaveFileDialog1.FileName
        Dim showUI As Boolean = True
        Dim address As String = "address of the code"
        If savefile <> "" Then
            My.Computer.Network.DownloadFile(address, savefile, _
"", "", True, 500, True)
            On Error Resume Next
        Else
        End If
    End Sub

    Public Sub DownloadFile( _
       ByVal address As System.Uri, _
       ByVal destinationFileName As String, _
       ByVal networkCredentials As System.Net.ICredentials, _
       ByVal showUI As Boolean, _
       ByVal connectionTimeout As Integer, _
       ByVal overwrite As Boolean, _
       ByVal onUserCancel As UICancelOption _
    )
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub CheckVersion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckVersion.Click
        fUpdate.Show()
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub Sysinfo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sysinfo.Click
        Shell("winver", AppWinStyle.NormalFocus)
    End Sub

    Private Sub SaveDiymenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveDiymenu.Click
        Loading.Show()
        delay(3)
        Dim Thread4 As New System.Threading.Thread(AddressOf TaskSaveDiyMenu)
        Thread4.Start()
        Thread4.Join()
        Loading.Hide()
        MsgBox("成功的应用了所有改变。Change all iteam(s) successfully. ")
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles runtimechoose.SelectedIndexChanged

    End Sub

    Private Sub RichTextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox6.TextChanged

    End Sub

    Private Sub Diy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Diy.Click

    End Sub

    Private Sub TweakRuntime_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TweakRuntime.Click
        Loading.Show()
        delay(4)
        Dim Thread2 As New System.Threading.Thread(AddressOf TaskTweakRuntime)
        Thread2.Start()
        Thread2.Join()
        Loading.Hide()
        MsgBox("成功的应用了所有改变。Change all iteam(s) successfully. ")
    End Sub

    Private Sub TweakSS_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TweakSS.Click
        Loading.Show()
        delay(2)
        Dim Thread2 As New System.Threading.Thread(AddressOf TaskTweakSS)
        Thread2.Start()
        Thread2.Join()
        Loading.Hide()
        MsgBox("成功的应用了所有改变。Change all iteam(s) successfully. ")
    End Sub

    Private Sub TweakOther_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TweakOther.Click
        Loading.Show()
        delay(10)
        Dim Thread1 As New System.Threading.Thread(AddressOf TaskTweakOther)
        Thread1.Start()
        Thread1.Join()
        Loading.Hide()
        MsgBox("成功的应用了所有改变。Change all iteam(s) successfully. ")
    End Sub

    Private Sub TaskTweakOther()
        For i = 0 To 16 Step 1
            If (otherchoose.GetItemChecked(i)) = True Then
                Shell("regedit /s" + Application.StartupPath() & "/res/oth/" & i & ".reg")
                Thread.Sleep(100)
            Else
                Shell("regedit /s" + Application.StartupPath() & "/res/oth/un/" & i & ".reg")
                Thread.Sleep(100)
            End If
            i = i + 1
        Next i
    End Sub

    Private Sub TaskTweakSS()
        For i = 0 To 7
            If (SSchoose.GetItemChecked(i)) = True Then
                Shell("regedit /s" + Application.StartupPath() & "/res/ss/" & i & ".reg")
            Else
                Shell("regedit /s" + Application.StartupPath() & "/res/ss/un/" & i & ".reg")
            End If
            i = i + 1
        Next i
    End Sub
    Private Sub TaskTweakRuntime()
        For i = 0 To 3
            If (runtimechoose.GetItemChecked(i)) = True Then
                Shell("regedit /s" + Application.StartupPath() & "/res/runtime/" & i & ".reg")
            Else
                Shell("regedit /s" + Application.StartupPath() & "/res/runtime/un/" & i & ".reg")
            End If
            i = i + 1
        Next i
    End Sub
    Private Sub TaskSaveDiyMain()
        For i = 0 To 29 Step 1
            If (DiyChoose.GetItemChecked(i)) = True Then
                Shell("regedit /s" + Application.StartupPath() & "/res/diy/main" & i & ".reg")
            Else
                Shell("regedit /s" + Application.StartupPath() & "/res/diy/main/un/" & i & ".reg")
            End If
            i = i + 1
        Next i
    End Sub
    Private Sub TaskSaveDiyMenu()
        For i = 0 To 29 Step 1
            If (DiyChoose.GetItemChecked(i)) = True Then
                Shell("regedit /s" + Application.StartupPath() & "/res/diy/main" & i & ".reg")
            Else
                Shell("regedit /s" + Application.StartupPath() & "/res/diy/main/un/" & i & ".reg")
            End If
            i = i + 1
        Next i
    End Sub
End Class

