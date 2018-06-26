Public Class Form1
    Dim operacion_ As String
    Dim Turno As New TurnosClass
    Dim indice_ As Byte

    Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property

    Property indice() As Byte
        Get
            Return indice_
        End Get
        Set(ByVal value As Byte)
            indice_ = value
        End Set
    End Property

    Private Sub aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        If TextBox1.Text.Length = 0 Then
            MsgBox("Debe ingresar Id")
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MsgBox("Ingrese Fecha")
        End If

        If TextBox3.Text.Length = 0 Then
            MsgBox("Debe ingresar Asignatura")
            Exit Sub
        End If
     
        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("seleccione opcion")
            Exit Sub
        End If
        If ComboBox2.SelectedIndex = -1 Then
            MsgBox("seleccione opcion")
            Exit Sub
        End If
        If ComboBox3.SelectedIndex = -1 Then
            MsgBox("seleccione opcion")
            Exit Sub
        End If
        If CDate(TextBox2.Text) > DateTime.Now Then
            MsgBox("Ingresar fecha")
            Exit Sub
        End If
        If ComboBox1.SelectedItem = ComboBox2.SelectedItem Or ComboBox1.SelectedItem = ComboBox3.SelectedItem Or ComboBox2.SelectedItem = ComboBox3.SelectedItem Then
            MsgBox("No repita item")
            Exit Sub
        End If

        Turno.Id = CInt(TextBox1.Text)
        Turno.fecha = TextBox2.Text
        Turno.Asignatura = TextBox3.Text
        Turno.Docente = ComboBox1.SelectedItem
        Turno.Vocal1 = ComboBox2.SelectedItem
        Turno.Vocal2 = ComboBox3.SelectedItem

        Select Case operacion_
            Case "nuevo"
                lst.Add(Turno)
            Case "modifica"
                lst.Item(indice_) = Turno
                Grilla.DataGridView1.Refresh()
            Case "elimina"
                lst.RemoveAt(indice_)
        End Select
        Me.Close()
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        Exit Sub

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsNumber(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each item As String In ComboBox1.Items
            ComboBox2.Items.Add(item)
            ComboBox3.Items.Add(item)
        Next
    End Sub

    
   

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not e.KeyChar = "/" And Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If

        Dim pos As Integer = TextBox2.SelectionStart
        If e.KeyChar = "/" And pos <> 2 And pos <> 5 Then
            e.Handled = False
        End If

        If Char.IsNumber(e.KeyChar) And (pos = 2 Or pos = 5) Then
            e.Handled = True
            Exit Sub

        End If
    End Sub

End Class
