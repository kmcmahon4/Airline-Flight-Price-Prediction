Imports System.ComponentModel
Imports System.Data
Imports System.Data.Odbc

Public Class chooseForm
    Public flightDate As Date

    Dim frmSeating As New seatingChart()
    Dim db As String = "Dsn=orcl12;uid=wmontana;pwd=0336321"
    Dim con As New OdbcConnection(db)
    Dim counter As Integer

    Private Sub buyBtn_Click(sender As Object, e As EventArgs) Handles buyBtn.Click
        Me.Hide()
        If counter < 1 Then
            counter = counter + 1
            flightDate = mnthCalendar.SelectionRange.Start.ToString()
        Else
            MsgBox("LISTEN HONG IF YOU WANT TO CHANGE THE DATE YOU NEED TO RESTART THE PROGRAM")
        End If

        seatingChart.ShowDialog()

    End Sub
    Private Sub lookBtn_Click(sender As Object, e As EventArgs) Handles lookBtn.Click
        Dim inputNumber As Integer

        inputNumber = InputBox("Please enter your confirmation number!")

        'Show From student db
        Dim fname As String
        Dim lname As String
        Dim ffnumber As Integer
        Dim flight_number As Integer
        Dim confirmnumber As Integer
        Dim rownumber As Integer
        Dim seatnumber As Integer
        Dim seatletter As String
        Dim fprice As Double



        Try
            Dim sql As String = "SELECT * FROM FLYER WHERE CONFIRMNUMBER = " + inputNumber.ToString + " ;"
            Dim cmd As New OdbcCommand(sql, con)
            Dim flyerReader As OdbcDataReader = cmd.ExecuteReader()


            While flyerReader.Read()
                fname = flyerReader(0)
                lname = flyerReader(1)
                ffnumber = CInt(flyerReader(2))
                flight_number = CInt(flyerReader(3))
                confirmnumber = CInt(flyerReader(4))
                rownumber = CInt(flyerReader(5))
                seatnumber = CInt(flyerReader(6))
                fprice = CDbl(flyerReader(7))

                Select Case seatnumber
                    Case 1
                        seatletter = "A"
                    Case 2
                        seatletter = "B"
                    Case 3
                        seatletter = "C"
                    Case 4
                        seatletter = "D"
                    Case 5
                        seatletter = "E"
                    Case 6
                        seatletter = "F"
                    Case Else
                        seatletter = "ERROR"
                End Select


                MsgBox("Name - " & fname & " " & lname & " " & vbNewLine &
                       "Frequent Flyer - " & ffnumber & " " & vbNewLine &
                       "Flight Number - " & flight_number & " " & vbNewLine &
                       "Confirmation - " & confirmnumber & " " & vbNewLine &
                       "Row Number - " & rownumber & " " & vbNewLine &
                       "Seat - " & seatletter & " " & vbNewLine &
                       "Price - $" & Math.Round(fprice, 2))


            End While

        Catch ex As Exception
            MsgBox("ERROR" & ex.ToString)

        End Try
    End Sub

    Private Sub chooseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'open connection
        Try
            con.Open()
        Catch ex As Exception
            MsgBox("Error opening connection")
        End Try
    End Sub
End Class