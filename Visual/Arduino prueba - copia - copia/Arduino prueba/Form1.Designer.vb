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
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_desconectar = New System.Windows.Forms.Button()
        Me.lbl_temperatura = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_humedad = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TMax = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TMin = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_alcohol = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.HMin = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.HMax = New System.Windows.Forms.Label()
        Me.Hum_min = New System.Windows.Forms.NumericUpDown()
        Me.Hum_max = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.AMin = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.AMax = New System.Windows.Forms.Label()
        Me.Alcohol_min = New System.Windows.Forms.NumericUpDown()
        Me.Alcohol_max = New System.Windows.Forms.NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.send = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.time = New System.Windows.Forms.Label()
        Me.TimeValue = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pwm = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.EstadoMotor = New System.Windows.Forms.Label()
        Me.recibidos = New System.Windows.Forms.Label()
        CType(Me.Temp_max, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Temp_min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hum_min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hum_max, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alcohol_min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alcohol_max, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeValue, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Location = New System.Drawing.Point(236, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Rango de T.Max"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(236, 56)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Rango de T.Min"
        '
        'Temp_max
        '
        Me.Temp_max.Location = New System.Drawing.Point(80, 26)
        Me.Temp_max.Margin = New System.Windows.Forms.Padding(4)
        Me.Temp_max.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.Temp_max.Name = "Temp_max"
        Me.Temp_max.Size = New System.Drawing.Size(133, 22)
        Me.Temp_max.TabIndex = 6
        Me.Temp_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Temp_min
        '
        Me.Temp_min.Location = New System.Drawing.Point(80, 56)
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
        'TMax
        '
        Me.TMax.AutoSize = True
        Me.TMax.Location = New System.Drawing.Point(433, 26)
        Me.TMax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TMax.Name = "TMax"
        Me.TMax.Size = New System.Drawing.Size(13, 17)
        Me.TMax.TabIndex = 38
        Me.TMax.Text = "-"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(476, 22)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 26)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Enviar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TMin
        '
        Me.TMin.AutoSize = True
        Me.TMin.Location = New System.Drawing.Point(433, 56)
        Me.TMin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TMin.Name = "TMin"
        Me.TMin.Size = New System.Drawing.Size(13, 17)
        Me.TMin.TabIndex = 40
        Me.TMin.Text = "-"
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
        'lbl_alcohol
        '
        Me.lbl_alcohol.AutoSize = True
        Me.lbl_alcohol.Location = New System.Drawing.Point(220, 419)
        Me.lbl_alcohol.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_alcohol.Name = "lbl_alcohol"
        Me.lbl_alcohol.Size = New System.Drawing.Size(13, 17)
        Me.lbl_alcohol.TabIndex = 42
        Me.lbl_alcohol.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(76, 419)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 17)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Alcohol :"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(476, 52)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 26)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Enviar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(476, 120)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 26)
        Me.Button3.TabIndex = 52
        Me.Button3.Text = "Enviar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'HMin
        '
        Me.HMin.AutoSize = True
        Me.HMin.Location = New System.Drawing.Point(433, 121)
        Me.HMin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HMin.Name = "HMin"
        Me.HMin.Size = New System.Drawing.Size(13, 17)
        Me.HMin.TabIndex = 51
        Me.HMin.Text = "-"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(476, 86)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(115, 26)
        Me.Button4.TabIndex = 50
        Me.Button4.Text = "Enviar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'HMax
        '
        Me.HMax.AutoSize = True
        Me.HMax.Location = New System.Drawing.Point(433, 88)
        Me.HMax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HMax.Name = "HMax"
        Me.HMax.Size = New System.Drawing.Size(13, 17)
        Me.HMax.TabIndex = 49
        Me.HMax.Text = "-"
        '
        'Hum_min
        '
        Me.Hum_min.Location = New System.Drawing.Point(80, 116)
        Me.Hum_min.Margin = New System.Windows.Forms.Padding(4)
        Me.Hum_min.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.Hum_min.Name = "Hum_min"
        Me.Hum_min.Size = New System.Drawing.Size(133, 22)
        Me.Hum_min.TabIndex = 48
        Me.Hum_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Hum_max
        '
        Me.Hum_max.Location = New System.Drawing.Point(80, 86)
        Me.Hum_max.Margin = New System.Windows.Forms.Padding(4)
        Me.Hum_max.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.Hum_max.Name = "Hum_max"
        Me.Hum_max.Size = New System.Drawing.Size(133, 22)
        Me.Hum_max.TabIndex = 47
        Me.Hum_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(236, 118)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 17)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Rango de H.Min"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(236, 86)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(113, 17)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "Rango de H.Max"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(476, 185)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(115, 26)
        Me.Button5.TabIndex = 60
        Me.Button5.Text = "Enviar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'AMin
        '
        Me.AMin.AutoSize = True
        Me.AMin.Location = New System.Drawing.Point(433, 176)
        Me.AMin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AMin.Name = "AMin"
        Me.AMin.Size = New System.Drawing.Size(13, 17)
        Me.AMin.TabIndex = 59
        Me.AMin.Text = "-"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(476, 151)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(115, 26)
        Me.Button6.TabIndex = 58
        Me.Button6.Text = "Enviar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'AMax
        '
        Me.AMax.AutoSize = True
        Me.AMax.Location = New System.Drawing.Point(433, 148)
        Me.AMax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AMax.Name = "AMax"
        Me.AMax.Size = New System.Drawing.Size(13, 17)
        Me.AMax.TabIndex = 57
        Me.AMax.Text = "-"
        '
        'Alcohol_min
        '
        Me.Alcohol_min.Location = New System.Drawing.Point(80, 176)
        Me.Alcohol_min.Margin = New System.Windows.Forms.Padding(4)
        Me.Alcohol_min.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.Alcohol_min.Name = "Alcohol_min"
        Me.Alcohol_min.Size = New System.Drawing.Size(133, 22)
        Me.Alcohol_min.TabIndex = 56
        Me.Alcohol_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Alcohol_max
        '
        Me.Alcohol_max.Location = New System.Drawing.Point(80, 146)
        Me.Alcohol_max.Margin = New System.Windows.Forms.Padding(4)
        Me.Alcohol_max.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.Alcohol_max.Name = "Alcohol_max"
        Me.Alcohol_max.Size = New System.Drawing.Size(133, 22)
        Me.Alcohol_max.TabIndex = 55
        Me.Alcohol_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(236, 176)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(109, 17)
        Me.Label17.TabIndex = 54
        Me.Label17.Text = "Rango de A.Min"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(236, 146)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 17)
        Me.Label18.TabIndex = 53
        Me.Label18.Text = "Rango de A.Max"
        '
        'send
        '
        Me.send.AutoSize = True
        Me.send.Location = New System.Drawing.Point(563, 519)
        Me.send.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.send.Name = "send"
        Me.send.Size = New System.Drawing.Size(13, 17)
        Me.send.TabIndex = 61
        Me.send.Text = "-"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(377, 236)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(115, 26)
        Me.Button7.TabIndex = 65
        Me.Button7.Text = "Enviar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'time
        '
        Me.time.AutoSize = True
        Me.time.Location = New System.Drawing.Point(332, 236)
        Me.time.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(13, 17)
        Me.time.TabIndex = 64
        Me.time.Text = "-"
        '
        'TimeValue
        '
        Me.TimeValue.Location = New System.Drawing.Point(84, 234)
        Me.TimeValue.Margin = New System.Windows.Forms.Padding(4)
        Me.TimeValue.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.TimeValue.Name = "TimeValue"
        Me.TimeValue.Size = New System.Drawing.Size(133, 22)
        Me.TimeValue.TabIndex = 63
        Me.TimeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(240, 234)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 17)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Tiempo"
        '
        'pwm
        '
        Me.pwm.AutoSize = True
        Me.pwm.Location = New System.Drawing.Point(980, 176)
        Me.pwm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pwm.Name = "pwm"
        Me.pwm.Size = New System.Drawing.Size(13, 17)
        Me.pwm.TabIndex = 66
        Me.pwm.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(775, 176)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 17)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Valor de potencia del motor"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(775, 151)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 17)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "Motor: "
        '
        'EstadoMotor
        '
        Me.EstadoMotor.AutoSize = True
        Me.EstadoMotor.Location = New System.Drawing.Point(980, 151)
        Me.EstadoMotor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EstadoMotor.Name = "EstadoMotor"
        Me.EstadoMotor.Size = New System.Drawing.Size(13, 17)
        Me.EstadoMotor.TabIndex = 69
        Me.EstadoMotor.Text = "-"
        '
        'recibidos
        '
        Me.recibidos.AutoSize = True
        Me.recibidos.Location = New System.Drawing.Point(358, 519)
        Me.recibidos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.recibidos.Name = "recibidos"
        Me.recibidos.Size = New System.Drawing.Size(13, 17)
        Me.recibidos.TabIndex = 70
        Me.recibidos.Text = "-"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1255, 604)
        Me.Controls.Add(Me.recibidos)
        Me.Controls.Add(Me.EstadoMotor)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pwm)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.time)
        Me.Controls.Add(Me.TimeValue)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.send)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.AMin)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.AMax)
        Me.Controls.Add(Me.Alcohol_min)
        Me.Controls.Add(Me.Alcohol_max)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.HMin)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.HMax)
        Me.Controls.Add(Me.Hum_min)
        Me.Controls.Add(Me.Hum_max)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_alcohol)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TMin)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TMax)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_humedad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_temperatura)
        Me.Controls.Add(Me.Btn_desconectar)
        Me.Controls.Add(Me.Label3)
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
        CType(Me.Hum_min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hum_max, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alcohol_min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alcohol_max, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeValue, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lbl_estado As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Btn_desconectar As System.Windows.Forms.Button
    Friend WithEvents lbl_temperatura As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_humedad As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TMax As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TMin As System.Windows.Forms.Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_alcohol As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents HMin As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents HMax As Label
    Private WithEvents Hum_min As NumericUpDown
    Private WithEvents Hum_max As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents AMin As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents AMax As Label
    Private WithEvents Alcohol_min As NumericUpDown
    Private WithEvents Alcohol_max As NumericUpDown
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents send As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents time As Label
    Private WithEvents TimeValue As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents pwm As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents EstadoMotor As Label
    Friend WithEvents recibidos As Label
End Class
