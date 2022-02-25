<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LastButton = New System.Windows.Forms.Button
        Me.NextButton = New System.Windows.Forms.Button
        Me.PreviousButton = New System.Windows.Forms.Button
        Me.FirstButton = New System.Windows.Forms.Button
        Me.Phone = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Address = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CustomerName = New System.Windows.Forms.TextBox
        Me.ExitButton = New System.Windows.Forms.Button
        Me.CustomerID = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'LastButton
        '
        Me.LastButton.FlatAppearance.BorderSize = 0
        Me.LastButton.Location = New System.Drawing.Point(333, 217)
        Me.LastButton.Name = "LastButton"
        Me.LastButton.Size = New System.Drawing.Size(100, 100)
        Me.LastButton.TabIndex = 128
        '
        'NextButton
        '
        Me.NextButton.FlatAppearance.BorderSize = 0
        Me.NextButton.Location = New System.Drawing.Point(227, 217)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(100, 100)
        Me.NextButton.TabIndex = 134
        '
        'PreviousButton
        '
        Me.PreviousButton.FlatAppearance.BorderSize = 0
        Me.PreviousButton.Location = New System.Drawing.Point(121, 217)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(100, 100)
        Me.PreviousButton.TabIndex = 127
        '
        'FirstButton
        '
        Me.FirstButton.FlatAppearance.BorderSize = 0
        Me.FirstButton.Location = New System.Drawing.Point(13, 217)
        Me.FirstButton.Name = "FirstButton"
        Me.FirstButton.Size = New System.Drawing.Size(100, 100)
        Me.FirstButton.TabIndex = 126
        '
        'Phone
        '
        Me.Phone.AcceptsReturn = True
        Me.Phone.BackColor = System.Drawing.SystemColors.Window
        Me.Phone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Phone.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Phone.Location = New System.Drawing.Point(126, 149)
        Me.Phone.MaxLength = 12
        Me.Phone.Name = "Phone"
        Me.Phone.Size = New System.Drawing.Size(134, 20)
        Me.Phone.TabIndex = 123
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(10, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 24)
        Me.Label4.TabIndex = 133
        Me.Label4.Text = "Phone"
        '
        'Address
        '
        Me.Address.AcceptsReturn = True
        Me.Address.BackColor = System.Drawing.SystemColors.Window
        Me.Address.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Address.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Address.Location = New System.Drawing.Point(127, 115)
        Me.Address.MaxLength = 50
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(263, 20)
        Me.Address.TabIndex = 122
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(12, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 24)
        Me.Label3.TabIndex = 132
        Me.Label3.Text = "Address"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(12, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 24)
        Me.Label2.TabIndex = 131
        Me.Label2.Text = "Customer Name"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(12, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "Customer ID"
        '
        'CustomerName
        '
        Me.CustomerName.AcceptsReturn = True
        Me.CustomerName.BackColor = System.Drawing.SystemColors.Window
        Me.CustomerName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CustomerName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CustomerName.Location = New System.Drawing.Point(127, 82)
        Me.CustomerName.MaxLength = 50
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.Size = New System.Drawing.Size(263, 20)
        Me.CustomerName.TabIndex = 121
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.Control
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ExitButton.Location = New System.Drawing.Point(469, 218)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ExitButton.Size = New System.Drawing.Size(100, 100)
        Me.ExitButton.TabIndex = 129
        Me.ExitButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'CustomerID
        '
        Me.CustomerID.AcceptsReturn = True
        Me.CustomerID.BackColor = System.Drawing.SystemColors.Window
        Me.CustomerID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CustomerID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CustomerID.Location = New System.Drawing.Point(128, 48)
        Me.CustomerID.MaxLength = 4
        Me.CustomerID.Name = "CustomerID"
        Me.CustomerID.Size = New System.Drawing.Size(84, 20)
        Me.CustomerID.TabIndex = 120
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 341)
        Me.Controls.Add(Me.LastButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PreviousButton)
        Me.Controls.Add(Me.FirstButton)
        Me.Controls.Add(Me.Phone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CustomerName)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.CustomerID)
        Me.Name = "Form1"
        Me.Text = "DC Image Button V. 3.5 Tutorial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LastButton As System.Windows.Forms.Button
    Friend WithEvents NextButton As System.Windows.Forms.Button
    Friend WithEvents PreviousButton As System.Windows.Forms.Button
    Friend WithEvents FirstButton As System.Windows.Forms.Button
    Public WithEvents Phone As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Address As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents CustomerName As System.Windows.Forms.TextBox
    Public WithEvents ExitButton As System.Windows.Forms.Button
    Public WithEvents CustomerID As System.Windows.Forms.TextBox

End Class
