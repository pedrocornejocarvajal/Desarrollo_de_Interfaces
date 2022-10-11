Imports _03_HelloWorld_EntidadesStandard

Public Class Form1
    ''' <summary>
    ''' prototipo: Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '''comentarios: Evento asociado al click del boton saludar. Mostrara por pantalla el nombre de la persona introducido con un saludo
    '''precondiciones:
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        '''Declaracion de variables
        Dim persona As clsPersona

        If TextBox1.Text.Length = 0 Then

            Label2.Visible = True

        Else
            persona = New clsPersona(TextBox1.Text)
            Label2.Visible = False
            MessageBox.Show("Hola " + persona.Nombre)

        End If
    End Sub
End Class
