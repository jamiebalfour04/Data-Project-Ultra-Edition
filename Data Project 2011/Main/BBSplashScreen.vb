Public NotInheritable Class BBSplashScreen
    Dim RegistryLocation As String = "Software\Balfour's Business\Elements Office Ultra\Data Project Ultra Edition"
    Private Sub BBSplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Settings.UsedSoftware = False
        My.Settings.Expired = False
        Dim c As New BalfoursBusinessClassLibrary.BBMRegistryActions
        Try


            Dim rkey As String = Nothing

            rkey = c.ReadRegistry(BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser, "Cobra\CurrentSystem\Add-on", "dpkey")

            If My.Settings.Expired = True Then
                End
            Else
                If c.BooleanReadRegistry(BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser, RegistryLocation, "usedSoftware") = False Then
                    Try
                        c.WriteRegistry(BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser, "Cobra\CurrentSystem\Add-on", "dpkey", "")
                        c.WriteRegistry(BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser, RegistryLocation, "compressionType", 1)
                        c.WriteRegistry(BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser, RegistryLocation, "opacity", "1")
                        c.WriteRegistry(BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser, RegistryLocation, "showStandardToolbar", "True")
                        c.WriteRegistry(BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser, RegistryLocation, "showFormattingToolbar", "True")
                        c.WriteRegistry(BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser, RegistryLocation, "showConversionToolbar", "False")
                        c.WriteRegistry(BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser, RegistryLocation, "showSidePanel", "True")
                        c.WriteRegistry(BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser, RegistryLocation, "locOfMainX", "0")
                        c.WriteRegistry(BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser, RegistryLocation, "locOfMainY", "0")
                        c.WriteRegistry(BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser, RegistryLocation, "sizeOfMainWidth", "800")
                        c.WriteRegistry(BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser, RegistryLocation, "sizeOfMainHeight", "600")
                        c.WriteRegistry(BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser, RegistryLocation, "sizeMaxi", "True")
                        c.WriteRegistry(BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser, RegistryLocation, "useSpecialOrientation", "False")
                        c.WriteRegistry(BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser, RegistryLocation, "pointer", "ibeam.cur")
                        c.WriteRegistry(BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser, RegistryLocation, "lang", "English (UK)")
                    Catch ex As Exception
                    End Try
                End If
            End If


            If My.Settings.UsedSoftware = True Then
                If My.Settings.Registered = False Or Not rkey = My.Settings.RegistrationKey Then
                    If Today = My.Settings.ExpireDate Or Today > My.Settings.ExpireDate Then
                        My.Settings.Expired = True
                        If DataProjectMain.Register = Windows.Forms.DialogResult.Yes Then
                        Else
                            End
                        End If
                    End If
                End If
            Else
                My.Settings.ExpireDate = Today.AddDays(30)
            End If


            Dim DaysLeft As TimeSpan
            DaysLeft = My.Settings.ExpireDate - Today


            c.WriteRegistry(BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser, RegistryLocation, "DaysLeft", DaysLeft)

            My.Settings.Save()
        Catch ex As Exception

        End Try


    End Sub
End Class
