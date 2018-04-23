using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.XtraReports.Web;
using DevExpress.Web.ASPxGridView;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ReportViewer1.Report = GetReport();
        ASPxGridView1.DataSource = Session["gridDataSource"];
    }

    protected XtraReport1 GetReport()
    {
        if ((XtraReport1)Session["report"] == null)
            Session["report"] = new XtraReport1();

        return (XtraReport1)Session["report"];
    }
    
    protected void ReportViewer1_Unload(object sender, EventArgs e)
    {
        (sender as ReportViewer).Report = null;
    }

    protected void ASPxGridView1_CustomCallback(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewCustomCallbackEventArgs e)
    {
        nwndDataSet ds = new nwndDataSet();
        nwndDataSetTableAdapters.ProductsTableAdapter pta = new nwndDataSetTableAdapters.ProductsTableAdapter();
        ASPxGridView gridView = sender as ASPxGridView;

        pta.FillBy(ds.Products, Convert.ToInt32(e.Parameters));
        gridView.DataSource = ds.Products;
        Session["gridDataSource"] = gridView.DataSource;

        gridView.DataBind();

        gridView.PageIndex = 0;
    }
}
