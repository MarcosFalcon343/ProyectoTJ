Imports System
Imports System.IO
Imports System.IO.Ports
Imports System.Threading

Public Class Form1
    Dim dato As String
    Dim dato1 As String
    Dim dato2 As Double
    Dim Dato3 As Double
    Dim numero
    'Dim TM = 0
    'Dim TM2 = 0
    ' utm As Integer = 0
    'Dim atm As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscapuerto()
        Btn_encendido.Text = "Apagado"
        Btn_encendido.BackColor = Color.Red
        Btn_automatico.Text = "Automatico"
        Btn_automatico.BackColor = Color.Yellow

    End Sub

    'Private Sub Temp_max_ValueChanged(sender As Object, e As EventArgs) Handles Temp_max.ValueChanged
    'Temp_max = Temp_max_Value("")
    '    TB_crojo.BackColor = Color.FromArgb(Val(TB_vrojo.Text), 0, 0)
    '    TB_combinado.BackColor = Color.FromArgb(Val(TB_vrojo.Text), Val(TB_vverde.Text), (TB_vazul.Text))

    'End Sub
    'Private Sub Temp_min_ValueChanged(sender As Object, e As EventArgs) Handles Temp_min.ValueChanged
    '    TB_vrojo.Text = Temp_min.Value
    '    TB_crojo.BackColor = Color.FromArgb(Val(TB_vrojo.Text), 0, 0)
    '    TB_combinado.BackColor = Color.FromArgb(Val(TB_vrojo.Text), Val(TB_vverde.Text), (TB_vazul.Text))
    '
    'End Sub
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
                If array.Length = 3 Then
                    numero = CDbl(Val(dato))
                    CheckForIllegalCrossThreadCalls = False

                    lbl_temperatura.Text = array(0)

                    lbl_humedad.Text = Val(array(1)) - 100

                    lbl_TM.Text = array(2)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        End If

        'Dim buffer As String
        'buffer = sppuerto.ReadLine
        'txtrecibe.Text = "RECIBIDO>> " & buffer & vbCrLf
    End Sub

    'Private Sub Temp_max_ValueChanged(sender As Object, e As EventArgs) Handles Temp_max.ValueChanged
    ' TM = Temp_max.Value
    ' End Sub

    ' Private Sub Btn_enviar_Click(sender As Object, e As EventArgs) Handles Btn_enviar.Click
    ' If sppuerto.IsOpen Then
    '   If utm <> atm Then
    '     sppuerto.WriteLine("TM" + Temp_max.Text)
    ' End If
    ' Else
    ' MsgBox("NO ESTAS CONECTADO", MsgBoxStyle.Exclamation)

    'End If
    ' End Sub

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

                Else
                    MsgBox("COENXION FALLIDA", MsgBoxStyle.Critical)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub




    Private Sub Btn_encendido_Click(sender As Object, e As EventArgs) Handles Btn_encendido.Click
        If Btn_encendido.Text = "Apagado" Then
            Btn_encendido.Text = "Encendido"
            Btn_encendido.BackColor = Color.Green
        Else
            Btn_encendido.Text = "Apagado"
            Btn_encendido.BackColor = Color.Red
        End If
    End Sub

    Private Sub Btn_automatico_Click(sender As Object, e As EventArgs) Handles Btn_automatico.Click
        If Btn_automatico.Text = "Automatico" Then
            Btn_automatico.Text = "Manual"
            Btn_automatico.BackColor = Color.BlueViolet
        Else
            Btn_automatico.Text = "Automatico"
            Btn_automatico.BackColor = Color.Yellow
        End If
    End Sub


    Private Sub Btn_desconectar_Click(sender As Object, e As EventArgs) Handles Btn_desconectar.Click
        'Dato3 = 3
        sppuerto.Close()
        lbl_estado.Text = "DESCONECTADO"
    End Sub




    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        sppuerto.DiscardInBuffer()
        sppuerto.WriteLine(Temp_max.Value)
        lbl_TM.Text = Temp_max.Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sppuerto.DiscardInBuffer()
        sppuerto.WriteLine(Temp_min.Value)
        Label4.Text = Temp_min.Value
    End Sub


End Class