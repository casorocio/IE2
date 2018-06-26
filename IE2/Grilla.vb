Public Class Grilla
    Private Sub Grilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = lst
    End Sub
    Private Sub Elimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Elimina.Click
        Form1.operacion = "elimina"
        Form1.Text = "Eliminar Contribuyente"
        Form1.indice = DataGridView1.CurrentRow.Index
        llenarform()
        Form1.Show()
    End Sub
    Private Sub llenarform()
        Form1.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        Form1.TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        Form1.TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        Form1.ComboBox1.SelectedItem = DataGridView1.CurrentRow.Cells(3).Value.ToString
        Form1.ComboBox2.SelectedItem = DataGridView1.CurrentRow.Cells(4).Value.ToString
        Form1.ComboBox3.SelectedItem = DataGridView1.CurrentRow.Cells(4).Value.ToString
    End Sub

    Private Sub Modifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modifica.Click
        Form1.operacion = "modifica"
        Form1.Text = "Modificar Articulo"
        Form1.indice = DataGridView1.CurrentRow.Index
        llenarform()
        Form1.Show()
    End Sub
    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        Form1.operacion = "nuevo"
        Form1.Text = "Nuevo contribuyente"
        Form1.Show()
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub
End Class