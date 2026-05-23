Imports BalfoursBusinessClassLibrary.BBMDisplays
Imports BalfoursBusinessClassLibrary.BBMBalfoursBusiness
Imports Microsoft.Win32
Public Class DataProjectMain
    Dim mColour1 As Color = Color.White
    Dim mColour2 As Color = Color.FromArgb(255, 51, 51, 51)
    Public Sub MakeFileAssociation()
        FileAssociation()
    End Sub
    Public Sub SendArguementData(ByVal ArgumentIn As String)
        Select Case LCase(ArgumentIn)
            Case Is = "-newopen"
                OpenFile("newopen")
            Case Is = "-silent"
                End
            Case Is = "-forced"
                NewChild("")
            Case Else
                Dim fileOpening As String = ArgumentIn.ToString.Replace("%20", " ")
                OpenFile(fileOpening)
        End Select
    End Sub
    Public Sub NewChild(ByVal Filename As String)
        Dim i As New DataProjectNotebook
        i.FileToOpen = Filename
        i.Text = "Untitled Notebook"
        MainMDITabControl.TabPages.Add(i)
    End Sub
    Public Sub ShowOptions()
        If SidebarWithGlassPanel.Visible = True Then
            SidebarWithGlassPanel.Visible = False
        Else
            SidebarWithGlassPanel.Visible = True
        End If
    End Sub
    Public Sub OpenFile(ByVal Filename As String)
        If Filename = "newopen" Then
            Dim i As New DataProjectNotebook
            i.FileToOpen = "newopen"
            MainMDITabControl.TabPages.Add(i)
            i.BbcDataProjectUltraControl1.OpenFile("newopen")
        Else
            Dim i As New DataProjectNotebook
            i.FileToOpen = Filename
            MainMDITabControl.TabPages.Add(i)
            i.BbcDataProjectUltraControl1.OpenFile(Filename)
        End If
    End Sub
    Private Sub DataProjectMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ClosingFormCommands(Me, BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser, "Software\Balfour's Business\Elements Office Ultra\Data Project Ultra Edition", e, MainMDITabControl)
    End Sub
    Public Function Register() As DialogResult
        Dim c As New BalfoursBusinessClassLibrary.BBMRegistryActions
        Dim rkey As String = Nothing
        rkey = c.ReadRegistry(BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser, "Cobra\CurrentSystem\Add-on", "dpkey")

        If My.Settings.Registered = False Or Not rkey = My.Settings.RegistrationKey Then
            Dim regikeyattempt As String
            regikeyattempt = BBTextInputBox("Please input the registration key", mColour1, mColour2)
            If regikeyattempt = My.Settings.RegistrationKey Then
                My.Settings.Registered = True
                c.WriteRegistry(BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser, "Cobra\CurrentSystem\Add-on", "wrkey", My.Settings.RegistrationKey)
                Return Windows.Forms.DialogResult.Yes
            Else
                Return Windows.Forms.DialogResult.No
            End If
        Else
            MsgBox("This edition of Wonderword is already registered", MsgBoxStyle.Information)
            Return Windows.Forms.DialogResult.Yes
        End If
    End Function
    Private Sub DPMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Balfour's Business\Data Project\Resources\")
        Dim c As New BalfoursBusinessClassLibrary.BBMRegistryActions


        If My.Application.CommandLineArgs.Count = 0 Then
            NewChild("")
        Else
            Try
                For Each arg As String In My.Application.CommandLineArgs
                    SendArguementData(arg)
                Next
            Catch ex As Exception
            End Try
        End If

        Try
            If (Val(System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.Revision.ToString) > Val(c.ReadRegistry(BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser, "Software\Balfour's Business\Elements Office Ultra\Wonderword Ultra Edition\", "exe version"))) And Not c.ReadRegistry(BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser, "Software\Balfour's Business\Elements Office Ultra\", "FileAssociationAsk") = "False" Then
                Select Case MessageBox.Show("The application has been updated and therefore the file associations need to be remade. Would you like to do this now?" & vbCrLf & vbCrLf & "If you press Yes, the program will associate the files (requires administrator permissions), if you press No all Balfour's Business software will stop asking if you wish to associate files on a version change, if you press Cancel the dialog will close but you will be asked again in the future.", "File Associations", MessageBoxButtons.YesNoCancel)
                    Case Is = DialogResult.Yes
                        MakeFileAssociation()
                    Case Is = DialogResult.No
                        c.WriteRegistry(BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser, "Software\Balfour's Business", "FileAssociationAsk", "False")
                End Select

            End If
        Catch ex As Exception
        End Try
        Dim BPop As New BalfoursBusinessExtensionLibrary.BBCPopUpMenu
        BPop.TransferTabControlToBBCPopUpMenu(TabControl1)
        Dim value As String = Nothing

        Dim s As Integer
        Try
            s = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.Revision
        Catch ex As Exception

        End Try
        OpeningCommands(Me, BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser, "Software\Balfour's Business\Elements Office Ultra\Data Project Ultra Edition")

        My.Settings.UsedSoftware = True
        My.Settings.Save()

    End Sub
    Private Sub MainMDITabControl_OpenDocumentButtonClicked() Handles MainMDITabControl.OpenDocumentButtonClicked
        NewChild("newopen")
    End Sub
    Private Sub MainMDITabControl_Tabs_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MainMDITabControl.Tabs_DoubleClick
        NewChild("")
    End Sub
#Region "Options panel"
    Private Sub cmdReinstallDP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MessageBox.Show("Are you sure you want to do this. All settings will be lost and any unsaved data here will not be recoverable. Save all projects first", "Data Project", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            My.Settings.ShowInstaller = True
            My.Settings.Save()
            MsgBox("You have chosen to re-install Data Project Ultra Edition when it next starts. Data Project is about close.", MsgBoxStyle.Information)
            End
        End If
    End Sub
    Private Sub cmdCreateInstallationFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreateInstallationFile.Click
        Dim c As New BalfoursBusinessClassLibrary.BBMOracleConfigurations
        c.SaveGenericOracleConfigurationFile(MainMDITabControl.RegistryLocation)
    End Sub
    Private Sub cmdAssociateFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAssociateFiles.Click
        MakeFileAssociation()
    End Sub
#End Region

    Private Sub CloseTabsOnClickToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseTabsOnClickToolStripMenuItem.Click
        MainMDITabControl.DeleteTabsMode = CloseTabsOnClickToolStripMenuItem.Checked
    End Sub
End Class