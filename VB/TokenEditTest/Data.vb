Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraEditors

Namespace TokenEditTest
    Public Class TreeListDataSet
        Private rootNodes As IList(Of TreeListRootObj)
        Public Sub New(ByVal tokens As IEnumerable(Of TokenEditToken))
            Me.rootNodes = CreateRootCol(tokens)
        End Sub
        Private Function CreateRootCol(ByVal tokens As IEnumerable(Of TokenEditToken)) As IList(Of TreeListRootObj)
            Dim res As New List(Of TreeListRootObj)()
            For Each token As TokenEditToken In tokens
                res.Add(New TreeListRootObj(token))
            Next token
            Return res
        End Function
        Public ReadOnly Property Count() As Integer
            Get
                Return Children.Count
            End Get
        End Property
        Public Function GetChildren() As TreeListRootObj()
            Return Me.rootNodes.ToArray()
        End Function
        Public ReadOnly Property Children() As IList(Of TreeListRootObj)
            Get
                Return rootNodes
            End Get
        End Property
    End Class

    Public Class TreeListRootObj

        Private leaf_Renamed As TreeListLeaf
        Public Sub New(ByVal token As TokenEditToken)
            Me.leaf_Renamed = New TreeListLeaf(token)
        End Sub
        Public Overrides Function ToString() As String
            Return "Root Node"
        End Function
        Public ReadOnly Property Leaf() As TreeListLeaf
            Get
                Return leaf_Renamed
            End Get
        End Property
    End Class

    Public Class TreeListLeaf

        Private token_Renamed As TokenEditToken
        Public Sub New(ByVal token As TokenEditToken)
            Me.token_Renamed = token
        End Sub
        Public Function IsMatch(ByVal filter As String) As Boolean
            Dim filterCore As String = filter.Trim()
            If String.IsNullOrEmpty(filterCore) Then
                Return True
            End If
            Return token_Renamed.ToString().StartsWith(filterCore, StringComparison.OrdinalIgnoreCase)
        End Function
        Public Overrides Function ToString() As String
            Return token_Renamed.ToString()
        End Function
        Public ReadOnly Property Token() As TokenEditToken
            Get
                Return token_Renamed
            End Get
        End Property
    End Class
End Namespace