<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_from = New System.Windows.Forms.TextBox()
        Me.txt_to = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.btn_sent = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_subject = New System.Windows.Forms.TextBox()
        Me.txt_port = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_smtpClient = New System.Windows.Forms.TextBox()
        Me.btn_consola_print = New System.Windows.Forms.Button()
        Me.btn_html = New System.Windows.Forms.Button()
        Me.btn_agregarArchivo = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.column_archivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_delete_archivo = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Notificacion por correo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "From:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(134, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "To:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(369, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password:"
        '
        'txt_from
        '
        Me.txt_from.Location = New System.Drawing.Point(162, 38)
        Me.txt_from.Name = "txt_from"
        Me.txt_from.Size = New System.Drawing.Size(191, 23)
        Me.txt_from.TabIndex = 4
        '
        'txt_to
        '
        Me.txt_to.Location = New System.Drawing.Point(162, 71)
        Me.txt_to.Name = "txt_to"
        Me.txt_to.Size = New System.Drawing.Size(191, 23)
        Me.txt_to.TabIndex = 5
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(435, 38)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(100, 23)
        Me.txt_password.TabIndex = 6
        '
        'btn_sent
        '
        Me.btn_sent.Location = New System.Drawing.Point(12, 93)
        Me.btn_sent.Name = "btn_sent"
        Me.btn_sent.Size = New System.Drawing.Size(75, 23)
        Me.btn_sent.TabIndex = 7
        Me.btn_sent.Text = "Sent"
        Me.btn_sent.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(162, 159)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(346, 150)
        Me.DataGridView1.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Column3"
        Me.Column3.Name = "Column3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(107, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Subject:"
        '
        'txt_subject
        '
        Me.txt_subject.Location = New System.Drawing.Point(162, 109)
        Me.txt_subject.Name = "txt_subject"
        Me.txt_subject.Size = New System.Drawing.Size(191, 23)
        Me.txt_subject.TabIndex = 10
        Me.txt_subject.Text = "Test - Mail"
        '
        'txt_port
        '
        Me.txt_port.Location = New System.Drawing.Point(610, 27)
        Me.txt_port.Name = "txt_port"
        Me.txt_port.Size = New System.Drawing.Size(47, 23)
        Me.txt_port.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(610, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Port:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(610, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "SMTP:"
        '
        'txt_smtpClient
        '
        Me.txt_smtpClient.Location = New System.Drawing.Point(610, 71)
        Me.txt_smtpClient.Name = "txt_smtpClient"
        Me.txt_smtpClient.Size = New System.Drawing.Size(156, 23)
        Me.txt_smtpClient.TabIndex = 14
        '
        'btn_consola_print
        '
        Me.btn_consola_print.Location = New System.Drawing.Point(12, 64)
        Me.btn_consola_print.Name = "btn_consola_print"
        Me.btn_consola_print.Size = New System.Drawing.Size(75, 23)
        Me.btn_consola_print.TabIndex = 15
        Me.btn_consola_print.Text = "Print"
        Me.btn_consola_print.UseVisualStyleBackColor = True
        '
        'btn_html
        '
        Me.btn_html.Location = New System.Drawing.Point(12, 35)
        Me.btn_html.Name = "btn_html"
        Me.btn_html.Size = New System.Drawing.Size(75, 23)
        Me.btn_html.TabIndex = 16
        Me.btn_html.Text = "HTML"
        Me.btn_html.UseVisualStyleBackColor = True
        '
        'btn_agregarArchivo
        '
        Me.btn_agregarArchivo.Location = New System.Drawing.Point(12, 327)
        Me.btn_agregarArchivo.Name = "btn_agregarArchivo"
        Me.btn_agregarArchivo.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregarArchivo.TabIndex = 17
        Me.btn_agregarArchivo.Text = "Agregar"
        Me.btn_agregarArchivo.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(100, 331)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Archivos:"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.column_archivo, Me.btn_delete_archivo})
        Me.DataGridView2.Location = New System.Drawing.Point(162, 331)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 25
        Me.DataGridView2.Size = New System.Drawing.Size(346, 155)
        Me.DataGridView2.TabIndex = 19
        '
        'column_archivo
        '
        Me.column_archivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.column_archivo.HeaderText = "Archivo"
        Me.column_archivo.Name = "column_archivo"
        '
        'btn_delete_archivo
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        Me.btn_delete_archivo.DefaultCellStyle = DataGridViewCellStyle1
        Me.btn_delete_archivo.HeaderText = ""
        Me.btn_delete_archivo.Name = "btn_delete_archivo"
        Me.btn_delete_archivo.Text = "X"
        Me.btn_delete_archivo.Width = 30
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 498)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_agregarArchivo)
        Me.Controls.Add(Me.btn_html)
        Me.Controls.Add(Me.btn_consola_print)
        Me.Controls.Add(Me.txt_smtpClient)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_port)
        Me.Controls.Add(Me.txt_subject)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_sent)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_to)
        Me.Controls.Add(Me.txt_from)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_from As TextBox
    Friend WithEvents txt_to As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents btn_sent As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_subject As TextBox
    Friend WithEvents txt_port As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_smtpClient As TextBox
    Friend WithEvents btn_consola_print As Button
    Friend WithEvents btn_html As Button
    Friend WithEvents btn_agregarArchivo As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents column_archivo As DataGridViewTextBoxColumn
    Friend WithEvents btn_delete_archivo As DataGridViewButtonColumn
End Class
