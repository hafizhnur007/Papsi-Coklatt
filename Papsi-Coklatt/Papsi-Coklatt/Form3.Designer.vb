<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rtxalamat = New System.Windows.Forms.RichTextBox()
        Me.txtnotelp = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbj = New System.Windows.Forms.ComboBox()
        Me.txtj = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtno = New System.Windows.Forms.TextBox()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(110, 20)
        Label1.TabIndex = 0
        Label1.Text = "Tanggal Order"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(16, 45)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(73, 20)
        Label2.TabIndex = 1
        Label2.Text = "No Order"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(29, 119)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(59, 20)
        Label3.TabIndex = 2
        Label3.Text = "Alamat"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(29, 82)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(90, 20)
        Label4.TabIndex = 3
        Label4.Text = "No Telepon"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(29, 47)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(51, 20)
        Label5.TabIndex = 4
        Label5.Text = "Nama"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(12, 83)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(0, 20)
        Label6.TabIndex = 5
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(29, 47)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(46, 20)
        Label7.TabIndex = 4
        Label7.Text = "Jenis"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(29, 82)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(60, 20)
        Label8.TabIndex = 3
        Label8.Text = "Jumlah"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(280, 82)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(34, 20)
        Label10.TabIndex = 8
        Label10.Text = "box"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rtxalamat)
        Me.GroupBox1.Controls.Add(Me.txtnotelp)
        Me.GroupBox1.Controls.Add(Me.txtnama)
        Me.GroupBox1.Controls.Add(Label5)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 259)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Supplier"
        '
        'rtxalamat
        '
        Me.rtxalamat.Location = New System.Drawing.Point(161, 119)
        Me.rtxalamat.Name = "rtxalamat"
        Me.rtxalamat.Size = New System.Drawing.Size(179, 120)
        Me.rtxalamat.TabIndex = 7
        Me.rtxalamat.Text = ""
        '
        'txtnotelp
        '
        Me.txtnotelp.Location = New System.Drawing.Point(161, 79)
        Me.txtnotelp.Name = "txtnotelp"
        Me.txtnotelp.Size = New System.Drawing.Size(179, 26)
        Me.txtnotelp.TabIndex = 6
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(161, 41)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(179, 26)
        Me.txtnama.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbj)
        Me.GroupBox2.Controls.Add(Label10)
        Me.GroupBox2.Controls.Add(Me.txtj)
        Me.GroupBox2.Controls.Add(Label7)
        Me.GroupBox2.Controls.Add(Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(393, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 116)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Pemesanan RM"
        '
        'cbj
        '
        Me.cbj.FormattingEnabled = True
        Me.cbj.Location = New System.Drawing.Point(161, 39)
        Me.cbj.Name = "cbj"
        Me.cbj.Size = New System.Drawing.Size(153, 28)
        Me.cbj.TabIndex = 9
        '
        'txtj
        '
        Me.txtj.Location = New System.Drawing.Point(161, 79)
        Me.txtj.Name = "txtj"
        Me.txtj.Size = New System.Drawing.Size(105, 26)
        Me.txtj.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(406, 228)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 37)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Input"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(406, 293)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 37)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(539, 228)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(204, 37)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Next to WH Math"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(539, 293)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(204, 37)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Back to Planning"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(22, 367)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(720, 203)
        Me.DataGridView1.TabIndex = 13
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID Purchase"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Supplier"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "No Telp"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Alamat"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "Jenis RM"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "Jumlah RM"
        Me.Column6.MinimumWidth = 8
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 150
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(159, 9)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(227, 26)
        Me.DateTimePicker1.TabIndex = 14
        '
        'txtno
        '
        Me.txtno.Location = New System.Drawing.Point(160, 49)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(225, 26)
        Me.txtno.TabIndex = 15
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 580)
        Me.Controls.Add(Me.txtno)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Name = "Form3"
        Me.Text = "Purchasing"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rtxalamat As RichTextBox
    Friend WithEvents txtnotelp As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbj As ComboBox
    Friend WithEvents txtj As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtno As TextBox
End Class
