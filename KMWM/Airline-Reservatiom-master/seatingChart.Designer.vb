<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class seatingChart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(seatingChart))
        Me.txtF = New System.Windows.Forms.TextBox()
        Me.txtE = New System.Windows.Forms.TextBox()
        Me.txtD = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.lstRows = New System.Windows.Forms.ListBox()
        Me.txtRow = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.chooseFrmBtn = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtF
        '
        Me.txtF.BackColor = System.Drawing.Color.LightGray
        Me.txtF.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtF.Location = New System.Drawing.Point(376, 219)
        Me.txtF.Margin = New System.Windows.Forms.Padding(4)
        Me.txtF.Name = "txtF"
        Me.txtF.Size = New System.Drawing.Size(42, 27)
        Me.txtF.TabIndex = 31
        Me.txtF.Text = "-"
        Me.txtF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtE
        '
        Me.txtE.BackColor = System.Drawing.Color.LightGray
        Me.txtE.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtE.Location = New System.Drawing.Point(324, 219)
        Me.txtE.Margin = New System.Windows.Forms.Padding(4)
        Me.txtE.Name = "txtE"
        Me.txtE.Size = New System.Drawing.Size(42, 27)
        Me.txtE.TabIndex = 30
        Me.txtE.Text = "-"
        Me.txtE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtD
        '
        Me.txtD.BackColor = System.Drawing.Color.LightGray
        Me.txtD.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtD.Location = New System.Drawing.Point(272, 219)
        Me.txtD.Margin = New System.Windows.Forms.Padding(4)
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(42, 27)
        Me.txtD.TabIndex = 29
        Me.txtD.Text = "-"
        Me.txtD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtC
        '
        Me.txtC.BackColor = System.Drawing.Color.LightGray
        Me.txtC.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC.Location = New System.Drawing.Point(220, 219)
        Me.txtC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(42, 27)
        Me.txtC.TabIndex = 28
        Me.txtC.Text = "-"
        Me.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtB
        '
        Me.txtB.BackColor = System.Drawing.Color.LightGray
        Me.txtB.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtB.Location = New System.Drawing.Point(168, 219)
        Me.txtB.Margin = New System.Windows.Forms.Padding(4)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(42, 27)
        Me.txtB.TabIndex = 27
        Me.txtB.Text = "-"
        Me.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtA
        '
        Me.txtA.BackColor = System.Drawing.Color.LightGray
        Me.txtA.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA.Location = New System.Drawing.Point(117, 219)
        Me.txtA.Margin = New System.Windows.Forms.Padding(4)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(42, 27)
        Me.txtA.TabIndex = 26
        Me.txtA.Text = "-"
        Me.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.LightGray
        Me.Label7.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(394, 190)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 19)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "F"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.LightGray
        Me.Label6.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(342, 190)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 19)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "E"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightGray
        Me.Label5.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(284, 190)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 19)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "D"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightGray
        Me.Label4.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(234, 190)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 19)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "C"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(196, 130)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 19)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "B"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightGray
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(130, 130)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 19)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "A"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 190)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 19)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Row"
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(9, 285)
        Me.btnDisplay.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(436, 60)
        Me.btnDisplay.TabIndex = 18
        Me.btnDisplay.Text = "Display Stats"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'lstDisplay
        '
        Me.lstDisplay.BackColor = System.Drawing.Color.LightGray
        Me.lstDisplay.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 19
        Me.lstDisplay.Location = New System.Drawing.Point(9, 367)
        Me.lstDisplay.Margin = New System.Windows.Forms.Padding(4)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(434, 251)
        Me.lstDisplay.TabIndex = 17
        '
        'lstRows
        '
        Me.lstRows.BackColor = System.Drawing.Color.LightGray
        Me.lstRows.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRows.FormattingEnabled = True
        Me.lstRows.ItemHeight = 21
        Me.lstRows.Location = New System.Drawing.Point(528, 194)
        Me.lstRows.Margin = New System.Windows.Forms.Padding(4)
        Me.lstRows.MultiColumn = True
        Me.lstRows.Name = "lstRows"
        Me.lstRows.Size = New System.Drawing.Size(97, 445)
        Me.lstRows.TabIndex = 16
        '
        'txtRow
        '
        Me.txtRow.BackColor = System.Drawing.Color.LightGray
        Me.txtRow.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRow.Location = New System.Drawing.Point(20, 216)
        Me.txtRow.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRow.Name = "txtRow"
        Me.txtRow.Size = New System.Drawing.Size(54, 27)
        Me.txtRow.TabIndex = 32
        Me.txtRow.Text = "-"
        Me.txtRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(82, 218)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 19)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "|"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.LightGray
        Me.Label9.Location = New System.Drawing.Point(82, 196)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 19)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "|"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.LightGray
        Me.Label10.Location = New System.Drawing.Point(82, 237)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 19)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "|"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.AirLine_Reservation.My.Resources.Resources.tail
        Me.PictureBox4.Location = New System.Drawing.Point(509, 638)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(137, 101)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 40
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.AirLine_Reservation.My.Resources.Resources.nose
        Me.PictureBox3.Location = New System.Drawing.Point(528, 47)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(99, 149)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 39
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(9, 18)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(321, 140)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 38
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.Location = New System.Drawing.Point(9, 187)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(436, 75)
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.AirLine_Reservation.My.Resources.Resources.wings
        Me.PictureBox5.Location = New System.Drawing.Point(51, 253)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(1054, 386)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 41
        Me.PictureBox5.TabStop = False
        '
        'chooseFrmBtn
        '
        Me.chooseFrmBtn.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chooseFrmBtn.Location = New System.Drawing.Point(9, 628)
        Me.chooseFrmBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.chooseFrmBtn.Name = "chooseFrmBtn"
        Me.chooseFrmBtn.Size = New System.Drawing.Size(436, 56)
        Me.chooseFrmBtn.TabIndex = 42
        Me.chooseFrmBtn.Text = "Back to Home?"
        Me.chooseFrmBtn.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.LightGray
        Me.Label11.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(183, 190)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 19)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "B"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.LightGray
        Me.Label12.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(130, 190)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(20, 19)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "A"
        '
        'seatingChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(892, 821)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.chooseFrmBtn)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtRow)
        Me.Controls.Add(Me.txtF)
        Me.Controls.Add(Me.txtE)
        Me.Controls.Add(Me.txtD)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lstRows)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "seatingChart"
        Me.Text = "Alaska Airlines Reservation"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtF As TextBox
    Friend WithEvents txtE As TextBox
    Friend WithEvents txtD As TextBox
    Friend WithEvents txtC As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents txtA As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents lstDisplay As ListBox
    Friend WithEvents lstRows As ListBox
    Friend WithEvents txtRow As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents chooseFrmBtn As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
