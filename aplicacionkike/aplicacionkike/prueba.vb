Public Class prueba
    'EVENTO DEL PANEL
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    'EVENTO DE IMAGEN DE CHABELO
    Private Sub picsonriente_Click(sender As Object, e As EventArgs) Handles picchabelo.Click
        picchabelo.BorderStyle = BorderStyle.FixedSingle
        lblmensaje.Text = "Chabelo"

    End Sub
    'EVENTO DE BOTON
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    'propiedad del  txtname el cual esta dibujado en la forma

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles textmen.TextChanged
        textmen.Text = "kike" 'poniendo el nombre del control en este caso un txtbox y un punto podemos acceder a los diferentes tipos de controles que tiene y como podemos manipularlo en este caso despliega un texto llamado kike
    End Sub

    Private Sub lblmensaje_Click(sender As Object, e As EventArgs) Handles lblmensaje.Click




    End Sub
    'FOTO DE BATMAN
    Private Sub pictman_Click(sender As Object, e As EventArgs) Handles pictman.Click
        pictman.BorderStyle = BorderStyle.FixedSingle
        lblmensaje.Text = "Batman"
    End Sub
    'BOTON PARA CAMBIAR LA PANTALLA POR OTRA
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide() 'OCULTAMOS LA 1 VENTANA
        Form2.ShowDialog() 'HACEMOS VISIBLE LA 2 VENTANA




    End Sub
End Class
