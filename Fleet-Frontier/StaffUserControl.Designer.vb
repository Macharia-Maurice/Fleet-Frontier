﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffUserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffUserControl))
        StaffHeaderPanel = New Panel()
        AddStaffButton = New Button()
        StaffSearchBar = New TextBox()
        StaffLabel = New Label()
        StaffBodyPanel = New Panel()
        StaffTabControl = New TabControl()
        DriverTabPage = New TabPage()
        DriversListPanel = New Panel()
        ConductorTabPage = New TabPage()
        ConductorListPanel = New Panel()
        StaffHeaderPanel.SuspendLayout()
        StaffBodyPanel.SuspendLayout()
        StaffTabControl.SuspendLayout()
        DriverTabPage.SuspendLayout()
        ConductorTabPage.SuspendLayout()
        SuspendLayout()
        ' 
        ' StaffHeaderPanel
        ' 
        StaffHeaderPanel.BackColor = Color.Silver
        StaffHeaderPanel.Controls.Add(AddStaffButton)
        StaffHeaderPanel.Controls.Add(StaffSearchBar)
        StaffHeaderPanel.Controls.Add(StaffLabel)
        StaffHeaderPanel.Dock = DockStyle.Top
        StaffHeaderPanel.Location = New Point(21, 20)
        StaffHeaderPanel.Name = "StaffHeaderPanel"
        StaffHeaderPanel.Size = New Size(982, 67)
        StaffHeaderPanel.TabIndex = 0
        ' 
        ' AddStaffButton
        ' 
        AddStaffButton.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        AddStaffButton.BackColor = Color.Gray
        AddStaffButton.FlatAppearance.BorderSize = 0
        AddStaffButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        AddStaffButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        AddStaffButton.FlatStyle = FlatStyle.Flat
        AddStaffButton.Font = New Font("Gabriola", 12F, FontStyle.Bold)
        AddStaffButton.Location = New Point(818, 15)
        AddStaffButton.Name = "AddStaffButton"
        AddStaffButton.Size = New Size(151, 39)
        AddStaffButton.TabIndex = 4
        AddStaffButton.Text = "Add staff"
        AddStaffButton.UseVisualStyleBackColor = False
        ' 
        ' StaffSearchBar
        ' 
        StaffSearchBar.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        StaffSearchBar.BackColor = Color.White
        StaffSearchBar.Location = New Point(613, 21)
        StaffSearchBar.MinimumSize = New Size(130, 27)
        StaffSearchBar.Name = "StaffSearchBar"
        StaffSearchBar.PlaceholderText = "Search"
        StaffSearchBar.Size = New Size(182, 27)
        StaffSearchBar.TabIndex = 3
        ' 
        ' StaffLabel
        ' 
        StaffLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        StaffLabel.AutoSize = True
        StaffLabel.Font = New Font("MV Boli", 15F, FontStyle.Bold)
        StaffLabel.Image = CType(resources.GetObject("StaffLabel.Image"), Image)
        StaffLabel.ImageAlign = ContentAlignment.MiddleLeft
        StaffLabel.Location = New Point(14, 21)
        StaffLabel.Name = "StaffLabel"
        StaffLabel.Size = New Size(105, 32)
        StaffLabel.TabIndex = 2
        StaffLabel.Text = "  Staff"
        StaffLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' StaffBodyPanel
        ' 
        StaffBodyPanel.BackColor = Color.Silver
        StaffBodyPanel.Controls.Add(StaffTabControl)
        StaffBodyPanel.Dock = DockStyle.Fill
        StaffBodyPanel.Location = New Point(21, 87)
        StaffBodyPanel.Name = "StaffBodyPanel"
        StaffBodyPanel.Size = New Size(982, 554)
        StaffBodyPanel.TabIndex = 1
        ' 
        ' StaffTabControl
        ' 
        StaffTabControl.Appearance = TabAppearance.FlatButtons
        StaffTabControl.Controls.Add(DriverTabPage)
        StaffTabControl.Controls.Add(ConductorTabPage)
        StaffTabControl.Dock = DockStyle.Fill
        StaffTabControl.Font = New Font("Gabriola", 10F, FontStyle.Bold)
        StaffTabControl.Location = New Point(0, 0)
        StaffTabControl.Multiline = True
        StaffTabControl.Name = "StaffTabControl"
        StaffTabControl.Padding = New Point(4, 3)
        StaffTabControl.SelectedIndex = 0
        StaffTabControl.Size = New Size(982, 554)
        StaffTabControl.TabIndex = 0
        ' 
        ' DriverTabPage
        ' 
        DriverTabPage.BackColor = Color.Silver
        DriverTabPage.Controls.Add(DriversListPanel)
        DriverTabPage.Font = New Font("Gabriola", 9F)
        DriverTabPage.Location = New Point(4, 43)
        DriverTabPage.Name = "DriverTabPage"
        DriverTabPage.Padding = New Padding(5)
        DriverTabPage.Size = New Size(974, 507)
        DriverTabPage.TabIndex = 0
        DriverTabPage.Text = "Drivers"
        ' 
        ' DriversListPanel
        ' 
        DriversListPanel.AutoScroll = True
        DriversListPanel.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DriversListPanel.Dock = DockStyle.Fill
        DriversListPanel.Location = New Point(5, 5)
        DriversListPanel.Margin = New Padding(0)
        DriversListPanel.Name = "DriversListPanel"
        DriversListPanel.Padding = New Padding(21, 20, 21, 20)
        DriversListPanel.Size = New Size(964, 497)
        DriversListPanel.TabIndex = 5
        ' 
        ' ConductorTabPage
        ' 
        ConductorTabPage.BackColor = Color.Silver
        ConductorTabPage.Controls.Add(ConductorListPanel)
        ConductorTabPage.Location = New Point(4, 43)
        ConductorTabPage.Name = "ConductorTabPage"
        ConductorTabPage.Padding = New Padding(3)
        ConductorTabPage.Size = New Size(974, 507)
        ConductorTabPage.TabIndex = 1
        ConductorTabPage.Text = "Conductors"
        ' 
        ' ConductorListPanel
        ' 
        ConductorListPanel.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ConductorListPanel.Dock = DockStyle.Fill
        ConductorListPanel.Location = New Point(3, 3)
        ConductorListPanel.Name = "ConductorListPanel"
        ConductorListPanel.Size = New Size(968, 501)
        ConductorListPanel.TabIndex = 0
        ' 
        ' StaffUserControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(StaffBodyPanel)
        Controls.Add(StaffHeaderPanel)
        Name = "StaffUserControl"
        Padding = New Padding(21, 20, 21, 20)
        Size = New Size(1024, 661)
        StaffHeaderPanel.ResumeLayout(False)
        StaffHeaderPanel.PerformLayout()
        StaffBodyPanel.ResumeLayout(False)
        StaffTabControl.ResumeLayout(False)
        DriverTabPage.ResumeLayout(False)
        ConductorTabPage.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents StaffHeaderPanel As Panel
    Friend WithEvents StaffBodyPanel As Panel
    Friend WithEvents StaffLabel As Label
    Friend WithEvents AddStaffButton As Button
    Friend WithEvents StaffSearchBar As TextBox
    Friend WithEvents StaffTabControl As TabControl
    Friend WithEvents DriverTabPage As TabPage
    Friend WithEvents ConductorTabPage As TabPage
    Friend WithEvents DriversListPanel As Panel
    Friend WithEvents ConductorListPanel As Panel

End Class
