﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.btninput = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txttargetprod = New System.Windows.Forms.TextBox()
        Me.txtkapasitas = New System.Windows.Forms.TextBox()
        Me.txtketerangan = New System.Windows.Forms.TextBox()
        Me.txtmaterial = New System.Windows.Forms.TextBox()
        Me.txtlineprod = New System.Windows.Forms.TextBox()
        Me.txtjumlahprod = New System.Windows.Forms.TextBox()
        Me.txtjenisprod = New System.Windows.Forms.TextBox()
        Me.txtidprod = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btninput
        '
        Me.btninput.Location = New System.Drawing.Point(202, 375)
        Me.btninput.Name = "btninput"
        Me.btninput.Size = New System.Drawing.Size(100, 24)
        Me.btninput.TabIndex = 0
        Me.btninput.Text = "Input"
        Me.btninput.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(202, 414)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(100, 24)
        Me.btnsave.TabIndex = 1
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(338, 375)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(100, 24)
        Me.btnedit.TabIndex = 2
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(338, 414)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(100, 24)
        Me.btncancel.TabIndex = 3
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(480, 414)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(100, 24)
        Me.btnexit.TabIndex = 4
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(480, 375)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(100, 24)
        Me.btndelete.TabIndex = 5
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(299, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 40)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "PRODUKSI"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txttargetprod)
        Me.GroupBox2.Controls.Add(Me.txtkapasitas)
        Me.GroupBox2.Controls.Add(Me.txtketerangan)
        Me.GroupBox2.Controls.Add(Me.txtmaterial)
        Me.GroupBox2.Controls.Add(Me.txtlineprod)
        Me.GroupBox2.Controls.Add(Me.txtjumlahprod)
        Me.GroupBox2.Controls.Add(Me.txtjenisprod)
        Me.GroupBox2.Controls.Add(Me.txtidprod)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(341, 279)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Produksi"
        '
        'txttargetprod
        '
        Me.txttargetprod.Location = New System.Drawing.Point(155, 225)
        Me.txttargetprod.Name = "txttargetprod"
        Me.txttargetprod.Size = New System.Drawing.Size(149, 22)
        Me.txttargetprod.TabIndex = 14
        '
        'txtkapasitas
        '
        Me.txtkapasitas.Location = New System.Drawing.Point(155, 197)
        Me.txtkapasitas.Name = "txtkapasitas"
        Me.txtkapasitas.Size = New System.Drawing.Size(149, 22)
        Me.txtkapasitas.TabIndex = 13
        '
        'txtketerangan
        '
        Me.txtketerangan.Location = New System.Drawing.Point(155, 169)
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.Size = New System.Drawing.Size(149, 22)
        Me.txtketerangan.TabIndex = 12
        '
        'txtmaterial
        '
        Me.txtmaterial.Location = New System.Drawing.Point(155, 141)
        Me.txtmaterial.Name = "txtmaterial"
        Me.txtmaterial.Size = New System.Drawing.Size(149, 22)
        Me.txtmaterial.TabIndex = 11
        '
        'txtlineprod
        '
        Me.txtlineprod.Location = New System.Drawing.Point(155, 113)
        Me.txtlineprod.Name = "txtlineprod"
        Me.txtlineprod.Size = New System.Drawing.Size(149, 22)
        Me.txtlineprod.TabIndex = 10
        '
        'txtjumlahprod
        '
        Me.txtjumlahprod.Location = New System.Drawing.Point(155, 85)
        Me.txtjumlahprod.Name = "txtjumlahprod"
        Me.txtjumlahprod.Size = New System.Drawing.Size(149, 22)
        Me.txtjumlahprod.TabIndex = 9
        '
        'txtjenisprod
        '
        Me.txtjenisprod.Location = New System.Drawing.Point(155, 57)
        Me.txtjenisprod.Name = "txtjenisprod"
        Me.txtjenisprod.Size = New System.Drawing.Size(149, 22)
        Me.txtjenisprod.TabIndex = 8
        '
        'txtidprod
        '
        Me.txtidprod.Location = New System.Drawing.Point(155, 29)
        Me.txtidprod.Name = "txtidprod"
        Me.txtidprod.Size = New System.Drawing.Size(149, 22)
        Me.txtidprod.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 228)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 17)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Target Produksi"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 203)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 17)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Kapasitas"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 174)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 17)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Keterangan"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 144)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 17)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Material"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 114)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 17)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Line Produksi"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(17, 86)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 17)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Jumlah Produksi"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(17, 58)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 17)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Jenis Produk"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(17, 29)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 17)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Id Produksi"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(379, 78)
        Me.DGV.Name = "DGV"
        Me.DGV.RowHeadersWidth = 51
        Me.DGV.RowTemplate.Height = 24
        Me.DGV.Size = New System.Drawing.Size(409, 279)
        Me.DGV.TabIndex = 16
        '
        'btnnext
        '
        Me.btnnext.Location = New System.Drawing.Point(612, 375)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(157, 63)
        Me.btnnext.TabIndex = 17
        Me.btnnext.Text = "Next To Warehouse"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(12, 375)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(157, 63)
        Me.btnback.TabIndex = 18
        Me.btnback.Text = "Back To Planning"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btninput)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btninput As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txttargetprod As TextBox
    Friend WithEvents txtkapasitas As TextBox
    Friend WithEvents txtketerangan As TextBox
    Friend WithEvents txtmaterial As TextBox
    Friend WithEvents txtlineprod As TextBox
    Friend WithEvents txtjumlahprod As TextBox
    Friend WithEvents txtjenisprod As TextBox
    Friend WithEvents txtidprod As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents btnnext As Button
    Friend WithEvents btnback As Button
End Class