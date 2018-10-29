<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.ActualizarBindingSourceButton = New System.Windows.Forms.Button()
        Me.EdadBindingSourceTextBox = New System.Windows.Forms.TextBox()
        Me.NombreBindingSourceTextBox = New System.Windows.Forms.TextBox()
        Me.IdBindingSourceTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CargarBindingSourceButton = New System.Windows.Forms.Button()
        Me.FiltrarButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NombreBinding = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewTabPage = New System.Windows.Forms.TabPage()
        Me.CargarDataGridViewButton = New System.Windows.Forms.Button()
        Me.ActualizarDataGridViewButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBoxTabPage = New System.Windows.Forms.TabPage()
        Me.CargarComboBoxButton = New System.Windows.Forms.Button()
        Me.IdComboBoxTextBox = New System.Windows.Forms.TextBox()
        Me.NombreComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBoxTabPage = New System.Windows.Forms.TabPage()
        Me.CargarListBoxButton = New System.Windows.Forms.Button()
        Me.Clientes = New System.Windows.Forms.Label()
        Me.ClientesListBox = New System.Windows.Forms.ListBox()
        Me.InsertarTabPage = New System.Windows.Forms.TabPage()
        Me.AceptarInsertarButton = New System.Windows.Forms.Button()
        Me.EdadTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage5.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataGridViewTabPage.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ComboBoxTabPage.SuspendLayout()
        Me.ListBoxTabPage.SuspendLayout()
        Me.InsertarTabPage.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.ActualizarBindingSourceButton)
        Me.TabPage5.Controls.Add(Me.EdadBindingSourceTextBox)
        Me.TabPage5.Controls.Add(Me.NombreBindingSourceTextBox)
        Me.TabPage5.Controls.Add(Me.IdBindingSourceTextBox)
        Me.TabPage5.Controls.Add(Me.Label7)
        Me.TabPage5.Controls.Add(Me.Label8)
        Me.TabPage5.Controls.Add(Me.Label9)
        Me.TabPage5.Controls.Add(Me.CargarBindingSourceButton)
        Me.TabPage5.Controls.Add(Me.FiltrarButton)
        Me.TabPage5.Controls.Add(Me.Label6)
        Me.TabPage5.Controls.Add(Me.NombreBinding)
        Me.TabPage5.Controls.Add(Me.DataGridView2)
        Me.TabPage5.Controls.Add(Me.GroupBox1)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(544, 274)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "BindingSource"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'ActualizarBindingSourceButton
        '
        Me.ActualizarBindingSourceButton.Location = New System.Drawing.Point(147, 220)
        Me.ActualizarBindingSourceButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ActualizarBindingSourceButton.Name = "ActualizarBindingSourceButton"
        Me.ActualizarBindingSourceButton.Size = New System.Drawing.Size(128, 28)
        Me.ActualizarBindingSourceButton.TabIndex = 15
        Me.ActualizarBindingSourceButton.Text = "Actualizar BBDD"
        Me.ActualizarBindingSourceButton.UseVisualStyleBackColor = True
        '
        'EdadBindingSourceTextBox
        '
        Me.EdadBindingSourceTextBox.Location = New System.Drawing.Point(359, 184)
        Me.EdadBindingSourceTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EdadBindingSourceTextBox.Name = "EdadBindingSourceTextBox"
        Me.EdadBindingSourceTextBox.Size = New System.Drawing.Size(132, 22)
        Me.EdadBindingSourceTextBox.TabIndex = 12
        '
        'NombreBindingSourceTextBox
        '
        Me.NombreBindingSourceTextBox.Location = New System.Drawing.Point(359, 126)
        Me.NombreBindingSourceTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NombreBindingSourceTextBox.Name = "NombreBindingSourceTextBox"
        Me.NombreBindingSourceTextBox.Size = New System.Drawing.Size(132, 22)
        Me.NombreBindingSourceTextBox.TabIndex = 10
        '
        'IdBindingSourceTextBox
        '
        Me.IdBindingSourceTextBox.Location = New System.Drawing.Point(359, 68)
        Me.IdBindingSourceTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IdBindingSourceTextBox.Name = "IdBindingSourceTextBox"
        Me.IdBindingSourceTextBox.Size = New System.Drawing.Size(132, 22)
        Me.IdBindingSourceTextBox.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(356, 163)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Edad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(356, 106)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Nombre"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(356, 47)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 17)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Identificador"
        '
        'CargarBindingSourceButton
        '
        Me.CargarBindingSourceButton.Location = New System.Drawing.Point(12, 220)
        Me.CargarBindingSourceButton.Name = "CargarBindingSourceButton"
        Me.CargarBindingSourceButton.Size = New System.Drawing.Size(118, 28)
        Me.CargarBindingSourceButton.TabIndex = 6
        Me.CargarBindingSourceButton.Text = "Cargar datos"
        Me.CargarBindingSourceButton.UseVisualStyleBackColor = True
        '
        'FiltrarButton
        '
        Me.FiltrarButton.Location = New System.Drawing.Point(211, 22)
        Me.FiltrarButton.Margin = New System.Windows.Forms.Padding(4)
        Me.FiltrarButton.Name = "FiltrarButton"
        Me.FiltrarButton.Size = New System.Drawing.Size(100, 28)
        Me.FiltrarButton.TabIndex = 4
        Me.FiltrarButton.Text = "Filtrar"
        Me.FiltrarButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 26)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Nombre"
        '
        'NombreBinding
        '
        Me.NombreBinding.Location = New System.Drawing.Point(71, 25)
        Me.NombreBinding.Margin = New System.Windows.Forms.Padding(4)
        Me.NombreBinding.Name = "NombreBinding"
        Me.NombreBinding.Size = New System.Drawing.Size(132, 22)
        Me.NombreBinding.TabIndex = 2
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(11, 55)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(300, 158)
        Me.DataGridView2.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(336, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 222)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Editar registro"
        '
        'DataGridViewTabPage
        '
        Me.DataGridViewTabPage.Controls.Add(Me.CargarDataGridViewButton)
        Me.DataGridViewTabPage.Controls.Add(Me.ActualizarDataGridViewButton)
        Me.DataGridViewTabPage.Controls.Add(Me.DataGridView1)
        Me.DataGridViewTabPage.Location = New System.Drawing.Point(4, 25)
        Me.DataGridViewTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewTabPage.Name = "DataGridViewTabPage"
        Me.DataGridViewTabPage.Size = New System.Drawing.Size(544, 268)
        Me.DataGridViewTabPage.TabIndex = 3
        Me.DataGridViewTabPage.Text = "DataGridView"
        Me.DataGridViewTabPage.UseVisualStyleBackColor = True
        '
        'CargarDataGridViewButton
        '
        Me.CargarDataGridViewButton.Location = New System.Drawing.Point(11, 222)
        Me.CargarDataGridViewButton.Name = "CargarDataGridViewButton"
        Me.CargarDataGridViewButton.Size = New System.Drawing.Size(118, 28)
        Me.CargarDataGridViewButton.TabIndex = 2
        Me.CargarDataGridViewButton.Text = "Cargar datos"
        Me.CargarDataGridViewButton.UseVisualStyleBackColor = True
        '
        'ActualizarDataGridViewButton
        '
        Me.ActualizarDataGridViewButton.Location = New System.Drawing.Point(150, 222)
        Me.ActualizarDataGridViewButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ActualizarDataGridViewButton.Name = "ActualizarDataGridViewButton"
        Me.ActualizarDataGridViewButton.Size = New System.Drawing.Size(128, 28)
        Me.ActualizarDataGridViewButton.TabIndex = 1
        Me.ActualizarDataGridViewButton.Text = "Actualizar BBDD"
        Me.ActualizarDataGridViewButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(11, 10)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(425, 199)
        Me.DataGridView1.TabIndex = 0
        '
        'ComboBoxTabPage
        '
        Me.ComboBoxTabPage.Controls.Add(Me.CargarComboBoxButton)
        Me.ComboBoxTabPage.Controls.Add(Me.IdComboBoxTextBox)
        Me.ComboBoxTabPage.Controls.Add(Me.NombreComboBox)
        Me.ComboBoxTabPage.Controls.Add(Me.Label4)
        Me.ComboBoxTabPage.Controls.Add(Me.Label5)
        Me.ComboBoxTabPage.Location = New System.Drawing.Point(4, 25)
        Me.ComboBoxTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxTabPage.Name = "ComboBoxTabPage"
        Me.ComboBoxTabPage.Size = New System.Drawing.Size(544, 268)
        Me.ComboBoxTabPage.TabIndex = 2
        Me.ComboBoxTabPage.Text = "ComboBox"
        Me.ComboBoxTabPage.UseVisualStyleBackColor = True
        '
        'CargarComboBoxButton
        '
        Me.CargarComboBoxButton.Location = New System.Drawing.Point(43, 158)
        Me.CargarComboBoxButton.Name = "CargarComboBoxButton"
        Me.CargarComboBoxButton.Size = New System.Drawing.Size(115, 25)
        Me.CargarComboBoxButton.TabIndex = 7
        Me.CargarComboBoxButton.Text = "Cargar datos"
        Me.CargarComboBoxButton.UseVisualStyleBackColor = True
        '
        'IdComboBoxTextBox
        '
        Me.IdComboBoxTextBox.Enabled = False
        Me.IdComboBoxTextBox.Location = New System.Drawing.Point(133, 89)
        Me.IdComboBoxTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IdComboBoxTextBox.Name = "IdComboBoxTextBox"
        Me.IdComboBoxTextBox.Size = New System.Drawing.Size(160, 22)
        Me.IdComboBoxTextBox.TabIndex = 6
        '
        'NombreComboBox
        '
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(133, 32)
        Me.NombreComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(160, 24)
        Me.NombreComboBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 35)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 92)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Identificador"
        '
        'ListBoxTabPage
        '
        Me.ListBoxTabPage.Controls.Add(Me.CargarListBoxButton)
        Me.ListBoxTabPage.Controls.Add(Me.Clientes)
        Me.ListBoxTabPage.Controls.Add(Me.ClientesListBox)
        Me.ListBoxTabPage.Location = New System.Drawing.Point(4, 25)
        Me.ListBoxTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBoxTabPage.Name = "ListBoxTabPage"
        Me.ListBoxTabPage.Padding = New System.Windows.Forms.Padding(4)
        Me.ListBoxTabPage.Size = New System.Drawing.Size(544, 268)
        Me.ListBoxTabPage.TabIndex = 1
        Me.ListBoxTabPage.Text = "ListBox"
        Me.ListBoxTabPage.UseVisualStyleBackColor = True
        '
        'CargarListBoxButton
        '
        Me.CargarListBoxButton.Location = New System.Drawing.Point(25, 224)
        Me.CargarListBoxButton.Name = "CargarListBoxButton"
        Me.CargarListBoxButton.Size = New System.Drawing.Size(123, 25)
        Me.CargarListBoxButton.TabIndex = 2
        Me.CargarListBoxButton.Text = "Cargar datos"
        Me.CargarListBoxButton.UseVisualStyleBackColor = True
        '
        'Clientes
        '
        Me.Clientes.AutoSize = True
        Me.Clientes.Location = New System.Drawing.Point(22, 18)
        Me.Clientes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Clientes.Name = "Clientes"
        Me.Clientes.Size = New System.Drawing.Size(58, 17)
        Me.Clientes.TabIndex = 1
        Me.Clientes.Text = "Clientes"
        '
        'ClientesListBox
        '
        Me.ClientesListBox.FormattingEnabled = True
        Me.ClientesListBox.ItemHeight = 16
        Me.ClientesListBox.Location = New System.Drawing.Point(25, 39)
        Me.ClientesListBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ClientesListBox.Name = "ClientesListBox"
        Me.ClientesListBox.Size = New System.Drawing.Size(169, 164)
        Me.ClientesListBox.TabIndex = 0
        '
        'InsertarTabPage
        '
        Me.InsertarTabPage.Controls.Add(Me.AceptarInsertarButton)
        Me.InsertarTabPage.Controls.Add(Me.EdadTextBox)
        Me.InsertarTabPage.Controls.Add(Me.NombreTextBox)
        Me.InsertarTabPage.Controls.Add(Me.IdTextBox)
        Me.InsertarTabPage.Controls.Add(Me.Label3)
        Me.InsertarTabPage.Controls.Add(Me.Label2)
        Me.InsertarTabPage.Controls.Add(Me.Label1)
        Me.InsertarTabPage.Location = New System.Drawing.Point(4, 25)
        Me.InsertarTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.InsertarTabPage.Name = "InsertarTabPage"
        Me.InsertarTabPage.Padding = New System.Windows.Forms.Padding(4)
        Me.InsertarTabPage.Size = New System.Drawing.Size(544, 268)
        Me.InsertarTabPage.TabIndex = 0
        Me.InsertarTabPage.Text = "Insertar"
        Me.InsertarTabPage.UseVisualStyleBackColor = True
        '
        'AceptarInsertarButton
        '
        Me.AceptarInsertarButton.Location = New System.Drawing.Point(28, 192)
        Me.AceptarInsertarButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AceptarInsertarButton.Name = "AceptarInsertarButton"
        Me.AceptarInsertarButton.Size = New System.Drawing.Size(100, 28)
        Me.AceptarInsertarButton.TabIndex = 6
        Me.AceptarInsertarButton.Text = "Aceptar"
        Me.AceptarInsertarButton.UseVisualStyleBackColor = True
        '
        'EdadTextBox
        '
        Me.EdadTextBox.Location = New System.Drawing.Point(119, 134)
        Me.EdadTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EdadTextBox.Name = "EdadTextBox"
        Me.EdadTextBox.Size = New System.Drawing.Size(132, 22)
        Me.EdadTextBox.TabIndex = 5
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Location = New System.Drawing.Point(119, 84)
        Me.NombreTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(132, 22)
        Me.NombreTextBox.TabIndex = 3
        '
        'IdTextBox
        '
        Me.IdTextBox.Location = New System.Drawing.Point(119, 38)
        Me.IdTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(132, 22)
        Me.IdTextBox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 137)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Edad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 87)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Identificador"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.InsertarTabPage)
        Me.TabControl1.Controls.Add(Me.ListBoxTabPage)
        Me.TabControl1.Controls.Add(Me.ComboBoxTabPage)
        Me.TabControl1.Controls.Add(Me.DataGridViewTabPage)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(552, 303)
        Me.TabControl1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 303)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "ADO"
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataGridViewTabPage.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ComboBoxTabPage.ResumeLayout(False)
        Me.ComboBoxTabPage.PerformLayout()
        Me.ListBoxTabPage.ResumeLayout(False)
        Me.ListBoxTabPage.PerformLayout()
        Me.InsertarTabPage.ResumeLayout(False)
        Me.InsertarTabPage.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents EdadBindingSourceTextBox As TextBox
    Friend WithEvents NombreBindingSourceTextBox As TextBox
    Friend WithEvents IdBindingSourceTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CargarBindingSourceButton As Button
    Friend WithEvents FiltrarButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents NombreBinding As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewTabPage As TabPage
    Friend WithEvents CargarDataGridViewButton As Button
    Friend WithEvents ActualizarDataGridViewButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBoxTabPage As TabPage
    Friend WithEvents CargarComboBoxButton As Button
    Friend WithEvents IdComboBoxTextBox As TextBox
    Friend WithEvents NombreComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBoxTabPage As TabPage
    Friend WithEvents CargarListBoxButton As Button
    Friend WithEvents Clientes As Label
    Friend WithEvents ClientesListBox As ListBox
    Friend WithEvents InsertarTabPage As TabPage
    Friend WithEvents AceptarInsertarButton As Button
    Friend WithEvents EdadTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ActualizarBindingSourceButton As Button
End Class
