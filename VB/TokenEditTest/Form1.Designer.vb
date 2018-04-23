Namespace TokenEditTest
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.tokenEdit = New DevExpress.XtraEditors.TokenEdit()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            DirectCast(Me.tokenEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tokenEdit
            ' 
            Me.tokenEdit.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.tokenEdit.Location = New System.Drawing.Point(12, 50)
            Me.tokenEdit.Name = "tokenEdit"
            Me.tokenEdit.Properties.EditMode = DevExpress.XtraEditors.TokenEditMode.Manual
            Me.tokenEdit.Properties.Separators.AddRange(New String() { ",", " "})
            Me.tokenEdit.Properties.ShowSeparators = False
            Me.tokenEdit.Properties.ValidationRules = (CType((DevExpress.XtraEditors.TokenEditValidationRules.ValidateOnLostFocus Or DevExpress.XtraEditors.TokenEditValidationRules.ValidateOnSeparatorInput), DevExpress.XtraEditors.TokenEditValidationRules))
            Me.tokenEdit.Size = New System.Drawing.Size(453, 20)
            Me.tokenEdit.TabIndex = 0
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Blue"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(482, 109)
            Me.Controls.Add(Me.tokenEdit)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.tokenEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents tokenEdit As DevExpress.XtraEditors.TokenEdit
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    End Class
End Namespace

