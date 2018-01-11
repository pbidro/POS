Public Class POS_VENTA


    Private Sub RibbonForm1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Show()
        txtBuscar.Select()
        InitializeDataGridView()
        TabControl1.TabPages(1).Enabled = False
        'TabControl1.TabPages(1).Text = "deshabilitado"
        txtBuscar.Text = PtxtBuscar



    End Sub


    Private Sub InitializeDataGridView()

        '' Create an unbound DataGridView by declaring a column count.
        'dgv.ColumnCount = 3
        'dgv.ColumnHeadersVisible = True

        '' Set the column header style.
        'Dim columnHeaderStyle As New DataGridViewCellStyle()

        'columnHeaderStyle.BackColor = Color.Beige
        'columnHeaderStyle.Font = New Font("Verdana", 10, FontStyle.Bold)
        'dgv.ColumnHeadersDefaultCellStyle = columnHeaderStyle

        '' Set the column header names.
        'dgv.Columns(0).Name = "Código"
        'dgv.Columns(1).Name = "Descripción"
        'dgv.Columns(2).Name = "Precio"

        '' Populate the rows.
        'Dim row1() As String = {"00001", "Diclofenaco", "100"}
        'Dim row2() As String = {"00002", "Aspirina", "200"}
        'Dim row3() As String = {"00003", "Clotrimazol", "300"}
        'Dim row4() As String = {"00004", "Clorfenamina", "400"}
        'Dim row5() As String = {"00005", "Salbutamol", "500"}
        'Dim row6() As String = {"00006", "Ibuprofeno", "600"}
        'Dim row7() As String = {"00006", "Paracetamol", "700"}
        'Dim rows() As Object = {row1, row2, row3, row4, row5, row6, row7}

        'Dim rowArray As String()
        'For Each rowArray In rows
        '    dgv.Rows.Add(rowArray)
        'Next rowArray
        'Dim total As Integer

        'Dim Col As Integer = Me.dgv.CurrentCell.ColumnIndex
        'For Each row As DataGridViewRow In Me.dgv.Rows
        '    total += Convert.ToInt32(Val(row.Cells(2).Value))
        'Next
        'LTotal.Text = total.ToString


    End Sub

    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp
        PtxtBuscar = txtBuscar.Text
    End Sub




    'Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click


    '    ' Multiple-line syntax:  
    '    If dgv.Rows.Count <> 0 Then
    '        TabControl1.TabPages(1).Enabled = True
    '        TabControl1.SelectedIndex = 1
    '    End If

    'End Sub


End Class
