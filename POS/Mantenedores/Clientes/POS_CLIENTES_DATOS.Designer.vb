﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class POS_CLIENTES_DATOS
    Inherits DevExpress.XtraEditors.XtraForm
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    '''
    Private Sub InitializeComponent()
        Me.dataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.windowsUIButtonPanelCloseButton = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.windowsUIButtonPanelMain = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.labelControl = New DevExpress.XtraEditors.LabelControl()
        CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataLayoutControl1
        '
        Me.dataLayoutControl1.AllowCustomization = False
        Me.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataLayoutControl1.Location = New System.Drawing.Point(68, 47)
        Me.dataLayoutControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.dataLayoutControl1.Name = "dataLayoutControl1"
        Me.dataLayoutControl1.Root = Me.layoutControlGroup1
        Me.dataLayoutControl1.Size = New System.Drawing.Size(1108, 685)
        Me.dataLayoutControl1.TabIndex = 0
        '
        'layoutControlGroup1
        '
        Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.layoutControlGroup1.GroupBordersVisible = False
        Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.layoutControlGroup1.Name = "Root"
        Me.layoutControlGroup1.Size = New System.Drawing.Size(1108, 685)
        Me.layoutControlGroup1.TextVisible = False
        '
        'windowsUIButtonPanelCloseButton
        '
        Me.windowsUIButtonPanelCloseButton.ButtonInterval = 0
        Me.windowsUIButtonPanelCloseButton.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("", Nothing, "Backward;Size32x32;GrayScaled")})
        Me.windowsUIButtonPanelCloseButton.ContentAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.windowsUIButtonPanelCloseButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.windowsUIButtonPanelCloseButton.ForeColor = System.Drawing.Color.Gray
        Me.windowsUIButtonPanelCloseButton.Location = New System.Drawing.Point(0, 0)
        Me.windowsUIButtonPanelCloseButton.Margin = New System.Windows.Forms.Padding(4)
        Me.windowsUIButtonPanelCloseButton.MaximumSize = New System.Drawing.Size(68, 0)
        Me.windowsUIButtonPanelCloseButton.MinimumSize = New System.Drawing.Size(68, 0)
        Me.windowsUIButtonPanelCloseButton.Name = "windowsUIButtonPanelCloseButton"
        Me.windowsUIButtonPanelCloseButton.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.windowsUIButtonPanelCloseButton.Padding = New System.Windows.Forms.Padding(8, 7, 0, 0)
        Me.windowsUIButtonPanelCloseButton.Size = New System.Drawing.Size(68, 732)
        Me.windowsUIButtonPanelCloseButton.TabIndex = 2
        Me.windowsUIButtonPanelCloseButton.Text = "windowsUIButtonPanel1"
        Me.windowsUIButtonPanelCloseButton.UseButtonBackgroundImages = False
        '
        'windowsUIButtonPanelMain
        '
        Me.windowsUIButtonPanelMain.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.windowsUIButtonPanelMain.AppearanceButton.Hovered.FontSizeDelta = -1
        Me.windowsUIButtonPanelMain.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseBackColor = True
        Me.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseFont = True
        Me.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseForeColor = True
        Me.windowsUIButtonPanelMain.AppearanceButton.Normal.FontSizeDelta = -1
        Me.windowsUIButtonPanelMain.AppearanceButton.Normal.Options.UseFont = True
        Me.windowsUIButtonPanelMain.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.windowsUIButtonPanelMain.AppearanceButton.Pressed.FontSizeDelta = -1
        Me.windowsUIButtonPanelMain.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseBackColor = True
        Me.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseFont = True
        Me.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseForeColor = True
        Me.windowsUIButtonPanelMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.windowsUIButtonPanelMain.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Guardar", Nothing, "Save;Size32x32;GrayScaled"), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Guardar y Cerrar", Nothing, "SaveAndClose;Size32x32;GrayScaled"), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Guardar y Nuevo", Nothing, "SaveAndNew;Size32x32;GrayScaled"), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Actualizar", Nothing, "Reset;Size32x32;GrayScaled"), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Eliminar", Nothing, "Edit/Delete;Size32x32;GrayScaled")})
        Me.windowsUIButtonPanelMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.windowsUIButtonPanelMain.EnableImageTransparency = True
        Me.windowsUIButtonPanelMain.ForeColor = System.Drawing.Color.White
        Me.windowsUIButtonPanelMain.Location = New System.Drawing.Point(0, 732)
        Me.windowsUIButtonPanelMain.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.windowsUIButtonPanelMain.MaximumSize = New System.Drawing.Size(0, 88)
        Me.windowsUIButtonPanelMain.MinimumSize = New System.Drawing.Size(90, 88)
        Me.windowsUIButtonPanelMain.Name = "windowsUIButtonPanelMain"
        Me.windowsUIButtonPanelMain.Size = New System.Drawing.Size(1176, 88)
        Me.windowsUIButtonPanelMain.TabIndex = 3
        Me.windowsUIButtonPanelMain.Text = "windowsUIButtonPanelMain"
        Me.windowsUIButtonPanelMain.UseButtonBackgroundImages = False
        '
        'labelControl
        '
        Me.labelControl.AllowHtmlString = True
        Me.labelControl.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.labelControl.Appearance.Options.UseFont = True
        Me.labelControl.Appearance.Options.UseForeColor = True
        Me.labelControl.Appearance.Options.UseTextOptions = True
        Me.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.labelControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelControl.Location = New System.Drawing.Point(68, 0)
        Me.labelControl.Margin = New System.Windows.Forms.Padding(4)
        Me.labelControl.Name = "labelControl"
        Me.labelControl.Padding = New System.Windows.Forms.Padding(15, 7, 0, 0)
        Me.labelControl.Size = New System.Drawing.Size(1108, 47)
        Me.labelControl.TabIndex = 1
        Me.labelControl.Text = "Datos Cliente"
        '
        'POS_CLIENTES_DATOS
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(1176, 820)
        Me.Controls.Add(Me.dataLayoutControl1)
        Me.Controls.Add(Me.labelControl)
        Me.Controls.Add(Me.windowsUIButtonPanelCloseButton)
        Me.Controls.Add(Me.windowsUIButtonPanelMain)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "POS_CLIENTES_DATOS"
        CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Private windowsUIButtonPanelCloseButton As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Private windowsUIButtonPanelMain As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Private labelControl As DevExpress.XtraEditors.LabelControl
End Class
