<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ClientFIOLabel As System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ClientIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientFIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientGenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientPassportDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeliveryServiceDataSet = New DeliveryService.DeliveryServiceDataSet()
        Me.ClientsTableAdapter = New DeliveryService.DeliveryServiceDataSetTableAdapters.ClientsTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New DeliveryService.DeliveryServiceDataSetTableAdapters.TableAdapterManager()
        Me.ClientFIOComboBox = New System.Windows.Forms.ComboBox()
        ClientFIOLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryServiceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClientFIOLabel
        '
        ClientFIOLabel.AutoSize = True
        ClientFIOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        ClientFIOLabel.Location = New System.Drawing.Point(60, 522)
        ClientFIOLabel.Name = "ClientFIOLabel"
        ClientFIOLabel.Size = New System.Drawing.Size(127, 29)
        ClientFIOLabel.TabIndex = 10
        ClientFIOLabel.Text = "Client FIO:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClientIDDataGridViewTextBoxColumn, Me.ClientFIODataGridViewTextBoxColumn, Me.ClientGenderDataGridViewTextBoxColumn, Me.ClientPhoneDataGridViewTextBoxColumn, Me.ClientPassportDataGridViewTextBoxColumn, Me.ClientAddressDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClientsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(56, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(2324, 433)
        Me.DataGridView1.TabIndex = 0
        '
        'ClientIDDataGridViewTextBoxColumn
        '
        Me.ClientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID"
        Me.ClientIDDataGridViewTextBoxColumn.HeaderText = "ClientID"
        Me.ClientIDDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.ClientIDDataGridViewTextBoxColumn.Name = "ClientIDDataGridViewTextBoxColumn"
        Me.ClientIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClientIDDataGridViewTextBoxColumn.Width = 200
        '
        'ClientFIODataGridViewTextBoxColumn
        '
        Me.ClientFIODataGridViewTextBoxColumn.DataPropertyName = "ClientFIO"
        Me.ClientFIODataGridViewTextBoxColumn.HeaderText = "ClientFIO"
        Me.ClientFIODataGridViewTextBoxColumn.MinimumWidth = 10
        Me.ClientFIODataGridViewTextBoxColumn.Name = "ClientFIODataGridViewTextBoxColumn"
        Me.ClientFIODataGridViewTextBoxColumn.Width = 200
        '
        'ClientGenderDataGridViewTextBoxColumn
        '
        Me.ClientGenderDataGridViewTextBoxColumn.DataPropertyName = "ClientGender"
        Me.ClientGenderDataGridViewTextBoxColumn.HeaderText = "ClientGender"
        Me.ClientGenderDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.ClientGenderDataGridViewTextBoxColumn.Name = "ClientGenderDataGridViewTextBoxColumn"
        Me.ClientGenderDataGridViewTextBoxColumn.Width = 200
        '
        'ClientPhoneDataGridViewTextBoxColumn
        '
        Me.ClientPhoneDataGridViewTextBoxColumn.DataPropertyName = "ClientPhone"
        Me.ClientPhoneDataGridViewTextBoxColumn.HeaderText = "ClientPhone"
        Me.ClientPhoneDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.ClientPhoneDataGridViewTextBoxColumn.Name = "ClientPhoneDataGridViewTextBoxColumn"
        Me.ClientPhoneDataGridViewTextBoxColumn.Width = 200
        '
        'ClientPassportDataGridViewTextBoxColumn
        '
        Me.ClientPassportDataGridViewTextBoxColumn.DataPropertyName = "ClientPassport"
        Me.ClientPassportDataGridViewTextBoxColumn.HeaderText = "ClientPassport"
        Me.ClientPassportDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.ClientPassportDataGridViewTextBoxColumn.Name = "ClientPassportDataGridViewTextBoxColumn"
        Me.ClientPassportDataGridViewTextBoxColumn.Width = 200
        '
        'ClientAddressDataGridViewTextBoxColumn
        '
        Me.ClientAddressDataGridViewTextBoxColumn.DataPropertyName = "ClientAddress"
        Me.ClientAddressDataGridViewTextBoxColumn.HeaderText = "ClientAddress"
        Me.ClientAddressDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.ClientAddressDataGridViewTextBoxColumn.Name = "ClientAddressDataGridViewTextBoxColumn"
        Me.ClientAddressDataGridViewTextBoxColumn.Width = 200
        '
        'ClientsBindingSource
        '
        Me.ClientsBindingSource.DataMember = "Clients"
        Me.ClientsBindingSource.DataSource = Me.DeliveryServiceDataSet
        '
        'DeliveryServiceDataSet
        '
        Me.DeliveryServiceDataSet.DataSetName = "DeliveryServiceDataSet"
        Me.DeliveryServiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientsTableAdapter
        '
        Me.ClientsTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 610)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ClientID"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBox1.Location = New System.Drawing.Point(203, 603)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(343, 31)
        Me.TextBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button1.Location = New System.Drawing.Point(596, 501)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 71)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Фильтр"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button2.Location = New System.Drawing.Point(793, 502)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(171, 70)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Все записи"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button3.Location = New System.Drawing.Point(596, 590)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(171, 68)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Найти"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(1991, 484)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 174)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Сортировка"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.Location = New System.Drawing.Point(103, 120)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(165, 44)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Сортировать"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(166, 72)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(142, 29)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Убывание"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(166, 37)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(173, 29)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Возрастание"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Items.AddRange(New Object() {"ClientID", "ClientFIO", "ClientGender", "ClientPhone", "ClientPassport", "ClientAddress"})
        Me.ListBox1.Location = New System.Drawing.Point(15, 39)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(137, 54)
        Me.ListBox1.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button4.Location = New System.Drawing.Point(793, 588)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(171, 70)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Закрыть"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientsTableAdapter = Me.ClientsTableAdapter
        Me.TableAdapterManager.UpdateOrder = DeliveryService.DeliveryServiceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClientFIOComboBox
        '
        Me.ClientFIOComboBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientFIOComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "ClientFIO", True))
        Me.ClientFIOComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClientsBindingSource, "ClientFIO", True))
        Me.ClientFIOComboBox.DataSource = Me.ClientsBindingSource
        Me.ClientFIOComboBox.DisplayMember = "ClientFIO"
        Me.ClientFIOComboBox.FormattingEnabled = True
        Me.ClientFIOComboBox.Location = New System.Drawing.Point(203, 518)
        Me.ClientFIOComboBox.Name = "ClientFIOComboBox"
        Me.ClientFIOComboBox.Size = New System.Drawing.Size(343, 33)
        Me.ClientFIOComboBox.TabIndex = 11
        Me.ClientFIOComboBox.ValueMember = "ClientFIO"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(2524, 713)
        Me.Controls.Add(ClientFIOLabel)
        Me.Controls.Add(Me.ClientFIOComboBox)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryServiceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DeliveryServiceDataSet As DeliveryServiceDataSet
    Friend WithEvents ClientsBindingSource As BindingSource
    Friend WithEvents ClientsTableAdapter As DeliveryServiceDataSetTableAdapters.ClientsTableAdapter
    Friend WithEvents ClientIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClientFIODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClientGenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClientPhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClientPassportDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClientAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button4 As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Button5 As Button
    Friend WithEvents TableAdapterManager As DeliveryServiceDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClientFIOComboBox As ComboBox
    Friend WithEvents ListBox1 As ListBox
End Class
