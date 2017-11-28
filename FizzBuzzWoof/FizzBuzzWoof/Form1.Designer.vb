<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FizzBuzzWoofForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FizzBuzzWoofForm))
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.btnFizz = New System.Windows.Forms.Button()
        Me.lblClickWhenReady = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.ForeColor = System.Drawing.Color.Linen
        Me.lblNumber.Location = New System.Drawing.Point(83, 63)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(131, 19)
        Me.lblNumber.TabIndex = 0
        Me.lblNumber.Text = "Enter a number:"
        '
        'txtNumber
        '
        Me.txtNumber.BackColor = System.Drawing.Color.Linen
        Me.txtNumber.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtNumber.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtNumber.Location = New System.Drawing.Point(262, 62)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(172, 20)
        Me.txtNumber.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 367)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(527, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'btnFizz
        '
        Me.btnFizz.Image = CType(resources.GetObject("btnFizz.Image"), System.Drawing.Image)
        Me.btnFizz.Location = New System.Drawing.Point(50, 162)
        Me.btnFizz.Name = "btnFizz"
        Me.btnFizz.Size = New System.Drawing.Size(96, 44)
        Me.btnFizz.TabIndex = 3
        Me.btnFizz.Text = "Fizz, Buzz, Woof...?"
        Me.btnFizz.UseVisualStyleBackColor = True
        '
        'lblClickWhenReady
        '
        Me.lblClickWhenReady.AutoSize = True
        Me.lblClickWhenReady.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClickWhenReady.ForeColor = System.Drawing.Color.Linen
        Me.lblClickWhenReady.Location = New System.Drawing.Point(31, 129)
        Me.lblClickWhenReady.Name = "lblClickWhenReady"
        Me.lblClickWhenReady.Size = New System.Drawing.Size(140, 19)
        Me.lblClickWhenReady.TabIndex = 4
        Me.lblClickWhenReady.Text = "Click when ready."
        '
        'btnClear
        '
        Me.btnClear.AllowDrop = True
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.Location = New System.Drawing.Point(372, 162)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 44)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.Location = New System.Drawing.Point(13, 240)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(502, 108)
        Me.lstResults.TabIndex = 7
        '
        'FizzBuzzWoofForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.ClientSize = New System.Drawing.Size(527, 389)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblClickWhenReady)
        Me.Controls.Add(Me.btnFizz)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblNumber)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "FizzBuzzWoofForm"
        Me.Text = "Fizz, Buzz, Woof..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents btnFizz As System.Windows.Forms.Button
    Friend WithEvents lblClickWhenReady As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lstResults As System.Windows.Forms.ListBox

End Class
