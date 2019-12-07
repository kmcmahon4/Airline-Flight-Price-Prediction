Imports System.ComponentModel
Imports System.Data
Imports System.Data.Odbc
Public Class assignFlyer
    Dim db As String = "Dsn=orcl12;uid=wmontana;pwd=0336321"
    Dim con As New OdbcConnection(db)


    Public seat As String
    Private Sub assignFlyer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case seat
            Case "X"
                MsgBox("ERROR SEAT ALREADY TAKEN")
                Close()
            Case Else
                MsgBox("Please fill out the information asked for")
        End Select

        Try
            con.Open()
        Catch ex As Exception
            MsgBox("Error opening connection - assign flyer")
        End Try

    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim firstName, lastName As String
        Dim ffNum, flightNumber As Integer

        seat = "X"

        firstName = fName.Text
        lastName = lName.Text
        ffNum = fFlyer.Text
        flightNumber = 205


        Try
            'insert data into flyer table via called procedure
            Dim sql As String = "Begin insert_flyer('" + firstName + "','" + lastName + "'," + ffNum.ToString + "," + flightNumber.ToString + "," + seatingChart.row.ToString + "," + seatingChart.seatNumber.ToString + "," + seatingChart.currentPrice.ToString + "); End;"
            Dim cmd As New OdbcCommand(sql, con)
            Dim flyerReader As OdbcDataReader = cmd.ExecuteReader()
            While flyerReader.Read()
                MsgBox(flyerReader(0))
            End While


        Catch ex As Exception
            MsgBox("Error On INSERT" & ex.ToString)


        End Try

        MsgBox("Your seat was priced at $" & Math.Round(seatingChart.currentPrice, 2))

        Dim confirmNumber As Integer

        Try
            'get confirmation number and assign it to customer
            Dim sql1 As String = "SELECT CONFIRMNUMBER FROM FLYER WHERE CONFIRMNUMBER = (select max(CONFIRMNUMBER) from FLYER);"
            Dim cmd1 As New OdbcCommand(sql1, con)
            Dim flyerReader1 As OdbcDataReader = cmd1.ExecuteReader()

            While flyerReader1.Read()
                confirmNumber = flyerReader1(0)
            End While

        Catch ex1 As Exception
            MsgBox("ERROR Can not retrieve confirmation number please call 1 (800) 654-5669" & ex1.ToString)


        End Try
        MsgBox("Your confirmation number is " & confirmNumber)

        Me.Close()
        con.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        con.Close()
        Me.Close()
    End Sub

    Private Sub lName_TextChanged(sender As Object, e As EventArgs) Handles lName.TextChanged

    End Sub
End Class