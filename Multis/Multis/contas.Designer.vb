<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class contas
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
        Me.components = New System.ComponentModel.Container()
        Me.UtilizadorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MultisDataSet = New Multis.MultisDataSet()
        Me.UtilizadorTableAdapter = New Multis.MultisDataSetTableAdapters.UtilizadorTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.UtilizadorBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.UtilizadorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MultisDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtilizadorBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UtilizadorBindingSource
        '
        Me.UtilizadorBindingSource.DataMember = "Utilizador"
        Me.UtilizadorBindingSource.DataSource = Me.MultisDataSet
        '
        'MultisDataSet
        '
        Me.MultisDataSet.DataSetName = "MultisDataSet"
        Me.MultisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UtilizadorTableAdapter
        '
        Me.UtilizadorTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1088, 869)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Sair"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 59)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(1160, 804)
        Me.WebBrowser1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.UtilizadorBindingSource1
        Me.ComboBox1.DisplayMember = "Utilizador"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(57, 6)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'UtilizadorBindingSource1
        '
        Me.UtilizadorBindingSource1.DataMember = "Utilizador"
        Me.UtilizadorBindingSource1.DataSource = Me.MultisDataSet
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(184, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Login"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtilizadorBindingSource1, "Pass", True))
        Me.TextBox1.Location = New System.Drawing.Point(57, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 6
        '
        'contas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1175, 904)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "contas"
        Me.Text = "contas"
        CType(Me.UtilizadorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MultisDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtilizadorBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MultisDataSet As MultisDataSet
    Friend WithEvents UtilizadorBindingSource As BindingSource
    Friend WithEvents UtilizadorTableAdapter As MultisDataSetTableAdapters.UtilizadorTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents UtilizadorBindingSource1 As BindingSource
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
