<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txtAssemAddress = New Telerik.WinControls.UI.RadTextBox()
        Me.BrowseBtn = New Telerik.WinControls.UI.RadButton()
        Me.cbExcludeDotNetAssemblies = New Telerik.WinControls.UI.RadCheckBox()
        Me.lblAssemList = New Telerik.WinControls.UI.RadListView()
        Me.GetDepenBtn = New Telerik.WinControls.UI.RadButton()
        Me.CopyBtn = New Telerik.WinControls.UI.RadButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.cbIgnoreNotFound = New Telerik.WinControls.UI.RadCheckBox()
        CType(Me.RadLabel1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtAssemAddress,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.BrowseBtn,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cbExcludeDotNetAssemblies,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblAssemList,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GetDepenBtn,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CopyBtn,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cbIgnoreNotFound,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(12, 21)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(107, 18)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Main Assembly File :"
        '
        'txtAssemAddress
        '
        Me.txtAssemAddress.Location = New System.Drawing.Point(125, 21)
        Me.txtAssemAddress.Name = "txtAssemAddress"
        Me.txtAssemAddress.Size = New System.Drawing.Size(489, 20)
        Me.txtAssemAddress.TabIndex = 1
        '
        'BrowseBtn
        '
        Me.BrowseBtn.Location = New System.Drawing.Point(632, 19)
        Me.BrowseBtn.Name = "BrowseBtn"
        Me.BrowseBtn.Size = New System.Drawing.Size(110, 24)
        Me.BrowseBtn.TabIndex = 1
        Me.BrowseBtn.Text = "Browse"
        '
        'cbExcludeDotNetAssemblies
        '
        Me.cbExcludeDotNetAssemblies.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbExcludeDotNetAssemblies.Location = New System.Drawing.Point(12, 56)
        Me.cbExcludeDotNetAssemblies.Name = "cbExcludeDotNetAssemblies"
        Me.cbExcludeDotNetAssemblies.Size = New System.Drawing.Size(250, 18)
        Me.cbExcludeDotNetAssemblies.TabIndex = 2
        Me.cbExcludeDotNetAssemblies.Text = "Exclude Microsoft .Net Framework Assemblies"
        Me.cbExcludeDotNetAssemblies.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'lblAssemList
        '
        Me.lblAssemList.Location = New System.Drawing.Point(12, 90)
        Me.lblAssemList.Name = "lblAssemList"
        Me.lblAssemList.Size = New System.Drawing.Size(602, 256)
        Me.lblAssemList.TabIndex = 3
        '
        'GetDepenBtn
        '
        Me.GetDepenBtn.Location = New System.Drawing.Point(632, 54)
        Me.GetDepenBtn.Name = "GetDepenBtn"
        Me.GetDepenBtn.Size = New System.Drawing.Size(110, 24)
        Me.GetDepenBtn.TabIndex = 2
        Me.GetDepenBtn.Text = "Get Dependencies"
        '
        'CopyBtn
        '
        Me.CopyBtn.Location = New System.Drawing.Point(632, 89)
        Me.CopyBtn.Name = "CopyBtn"
        Me.CopyBtn.Size = New System.Drawing.Size(110, 24)
        Me.CopyBtn.TabIndex = 3
        Me.CopyBtn.Text = "Copy Found Files"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = ".Net Assembly File (.exe,.dll)|*.exe;*.dll"
        '
        'cbIgnoreNotFound
        '
        Me.cbIgnoreNotFound.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbIgnoreNotFound.Location = New System.Drawing.Point(279, 56)
        Me.cbIgnoreNotFound.Name = "cbIgnoreNotFound"
        Me.cbIgnoreNotFound.Size = New System.Drawing.Size(110, 18)
        Me.cbIgnoreNotFound.TabIndex = 4
        Me.cbIgnoreNotFound.Text = "Ignore Not Found"
        Me.cbIgnoreNotFound.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 358)
        Me.Controls.Add(Me.cbIgnoreNotFound)
        Me.Controls.Add(Me.CopyBtn)
        Me.Controls.Add(Me.GetDepenBtn)
        Me.Controls.Add(Me.lblAssemList)
        Me.Controls.Add(Me.cbExcludeDotNetAssemblies)
        Me.Controls.Add(Me.BrowseBtn)
        Me.Controls.Add(Me.txtAssemAddress)
        Me.Controls.Add(Me.RadLabel1)
        Me.Name = "Form1"
        Me.Text = "Assembly Dependencies Finder"
        CType(Me.RadLabel1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtAssemAddress,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BrowseBtn,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cbExcludeDotNetAssemblies,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblAssemList,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GetDepenBtn,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CopyBtn,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cbIgnoreNotFound,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtAssemAddress As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents BrowseBtn As Telerik.WinControls.UI.RadButton
    Friend WithEvents cbExcludeDotNetAssemblies As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents lblAssemList As Telerik.WinControls.UI.RadListView
    Friend WithEvents GetDepenBtn As Telerik.WinControls.UI.RadButton
    Friend WithEvents CopyBtn As Telerik.WinControls.UI.RadButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents cbIgnoreNotFound As Telerik.WinControls.UI.RadCheckBox
End Class
