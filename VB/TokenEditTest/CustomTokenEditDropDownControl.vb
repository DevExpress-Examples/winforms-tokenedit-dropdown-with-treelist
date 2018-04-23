Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes

Namespace TokenEditTest
    Partial Public Class CustomTokenEditDropDownControl
        Inherits CustomTokenEditDropDownControlBase

        Public Sub New()
            InitializeComponent()
        End Sub
        Public Overrides Sub Initialize(ByVal ownerEdit As TokenEdit, ByVal ownerPopup As TokenEditPopupForm)
            MyBase.Initialize(ownerEdit, ownerPopup)
        End Sub
        Public Overrides Sub InitializeAppearances(ByVal appearanceDropDown As AppearanceObject)
            MyBase.InitializeAppearances(appearanceDropDown)
        End Sub
        Public Overrides Sub SetDataSource(ByVal dataSource As Object)
            TreeList.DataSource = New TreeListDataSet(DirectCast(dataSource, IEnumerable(Of TokenEditToken)))
            TreeList.ExpandAll()
        End Sub
        Private currentFilter As String = String.Empty
        Public Overrides Sub SetFilter(ByVal filter As String, ByVal columnName As String)
            Me.currentFilter = filter
            TreeList.FilterNodes()
            If TreeList.VisibleNodesCount = 0 Then
                OwnerEdit.ClosePopup(PopupCloseMode.Cancel)
            End If
        End Sub
        Public Overrides Sub OnShowingPopupForm()
            MyBase.OnShowingPopupForm()
        End Sub
        Public Overrides Function GetItemCount() As Integer
            Return TreeList.VisibleNodesCount
        End Function
        Public Overrides Function CalcFormWidth() As Integer
            Return 500
        End Function
        Public Overrides Function CalcFormHeight(ByVal itemCount As Integer) As Integer
            Return 200
        End Function
        Public Overrides Function GetResultValue() As Object
            Dim leaf As TreeListLeaf = TryCast(GetSelectedDataItem(), TreeListLeaf)
            Return If(leaf IsNot Nothing, leaf.Token, Nothing)
        End Function
        Public Overrides ReadOnly Property IsTokenSelected() As Boolean
            Get
                Return Me.selNode IsNot Nothing
            End Get
        End Property
        Public Overrides Sub ResetSelection()
            Me.selNode = Nothing
            TreeList.FocusedNode = Nothing
        End Sub
        Public Overrides Sub ProcessKeyDown(ByVal e As KeyEventArgs)
            MyBase.ProcessKeyDown(e)
            TreeList.DoKeyDown(e)
        End Sub
        Public Overrides Sub OnEditorMouseWheel(ByVal e As MouseEventArgs)
            Dim [step] As Integer = If(SystemInformation.MouseWheelScrollLines > 0, SystemInformation.MouseWheelScrollLines, 1)
            If e.Delta > 0 Then
                [step] *= -1
            End If
            TreeList.TopVisibleNodeIndex += [step]
        End Sub
        Public Overrides Sub ResetResultValue()
            Me.selNode = Nothing
        End Sub
        #Region "TreeList Handlers"
        Private selNode As TreeListNode = Nothing
        Private Sub OnTreeListFocusedNodeChanged(ByVal sender As Object, ByVal e As FocusedNodeChangedEventArgs) Handles treeList_Renamed.FocusedNodeChanged
            Me.selNode = e.Node
        End Sub
        Private Sub OnTreeListDoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles treeList_Renamed.DoubleClick
            Dim hi As TreeListHitInfo = TreeList.CalcHitInfo(TreeList.PointToClient(Control.MousePosition))
            If hi.HitInfoType = HitInfoType.Cell AndAlso TypeOf GetSelectedDataItem() Is TreeListLeaf Then
                OwnerEdit.ClosePopup(PopupCloseMode.Normal)
            End If
        End Sub
        Private Function GetSelectedDataItem() As Object
            Return If(Me.selNode IsNot Nothing, TreeList.GetDataRecordByNode(Me.selNode), Nothing)
        End Function
        Private Sub OnTreeListVirtualTreeGetChildNodes(ByVal sender As Object, ByVal e As VirtualTreeGetChildNodesInfo) Handles treeList_Renamed.VirtualTreeGetChildNodes
            If TypeOf e.Node Is TreeListDataSet Then
                e.Children = CType(e.Node, TreeListDataSet).GetChildren()
            End If
            If TypeOf e.Node Is TreeListRootObj Then
                e.Children = New Object() {CType(e.Node, TreeListRootObj).Leaf}
            End If
        End Sub
        Private Sub OnTreeListVirtualTreeGetCellValue(ByVal sender As Object, ByVal e As VirtualTreeGetCellValueInfo) Handles treeList_Renamed.VirtualTreeGetCellValue
            If TypeOf e.Node Is TreeListRootObj OrElse TypeOf e.Node Is TreeListLeaf Then
                e.CellData = e.Node.ToString()
            End If
        End Sub
        Private Sub OnTreeListFilterNode(ByVal sender As Object, ByVal e As FilterNodeEventArgs) Handles treeList_Renamed.FilterNode
            Dim obj As TreeListRootObj = TryCast(TreeList.GetDataRecordByNode(e.Node), TreeListRootObj)
            If obj IsNot Nothing AndAlso (Not obj.Leaf.IsMatch(currentFilter)) Then
                e.Node.Visible = False
                e.Handled = True
            End If
        End Sub
        #End Region
        Protected ReadOnly Property TreeList() As CustomTreeList
            Get
                Return treeList_Renamed
            End Get
        End Property
    End Class

    Public Class CustomTreeList
        Inherits TreeList

        Public Sub New()
            BorderStyle = BorderStyles.NoBorder
            SetStyle(ControlStyles.UserMouse, False)
        End Sub
        Public Sub DoKeyDown(ByVal e As KeyEventArgs)
            OnKeyDown(e)
        End Sub
    End Class
End Namespace
