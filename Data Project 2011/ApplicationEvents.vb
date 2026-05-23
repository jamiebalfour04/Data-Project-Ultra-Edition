Imports BalfoursBusinessClassLibrary.BBMRegistryActions

Namespace My
    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Protected Overrides Function OnInitialize(ByVal argv As System.Collections.ObjectModel.ReadOnlyCollection(Of String)) As Boolean
            Me.MinimumSplashScreenDisplayTime = 3000
            Return MyBase.OnInitialize(argv)
        End Function
        Private Sub newAppOpens(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            If e.CommandLine.Count > 0 Then
                Dim reg As New BalfoursBusinessClassLibrary.BBMRegistryActions
                If reg.BooleanReadRegistry(RegistryType.CurrentUser, "Software\Balfour's Business\Elements Office Ultra\Data Project Ultra Edition", "argWarnings") = True Then
                    If MsgBox("An application has requested to send argument data to this application. Do you want to allow it?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        For Each s As String In e.CommandLine
                            Dim mainWind As DataProjectMain = MainForm

                            mainWind.SendArguementData(s)
                        Next
                    End If
                Else
                    For Each s As String In e.CommandLine
                        Dim mainWind As DataProjectMain = MainForm

                        mainWind.SendArguementData(s)
                    Next
                End If

            End If
        End Sub
    End Class


End Namespace

