Imports System.Net.Mail

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Dim sBody As String = "Body - Mensaje de prueba."

    Private Sub btn_sent_Click(sender As Object, e As EventArgs) Handles btn_sent.Click

        Try
            'Mensaje Nuevo
            Dim mail As New MailMessage
            mail.From = New MailAddress(txt_from.Text, "Test - mail")
            mail.To.Add(txt_to.Text)
            mail.Subject = (txt_subject.Text)
            mail.IsBodyHtml = True 'Para que se pueda escribir codigo HTML en el cuerpo del mensaje. Lo utilice para crear principalmente la tabla.
            message_body() 'Sub-rutina para crear el mensaje.
            mail.Body = (sBody)

            'Dim archivo As New Attachment("C:\Users\eh\Desktop\hola.txt")
            'mail.Attachments.Add(archivo)

            For Each fila As DataGridViewRow In DataGridView2.Rows
                'Debug.WriteLine("valor: " & fila.Cells(0).Value)
                Dim archivo As New Attachment(fila.Cells(0).Value.ToString)
                mail.Attachments.Add(archivo)
            Next


            'Conexion al servidor
            Dim servidor As New SmtpClient(txt_smtpClient.Text)
            servidor.Port = CInt(txt_port.Text)
            servidor.EnableSsl = True
            servidor.Credentials = New System.Net.NetworkCredential(txt_from.Text, txt_password.Text)
            servidor.Send(mail)

            MsgBox("Mensaje enviado")

        Catch ex As Exception

            MsgBox("EH_Error: " & ex.ToString)


        End Try



    End Sub

    Private Sub message_body()

        sBody = "<html><body>
            <h1>" & txt_subject.Text & "</h1>
               <table>
                <tr>
                    <th>EQUIPO</th>
                    <th>MODELO</th>
                    <th>SERIAL</th>
                </tr>
                <tr>
                    <td>PESA</td>
                    <td>DIBAL</td>
                    <td>239034345</td>
                </tr>"

        For Each fila As DataGridViewRow In DataGridView1.Rows
            sBody += "
                    <tr>
                    <td>" & fila.Cells(0).Value & "</td>
                    <td>" & fila.Cells(1).Value & "</td>
                    <td>" & fila.Cells(2).Value & "</td>
                     </tr>"
        Next

        sBody += "
                <p>Saludos.</p>
                </table>
        </body></html>"
    End Sub

    Private Sub btn_consola_print_Click(sender As Object, e As EventArgs) Handles btn_consola_print.Click
        Dim sprueba As String = ""
        For Each fila As DataGridViewRow In DataGridView1.Rows
            'Debug.WriteLine(fila.Cells(0).Value)
            sprueba += "Equipo: " & fila.Cells(0).Value & " - "
            sprueba += "Modelo: " & fila.Cells(1).Value & " - "
            sprueba += "Sn: " & fila.Cells(2).Value
            sprueba += vbCrLf 'Salto de linea
        Next
        Debug.WriteLine(sprueba)
        Debug.WriteLine("======= Separador ====")
        sBody += vbCrLf + sprueba
        Debug.WriteLine(sBody)

        Debug.WriteLine("======= Separador ====")
        For Each fila As DataGridViewRow In DataGridView2.Rows
            Debug.WriteLine("valor: " & fila.Cells(0).Value)
        Next
    End Sub

    Private Sub btn_html_Click(sender As Object, e As EventArgs) Handles btn_html.Click
        Debug.WriteLine("======= Separador ====")
        message_body()
        Debug.WriteLine(sBody)
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        'MsgBox("celda: " & DataGridView2.CurrentRow.Index.ToString)
        ' If DataGridView2.RowCount > 1 And DataGridView2.RowCount Then
        DataGridView2.Rows.RemoveAt(DataGridView2.CurrentRow.Index) ' Eliminar la fila
        'Else
        'MsgBox("No hay archivo adjunto.")
        'End If
    End Sub

    Private Sub btn_agregarArchivo_Click(sender As Object, e As EventArgs) Handles btn_agregarArchivo.Click

        'Adjuntar archivo
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            'Insertar row con la direccion del archivo
            Me.DataGridView2.ClearSelection()
            DataGridView2.Rows.Add() 'Agregar una fila
            'Me.DataGridView2.CurrentCell = Me.DataGridView2.Rows(Me.DataGridView2.RowCount - 1).Cells(0)
            'DataGridView2.CurrentCell = DataGridView2.Item(0, DataGridView2.RowCount - 2) 'Siempre y cuando el usuario pueda agregar filas
            DataGridView2.CurrentCell = DataGridView2.Item(0, DataGridView2.RowCount - 1)
            DataGridView2.CurrentCell.Value = openFileDialog1.FileName()

            Me.DataGridView2.Refresh()

        End If


    End Sub


End Class
