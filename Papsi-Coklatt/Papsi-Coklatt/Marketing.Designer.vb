<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Marketing
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcustomer = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtnotelp = New System.Windows.Forms.TextBox()
        Me.txtjumlahproduk = New System.Windows.Forms.TextBox()
        Me.txttanggalorder = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.txtjenisproduk = New System.Windows.Forms.ComboBox()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Customer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No. Telp"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal Order"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jenis Produk"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Jumlah Produk"
        '
        'txtcustomer
        '
        Me.txtcustomer.Location = New System.Drawing.Point(149, 32)
        Me.txtcustomer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcustomer.Name = "txtcustomer"
        Me.txtcustomer.Size = New System.Drawing.Size(210, 26)
        Me.txtcustomer.TabIndex = 7
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(149, 78)
        Me.txtalamat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(210, 26)
        Me.txtalamat.TabIndex = 8
        '
        'txtnotelp
        '
        Me.txtnotelp.Location = New System.Drawing.Point(149, 122)
        Me.txtnotelp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnotelp.Name = "txtnotelp"
        Me.txtnotelp.Size = New System.Drawing.Size(210, 26)
        Me.txtnotelp.TabIndex = 9
        '
        'txtjumlahproduk
        '
        Me.txtjumlahproduk.Location = New System.Drawing.Point(149, 245)
        Me.txtjumlahproduk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtjumlahproduk.Name = "txtjumlahproduk"
        Me.txtjumlahproduk.Size = New System.Drawing.Size(210, 26)
        Me.txtjumlahproduk.TabIndex = 11
        '
        'txttanggalorder
        '
        Me.txttanggalorder.Location = New System.Drawing.Point(149, 162)
        Me.txttanggalorder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txttanggalorder.Name = "txttanggalorder"
        Me.txttanggalorder.Size = New System.Drawing.Size(210, 26)
        Me.txttanggalorder.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 285)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 32)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Input"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(249, 333)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 30)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(249, 285)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 32)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(137, 333)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(110, 30)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(137, 285)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(110, 32)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Save"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(26, 333)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(110, 30)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "Cancel"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(395, 11)
        Me.DGV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGV.Name = "DGV"
        Me.DGV.RowHeadersWidth = 62
        Me.DGV.RowTemplate.Height = 28
        Me.DGV.Size = New System.Drawing.Size(821, 400)
        Me.DGV.TabIndex = 19
        '
        'txtjenisproduk
        '
        Me.txtjenisproduk.FormattingEnabled = True
        Me.txtjenisproduk.Items.AddRange(New Object() {"Cashew", "Chunky Bar", "Bites"})
        Me.txtjenisproduk.Location = New System.Drawing.Point(149, 203)
        Me.txtjenisproduk.Name = "txtjenisproduk"
        Me.txtjenisproduk.Size = New System.Drawing.Size(210, 28)
        Me.txtjenisproduk.TabIndex = 36
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(101, 377)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(185, 33)
        Me.Button7.TabIndex = 37
        Me.Button7.Text = "Planning"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Marketing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1228, 422)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.txtjenisproduk)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txttanggalorder)
        Me.Controls.Add(Me.txtjumlahproduk)
        Me.Controls.Add(Me.txtnotelp)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtcustomer)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Marketing"
        Me.Text = "Marketing"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcustomer As TextBox
    Friend WithEvents txtalamat As TextBox
    Friend WithEvents txtnotelp As TextBox
    Friend WithEvents txtjumlahproduk As TextBox
    Friend WithEvents txttanggalorder As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents txtjenisproduk As ComboBox
    Friend WithEvents Button7 As Button
End Class
