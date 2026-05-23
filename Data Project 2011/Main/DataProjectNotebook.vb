Imports System.IO
Imports BalfoursBusinessClassLibrary.BBMBalfoursBusiness
Imports BalfoursBusinessClassLibrary.BBMSpecialisedFunctions
Imports BalfoursBusinessClassLibrary.BBMDisplays
Public Class DataProjectNotebook
    Public Property FileToOpen As String
#Region "Startup"
    Dim mColour1 As Color = Color.White
    Dim mColour2 As Color = Color.FromArgb(255, 51, 51, 51)
    Private Sub FileToolStripMenuItem_DropDownOpened(sender As System.Object, e As System.EventArgs) Handles FileToolStripMenuItem.DropDownOpened, EditToolStripMenuItem.DropDownOpened, ViewToolStripMenuItem.DropDownOpened, _
ToolsToolStripMenuItem.DropDownOpened, HelpToolStripMenuItem.DropDownOpened

        sender.ForeColor = Color.Black
    End Sub
    Private Sub FileToolStripMenuItem_DropDownClosed(sender As System.Object, e As System.EventArgs) Handles FileToolStripMenuItem.DropDownClosed, EditToolStripMenuItem.DropDownClosed, ViewToolStripMenuItem.DropDownClosed, _
      ToolsToolStripMenuItem.DropDownClosed, HelpToolStripMenuItem.DropDownClosed

        sender.ForeColor = Color.White
    End Sub
    Private Sub DataProjectPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        RecentFilesUpdate()
        If FileToOpen = Nothing Or FileToOpen = Nothing Then
            NewFile()
        End If
        Dim c As New BalfoursBusinessClassLibrary.BBMRegistryActions
        BbcDataProjectUltraControl1.CompressionType = c.ReadRegistry(BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser, "Software\Balfour's Business\Elements Office Ultra\Data Project Ultra Edition", "compressionType")

        DataProjectMain.MainMDITabControl.Theme = c.ReadRegistry(BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser, "Software\Balfour's Business\Elements Office Ultra\Data Project Ultra Edition", "theme")

        DataProjectMain.MainMDITabControl.ReloadTheme()

    End Sub
#End Region
#Region "New, Open and Save"
    Public Sub NewFile()
        BbcDataProjectUltraControl1.NewPageIntoNotebook()
    End Sub
    Public Sub SaveFile(Optional ByVal Filename As String = Nothing)
        If Filename = Nothing Then
            Dim sfd1 As New SaveFileDialog
            sfd1.Filter = "Data Project Ultra Extension (.dux)|*.dux"
            If sfd1.ShowDialog = Windows.Forms.DialogResult.OK Then
                BbcDataProjectUltraControl1.SaveFile(sfd1.FileName)
                RefreshRecent(sfd1.FileName)
                Dim fileData As FileInfo = My.Computer.FileSystem.GetFileInfo(sfd1.FileName)
                Me.Text = fileData.Name
            End If
        Else
            BbcDataProjectUltraControl1.SaveFile(Filename)
            Dim fileData As FileInfo = My.Computer.FileSystem.GetFileInfo(Filename)
            Me.Text = fileData.Name
            RefreshRecent(Filename)
        End If
    End Sub
    Public Sub OpenNotebook(ByVal Filename As String)
        RefreshRecent(BbcDataProjectUltraControl1.OpenFile(Filename))
        Try
            Dim fileData As FileInfo = My.Computer.FileSystem.GetFileInfo(BbcDataProjectUltraControl1.CurrentFile)
            Me.Text = fileData.Name
        Catch ex As Exception
        End Try
    End Sub
#End Region
#Region "File"
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewPageToolStripMenuItem.Click
        Try
            Dim i As DataProjectNotebook
            i = DataProjectMain.MainMDITabControl.SelectedForm
            i.NewFile()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            Dim i As DataProjectNotebook
            i = DataProjectMain.MainMDITabControl.SelectedForm
            i.OpenNotebook("")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Try
            Dim i As DataProjectNotebook
            i = DataProjectMain.MainMDITabControl.SelectedForm
            i.SaveFile(BbcDataProjectUltraControl1.CurrentFile)
        Catch ex As Exception
        End Try

    End Sub
    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        Try
            Dim i As DataProjectNotebook
            i = DataProjectMain.MainMDITabControl.SelectedForm
            i.SaveFile()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        Try
            Dim i As DataProjectNotebook
            i = DataProjectMain.MainMDITabControl.SelectedForm
            i.BbcDataProjectUltraControl1.PrintFile()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        Dim i As DataProjectNotebook
        i = DataProjectMain.MainMDITabControl.SelectedForm
        DataProjectMain.MainMDITabControl.TabPages.Add(i.BbcDataProjectUltraControl1.PrintPreview)
    End Sub
    Private Sub DPOptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DPOptionsToolStripMenuItem.Click
        DataProjectMain.ShowOptions()
    End Sub
#End Region
#Region "Edit functions"
    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        Try
            Dim i As DataProjectNotebook
            i = DataProjectMain.MainMDITabControl.SelectedForm
            i.BbcDataProjectUltraControl1.Undo()
        Catch ex As Exception
        End Try

    End Sub
    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        Try
            Dim i As DataProjectNotebook
            i = DataProjectMain.MainMDITabControl.SelectedForm
            i.BbcDataProjectUltraControl1.Redo()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        Try
            Dim i As DataProjectNotebook
            i = DataProjectMain.MainMDITabControl.SelectedForm
            i.BbcDataProjectUltraControl1.SelectAll()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        Try
            Dim i As DataProjectNotebook
            i = DataProjectMain.MainMDITabControl.SelectedForm
            i.BbcDataProjectUltraControl1.Cut()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Try
            Dim i As DataProjectNotebook
            i = DataProjectMain.MainMDITabControl.SelectedForm
            i.BbcDataProjectUltraControl1.Copy()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        Try
            Dim i As DataProjectNotebook
            i = DataProjectMain.MainMDITabControl.SelectedForm
            i.BbcDataProjectUltraControl1.Paste()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub SetPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetPagePasswordToolStripMenuItem.Click
        Dim i As String = ChangePassword()
        BbcDataProjectUltraControl1.SetPassword(i)
    End Sub
#End Region
#Region "Tools"
    Private Sub ChangeFontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeFontToolStripMenuItem.Click
        Dim fd1 As New FontDialog
        If fd1.ShowDialog = Windows.Forms.DialogResult.OK Then
            BbcDataProjectUltraControl1.SetSelectionFont(fd1.Font)
        End If
    End Sub
    Private Sub ChangeColourToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeColourToolStripMenuItem.Click
        Dim cd1 As New ColorDialog
        If cd1.ShowDialog = Windows.Forms.DialogResult.OK Then
            BbcDataProjectUltraControl1.SelectionBackColour = cd1.Color
        End If
    End Sub
    Private Sub ImportBlackRabbitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportBlackRabbitToolStripMenuItem.Click
        BbcDataProjectUltraControl1.AttachBlackRabbitScript()
    End Sub
    Private Sub DebugToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DebugToolStripMenuItem.Click
        BbcDataProjectUltraControl1.Debug()
    End Sub
    Private Sub TestScriptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestScriptToolStripMenuItem.Click
        BbcDataProjectUltraControl1.TestScript()
    End Sub
    Private Sub NewMSIInterfaceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewMSIInterfaceToolStripMenuItem.Click
        BbcDataProjectUltraControl1.MSIScriptingInterfaceLanguageOnSelection()
    End Sub
    Private Sub EditCurrentMacrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditCurrentMacrosToolStripMenuItem.Click
        BbcDataProjectUltraControl1.EditDocumentMacros()
    End Sub
    Private Sub InputPanelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputPanelToolStripMenuItem.Click
        Try
            Shell("C:\Program Files\Common Files\Microsoft Shared\ink\TabTip.exe")
        Catch ex As Exception
            MsgBox("The Input Panel cannot be found.", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region
#Region "Recent files"
    Public Sub RefreshRecent(ByVal Filename As String)
        RefreshRecents(Filename, "Software\Balfour's Business\Elements Office Ultra\Data Project Ultra Edition", Recent1ToolStripMenuItem, Recent2ToolStripMenuItem, Recent3ToolStripMenuItem, Recent4ToolStripMenuItem, "Project")
        RecentFilesUpdate()
    End Sub
    Public Sub RecentFilesUpdate()
        RecentFilesUpdater("Software\Balfour's Business\Elements Office Ultra\Data Project Ultra Edition", Recent1ToolStripMenuItem, Recent2ToolStripMenuItem, Recent3ToolStripMenuItem, Recent4ToolStripMenuItem, toolStripSeparator2, "Project")
    End Sub
    Private Sub RecentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Recent1ToolStripMenuItem.Click, Recent2ToolStripMenuItem.Click, _
        Recent3ToolStripMenuItem.Click, Recent4ToolStripMenuItem.Click

        Dim c As New BalfoursBusinessClassLibrary.BBMRegistryActions
        Dim Recent As String = Nothing
        Recent = sender.ToolTipText
        If My.Computer.FileSystem.FileExists(Recent) Then
            Call OpenNotebook(Recent)
        Else
            MsgBox("The file no longer exists in this location", MsgBoxStyle.Exclamation)
        End If
    End Sub
#End Region

    Private Sub InsertVideoLinkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertVideoLinkToolStripMenuItem.Click
        Dim ofd1 As New OpenFileDialog
        ofd1.Filter = "Windows Movie Video (*.wmv)|*.wmv"
        If ofd1.ShowDialog = Windows.Forms.DialogResult.OK Then
            BbcDataProjectUltraControl1.InsertVideoLink(ofd1.FileName)
        End If
    End Sub

    Private Sub WelcomeToDataProjectToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles WelcomeToDataProjectToolStripMenuItem.Click

    End Sub

    Private Sub HelpToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles HelpToolStripMenuItem1.Click

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Dim name As String = "Data Project Ultra Edition 2.4.2"
        Dim copyright As String = "Copyright 2005 - 2011 Balfour's Business"
        Dim DaysLeft As TimeSpan
        DaysLeft = My.Settings.ExpireDate - Today
        Dim compliance As String = "Complies with standards:" & vbCrLf & vbCrLf & "BBSA-DUX" & vbCrLf & "BBSA-BIF" & vbCrLf & "BBSA-BBA"
        Dim version As String
        Try
            version = My.Application.Deployment.CurrentVersion.Major & "." & My.Application.Deployment.CurrentVersion.Minor & "." & My.Application.Deployment.CurrentVersion.Build & "." & My.Application.Deployment.CurrentVersion.Revision
        Catch ex As Exception
            version = "2.4.2.1000"
        End Try
        BBAboutDialog(name, mColour1, mColour2, copyright, version, Me.Icon, DaysLeft.TotalDays, My.Settings.Registered, My.Resources.License, compliance)

    End Sub
End Class