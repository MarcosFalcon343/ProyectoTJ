Imports System
Imports System.IO
Imports System.IO.Ports
Imports System.Threading

Public Class Form1
    Dim dato As String
    Dim numero

    Dim MQ3RangoMax As String
    Dim MQ3RangoMin As String
    Dim TemRangoMax As String
    Dim TemRangoMin As String
    Dim HumRangoMax As String
    Dim HumRangoMin As String
    Dim timeDelay As String
    Dim Modo As String
    Dim AM As String

    Dim MQ3Valor As String
    Dim TemValor As String
    Dim HumValor As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscapuerto()
        Btn_encendido.Text = "Apagado"
        Btn_encendido.BackColor = Color.Red
        Btn_automatico.Text = "Automatico"
        Btn_automatico.BackColor = Color.Yellow

        MQ3RangoMax = "400"
        MQ3RangoMin = "270"
        TemRangoMax = "50"
        TemRangoMin = "20"
        HumRangoMax = "80"
        HumRangoMin = "30"
        timeDelay = "2"
        Modo = "A"
        AM = "D"

    End Sub


    'Puertos seriales
    Private Sub buscapuerto()
        Try
            cmbPort.Items.Clear()
            For Each puerto As String In My.Computer.Ports.SerialPortNames
                cmbPort.Items.Add(puerto)
            Next
            If cmbPort.Items.Count > 0 Then
                cmbPort.SelectedIndex = 0

            Else
                MsgBox("NO HAY PUERTOS DISPONIBLES EN TU SISTEMA")

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub sppuerto_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles sppuerto.DataReceived
        If sppuerto.IsOpen() Then
            Dim array() As String
            Try
                dato = sppuerto.ReadLine()
                array = Split(dato, ",")
                If array.Length = 5 Then
                    numero = CDbl(Val(dato))
                    CheckForIllegalCrossThreadCalls = False



                    lbl_temperatura.Text = array(1)

                    lbl_humedad.Text = array(2)

                    lbl_alcohol.Text = array(0)

                    pwm.Text = array(3)

                    EstadoMotor.Text = array(4)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        End If

    End Sub



    Private Sub Btn_conectar_Click(sender As Object, e As EventArgs) Handles Btn_conectar.Click
        Try
            With sppuerto
                .BaudRate = 9600
                .DataBits = 8
                .Parity = IO.Ports.Parity.None
                .StopBits = 1
                .PortName = cmbPort.Text
                .Open()

                If .IsOpen Then
                    lbl_estado.Text = "CONECTADO"
                    sendDataRange()

                Else
                    MsgBox("COENXION FALLIDA", MsgBoxStyle.Critical)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub Btn_desconectar_Click(sender As Object, e As EventArgs) Handles Btn_desconectar.Click
        'Dato3 = 3
        sppuerto.Close()
        lbl_estado.Text = "DESCONECTADO"
    End Sub


    'Enviar datos
    Private Sub sendDataRange()
        sppuerto.DiscardInBuffer()
        sppuerto.WriteLine(MQ3RangoMax + "," + MQ3RangoMin + "," + TemRangoMax + "," + TemRangoMin + "," + HumRangoMax + "," + HumRangoMin + "," + timeDelay + "," + Modo + "," + AM + ",I")
        send.Text = MQ3RangoMax + "," + MQ3RangoMin + "," + TemRangoMax + "," + TemRangoMin + "," + HumRangoMax + "," + HumRangoMin + "," + timeDelay + "," + Modo + "," + AM + ",I"

        TMax.Text = TemRangoMax
        TMin.Text = TemRangoMin
        HMax.Text = HumRangoMax
        HMin.Text = HumRangoMin
        AMax.Text = MQ3RangoMax
        AMin.Text = MQ3RangoMin
        time.Text = timeDelay
    End Sub

    'botones
    Private Sub Btn_encendido_Click(sender As Object, e As EventArgs) Handles Btn_encendido.Click
        If Btn_encendido.Text = "Apagado" Then
            Btn_encendido.Text = "Encendido"
            Btn_encendido.BackColor = Color.Green
            AM = "A"
            sendDataRange()
        Else
            Btn_encendido.Text = "Apagado"
            Btn_encendido.BackColor = Color.Red
            AM = "D"
            sendDataRange()
        End If
    End Sub

    Private Sub Btn_automatico_Click(sender As Object, e As EventArgs) Handles Btn_automatico.Click
        If Btn_automatico.Text = "Automatico" Then
            Btn_automatico.Text = "Manual"
            Btn_automatico.BackColor = Color.BlueViolet
            Modo = "M"
            sendDataRange()
        Else
            Btn_automatico.Text = "Automatico"
            Btn_automatico.BackColor = Color.Yellow
            Modo = "A"
            sendDataRange()
        End If
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TemRangoMax = Temp_max.Value
        sendDataRange()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TemRangoMin = Temp_min.Value
        sendDataRange()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        HumRangoMax = Hum_max.Value
        sendDataRange()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        HumRangoMin = Hum_min.Value
        sendDataRange()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MQ3RangoMax = Alcohol_max.Value
        sendDataRange()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MQ3RangoMin = Alcohol_min.Value
        sendDataRange()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        timeDelay = TimeValue.Value
        sendDataRange()
    End Sub

End Class