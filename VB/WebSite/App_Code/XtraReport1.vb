Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports System.Collections.Generic
Imports DevExpress.XtraPrinting.HtmlExport.Controls

''' <summary>
''' Summary description for XtraReport1
''' </summary>
Public Class XtraReport1
	Inherits DevExpress.XtraReports.UI.XtraReport
	Private Detail As DevExpress.XtraReports.UI.DetailBand
	Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
	Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
	Private xrLabel1 As XRLabel
	Private WithEvents xrLabel2 As XRLabel
	Private xrLabel3 As XRLabel
	Private xrPictureBox1 As XRPictureBox
	Private nwndDataSet1 As nwndDataSet
	Private categoriesTableAdapter1 As nwndDataSetTableAdapters.CategoriesTableAdapter
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	Public Sub New()
		InitializeComponent()
		'
		' TODO: Add constructor logic here
		'

	End Sub

	''' <summary> 
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resourceFileName As String = "XtraReport1.resx"
		Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
		Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
		Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
		Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
		Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
		Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
		Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
		Me.nwndDataSet1 = New nwndDataSet()
		Me.categoriesTableAdapter1 = New nwndDataSetTableAdapters.CategoriesTableAdapter()
		CType(Me.nwndDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' Detail
		' 
		Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox1, Me.xrLabel3, Me.xrLabel2})
		Me.Detail.Height = 142
		Me.Detail.Name = "Detail"
		Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' xrPictureBox1
		' 
		Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture", "")})
		Me.xrPictureBox1.Location = New System.Drawing.Point(500, 42)
		Me.xrPictureBox1.Name = "xrPictureBox1"
		Me.xrPictureBox1.Size = New System.Drawing.Size(133, 67)
		' 
		' xrLabel3
		' 
		Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description", "")})
		Me.xrLabel3.Location = New System.Drawing.Point(25, 83)
		Me.xrLabel3.Name = "xrLabel3"
		Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel3.Size = New System.Drawing.Size(308, 25)
		Me.xrLabel3.Text = "xrLabel3"
		' 
		' xrLabel2
		' 
		Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName", ""), New DevExpress.XtraReports.UI.XRBinding("Tag", Nothing, "Categories.CategoryID", "")})
		Me.xrLabel2.Location = New System.Drawing.Point(25, 42)
		Me.xrLabel2.Name = "xrLabel2"
		Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel2.Size = New System.Drawing.Size(133, 25)
		Me.xrLabel2.Text = "xrLabel2"
'		Me.xrLabel2.HtmlItemCreated += New DevExpress.XtraReports.UI.HtmlEventHandler(Me.xrLabel2_HtmlItemCreated);
		' 
		' PageHeader
		' 
		Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
		Me.PageHeader.Height = 42
		Me.PageHeader.Name = "PageHeader"
		Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' xrLabel1
		' 
		Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 25F)
		Me.xrLabel1.Location = New System.Drawing.Point(250, 0)
		Me.xrLabel1.Name = "xrLabel1"
		Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel1.Size = New System.Drawing.Size(158, 42)
		Me.xrLabel1.StylePriority.UseFont = False
		Me.xrLabel1.Text = "Categories"
		' 
		' PageFooter
		' 
		Me.PageFooter.Height = 30
		Me.PageFooter.Name = "PageFooter"
		Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' nwndDataSet1
		' 
		Me.nwndDataSet1.DataSetName = "nwndDataSet"
		Me.nwndDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		' 
		' categoriesTableAdapter1
		' 
		Me.categoriesTableAdapter1.ClearBeforeFill = True
		' 
		' XtraReport1
		' 
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter})
		Me.DataAdapter = Me.categoriesTableAdapter1
		Me.DataMember = "Categories"
		Me.DataSource = Me.nwndDataSet1
		Me.Version = "8.2"
		CType(Me.nwndDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	#End Region

	Private Sub xrLabel2_HtmlItemCreated(ByVal sender As Object, ByVal e As HtmlEventArgs) Handles xrLabel2.HtmlItemCreated
		Dim link As New DXHtmlLiteralControl()
		link.Text = String.Format("<a id='cat{0}' href='javascript:DXReportViewerWindow.UpdateProductsInfo({0})' style='color:blue; cursor:pointer;'>{1}</a>", e.Brick.Value.ToString(), e.Brick.TextValue)
		e.ContentCell.Controls.Clear()
		e.ContentCell.Controls.Add(link)
	End Sub
End Class
