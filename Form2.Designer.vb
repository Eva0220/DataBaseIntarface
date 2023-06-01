<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim ClientIDLabel1 As System.Windows.Forms.Label
        Dim ClientFIOLabel As System.Windows.Forms.Label
        Dim ClientGenderLabel As System.Windows.Forms.Label
        Dim ClientPhoneLabel As System.Windows.Forms.Label
        Dim ClientPassportLabel As System.Windows.Forms.Label
        Dim ClientAddressLabel As System.Windows.Forms.Label
        Me.ClientsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ClientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeliveryServiceDataSet = New DeliveryService.DeliveryServiceDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClientsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ClientsTableAdapter = New DeliveryService.DeliveryServiceDataSetTableAdapters.ClientsTableAdapter()
        Me.TableAdapterManager = New DeliveryService.DeliveryServiceDataSetTableAdapters.TableAdapterManager()
        Me.ClientIDTextBox = New System.Windows.Forms.TextBox()
        Me.ClientFIOTextBox = New System.Windows.Forms.TextBox()
        Me.ClientGenderTextBox = New System.Windows.Forms.TextBox()
        Me.ClientPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.ClientPassportTextBox = New System.Windows.Forms.TextBox()
        Me.ClientAddressTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        ClientIDLabel1 = New System.Windows.Forms.Label()
        ClientFIOLabel = New System.Windows.Forms.Label()
        ClientGenderLabel = New System.Windows.Forms.Label()
        ClientPhoneLabel = New System.Windows.Forms.Label()
        ClientPassportLabel = New System.Windows.Forms.Label()
        ClientAddressLabel = New System.Windows.Forms.Label()
        CType(Me.ClientsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryServiceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClientIDLabel1
        '
        ClientIDLabel1.AutoSize = True
        ClientIDLabel1.Location = New System.Drawing.Point(64, 155)
        ClientIDLabel1.Name = "ClientIDLabel1"
        ClientIDLabel1.Size = New System.Drawing.Size(99, 25)
        ClientIDLabel1.TabIndex = 3
        ClientIDLabel1.Text = "Client ID:"
        '
        'ClientFIOLabel
        '
        ClientFIOLabel.AutoSize = True
        ClientFIOLabel.Location = New System.Drawing.Point(64, 217)
        ClientFIOLabel.Name = "ClientFIOLabel"
        ClientFIOLabel.Size = New System.Drawing.Size(113, 25)
        ClientFIOLabel.TabIndex = 4
        ClientFIOLabel.Text = "Client FIO:"
        '
        'ClientGenderLabel
        '
        ClientGenderLabel.AutoSize = True
        ClientGenderLabel.Location = New System.Drawing.Point(64, 277)
        ClientGenderLabel.Name = "ClientGenderLabel"
        ClientGenderLabel.Size = New System.Drawing.Size(150, 25)
        ClientGenderLabel.TabIndex = 6
        ClientGenderLabel.Text = "Client Gender:"
        '
        'ClientPhoneLabel
        '
        ClientPhoneLabel.AutoSize = True
        ClientPhoneLabel.Location = New System.Drawing.Point(64, 340)
        ClientPhoneLabel.Name = "ClientPhoneLabel"
        ClientPhoneLabel.Size = New System.Drawing.Size(141, 25)
        ClientPhoneLabel.TabIndex = 8
        ClientPhoneLabel.Text = "Client Phone:"
        '
        'ClientPassportLabel
        '
        ClientPassportLabel.AutoSize = True
        ClientPassportLabel.Location = New System.Drawing.Point(64, 403)
        ClientPassportLabel.Name = "ClientPassportLabel"
        ClientPassportLabel.Size = New System.Drawing.Size(164, 25)
        ClientPassportLabel.TabIndex = 10
        ClientPassportLabel.Text = "Client Passport:"
        '
        'ClientAddressLabel
        '
        ClientAddressLabel.AutoSize = True
        ClientAddressLabel.Location = New System.Drawing.Point(64, 462)
        ClientAddressLabel.Name = "ClientAddressLabel"
        ClientAddressLabel.Size = New System.Drawing.Size(158, 25)
        ClientAddressLabel.TabIndex = 12
        ClientAddressLabel.Text = "Client Address:"
        '
        'ClientsBindingNavigator
        '
        Me.ClientsBindingNavigator.AddNewItem = Nothing
        Me.ClientsBindingNavigator.CountItem = Nothing
        Me.ClientsBindingNavigator.DeleteItem = Nothing
        Me.ClientsBindingNavigator.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ClientsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClientsBindingNavigator.MoveFirstItem = Nothing
        Me.ClientsBindingNavigator.MoveLastItem = Nothing
        Me.ClientsBindingNavigator.MoveNextItem = Nothing
        Me.ClientsBindingNavigator.MovePreviousItem = Nothing
        Me.ClientsBindingNavigator.Name = "ClientsBindingNavigator"
        Me.ClientsBindingNavigator.PositionItem = Nothing
        Me.ClientsBindingNavigator.Size = New System.Drawing.Size(649, 25)
        Me.ClientsBindingNavigator.TabIndex = 21
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 23)
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(86, 36)
        Me.BindingNavigatorCountItem.Text = "для {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 23)
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 23)
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 23)
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(100, 39)
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 23)
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 23)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'ClientsBindingNavigatorSaveItem
        '
        Me.ClientsBindingNavigatorSaveItem.Name = "ClientsBindingNavigatorSaveItem"
        Me.ClientsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        '
        'ClientsTableAdapter
        '
        Me.ClientsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientsTableAdapter = Me.ClientsTableAdapter
        Me.TableAdapterManager.UpdateOrder = DeliveryService.DeliveryServiceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClientIDTextBox
        '
        Me.ClientIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "ClientID", True))
        Me.ClientIDTextBox.Location = New System.Drawing.Point(238, 149)
        Me.ClientIDTextBox.Name = "ClientIDTextBox"
        Me.ClientIDTextBox.Size = New System.Drawing.Size(367, 31)
        Me.ClientIDTextBox.TabIndex = 4
        '
        'ClientFIOTextBox
        '
        Me.ClientFIOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "ClientFIO", True))
        Me.ClientFIOTextBox.Location = New System.Drawing.Point(238, 211)
        Me.ClientFIOTextBox.Name = "ClientFIOTextBox"
        Me.ClientFIOTextBox.Size = New System.Drawing.Size(367, 31)
        Me.ClientFIOTextBox.TabIndex = 5
        '
        'ClientGenderTextBox
        '
        Me.ClientGenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "ClientGender", True))
        Me.ClientGenderTextBox.Location = New System.Drawing.Point(238, 271)
        Me.ClientGenderTextBox.Name = "ClientGenderTextBox"
        Me.ClientGenderTextBox.Size = New System.Drawing.Size(367, 31)
        Me.ClientGenderTextBox.TabIndex = 7
        '
        'ClientPhoneTextBox
        '
        Me.ClientPhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "ClientPhone", True))
        Me.ClientPhoneTextBox.Location = New System.Drawing.Point(238, 334)
        Me.ClientPhoneTextBox.Name = "ClientPhoneTextBox"
        Me.ClientPhoneTextBox.Size = New System.Drawing.Size(367, 31)
        Me.ClientPhoneTextBox.TabIndex = 9
        '
        'ClientPassportTextBox
        '
        Me.ClientPassportTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "ClientPassport", True))
        Me.ClientPassportTextBox.Location = New System.Drawing.Point(238, 397)
        Me.ClientPassportTextBox.Name = "ClientPassportTextBox"
        Me.ClientPassportTextBox.Size = New System.Drawing.Size(367, 31)
        Me.ClientPassportTextBox.TabIndex = 11
        '
        'ClientAddressTextBox
        '
        Me.ClientAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "ClientAddress", True))
        Me.ClientAddressTextBox.Location = New System.Drawing.Point(238, 456)
        Me.ClientAddressTextBox.Name = "ClientAddressTextBox"
        Me.ClientAddressTextBox.Size = New System.Drawing.Size(367, 31)
        Me.ClientAddressTextBox.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 514)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 60)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Первый"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(129, 514)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(171, 60)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Предыдущий"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(306, 514)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(167, 60)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Следующий"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(479, 514)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(149, 60)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Последний"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(147, 602)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(137, 60)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "Добавить"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(322, 602)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(137, 60)
        Me.Button6.TabIndex = 19
        Me.Button6.Text = "Удалить"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(502, 670)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(103, 60)
        Me.Button7.TabIndex = 20
        Me.Button7.Text = "Назад"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 51)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Client"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 742)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ClientAddressLabel)
        Me.Controls.Add(Me.ClientAddressTextBox)
        Me.Controls.Add(ClientPassportLabel)
        Me.Controls.Add(Me.ClientPassportTextBox)
        Me.Controls.Add(ClientPhoneLabel)
        Me.Controls.Add(Me.ClientPhoneTextBox)
        Me.Controls.Add(ClientGenderLabel)
        Me.Controls.Add(Me.ClientGenderTextBox)
        Me.Controls.Add(ClientFIOLabel)
        Me.Controls.Add(Me.ClientFIOTextBox)
        Me.Controls.Add(ClientIDLabel1)
        Me.Controls.Add(Me.ClientIDTextBox)
        Me.Controls.Add(Me.ClientsBindingNavigator)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.ClientsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryServiceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DeliveryServiceDataSet As DeliveryServiceDataSet
    Friend WithEvents ClientsBindingSource As BindingSource
    Friend WithEvents ClientsTableAdapter As DeliveryServiceDataSetTableAdapters.ClientsTableAdapter
    Friend WithEvents TableAdapterManager As DeliveryServiceDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClientsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ClientsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ClientIDTextBox As TextBox
    Friend WithEvents ClientFIOTextBox As TextBox
    Friend WithEvents ClientGenderTextBox As TextBox
    Friend WithEvents ClientPhoneTextBox As TextBox
    Friend WithEvents ClientPassportTextBox As TextBox
    Friend WithEvents ClientAddressTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label1 As Label
End Class
