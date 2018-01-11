Partial Public Class POS_Main
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
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(POS_Main))
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement5 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement6 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.TileNavPane1 = New DevExpress.XtraBars.Navigation.TileNavPane()
        Me.NavButton2 = New DevExpress.XtraBars.Navigation.NavButton()
        Me.Configuracion = New DevExpress.XtraBars.Navigation.NavButton()
        Me.Ayuda = New DevExpress.XtraBars.Navigation.NavButton()
        Me.Salir = New DevExpress.XtraBars.Navigation.NavButton()
        Me.Ventas = New DevExpress.XtraBars.Navigation.TileNavItem()
        Me.Clientes = New DevExpress.XtraBars.Navigation.TileNavItem()
        Me.Productos = New DevExpress.XtraBars.Navigation.TileNavItem()
        Me.Inventario = New DevExpress.XtraBars.Navigation.TileNavItem()
        Me.Caja = New DevExpress.XtraBars.Navigation.TileNavItem()
        Me.Informes = New DevExpress.XtraBars.Navigation.TileNavItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.TileNavPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TileNavPane1
        '
        Me.TileNavPane1.ButtonPadding = New System.Windows.Forms.Padding(12)
        Me.TileNavPane1.Buttons.Add(Me.NavButton2)
        Me.TileNavPane1.Buttons.Add(Me.Configuracion)
        Me.TileNavPane1.Buttons.Add(Me.Ayuda)
        Me.TileNavPane1.Buttons.Add(Me.Salir)
        '
        'TileNavCategory1
        '
        Me.TileNavPane1.DefaultCategory.Items.AddRange(New DevExpress.XtraBars.Navigation.TileNavItem() {Me.Ventas, Me.Clientes, Me.Productos, Me.Inventario, Me.Caja, Me.Informes})
        Me.TileNavPane1.DefaultCategory.Name = "TileNavCategory1"
        Me.TileNavPane1.DefaultCategory.OptionsDropDown.BackColor = System.Drawing.Color.Empty
        Me.TileNavPane1.DefaultCategory.OwnerCollection = Nothing
        '
        '
        '
        Me.TileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        Me.TileNavPane1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TileNavPane1.Location = New System.Drawing.Point(0, 0)
        Me.TileNavPane1.Name = "TileNavPane1"
        Me.TileNavPane1.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty
        Me.TileNavPane1.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty
        Me.TileNavPane1.Size = New System.Drawing.Size(1354, 48)
        Me.TileNavPane1.TabIndex = 0
        Me.TileNavPane1.Text = "TileNavPane1"
        '
        'NavButton2
        '
        Me.NavButton2.Caption = "Plataforma"
        Me.NavButton2.Glyph = CType(resources.GetObject("NavButton2.Glyph"), System.Drawing.Image)
        Me.NavButton2.IsMain = True
        Me.NavButton2.Name = "NavButton2"
        '
        'Configuracion
        '
        Me.Configuracion.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right
        Me.Configuracion.Caption = "Configuracion"
        Me.Configuracion.Glyph = CType(resources.GetObject("Configuracion.Glyph"), System.Drawing.Image)
        Me.Configuracion.Name = "Configuracion"
        '
        'Ayuda
        '
        Me.Ayuda.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right
        Me.Ayuda.Caption = "Ayuda"
        Me.Ayuda.Glyph = CType(resources.GetObject("Ayuda.Glyph"), System.Drawing.Image)
        Me.Ayuda.Name = "Ayuda"
        '
        'Salir
        '
        Me.Salir.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right
        Me.Salir.Caption = "Salir"
        Me.Salir.Glyph = CType(resources.GetObject("Salir.Glyph"), System.Drawing.Image)
        Me.Salir.Name = "Salir"
        '
        'Ventas
        '
        Me.Ventas.Caption = "Ventas"
        Me.Ventas.Name = "Ventas"
        Me.Ventas.OptionsDropDown.BackColor = System.Drawing.Color.Empty
        Me.Ventas.OwnerCollection = Me.TileNavPane1.DefaultCategory.Items
        '
        '
        '
        Me.Ventas.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement1.Image = CType(resources.GetObject("TileItemElement1.Image"), System.Drawing.Image)
        TileItemElement1.Text = "Ventas"
        Me.Ventas.Tile.Elements.Add(TileItemElement1)
        Me.Ventas.Tile.Name = "TileBarItem1"
        '
        'Clientes
        '
        Me.Clientes.Caption = "Clientes"
        Me.Clientes.Name = "Clientes"
        Me.Clientes.OptionsDropDown.BackColor = System.Drawing.Color.Empty
        Me.Clientes.OwnerCollection = Me.TileNavPane1.DefaultCategory.Items
        '
        '
        '
        Me.Clientes.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement2.Image = CType(resources.GetObject("TileItemElement2.Image"), System.Drawing.Image)
        TileItemElement2.Text = "Clientes"
        Me.Clientes.Tile.Elements.Add(TileItemElement2)
        Me.Clientes.Tile.Name = "TileBarItem1"
        '
        'Productos
        '
        Me.Productos.Caption = "Productos"
        Me.Productos.Name = "Productos"
        Me.Productos.OptionsDropDown.BackColor = System.Drawing.Color.Empty
        Me.Productos.OwnerCollection = Me.TileNavPane1.DefaultCategory.Items
        '
        '
        '
        Me.Productos.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement3.Image = CType(resources.GetObject("TileItemElement3.Image"), System.Drawing.Image)
        TileItemElement3.Text = "Productos"
        Me.Productos.Tile.Elements.Add(TileItemElement3)
        Me.Productos.Tile.Name = "TileBarItem3"
        '
        'Inventario
        '
        Me.Inventario.Caption = "Inventario"
        Me.Inventario.Name = "Inventario"
        Me.Inventario.OptionsDropDown.BackColor = System.Drawing.Color.Empty
        Me.Inventario.OwnerCollection = Me.TileNavPane1.DefaultCategory.Items
        '
        '
        '
        Me.Inventario.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement4.Image = CType(resources.GetObject("TileItemElement4.Image"), System.Drawing.Image)
        TileItemElement4.Text = "Inventario"
        Me.Inventario.Tile.Elements.Add(TileItemElement4)
        Me.Inventario.Tile.Name = "TileBarItem2"
        '
        'Caja
        '
        Me.Caja.Caption = "Caja"
        Me.Caja.Name = "Caja"
        Me.Caja.OptionsDropDown.BackColor = System.Drawing.Color.Empty
        Me.Caja.OwnerCollection = Me.TileNavPane1.DefaultCategory.Items
        '
        '
        '
        Me.Caja.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement5.Image = CType(resources.GetObject("TileItemElement5.Image"), System.Drawing.Image)
        TileItemElement5.Text = "Caja"
        Me.Caja.Tile.Elements.Add(TileItemElement5)
        Me.Caja.Tile.Name = "TileBarItem5"
        '
        'Informes
        '
        Me.Informes.Caption = "Informes"
        Me.Informes.Name = "Informes"
        Me.Informes.OptionsDropDown.BackColor = System.Drawing.Color.Empty
        Me.Informes.OwnerCollection = Me.TileNavPane1.DefaultCategory.Items
        '
        '
        '
        Me.Informes.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement6.Image = CType(resources.GetObject("TileItemElement6.Image"), System.Drawing.Image)
        TileItemElement6.Text = "Informes"
        Me.Informes.Tile.Elements.Add(TileItemElement6)
        Me.Informes.Tile.Name = "TileBarItem4"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 48)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1354, 500)
        Me.Panel1.TabIndex = 1
        '
        'POS_Main
        '
        Me.ClientSize = New System.Drawing.Size(1354, 548)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TileNavPane1)
        Me.Name = "POS_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SENEG-POS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TileNavPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TileNavPane1 As DevExpress.XtraBars.Navigation.TileNavPane
    Friend WithEvents NavButton2 As DevExpress.XtraBars.Navigation.NavButton
    Friend WithEvents Ventas As DevExpress.XtraBars.Navigation.TileNavItem
    Friend WithEvents Clientes As DevExpress.XtraBars.Navigation.TileNavItem
    Friend WithEvents Productos As DevExpress.XtraBars.Navigation.TileNavItem
    Friend WithEvents Inventario As DevExpress.XtraBars.Navigation.TileNavItem
    Friend WithEvents Informes As DevExpress.XtraBars.Navigation.TileNavItem
    Friend WithEvents Configuracion As DevExpress.XtraBars.Navigation.NavButton
    Friend WithEvents Ayuda As DevExpress.XtraBars.Navigation.NavButton
    Friend WithEvents Salir As DevExpress.XtraBars.Navigation.NavButton
    Friend WithEvents Caja As DevExpress.XtraBars.Navigation.TileNavItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

#End Region

End Class
