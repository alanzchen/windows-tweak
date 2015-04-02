Public NotInheritable Class Loading

    'TODO: 可轻松将此窗体设置为应用程序的初始屏幕，方法是转到
    '  “项目设计器”的“应用程序”选项卡(“项目”菜单下的“属性”)。
    Declare Auto Function DwmIsCompositionEnabled Lib "dwmapi.dll" Alias "DwmIsCompositionEnabled" (ByRef pfEnabled As Boolean) As Integer
    Declare Auto Function DwmExtendFrameIntoClientArea Lib "dwmapi.dll" Alias "DwmExtendFrameIntoClientArea" (ByVal hWnd As IntPtr, ByRef pMargin As Margins) As Integer
    Dim pMargins As New Margins With {.Bottom = 140}

    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
    End Sub

End Class
