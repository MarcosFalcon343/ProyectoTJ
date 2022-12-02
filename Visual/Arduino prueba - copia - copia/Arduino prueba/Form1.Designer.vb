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
        Me.components = New System.ComponentModel.Container()
        Me.Btn_automatico = New System.Windows.Forms.Button()
        Me.Btn_encendido = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Temp_max = New System.Windows.Forms.NumericUpDown()
        Me.Temp_min = New System.Windows.Forms.NumericUpDown()
        Me.cmbPort = New System.Windows.Forms.ComboBox()
        Me.sppuerto = New System.IO.Ports.SerialPort(Me.components)
        Me.Btn_conectar = New System.Windows.Forms.Button()
        Me.txtrecibe = New System.Windows.Forms.TextBox()
        Me.txtenvia = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_desconectar = New System.Windows.Forms.Button()
        Me.lbl_temperatura = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_humedad = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_TM = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.Temp_max, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Temp_min, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_automatico
        '
        Me.Btn_automatico.Location = New System.Drawing.Point(791, 52)
        Me.Btn_automatico.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_automatico.Name = "Btn_automatico"
        Me.Btn_automatico.Size = New System.Drawing.Size(147, 65)
        Me.Btn_automatico.TabIndex = 0
        Me.Btn_automatico.Text = "Automatico "
        Me.Btn_automatico.UseVisualStyleBackColor = True
        '
        'Btn_encendido
        '
        Me.Btn_encendido.Location = New System.Drawing.Point(1008, 52)
        Me.Btn_encendido.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_encendido.Name = "Btn_encendido"
        Me.Btn_encendido.Size = New System.Drawing.Size(147, 65)
        Me.Btn_encendido.TabIndex = 1
        Me.Btn_encendido.Text = "Encendido"
        Me.Btn_encendido.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(253, 116)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Rango de T.Max"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(257, 185)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Rango de T.Min"
        '
        'Temp_max
        '
        Me.Temp_max.Location = New System.Drawing.Point(80, 107)
        Me.Temp_max.Margin = New System.Windows.Forms.Padding(4)
        Me.Temp_max.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.Temp_max.Name = "Temp_max"
        Me.Temp_max.Size = New System.Drawing.Size(133, 22)
        Me.Temp_max.TabIndex = 6
        Me.Temp_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Temp_min
        '
        Me.Temp_min.Location = New System.Drawing.Point(80, 182)
        Me.Temp_min.Margin = New System.Windows.Forms.Padding(4)
        Me.Temp_min.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.Temp_min.Name = "Temp_min"
        Me.Temp_min.Size = New System.Drawing.Size(133, 22)
        Me.Temp_min.TabIndex = 7
        Me.Temp_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbPort
        '
        Me.cmbPort.FormattingEnabled = True
        Me.cmbPort.Location = New System.Drawing.Point(797, 334)
        Me.cmbPort.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPort.Name = "cmbPort"
        Me.cmbPort.Size = New System.Drawing.Size(160, 24)
        Me.cmbPort.TabIndex = 24
        '
        'sppuerto
        '
        '
        'Btn_conectar
        '
        Me.Btn_conectar.Location = New System.Drawing.Point(764, 260)
        Me.Btn_conectar.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_conectar.Name = "Btn_conectar"
        Me.Btn_conectar.Size = New System.Drawing.Size(131, 39)
        Me.Btn_conectar.TabIndex = 26
        Me.Btn_conectar.Text = "Conectar"
        Me.Btn_conectar.UseVisualStyleBackColor = True
        '
        'txtrecibe
        '
        Me.txtrecibe.Location = New System.Drawing.Point(797, 400)
        Me.txtrecibe.Margin = New System.Windows.Forms.Padding(4)
        Me.txtrecibe.Multiline = True
        Me.txtrecibe.Name = "txtrecibe"
        Me.txtrecibe.Size = New System.Drawing.Size(253, 20)
        Me.txtrecibe.TabIndex = 27
        '
        'txtenvia
        '
        Me.txtenvia.Location = New System.Drawing.Point(797, 458)
        Me.txtenvia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtenvia.Name = "txtenvia"
        Me.txtenvia.Size = New System.Drawing.Size(145, 22)
        Me.txtenvia.TabIndex = 28
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(496, 174)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 37)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Enviar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lbl_estado
        '
        Me.lbl_estado.AutoSize = True
        Me.lbl_estado.Location = New System.Drawing.Point(1004, 337)
        Me.lbl_estado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(13, 17)
        Me.lbl_estado.TabIndex = 25
        Me.lbl_estado.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 314)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Temperatura :"
        '
        'Btn_desconectar
        '
        Me.Btn_desconectar.Location = New System.Drawing.Point(921, 260)
        Me.Btn_desconectar.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_desconectar.Name = "Btn_desconectar"
        Me.Btn_desconectar.Size = New System.Drawing.Size(131, 39)
        Me.Btn_desconectar.TabIndex = 32
        Me.Btn_desconectar.Text = "Desconectar"
        Me.Btn_desconectar.UseVisualStyleBackColor = True
        '
        'lbl_temperatura
        '
        Me.lbl_temperatura.AutoSize = True
        Me.lbl_temperatura.Location = New System.Drawing.Point(220, 314)
        Me.lbl_temperatura.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_temperatura.Name = "lbl_temperatura"
        Me.lbl_temperatura.Size = New System.Drawing.Size(13, 17)
        Me.lbl_temperatura.TabIndex = 33
        Me.lbl_temperatura.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(76, 369)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 17)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Humedad :"
        '
        'lbl_humedad
        '
        Me.lbl_humedad.AutoSize = True
        Me.lbl_humedad.Location = New System.Drawing.Point(220, 369)
        Me.lbl_humedad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_humedad.Name = "lbl_humedad"
        Me.lbl_humedad.Size = New System.Drawing.Size(13, 17)
        Me.lbl_humedad.TabIndex = 35
        Me.lbl_humedad.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(347, 314)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 17)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "°C"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(351, 369)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 17)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "%"
        '
        'lbl_TM
        '
        Me.lbl_TM.AutoSize = True
        Me.lbl_TM.Location = New System.Drawing.Point(433, 116)
        Me.lbl_TM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_TM.Name = "lbl_TM"
        Me.lbl_TM.Size = New System.Drawing.Size(13, 17)
        Me.lbl_TM.TabIndex = 38
        Me.lbl_TM.Text = "-"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(496, 105)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 37)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Enviar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(433, 175)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 17)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(351, 419)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 17)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(220, 419)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 17)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(76, 419)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 17)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Humedad :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1255, 604)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_TM)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_humedad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_temperatura)
        Me.Controls.Add(Me.Btn_desconectar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtenvia)
        Me.Controls.Add(Me.txtrecibe)
        Me.Controls.Add(Me.Btn_conectar)
        Me.Controls.Add(Me.lbl_estado)
        Me.Controls.Add(Me.cmbPort)
        Me.Controls.Add(Me.Temp_min)
        Me.Controls.Add(Me.Temp_max)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_encendido)
        Me.Controls.Add(Me.Btn_automatico)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "."
        CType(Me.Temp_max, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Temp_min, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_automatico As System.Windows.Forms.Button
    Friend WithEvents Btn_encendido As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Temp_max As System.Windows.Forms.NumericUpDown
    Private WithEvents Temp_min As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbPort As System.Windows.Forms.ComboBox
    Friend WithEvents sppuerto As System.IO.Ports.SerialPort
    Friend WithEvents Btn_conectar As System.Windows.Forms.Button
    Friend WithEvents txtrecibe As System.Windows.Forms.TextBox
    Friend WithEvents txtenvia As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lbl_estado As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Btn_desconectar As System.Windows.Forms.Button
    Friend WithEvents lbl_temperatura As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_humedad As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbl_TM As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
