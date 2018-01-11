Imports System.ComponentModel
Imports System.Text



Partial Public Class POS_Main
    Dim frmLoad As Form


    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub TileNavPane1_Click(sender As Object, e As EventArgs) Handles TileNavPane1.Click

    End Sub

    'Private Sub TileNavPane1_ElementClick(sender As Object, e As NavElementEventArgs)
    '    ' Determine the navigation element being clicked using the e.Element property  
    '    ' and perform the required action. In this example, the Home button click  
    '    ' nullifies the element currently selected in the TileNavPane.  
    '    If e.Element.Name = "Home" Then
    '        TileNavPane1.SelectedElement = Nothing
    '    End If
    'End Sub

    Private Sub TileNavPane1_ElementClick(sender As Object, e As DevExpress.XtraBars.Navigation.NavElementEventArgs) Handles TileNavPane1.ElementClick
        '    ' Determine the navigation element being clicked using the e.Element property  
        '    ' and perform the required action. In this example, the Home button click  
        '    ' nullifies the element currently selected in the TileNavPane.  
        Select Case e.Element.Name
            Case "Ventas"
                RemoveControl()
                Dim frm2 As POS_VENTA = New POS_VENTA()
                Me.Text = "SENEG-POS - Productos"
                cargar_panel(frm2)


            Case "Clientes"
                RemoveControl()
                Dim frm2 As POS_CLIENTES = New POS_CLIENTES()
                Me.Text = "SENEG-POS - Clientes"

                cargar_panel(frm2)
            Case "Productos"
                RemoveControl()
                Dim frm2 As POS_CLIENTES_DATOS = New POS_CLIENTES_DATOS()
                Me.Text = "SENEG-POS - Productos"
                cargar_panel(frm2)
            Case "Salir"
                Application.Exit()
            Case Else
                TileNavPane1.SelectedElement = Nothing
        End Select

    End Sub

    Private Sub cargar_panel(frm As Form)



        Try
            frmLoad = frm
            frmLoad.TopLevel = False
            frmLoad.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            frmLoad.Dock = DockStyle.Fill
            frmLoad.MaximizeBox = True
            frm.Anchor = AnchorStyles.Bottom
            frm.Anchor = AnchorStyles.Top
            frm.Anchor = AnchorStyles.Left
            frm.Anchor = AnchorStyles.Right
            Panel1.Controls.Add(frmLoad)
            frmLoad.Show()
        Catch ex As Exception
            frmLoad = frm
            frmLoad.TopLevel = False
            frmLoad.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            frmLoad.Dock = DockStyle.Fill
            frmLoad.MaximizeBox = True
            frm.Anchor = AnchorStyles.Bottom
            frm.Anchor = AnchorStyles.Top
            frm.Anchor = AnchorStyles.Left
            frm.Anchor = AnchorStyles.Right
            Panel1.Controls.Add(frmLoad)
            frmLoad.Show()
        End Try




    End Sub

    Public Sub RemoveControl()

        If Panel1.Controls.Contains(frmLoad) Then
            Panel1.Controls.Remove(frmLoad)
            frmLoad.Dispose()
        End If
    End Sub



    Private Sub _MainPanel_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged


        'Dim frm2 As POS_VENTA = New POS_VENTA()
        'Me.Text = "SENEG-POS - Productos"
        'cargar_panel(frm2)


    End Sub

End Class
