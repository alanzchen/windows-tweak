

Public Class fUpdate
    Declare Auto Function DwmIsCompositionEnabled Lib "dwmapi.dll" Alias "DwmIsCompositionEnabled" (ByRef pfEnabled As Boolean) As Integer
    Declare Auto Function DwmExtendFrameIntoClientArea Lib "dwmapi.dll" Alias "DwmExtendFrameIntoClientArea" (ByVal hWnd As IntPtr, ByRef pMargin As Margins) As Integer
    Dim pMargins As New Margins With {.Bottom = 785}
    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub WebBrowser1_Navigated(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        Con.Text = "就绪 | Ready"
    End Sub

    Private Sub WebBrowser1_Navigating(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        Con.Text = "正在导航 | Navigating"
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

    Private Sub Update_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
        End If
        Con.Text = "就绪 | Ready"
    End Sub

    Private Sub Go_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Go.Click
        If Addressbox.SelectedItem <> "选择一个更新服务器。" Then
            WebBrowser1.Navigate(Addressbox.SelectedItem)
        Else
            MsgBox("选择一个更新服务器")
        End If
    End Sub
End Class