Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace TokenEditTest
    Partial Public Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            InitTokenEdit()
        End Sub
        Private Sub InitTokenEdit()
            tokenEdit.Properties.CustomDropDownControl = New CustomTokenEditDropDownControl()
            For i As Integer = 0 To 19
                Dim desc As String = String.Format("Token{0}", i.ToString())
                tokenEdit.Properties.Tokens.Add(New TokenEditToken(desc, desc))
            Next i
        End Sub
        Private Sub OnTokenEditValidateToken(ByVal sender As Object, ByVal e As TokenEditValidateTokenEventArgs) Handles tokenEdit.ValidateToken
            e.Value = e.Description
            e.IsValid = True
        End Sub
        Private Sub OnTokenEditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tokenEdit.EditValueChanged
            Text = DirectCast(sender, TokenEdit).EditValue.ToString()
        End Sub
    End Class
End Namespace
