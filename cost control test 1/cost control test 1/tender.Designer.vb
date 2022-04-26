<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tender
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tender))
        Me.dgv_tender = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_no_tender = New System.Windows.Forms.TextBox()
        Me.txt_nama_tender = New System.Windows.Forms.TextBox()
        Me.txt_tgl_tender = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_ket_client = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_nama_client = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_kd_client = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BACKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgv_tender, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_tender
        '
        Me.dgv_tender.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_tender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tender.Location = New System.Drawing.Point(12, 336)
        Me.dgv_tender.Name = "dgv_tender"
        Me.dgv_tender.Size = New System.Drawing.Size(809, 235)
        Me.dgv_tender.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No. Tender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Tender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tanggal Tender"
        '
        'txt_no_tender
        '
        Me.txt_no_tender.Location = New System.Drawing.Point(115, 43)
        Me.txt_no_tender.Name = "txt_no_tender"
        Me.txt_no_tender.Size = New System.Drawing.Size(189, 20)
        Me.txt_no_tender.TabIndex = 6
        '
        'txt_nama_tender
        '
        Me.txt_nama_tender.Location = New System.Drawing.Point(115, 69)
        Me.txt_nama_tender.Name = "txt_nama_tender"
        Me.txt_nama_tender.Size = New System.Drawing.Size(189, 20)
        Me.txt_nama_tender.TabIndex = 7
        '
        'txt_tgl_tender
        '
        Me.txt_tgl_tender.Location = New System.Drawing.Point(115, 95)
        Me.txt_tgl_tender.Name = "txt_tgl_tender"
        Me.txt_tgl_tender.Size = New System.Drawing.Size(189, 20)
        Me.txt_tgl_tender.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.txt_ket_client)
        Me.GroupBox1.Controls.Add(Me.txt_nama_tender)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_nama_client)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_tgl_tender)
        Me.GroupBox1.Controls.Add(Me.txt_kd_client)
        Me.GroupBox1.Controls.Add(Me.txt_no_tender)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 280)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tender and Client"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 133)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Client Form"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Tender Form"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.cost_control_test_1.My.Resources.Resources.icons8_plus_math_15
        Me.Button2.Location = New System.Drawing.Point(192, 233)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 33)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Tambah Data"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txt_ket_client
        '
        Me.txt_ket_client.Location = New System.Drawing.Point(115, 201)
        Me.txt_ket_client.Name = "txt_ket_client"
        Me.txt_ket_client.Size = New System.Drawing.Size(189, 20)
        Me.txt_ket_client.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Nama Client"
        '
        'txt_nama_client
        '
        Me.txt_nama_client.Location = New System.Drawing.Point(115, 175)
        Me.txt_nama_client.Name = "txt_nama_client"
        Me.txt_nama_client.Size = New System.Drawing.Size(189, 20)
        Me.txt_nama_client.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Keterangan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Kode Client"
        '
        'txt_kd_client
        '
        Me.txt_kd_client.Location = New System.Drawing.Point(115, 149)
        Me.txt_kd_client.Name = "txt_kd_client"
        Me.txt_kd_client.Size = New System.Drawing.Size(189, 20)
        Me.txt_kd_client.TabIndex = 14
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.TextBox10)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TextBox7)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TextBox8)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TextBox9)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox3.Location = New System.Drawing.Point(365, 43)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(318, 165)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pekerjaan"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(233, 133)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(18, 133)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(209, 20)
        Me.TextBox1.TabIndex = 26
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(119, 105)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(189, 20)
        Me.TextBox10.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Total Tender"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(119, 79)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(189, 20)
        Me.TextBox7.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Nama Pekerjaan"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(119, 53)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(189, 20)
        Me.TextBox8.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Kode Pekerjaan"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(119, 27)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(189, 20)
        Me.TextBox9.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Jumlah Harga"
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.MintCream
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Location = New System.Drawing.Point(680, 300)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(141, 23)
        Me.btn_search.TabIndex = 18
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(365, 300)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(308, 20)
        Me.txt_search.TabIndex = 20
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Honeydew
        Me.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Image = Global.cost_control_test_1.My.Resources.Resources.icons8_cancel_30
        Me.btn_cancel.Location = New System.Drawing.Point(608, 221)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 61)
        Me.btn_cancel.TabIndex = 24
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Honeydew
        Me.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Image = Global.cost_control_test_1.My.Resources.Resources.icons8_trash_can_30
        Me.btn_delete.Location = New System.Drawing.Point(527, 221)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 60)
        Me.btn_delete.TabIndex = 23
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.Honeydew
        Me.btn_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btn_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.Image = Global.cost_control_test_1.My.Resources.Resources.icons8_edit_30
        Me.btn_edit.Location = New System.Drawing.Point(446, 221)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 60)
        Me.btn_edit.TabIndex = 22
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Honeydew
        Me.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Image = Global.cost_control_test_1.My.Resources.Resources.icons8_save_30
        Me.btn_save.Location = New System.Drawing.Point(365, 221)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 60)
        Me.btn_save.TabIndex = 21
        Me.btn_save.Text = "Save"
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BACKToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(833, 24)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BACKToolStripMenuItem
        '
        Me.BACKToolStripMenuItem.Image = Global.cost_control_test_1.My.Resources.Resources.icons8_back_64
        Me.BACKToolStripMenuItem.Name = "BACKToolStripMenuItem"
        Me.BACKToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.BACKToolStripMenuItem.Text = "BACK"
        '
        'tender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.cost_control_test_1.My.Resources.Resources.more_leaves
        Me.ClientSize = New System.Drawing.Size(833, 583)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dgv_tender)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "tender"
        Me.Text = "TENDER"
        CType(Me.dgv_tender, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_tender As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_no_tender As TextBox
    Friend WithEvents txt_nama_tender As TextBox
    Friend WithEvents txt_tgl_tender As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_ket_client As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_nama_client As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_kd_client As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_search As Button
    Friend WithEvents txt_search As TextBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BACKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
End Class
