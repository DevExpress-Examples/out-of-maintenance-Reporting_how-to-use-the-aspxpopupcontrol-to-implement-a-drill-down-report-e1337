using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using DevExpress.XtraPrinting.HtmlExport.Controls;

/// <summary>
/// Summary description for XtraReport1
/// </summary>
public class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
    private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
    private XRLabel xrLabel1;
    private XRLabel xrLabel2;
    private XRLabel xrLabel3;
    private XRPictureBox xrPictureBox1;
    private nwndDataSet nwndDataSet1;
    private nwndDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter1;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public XtraReport1() {
        InitializeComponent();
        //
        // TODO: Add constructor logic here
        //

    }

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        string resourceFileName = "XtraReport1.resx";
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
        this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
        this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
        this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
        this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
        this.nwndDataSet1 = new nwndDataSet();
        this.categoriesTableAdapter1 = new nwndDataSetTableAdapters.CategoriesTableAdapter();
        ((System.ComponentModel.ISupportInitialize)(this.nwndDataSet1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.xrLabel3,
            this.xrLabel2});
        this.Detail.Height = 142;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrPictureBox1
        // 
        this.xrPictureBox1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Image", null, "Categories.Picture", "")});
        this.xrPictureBox1.Location = new System.Drawing.Point(500, 42);
        this.xrPictureBox1.Name = "xrPictureBox1";
        this.xrPictureBox1.Size = new System.Drawing.Size(133, 67);
        // 
        // xrLabel3
        // 
        this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Categories.Description", "")});
        this.xrLabel3.Location = new System.Drawing.Point(25, 83);
        this.xrLabel3.Name = "xrLabel3";
        this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel3.Size = new System.Drawing.Size(308, 25);
        this.xrLabel3.Text = "xrLabel3";
        // 
        // xrLabel2
        // 
        this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Categories.CategoryName", ""),
            new DevExpress.XtraReports.UI.XRBinding("Tag", null, "Categories.CategoryID", "")});
        this.xrLabel2.Location = new System.Drawing.Point(25, 42);
        this.xrLabel2.Name = "xrLabel2";
        this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel2.Size = new System.Drawing.Size(133, 25);
        this.xrLabel2.Text = "xrLabel2";
        this.xrLabel2.HtmlItemCreated += new DevExpress.XtraReports.UI.HtmlEventHandler(this.xrLabel2_HtmlItemCreated);
        // 
        // PageHeader
        // 
        this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
        this.PageHeader.Height = 42;
        this.PageHeader.Name = "PageHeader";
        this.PageHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrLabel1
        // 
        this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 25F);
        this.xrLabel1.Location = new System.Drawing.Point(250, 0);
        this.xrLabel1.Name = "xrLabel1";
        this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel1.Size = new System.Drawing.Size(158, 42);
        this.xrLabel1.StylePriority.UseFont = false;
        this.xrLabel1.Text = "Categories";
        // 
        // PageFooter
        // 
        this.PageFooter.Height = 30;
        this.PageFooter.Name = "PageFooter";
        this.PageFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // nwndDataSet1
        // 
        this.nwndDataSet1.DataSetName = "nwndDataSet";
        this.nwndDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
        // 
        // categoriesTableAdapter1
        // 
        this.categoriesTableAdapter1.ClearBeforeFill = true;
        // 
        // XtraReport1
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageHeader,
            this.PageFooter});
        this.DataAdapter = this.categoriesTableAdapter1;
        this.DataMember = "Categories";
        this.DataSource = this.nwndDataSet1;
        this.Version = "8.2";
        ((System.ComponentModel.ISupportInitialize)(this.nwndDataSet1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private void xrLabel2_HtmlItemCreated(object sender, HtmlEventArgs e) {
        DXHtmlLiteralControl link = new DXHtmlLiteralControl();
        link.Text = string.Format("<a id='cat{0}' href='javascript:DXReportViewerWindow.UpdateProductsInfo({0})' style='color:blue; cursor:pointer;'>{1}</a>", e.Brick.Value.ToString(), e.Brick.TextValue);
        e.ContentCell.Controls.Clear();
        e.ContentCell.Controls.Add(link);
    }
}
