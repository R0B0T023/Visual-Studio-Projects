<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtAM = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxdia = New System.Windows.Forms.ComboBox()
        Me.cbxmes = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxanio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxsexo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbxestado = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtcurp = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Solicita tu CURP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DATOS PERSONALES"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre(s)*:"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(16, 120)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(121, 20)
        Me.txtnombre.TabIndex = 3
        '
        'txtAM
        '
        Me.txtAM.Location = New System.Drawing.Point(16, 181)
        Me.txtAM.Name = "txtAM"
        Me.txtAM.Size = New System.Drawing.Size(121, 20)
        Me.txtAM.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Segundo Apellido*:"
        '
        'txtAP
        '
        Me.txtAP.Location = New System.Drawing.Point(205, 120)
        Me.txtAP.Name = "txtAP"
        Me.txtAP.Size = New System.Drawing.Size(121, 20)
        Me.txtAP.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(202, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Primer Apellido*:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(202, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Dia de Nacimiento*:"
        '
        'cbxdia
        '
        Me.cbxdia.FormattingEnabled = True
        Me.cbxdia.Items.AddRange(New Object() {"Seleccione el Dia", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cbxdia.Location = New System.Drawing.Point(205, 181)
        Me.cbxdia.Name = "cbxdia"
        Me.cbxdia.Size = New System.Drawing.Size(121, 21)
        Me.cbxdia.TabIndex = 9
        '
        'cbxmes
        '
        Me.cbxmes.FormattingEnabled = True
        Me.cbxmes.Items.AddRange(New Object() {"Seleccione el Mes", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cbxmes.Location = New System.Drawing.Point(16, 246)
        Me.cbxmes.Name = "cbxmes"
        Me.cbxmes.Size = New System.Drawing.Size(121, 21)
        Me.cbxmes.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Mes de Nacimiento*:"
        '
        'cbxanio
        '
        Me.cbxanio.Location = New System.Drawing.Point(205, 246)
        Me.cbxanio.Name = "cbxanio"
        Me.cbxanio.Size = New System.Drawing.Size(121, 20)
        Me.cbxanio.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(202, 229)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Año de Nacimiento*:"
        '
        'cbxsexo
        '
        Me.cbxsexo.FormattingEnabled = True
        Me.cbxsexo.Items.AddRange(New Object() {"Seleccione el Sexo", "Mujer", "Hombre"})
        Me.cbxsexo.Location = New System.Drawing.Point(16, 318)
        Me.cbxsexo.Name = "cbxsexo"
        Me.cbxsexo.Size = New System.Drawing.Size(121, 21)
        Me.cbxsexo.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 301)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Sexo*:"
        '
        'cbxestado
        '
        Me.cbxestado.FormattingEnabled = True
        Me.cbxestado.Items.AddRange(New Object() {"Seleccione el Estado", "Aguascalientes", "Baja california", "Baja california sur", "Campeche", "Coahuila", "Colima", "Chiapas ", "Chihuahua", "Ciudad de Mexico", "Durango", "Guanajuato", "Guerrero", "Hidalgo", "Jalisco", "Estado de Mexico", "Michoacan", "Morelos", "Nayarit", "Nuevo Leon", "Oaxaca", "Puebla", "Queretaro", "Quintana Roo", "San Luis Potosi", "Sinaloa", "Sonora", "Tabasco", "Tamaulipas", "Tlaxcala", "Veracruz", "Yucatan", "Zacatecas", "Nacido en El Extranjero"})
        Me.cbxestado.Location = New System.Drawing.Point(205, 318)
        Me.cbxestado.Name = "cbxestado"
        Me.cbxestado.Size = New System.Drawing.Size(121, 21)
        Me.cbxestado.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(202, 301)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Estado*:"
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(122, 359)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(97, 33)
        Me.btnbuscar.TabIndex = 18
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(568, 103)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "CURP:"
        '
        'txtcurp
        '
        Me.txtcurp.Location = New System.Drawing.Point(468, 119)
        Me.txtcurp.Name = "txtcurp"
        Me.txtcurp.Size = New System.Drawing.Size(220, 20)
        Me.txtcurp.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 450)
        Me.Controls.Add(Me.txtcurp)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.cbxestado)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbxsexo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbxanio)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbxmes)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbxdia)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAM)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "CURP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtAM As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAP As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbxdia As ComboBox
    Friend WithEvents cbxmes As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbxanio As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbxsexo As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbxestado As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnbuscar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtcurp As TextBox
End Class
