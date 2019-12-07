<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chooseForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(chooseForm))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.buyBtn = New System.Windows.Forms.Button()
        Me.lookBtn = New System.Windows.Forms.Button()
        Me.mnthCalendar = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(53, 13)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(298, 120)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 39
        Me.PictureBox2.TabStop = False
        '
        'buyBtn
        '
        Me.buyBtn.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buyBtn.Location = New System.Drawing.Point(83, 380)
        Me.buyBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buyBtn.Name = "buyBtn"
        Me.buyBtn.Size = New System.Drawing.Size(240, 89)
        Me.buyBtn.TabIndex = 40
        Me.buyBtn.Text = "Continue With Your Purchase"
        Me.buyBtn.UseVisualStyleBackColor = True
        '
        'lookBtn
        '
        Me.lookBtn.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lookBtn.Location = New System.Drawing.Point(83, 529)
        Me.lookBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lookBtn.Name = "lookBtn"
        Me.lookBtn.Size = New System.Drawing.Size(240, 104)
        Me.lookBtn.TabIndex = 41
        Me.lookBtn.Text = "Look Up Seat With Confirmation Number"
        Me.lookBtn.UseVisualStyleBackColor = True
        '
        'mnthCalendar
        '
        Me.mnthCalendar.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnthCalendar.Location = New System.Drawing.Point(90, 188)
        Me.mnthCalendar.Margin = New System.Windows.Forms.Padding(14, 13, 14, 13)
        Me.mnthCalendar.MaxDate = New Date(2022, 1, 1, 0, 0, 0, 0)
        Me.mnthCalendar.MaxSelectionCount = 1
        Me.mnthCalendar.MinDate = New Date(2019, 7, 15, 0, 0, 0, 0)
        Me.mnthCalendar.Name = "mnthCalendar"
        Me.mnthCalendar.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(179, 490)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 19)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "- OR -"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(19, 137)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(375, 24)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Choose a Flight Date and Purchase Seat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(96, 161)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(227, 24)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "EWR to LAX - Flight 205"
        '
        'chooseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(407, 721)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mnthCalendar)
        Me.Controls.Add(Me.lookBtn)
        Me.Controls.Add(Me.buyBtn)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "chooseForm"
        Me.Text = "Alaska Air"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents buyBtn As Button
    Friend WithEvents lookBtn As Button
    Friend WithEvents mnthCalendar As MonthCalendar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
