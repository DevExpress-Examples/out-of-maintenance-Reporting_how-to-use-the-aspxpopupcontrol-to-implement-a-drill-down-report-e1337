<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1337)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [XtraReport1.cs](./CS/WebSite/App_Code/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/WebSite/App_Code/XtraReport1.vb))
* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to use the ASPxPopupControl to implement a drill-down report
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e1337)**
<!-- run online end -->


<p>This example illustrates how to implement a drill-down master-detail report using an ASPxPopupControl with an ASPxGridView inside it.</p><p>Some key points include:</p><p>- The XRLabel.HtmlItemCreated event is handled to make a hyperlink html element with the href='javascript:...' attribute via the e.ContentCell.InnerHtml parameter. This link will invoke a special script function to update detail data.<br />
- The XRLabel.Tag property is bound to the ID field of the master data table. This allows obtaining this ID in the XRLabel.HtmlItemCreated event handler via the e.Brick.Value parameter.<br />
- The ASPxGridView update process is inedited from the client side via the ASPxClientGridView.PerformCallback() method.<br />
- The ASPxPopupControl.ShowAtElement() method is called to show the ASPxPopupControl over the specified html element.</p>

<br/>


