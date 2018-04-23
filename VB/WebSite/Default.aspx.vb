Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.XtraReports.Web
Imports DevExpress.Web.ASPxGridView

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		ReportViewer1.Report = GetReport()
		ASPxGridView1.DataSource = Session("gridDataSource")
	End Sub

	Protected Function GetReport() As XtraReport1
		If CType(Session("report"), XtraReport1) Is Nothing Then
			Session("report") = New XtraReport1()
		End If

		Return CType(Session("report"), XtraReport1)
	End Function

	Protected Sub ReportViewer1_Unload(ByVal sender As Object, ByVal e As EventArgs)
		TryCast(sender, ReportViewer).Report = Nothing
	End Sub

	Protected Sub ASPxGridView1_CustomCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomCallbackEventArgs)
		Dim ds As New nwndDataSet()
		Dim pta As New nwndDataSetTableAdapters.ProductsTableAdapter()
		Dim gridView As ASPxGridView = TryCast(sender, ASPxGridView)

		pta.FillBy(ds.Products, Convert.ToInt32(e.Parameters))
		gridView.DataSource = ds.Products
		Session("gridDataSource") = gridView.DataSource

		gridView.DataBind()

		gridView.PageIndex = 0
	End Sub
End Class
