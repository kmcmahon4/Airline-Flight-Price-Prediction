Imports System.ComponentModel
Imports System.Data
Imports System.Data.Odbc

Public Class seatingChart
    Dim db As String = "Dsn=orcl12;uid=wmontana;pwd=0336321"
    Dim con As New OdbcConnection(db)

    Dim seats(20, 6) As String
    Dim frmAssign As New assignFlyer()
    Public currentPrice As Double
    Public a As Double
    Public b1 As Double
    Public b2 As Double
    Public row As Integer
    Public seatNumber As Integer
    Dim counter As Integer = 0






    Public Sub frmSeatingChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If counter < 1 Then
            counter = counter + 1
            'initialize seat list
            lstRows.Items.Add(" A B C  D E F ")
            For i As Integer = 1 To 20
                For j As Integer = 1 To 6
                    seats(i, j) = "O"
                Next
                lstRows.Items.Add(" OOO OOO ")
            Next

            'open connection
            Try
                con.Open()
            Catch ex As Exception
                lstDisplay.Items.Add("Error opening connection - frm_seating_chart")
            End Try
        End If




    End Sub

    Private Sub updateRow(row As Integer)
        txtRow.Text = row.ToString()
        txtA.Text = seats(row, 1)
        txtB.Text = seats(row, 2)
        txtC.Text = seats(row, 3)
        txtD.Text = seats(row, 4)
        txtE.Text = seats(row, 5)
        txtF.Text = seats(row, 6)
    End Sub
    Private Sub Assign(seat As Integer)
        row = lstRows.SelectedIndex
        If row > 0 Then
            assignFlyer.seat = seats(row, seat)
            assignFlyer.ShowDialog()
            seats(row, seat) = assignFlyer.seat

            updateRow(row)
            lstRows.Items(row) = " " & seats(row, 1) & seats(row, 2) & seats(row, 3) &
                                 " " & seats(row, 4) & seats(row, 5) & seats(row, 6)
        End If
    End Sub

    Private Sub lstRows_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRows.SelectedIndexChanged
        Dim row As Integer = lstRows.SelectedIndex
        If row > 0 Then
            updateRow(row)
        End If
    End Sub

    Private Sub txtA_Click(sender As Object, e As EventArgs) Handles txtA.Click
        seatNumber = 1
        Assign(1)

    End Sub

    Private Sub txtB_Click(sender As Object, e As EventArgs) Handles txtB.Click
        seatNumber = 2
        Assign(2)

    End Sub

    Private Sub txtC_Click(sender As Object, e As EventArgs) Handles txtC.Click
        seatNumber = 3
        Assign(3)

    End Sub

    Private Sub txtD_Click(sender As Object, e As EventArgs) Handles txtD.Click
        seatNumber = 4
        Assign(4)

    End Sub

    Private Sub txtE_Click(sender As Object, e As EventArgs) Handles txtE.Click
        seatNumber = 5
        Assign(5)

    End Sub

    Private Sub txtF_Click(sender As Object, e As EventArgs) Handles txtF.Click
        seatNumber = 6
        Assign(6)

    End Sub

    Public Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim passengers As Integer = 0
        Dim vacant As Integer = 0
        Dim window As Integer = 0


        For i As Integer = 1 To 20
            For j As Integer = 1 To 6
                Select Case seats(i, j)
                    Case "X"
                        passengers += 1
                    Case Else
                        vacant += 1
                        If j = 1 Or j = 6 Then
                            window += 1
                        End If
                End Select
            Next
        Next



        Dim seatsAvailble As Integer = vacant
        Dim totalSeats As Integer = 120
        Dim Today As Date = Date.Now
        Dim daysUntil As Double = DateAndTime.DateDiff("d", Today, chooseForm.flightDate)



        lstDisplay.Items.Clear()
        lstDisplay.Items.Add("Flights Total Capacity:" & totalSeats)
        lstDisplay.Items.Add("Total Seats Availbe:" & seatsAvailble)
        lstDisplay.Items.Add("Seats Filled : " & (20 * 6 - vacant))
        lstDisplay.Items.Add("Windows Available : " & window)
        lstDisplay.Items.Add("Other Available seats :" & vacant - window)
        lstDisplay.Items.Add("Date of Flight " + chooseForm.flightDate)
        lstDisplay.Items.Add("Days Until Flight : " & (daysUntil + 1))


        Try
            Dim sql As String = "SELECT * FROM COEF;"
            Dim cmd As New OdbcCommand(sql, con)
            Dim coefReader As OdbcDataReader = cmd.ExecuteReader()
            While coefReader.Read()

                a = (coefReader(3))
                b1 = (coefReader(4))
                b2 = (coefReader(5))
            End While

        Catch ex As Exception
            lstDisplay.Items.Add("ERROR" & ex.ToString)

        End Try

        ' lstDisplay.Items.Add("a = " & a)
        ' lstDisplay.Items.Add("b1 = " & b1)
        'lstDisplay.Items.Add("b2 = " & b2)
        currentPrice = a + (b1 * (-vacant - 1)) + (b2 * -daysUntil)

        If currentPrice < 138.0 Then
            currentPrice = 138.0
        End If

        lstDisplay.Items.Add("Current Price = $" & Math.Round(currentPrice, 2))




        ''Show From student db
        'Dim sn As String
        'Dim sid As Double
        'Dim cls As Double
        'Dim maj As String

        'Try
        '    Dim sql As String = "SELECT * FROM STUDENT;"
        '    Dim cmd As New OdbcCommand(sql, con)
        '    Dim studentReader As OdbcDataReader = cmd.ExecuteReader()

        '    While studentReader.Read()
        '        sn = studentReader(0)
        '        sid = CInt(studentReader(1))
        '        cls = CInt(studentReader(2))
        '        maj = studentReader(3)

        '        lstDisplay.Items.Add(sn & " " & sid & " " & cls & " " & maj)


        '    End While

        'Catch ex As Exception
        '    lstDisplay.Items.Add("ERROR" & ex.ToString)

        'End Try




    End Sub

    'Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
    '    Dim sn, maj As String
    '    Dim sid As Integer
    '    Dim cls As Double
    '    sn = "Montana"
    '    sid = 1
    '    cls = 2
    '    maj = "CS"
    '    Try
    '        'insert data into student table
    '        Dim sql As String = "INSERT INTO STUDENT VALUES('" + sn + "'," + sid.ToString() + "," + cls.ToString() + ",'" + maj + "');"
    '        Dim cmd As New OdbcCommand(sql, con)
    '        Dim studentReader As OdbcDataReader = cmd.ExecuteReader()

    '        While studentReader.Read()
    '            lstDisplay.Items.Add(studentReader(0))
    '        End While


    '    Catch ex As Exception
    '        lstDisplay.Items.Add("ERROR on INSERT" & ex.ToString)


    '    End Try

    'End Sub
    'Private Sub btnInsert_Click(sender As Object, e As EventArgs)
    '    Dim fname, lname As String
    '    Dim ffNum, flightNumber As Integer


    '    ''INSERT
    '    fname = "Wyatt"
    '    lname = "Montana"
    '    ffNum = 223412341
    '    flightNumber = 205
    '    Try
    '        'insert data into student table
    '        Dim sql As String = "INSERT INTO FLYER VALUES('" + fname + "','" + lname + "'," + ffNum.ToString + "," + flightNumber.ToString + ");"
    '        Dim cmd As New OdbcCommand(sql, con)
    '        Dim flyerReader As OdbcDataReader = cmd.ExecuteReader()

    '        While flyerReader.Read()
    '            lstDisplay.Items.Add(flyerReader(0))
    '        End While


    '    Catch ex As Exception
    '        lstDisplay.Items.Add("ERROR on INSERT" & ex.ToString)


    '    End Try
    '    'PROCEDURE
    '    fname = "Kerri"
    '    lname = "McMahon"
    '    ffNum = 223412341
    '    flightNumber = 205
    '    Try
    '        'insert data into student table
    '        Dim sql As String = "Begin insert_flyer('" + fname + "','" + lname + "'," + ffNum.ToString + "," + flightNumber.ToString + "); end;"
    '        Dim cmd As New OdbcCommand(sql, con)
    '        Dim flyerReader As OdbcDataReader = cmd.ExecuteReader()

    '        While flyerReader.Read()
    '            lstDisplay.Items.Add(flyerReader(0))
    '        End While


    '    Catch ex As Exception
    '        lstDisplay.Items.Add("ERROR on INSERT" & ex.ToString)


    '    End Try

    'End Sub

    Private Sub seatingChart_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub chooseFrmBtn_Click(sender As Object, e As EventArgs) Handles chooseFrmBtn.Click
        Me.Hide()
        chooseForm.Show()
    End Sub


End Class

