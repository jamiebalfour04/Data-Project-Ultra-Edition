<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataProjectMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataProjectMain))
        Me.DropDownItemList = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseTabsOnClickToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DataProjectSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlackTopBar = New System.Windows.Forms.Panel()
        Me.SidebarWithGlassPanel = New System.Windows.Forms.Panel()
        Me.OptionContainerPanel = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CheckBoxPanel = New System.Windows.Forms.Panel()
        Me.BbcRevolutionaryCheckbox3 = New BalfoursBusinessClassLibrary.BBCRevolutionaryCheckbox()
        Me.BbcRevolutionaryCheckbox2 = New BalfoursBusinessClassLibrary.BBCRevolutionaryCheckbox()
        Me.lblChangeInfo = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdDeleteOracleFile = New System.Windows.Forms.Button()
        Me.cmdChangeDefaultFont = New System.Windows.Forms.Button()
        Me.cmdAssociateFiles = New System.Windows.Forms.Button()
        Me.cmdObtainStickyEncryptID = New System.Windows.Forms.Button()
        Me.cmdInsertAnID = New System.Windows.Forms.Button()
        Me.cmdCreateInstallationFile = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.CompressionPanel = New System.Windows.Forms.Panel()
        Me.BbcRevolutionaryRadioButton3 = New BalfoursBusinessClassLibrary.BBCRevolutionaryRadioButton()
        Me.BbcRevolutionaryRadioButton2 = New BalfoursBusinessClassLibrary.BBCRevolutionaryRadioButton()
        Me.BbcRevolutionaryRadioButton1 = New BalfoursBusinessClassLibrary.BBCRevolutionaryRadioButton()
        Me.BbcRevolutionaryRadioButton4 = New BalfoursBusinessClassLibrary.BBCRevolutionaryRadioButton()
        Me.MainMDITabControl = New BalfoursBusinessClassLibrary.BBCTabControlWithOrb()
        Me.BbcStatusBar1 = New BalfoursBusinessClassLibrary.BBCBottomBar()
        Me.BbcTopBar1 = New BalfoursBusinessClassLibrary.BBCTopBar()
        Me.DropDownItemList.SuspendLayout()
        Me.SidebarWithGlassPanel.SuspendLayout()
        Me.OptionContainerPanel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.CheckBoxPanel.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.CompressionPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'DropDownItemList
        '
        Me.DropDownItemList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.NewTabToolStripMenuItem, Me.OpenImageToolStripMenuItem, Me.CloseTabsOnClickToolStripMenuItem, Me.ToolStripSeparator2, Me.DataProjectSettingsToolStripMenuItem})
        Me.DropDownItemList.Name = "ContextMenuStrip1"
        Me.DropDownItemList.Size = New System.Drawing.Size(251, 104)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(247, 6)
        '
        'NewTabToolStripMenuItem
        '
        Me.NewTabToolStripMenuItem.Image = CType(resources.GetObject("NewTabToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewTabToolStripMenuItem.Name = "NewTabToolStripMenuItem"
        Me.NewTabToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.NewTabToolStripMenuItem.Text = "New tab"
        '
        'OpenImageToolStripMenuItem
        '
        Me.OpenImageToolStripMenuItem.Image = CType(resources.GetObject("OpenImageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenImageToolStripMenuItem.Name = "OpenImageToolStripMenuItem"
        Me.OpenImageToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.OpenImageToolStripMenuItem.Text = "Open image"
        '
        'CloseTabsOnClickToolStripMenuItem
        '
        Me.CloseTabsOnClickToolStripMenuItem.CheckOnClick = True
        Me.CloseTabsOnClickToolStripMenuItem.Image = CType(resources.GetObject("CloseTabsOnClickToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CloseTabsOnClickToolStripMenuItem.Name = "CloseTabsOnClickToolStripMenuItem"
        Me.CloseTabsOnClickToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.CloseTabsOnClickToolStripMenuItem.Text = "Close tabs on click"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(247, 6)
        '
        'DataProjectSettingsToolStripMenuItem
        '
        Me.DataProjectSettingsToolStripMenuItem.Image = CType(resources.GetObject("DataProjectSettingsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DataProjectSettingsToolStripMenuItem.Name = "DataProjectSettingsToolStripMenuItem"
        Me.DataProjectSettingsToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.DataProjectSettingsToolStripMenuItem.Text = "Data Project Ultra Edition settings"
        '
        'BlackTopBar
        '
        Me.BlackTopBar.BackColor = System.Drawing.Color.Black
        Me.BlackTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.BlackTopBar.Location = New System.Drawing.Point(0, 0)
        Me.BlackTopBar.Name = "BlackTopBar"
        Me.BlackTopBar.Size = New System.Drawing.Size(354, 31)
        Me.BlackTopBar.TabIndex = 1013
        '
        'SidebarWithGlassPanel
        '
        Me.SidebarWithGlassPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SidebarWithGlassPanel.Controls.Add(Me.OptionContainerPanel)
        Me.SidebarWithGlassPanel.Controls.Add(Me.BlackTopBar)
        Me.SidebarWithGlassPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.SidebarWithGlassPanel.Location = New System.Drawing.Point(0, 0)
        Me.SidebarWithGlassPanel.Name = "SidebarWithGlassPanel"
        Me.SidebarWithGlassPanel.Size = New System.Drawing.Size(354, 730)
        Me.SidebarWithGlassPanel.TabIndex = 1018
        Me.SidebarWithGlassPanel.Visible = False
        '
        'OptionContainerPanel
        '
        Me.OptionContainerPanel.AutoScroll = True
        Me.OptionContainerPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.OptionContainerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OptionContainerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OptionContainerPanel.Controls.Add(Me.TabControl1)
        Me.OptionContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OptionContainerPanel.ForeColor = System.Drawing.Color.White
        Me.OptionContainerPanel.Location = New System.Drawing.Point(0, 31)
        Me.OptionContainerPanel.Name = "OptionContainerPanel"
        Me.OptionContainerPanel.Size = New System.Drawing.Size(354, 699)
        Me.OptionContainerPanel.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(352, 697)
        Me.TabControl1.TabIndex = 1022
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.CheckBoxPanel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(344, 671)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        '
        'CheckBoxPanel
        '
        Me.CheckBoxPanel.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CheckBoxPanel.Controls.Add(Me.BbcRevolutionaryCheckbox3)
        Me.CheckBoxPanel.Controls.Add(Me.BbcRevolutionaryCheckbox2)
        Me.CheckBoxPanel.Controls.Add(Me.lblChangeInfo)
        Me.CheckBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBoxPanel.Location = New System.Drawing.Point(3, 3)
        Me.CheckBoxPanel.Name = "CheckBoxPanel"
        Me.CheckBoxPanel.Size = New System.Drawing.Size(338, 665)
        Me.CheckBoxPanel.TabIndex = 1019
        '
        'BbcRevolutionaryCheckbox3
        '
        Me.BbcRevolutionaryCheckbox3.AutoSize = True
        Me.BbcRevolutionaryCheckbox3.Location = New System.Drawing.Point(5, 56)
        Me.BbcRevolutionaryCheckbox3.Name = "BbcRevolutionaryCheckbox3"
        Me.BbcRevolutionaryCheckbox3.RegistryKeyToWriteValue = BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser
        Me.BbcRevolutionaryCheckbox3.RegistryLocationToWritePath = "Software\Balfour's Business\Elements Office Ultra\Data Project Ultra Edition"
        Me.BbcRevolutionaryCheckbox3.RegistryLocationToWriteValue = "showBRWarnings"
        Me.BbcRevolutionaryCheckbox3.Size = New System.Drawing.Size(214, 17)
        Me.BbcRevolutionaryCheckbox3.TabIndex = 1020
        Me.BbcRevolutionaryCheckbox3.Text = "Show BlackRabbit Start Script warnings"
        Me.BbcRevolutionaryCheckbox3.UseVisualStyleBackColor = True
        '
        'BbcRevolutionaryCheckbox2
        '
        Me.BbcRevolutionaryCheckbox2.AutoSize = True
        Me.BbcRevolutionaryCheckbox2.Location = New System.Drawing.Point(5, 33)
        Me.BbcRevolutionaryCheckbox2.Name = "BbcRevolutionaryCheckbox2"
        Me.BbcRevolutionaryCheckbox2.RegistryKeyToWriteValue = BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser
        Me.BbcRevolutionaryCheckbox2.RegistryLocationToWritePath = "Software\Balfour's Business\Elements Office Ultra\Data Project Ultra Edition"
        Me.BbcRevolutionaryCheckbox2.RegistryLocationToWriteValue = "ignoreLinks"
        Me.BbcRevolutionaryCheckbox2.Size = New System.Drawing.Size(120, 17)
        Me.BbcRevolutionaryCheckbox2.TabIndex = 1019
        Me.BbcRevolutionaryCheckbox2.Text = "Ignore link warnings"
        Me.BbcRevolutionaryCheckbox2.UseVisualStyleBackColor = True
        '
        'lblChangeInfo
        '
        Me.lblChangeInfo.AutoSize = True
        Me.lblChangeInfo.Location = New System.Drawing.Point(2, 13)
        Me.lblChangeInfo.Name = "lblChangeInfo"
        Me.lblChangeInfo.Size = New System.Drawing.Size(282, 13)
        Me.lblChangeInfo.TabIndex = 1018
        Me.lblChangeInfo.Text = "Some changes take effect after the application is restarted"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(344, 671)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Specific"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cmdDeleteOracleFile, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdChangeDefaultFont, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdAssociateFiles, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdObtainStickyEncryptID, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdInsertAnID, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdCreateInstallationFile, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.Black
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(338, 665)
        Me.TableLayoutPanel1.TabIndex = 1016
        '
        'cmdDeleteOracleFile
        '
        Me.cmdDeleteOracleFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdDeleteOracleFile.Location = New System.Drawing.Point(172, 33)
        Me.cmdDeleteOracleFile.Name = "cmdDeleteOracleFile"
        Me.cmdDeleteOracleFile.Size = New System.Drawing.Size(163, 24)
        Me.cmdDeleteOracleFile.TabIndex = 7
        Me.cmdDeleteOracleFile.Text = "Delete an Oracle Installation"
        Me.cmdDeleteOracleFile.UseVisualStyleBackColor = True
        '
        'cmdChangeDefaultFont
        '
        Me.cmdChangeDefaultFont.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdChangeDefaultFont.Image = CType(resources.GetObject("cmdChangeDefaultFont.Image"), System.Drawing.Image)
        Me.cmdChangeDefaultFont.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdChangeDefaultFont.Location = New System.Drawing.Point(3, 63)
        Me.cmdChangeDefaultFont.Name = "cmdChangeDefaultFont"
        Me.cmdChangeDefaultFont.Size = New System.Drawing.Size(163, 24)
        Me.cmdChangeDefaultFont.TabIndex = 5
        Me.cmdChangeDefaultFont.Text = "Change default font"
        Me.cmdChangeDefaultFont.UseVisualStyleBackColor = True
        '
        'cmdAssociateFiles
        '
        Me.cmdAssociateFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdAssociateFiles.Location = New System.Drawing.Point(3, 3)
        Me.cmdAssociateFiles.Name = "cmdAssociateFiles"
        Me.cmdAssociateFiles.Size = New System.Drawing.Size(163, 24)
        Me.cmdAssociateFiles.TabIndex = 2
        Me.cmdAssociateFiles.Text = "Associate files"
        Me.cmdAssociateFiles.UseVisualStyleBackColor = True
        '
        'cmdObtainStickyEncryptID
        '
        Me.cmdObtainStickyEncryptID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdObtainStickyEncryptID.Location = New System.Drawing.Point(172, 3)
        Me.cmdObtainStickyEncryptID.Name = "cmdObtainStickyEncryptID"
        Me.cmdObtainStickyEncryptID.Size = New System.Drawing.Size(163, 24)
        Me.cmdObtainStickyEncryptID.TabIndex = 0
        Me.cmdObtainStickyEncryptID.Text = "Obtain a StickyEncrypt ID"
        Me.cmdObtainStickyEncryptID.UseVisualStyleBackColor = True
        '
        'cmdInsertAnID
        '
        Me.cmdInsertAnID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdInsertAnID.Image = CType(resources.GetObject("cmdInsertAnID.Image"), System.Drawing.Image)
        Me.cmdInsertAnID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdInsertAnID.Location = New System.Drawing.Point(172, 63)
        Me.cmdInsertAnID.Name = "cmdInsertAnID"
        Me.cmdInsertAnID.Size = New System.Drawing.Size(163, 24)
        Me.cmdInsertAnID.TabIndex = 1
        Me.cmdInsertAnID.Text = "Insert StickyEncrypt ID"
        Me.cmdInsertAnID.UseVisualStyleBackColor = True
        '
        'cmdCreateInstallationFile
        '
        Me.cmdCreateInstallationFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdCreateInstallationFile.Location = New System.Drawing.Point(3, 33)
        Me.cmdCreateInstallationFile.Name = "cmdCreateInstallationFile"
        Me.cmdCreateInstallationFile.Size = New System.Drawing.Size(163, 24)
        Me.cmdCreateInstallationFile.TabIndex = 3
        Me.cmdCreateInstallationFile.Text = "Create an Oracle Installation"
        Me.cmdCreateInstallationFile.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.CompressionPanel)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(344, 671)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Compression"
        '
        'CompressionPanel
        '
        Me.CompressionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CompressionPanel.Controls.Add(Me.BbcRevolutionaryRadioButton3)
        Me.CompressionPanel.Controls.Add(Me.BbcRevolutionaryRadioButton2)
        Me.CompressionPanel.Controls.Add(Me.BbcRevolutionaryRadioButton1)
        Me.CompressionPanel.Controls.Add(Me.BbcRevolutionaryRadioButton4)
        Me.CompressionPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.CompressionPanel.Location = New System.Drawing.Point(0, 0)
        Me.CompressionPanel.Name = "CompressionPanel"
        Me.CompressionPanel.Size = New System.Drawing.Size(344, 131)
        Me.CompressionPanel.TabIndex = 0
        '
        'BbcRevolutionaryRadioButton3
        '
        Me.BbcRevolutionaryRadioButton3.AutoSize = True
        Me.BbcRevolutionaryRadioButton3.Location = New System.Drawing.Point(7, 69)
        Me.BbcRevolutionaryRadioButton3.Name = "BbcRevolutionaryRadioButton3"
        Me.BbcRevolutionaryRadioButton3.RegistryKeyToWriteValue = BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser
        Me.BbcRevolutionaryRadioButton3.RegistryLocationToWritePath = "Software\Balfour's Business\Elements Office Ultra\Data Project Ultra Edition"
        Me.BbcRevolutionaryRadioButton3.RegistryLocationToWriteValue = "compressionType"
        Me.BbcRevolutionaryRadioButton3.Size = New System.Drawing.Size(128, 17)
        Me.BbcRevolutionaryRadioButton3.TabIndex = 3
        Me.BbcRevolutionaryRadioButton3.Text = "Minimum compression"
        Me.BbcRevolutionaryRadioButton3.UseVisualStyleBackColor = True
        Me.BbcRevolutionaryRadioButton3.ValueToWriteOnCheck = "2"
        '
        'BbcRevolutionaryRadioButton2
        '
        Me.BbcRevolutionaryRadioButton2.AutoSize = True
        Me.BbcRevolutionaryRadioButton2.Checked = True
        Me.BbcRevolutionaryRadioButton2.Location = New System.Drawing.Point(7, 46)
        Me.BbcRevolutionaryRadioButton2.Name = "BbcRevolutionaryRadioButton2"
        Me.BbcRevolutionaryRadioButton2.RegistryKeyToWriteValue = BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser
        Me.BbcRevolutionaryRadioButton2.RegistryLocationToWritePath = "Software\Balfour's Business\Elements Office Ultra\Data Project Ultra Edition"
        Me.BbcRevolutionaryRadioButton2.RegistryLocationToWriteValue = "compressionType"
        Me.BbcRevolutionaryRadioButton2.Size = New System.Drawing.Size(131, 17)
        Me.BbcRevolutionaryRadioButton2.TabIndex = 2
        Me.BbcRevolutionaryRadioButton2.TabStop = True
        Me.BbcRevolutionaryRadioButton2.Text = "Maximum compression"
        Me.BbcRevolutionaryRadioButton2.UseVisualStyleBackColor = True
        Me.BbcRevolutionaryRadioButton2.ValueToWriteOnCheck = "1"
        '
        'BbcRevolutionaryRadioButton1
        '
        Me.BbcRevolutionaryRadioButton1.AutoSize = True
        Me.BbcRevolutionaryRadioButton1.Location = New System.Drawing.Point(7, 23)
        Me.BbcRevolutionaryRadioButton1.Name = "BbcRevolutionaryRadioButton1"
        Me.BbcRevolutionaryRadioButton1.RegistryKeyToWriteValue = BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser
        Me.BbcRevolutionaryRadioButton1.RegistryLocationToWritePath = "Software\Balfour's Business\Elements Office Ultra\Data Project Ultra Edition"
        Me.BbcRevolutionaryRadioButton1.RegistryLocationToWriteValue = "compressionType"
        Me.BbcRevolutionaryRadioButton1.Size = New System.Drawing.Size(229, 17)
        Me.BbcRevolutionaryRadioButton1.TabIndex = 1
        Me.BbcRevolutionaryRadioButton1.Text = "Ask me each time what compression to use"
        Me.BbcRevolutionaryRadioButton1.UseVisualStyleBackColor = True
        Me.BbcRevolutionaryRadioButton1.ValueToWriteOnCheck = "3"
        '
        'BbcRevolutionaryRadioButton4
        '
        Me.BbcRevolutionaryRadioButton4.AutoSize = True
        Me.BbcRevolutionaryRadioButton4.Location = New System.Drawing.Point(7, 92)
        Me.BbcRevolutionaryRadioButton4.Name = "BbcRevolutionaryRadioButton4"
        Me.BbcRevolutionaryRadioButton4.RegistryKeyToWriteValue = BalfoursBusinessClassLibrary.BBMRegistryActions.RegistryType.CurrentUser
        Me.BbcRevolutionaryRadioButton4.RegistryLocationToWritePath = "Software\Balfour's Business\Elements Office Ultra\Data Project Ultra Edition"
        Me.BbcRevolutionaryRadioButton4.RegistryLocationToWriteValue = "compressionType"
        Me.BbcRevolutionaryRadioButton4.Size = New System.Drawing.Size(141, 17)
        Me.BbcRevolutionaryRadioButton4.TabIndex = 0
        Me.BbcRevolutionaryRadioButton4.Text = "UltraSpeed Compression"
        Me.BbcRevolutionaryRadioButton4.UseVisualStyleBackColor = True
        Me.BbcRevolutionaryRadioButton4.ValueToWriteOnCheck = "3"
        '
        'MainMDITabControl
        '
        Me.MainMDITabControl.AddDefaultContextItemsAfter = True
        Me.MainMDITabControl.AddDefaultContextItemsBefore = True
        Me.MainMDITabControl.AddRecentAndFavouritesToMenu = False
        Me.MainMDITabControl.Alignment = BalfoursBusinessClassLibrary.BBCTabControlWithOrb.TabAlignment.Top
        Me.MainMDITabControl.BackColor = System.Drawing.Color.Black
        Me.MainMDITabControl.BackHighColor = System.Drawing.Color.Transparent
        Me.MainMDITabControl.BackLowColor = System.Drawing.Color.Transparent
        Me.MainMDITabControl.DefaultOrbMenu = True
        Me.MainMDITabControl.DefaultSoftwareColour = System.Drawing.Color.White
        Me.MainMDITabControl.DelayDrag = True
        Me.MainMDITabControl.DeleteTabsMode = False
        Me.MainMDITabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainMDITabControl.DropDownFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.MainMDITabControl.DropDownItemList = Me.DropDownItemList
        Me.MainMDITabControl.FontBoldOnSelect = False
        Me.MainMDITabControl.ForeColor = System.Drawing.Color.White
        Me.MainMDITabControl.ForeColorDisabled = System.Drawing.Color.Black
        Me.MainMDITabControl.LeftOffset = 3
        Me.MainMDITabControl.LinkedBBCBottomBar = Me.BbcStatusBar1
        Me.MainMDITabControl.LinkedBBCTopBar = Me.BbcTopBar1
        Me.MainMDITabControl.LinkedForm = Me
        Me.MainMDITabControl.LinkedGlassControl1 = Me.BlackTopBar
        Me.MainMDITabControl.LinkedTopBar = Nothing
        Me.MainMDITabControl.Location = New System.Drawing.Point(354, 0)
        Me.MainMDITabControl.MenuRenderer = Nothing
        Me.MainMDITabControl.Name = "MainMDITabControl"
        Me.MainMDITabControl.OrbGlowOnHover = True
        Me.MainMDITabControl.OrbImage = CType(resources.GetObject("MainMDITabControl.OrbImage"), System.Drawing.Image)
        Me.MainMDITabControl.OrbTooltip = Nothing
        Me.MainMDITabControl.OrbVisible = True
        Me.MainMDITabControl.OrbWidth = 28
        Me.MainMDITabControl.OverrideTheme = True
        Me.MainMDITabControl.PingSpeed = 1000.0!
        Me.MainMDITabControl.RegistryLocation = "Software\Balfour's Business\Elements Office Ultra\Data Project Ultra Edition"
        Me.MainMDITabControl.SetBackLowColorWithTheme = True
        Me.MainMDITabControl.SetFormTextAutomatically = True
        Me.MainMDITabControl.ShowAddNewBrowserButton = False
        Me.MainMDITabControl.Size = New System.Drawing.Size(654, 730)
        Me.MainMDITabControl.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.MainMDITabControl.TabApplicationWebsite = Nothing
        Me.MainMDITabControl.TabBackHighAlpha = 100
        Me.MainMDITabControl.TabBackHighColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MainMDITabControl.TabBackLowColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.MainMDITabControl.TabBorderEnhanceWeight = BalfoursBusinessClassLibrary.BBCTabControlWithOrb.Weight.Medium
        Me.MainMDITabControl.TabCloseButtonImage = Nothing
        Me.MainMDITabControl.TabCloseButtonImageDisabled = Nothing
        Me.MainMDITabControl.TabCloseButtonImageHot = Nothing
        Me.MainMDITabControl.TabControlIcon = Nothing
        Me.MainMDITabControl.TabIndex = 2
        Me.MainMDITabControl.TabMinimumWidth = 200
        Me.MainMDITabControl.TabPingColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.MainMDITabControl.TabsDirection = BalfoursBusinessClassLibrary.BBCTabControlWithOrb.FlowDirection.LeftToRight
        Me.MainMDITabControl.TabSpecification = "Document"
        Me.MainMDITabControl.Theme = BalfoursBusinessClassLibrary.BBCTabControlWithOrb.ThemeType.GlassTheme
        Me.MainMDITabControl.ThemeCustomFilename = Nothing
        Me.MainMDITabControl.TopSeparator = False
        Me.MainMDITabControl.UseCircularOrb = True
        Me.MainMDITabControl.UseCustomColours = False
        Me.MainMDITabControl.UseDragOnBar = True
        Me.MainMDITabControl.UseGenericBBTheme = True
        Me.MainMDITabControl.UseInvertColourOnDropDownButtonOnGlassTheme = False
        Me.MainMDITabControl.UseThemes = True
        Me.MainMDITabControl.WebsiteForThemeDownload = "http://www.jamiebalfour.co.uk/Business/Theme.bbt"
        '
        'BbcStatusBar1
        '
        Me.BbcStatusBar1.BackgroundImage = CType(resources.GetObject("BbcStatusBar1.BackgroundImage"), System.Drawing.Image)
        Me.BbcStatusBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BbcStatusBar1.CopyrightLabelBorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BbcStatusBar1.CopyrightText = "Data Project Ultra Edition Copyright 2011 Balfour's Business"
        Me.BbcStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BbcStatusBar1.ForeColor = System.Drawing.Color.White
        Me.BbcStatusBar1.LinkedForm = Nothing
        Me.BbcStatusBar1.Location = New System.Drawing.Point(0, 702)
        Me.BbcStatusBar1.Name = "BbcStatusBar1"
        Me.BbcStatusBar1.Recent1String = "Recent 1"
        Me.BbcStatusBar1.Recent2String = "Recent 2"
        Me.BbcStatusBar1.Recent3String = "Recent 3"
        Me.BbcStatusBar1.Recent4String = "Recent 4"
        Me.BbcStatusBar1.RotatingOrb = CType(resources.GetObject("BbcStatusBar1.RotatingOrb"), System.Drawing.Image)
        Me.BbcStatusBar1.RotatingOrbBackColour = System.Drawing.Color.Transparent
        Me.BbcStatusBar1.RotatingOrbBorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BbcStatusBar1.ShowCloseOnStartMenu = False
        Me.BbcStatusBar1.ShowDocumentsOnStartMenu = False
        Me.BbcStatusBar1.ShowOrb = True
        Me.BbcStatusBar1.ShowProgramsOnStartMenu = False
        Me.BbcStatusBar1.ShowSettingsOnStartMenu = False
        Me.BbcStatusBar1.ShowStartMenu = False
        Me.BbcStatusBar1.Size = New System.Drawing.Size(1008, 28)
        Me.BbcStatusBar1.TabIndex = 0
        Me.BbcStatusBar1.UseHyperMode = False
        '
        'BbcTopBar1
        '
        Me.BbcTopBar1.BackgroundImage = CType(resources.GetObject("BbcTopBar1.BackgroundImage"), System.Drawing.Image)
        Me.BbcTopBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BbcTopBar1.BoldText = "ultra"
        Me.BbcTopBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BbcTopBar1.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BbcTopBar1.ForeColor = System.Drawing.Color.White
        Me.BbcTopBar1.HoverColor = System.Drawing.Color.LightBlue
        Me.BbcTopBar1.LinkedForm = Me
        Me.BbcTopBar1.Location = New System.Drawing.Point(0, 0)
        Me.BbcTopBar1.MainImage = CType(resources.GetObject("BbcTopBar1.MainImage"), System.Drawing.Image)
        Me.BbcTopBar1.Name = "BbcTopBar1"
        Me.BbcTopBar1.ShowHelpAndSupport = False
        Me.BbcTopBar1.Size = New System.Drawing.Size(1008, 65)
        Me.BbcTopBar1.StandardText1 = "data project"
        Me.BbcTopBar1.StandardText2 = "edition"
        Me.BbcTopBar1.TabIndex = 1
        Me.BbcTopBar1.UseNonStandardSizes = False
        '
        'DataProjectMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.MainMDITabControl)
        Me.Controls.Add(Me.SidebarWithGlassPanel)
        Me.Controls.Add(Me.BbcTopBar1)
        Me.Controls.Add(Me.BbcStatusBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "DataProjectMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Data Project Ultra Edition"
        Me.DropDownItemList.ResumeLayout(False)
        Me.SidebarWithGlassPanel.ResumeLayout(False)
        Me.OptionContainerPanel.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.CheckBoxPanel.ResumeLayout(False)
        Me.CheckBoxPanel.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.CompressionPanel.ResumeLayout(False)
        Me.CompressionPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BbcStatusBar1 As BalfoursBusinessClassLibrary.BBCBottomBar
    Friend WithEvents BbcTopBar1 As BalfoursBusinessClassLibrary.BBCTopBar
    Friend WithEvents MainMDITabControl As BalfoursBusinessClassLibrary.BBCTabControlWithOrb
    Friend WithEvents DropDownItemList As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseTabsOnClickToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataProjectSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SidebarWithGlassPanel As System.Windows.Forms.Panel
    Friend WithEvents OptionContainerPanel As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents CheckBoxPanel As System.Windows.Forms.Panel
    Friend WithEvents BbcRevolutionaryCheckbox3 As BalfoursBusinessClassLibrary.BBCRevolutionaryCheckbox
    Friend WithEvents BbcRevolutionaryCheckbox2 As BalfoursBusinessClassLibrary.BBCRevolutionaryCheckbox
    Friend WithEvents lblChangeInfo As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdDeleteOracleFile As System.Windows.Forms.Button
    Friend WithEvents cmdChangeDefaultFont As System.Windows.Forms.Button
    Friend WithEvents cmdAssociateFiles As System.Windows.Forms.Button
    Friend WithEvents cmdObtainStickyEncryptID As System.Windows.Forms.Button
    Friend WithEvents cmdInsertAnID As System.Windows.Forms.Button
    Friend WithEvents cmdCreateInstallationFile As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents CompressionPanel As System.Windows.Forms.Panel
    Friend WithEvents BbcRevolutionaryRadioButton3 As BalfoursBusinessClassLibrary.BBCRevolutionaryRadioButton
    Friend WithEvents BbcRevolutionaryRadioButton2 As BalfoursBusinessClassLibrary.BBCRevolutionaryRadioButton
    Friend WithEvents BbcRevolutionaryRadioButton1 As BalfoursBusinessClassLibrary.BBCRevolutionaryRadioButton
    Friend WithEvents BbcRevolutionaryRadioButton4 As BalfoursBusinessClassLibrary.BBCRevolutionaryRadioButton
    Friend WithEvents BlackTopBar As System.Windows.Forms.Panel
End Class
