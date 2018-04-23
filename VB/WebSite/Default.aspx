<%@ Page Language="vb" AutoEventWireup="true"  CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.XtraReports.v8.3.Web, Version=8.3.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.XtraReports.Web" TagPrefix="dxxr" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v8.3, Version=8.3.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dxwgv" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v8.3, Version=8.3.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>

<%@ Register Assembly="DevExpress.Web.v8.3, Version=8.3.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dxpc" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Untitled Page</title>

	<script language="javascript" type="text/javascript">

		function UpdateProductsInfo(categoryId) {
			var element = document.getElementById('cat' + categoryId);

			gridView.PerformCallback(categoryId);
			popupControl.ShowAtElement(element);
		}

	</script>

</head>
<body>
	<form id="form1" runat="server">
	<div>
		<dxpc:ASPxPopupControl ID="ASPxPopupControl1" runat="server" 
			ClientInstanceName="popupControl" Width="407px" BackColor="#FFFF99" 
			FooterText="" HeaderText="Products list" PopupHorizontalOffset="20" 
			PopupVerticalOffset="20">
			<ClientSideEvents Init="function(s, e) {
	//popupControl.ShowAtPos(100, 100);
}" />
			<ContentCollection>
				<dxpc:PopupControlContentControl runat="server">
					<dxwgv:ASPxGridView ID="ASPxGridView1" runat="server" 
						AutoGenerateColumns="False" Width="413px" 
						ClientInstanceName="gridView" 
						OnCustomCallback="ASPxGridView1_CustomCallback">
						<Columns>
							<dxwgv:GridViewDataTextColumn FieldName="ProductName" VisibleIndex="0">
							</dxwgv:GridViewDataTextColumn>
							<dxwgv:GridViewDataTextColumn FieldName="UnitPrice" VisibleIndex="1">
							</dxwgv:GridViewDataTextColumn>
							<dxwgv:GridViewDataTextColumn FieldName="UnitsInStock" VisibleIndex="2">
							</dxwgv:GridViewDataTextColumn>
						</Columns>
						<SettingsPager PageSize="5">
						</SettingsPager>
					</dxwgv:ASPxGridView>
				</dxpc:PopupControlContentControl>
			</ContentCollection>

			<HeaderStyle BackColor="#FF99CC" Font-Bold="True" Font-Size="Large" />
			<Border BorderColor="#6666FF" />

		</dxpc:ASPxPopupControl>
		<br />
		<dxxr:ReportToolbar ID="ReportToolbar1" runat="server" 
			ShowDefaultButtons="False" ReportViewer="<%#ReportViewer1%>">
			<Items>
				<dxxr:ReportToolbarButton ItemKind="Search" 
					ToolTip="Display the search window" />
				<dxxr:ReportToolbarSeparator />
				<dxxr:ReportToolbarButton ItemKind="PrintReport" ToolTip="Print the report" />
				<dxxr:ReportToolbarButton ItemKind="PrintPage" 
					ToolTip="Print the current page" />
				<dxxr:ReportToolbarSeparator />
				<dxxr:ReportToolbarButton Enabled="False" ItemKind="FirstPage" 
					ToolTip="First Page" />
				<dxxr:ReportToolbarButton Enabled="False" ItemKind="PreviousPage" 
					ToolTip="Previous Page" />
				<dxxr:ReportToolbarLabel Text="Page" />
				<dxxr:ReportToolbarComboBox ItemKind="PageNumber" Width="65px">
				</dxxr:ReportToolbarComboBox>
				<dxxr:ReportToolbarLabel Text="of" />
				<dxxr:ReportToolbarTextBox IsReadOnly="True" ItemKind="PageCount" />
				<dxxr:ReportToolbarButton ItemKind="NextPage" ToolTip="Next Page" />
				<dxxr:ReportToolbarButton ItemKind="LastPage" ToolTip="Last Page" />
				<dxxr:ReportToolbarSeparator />
				<dxxr:ReportToolbarButton ItemKind="SaveToDisk" 
					ToolTip="Export a report and save it to the disk" />
				<dxxr:ReportToolbarButton ItemKind="SaveToWindow" 
					ToolTip="Export a report and show it in a new window" />
				<dxxr:ReportToolbarComboBox ItemKind="SaveFormat" Width="70px">
					<Elements>
						<dxxr:ListElement Text="Pdf" Value="pdf" />
						<dxxr:ListElement Text="Xls" Value="xls" />
						<dxxr:ListElement Text="Rtf" Value="rtf" />
						<dxxr:ListElement Text="Mht" Value="mht" />
						<dxxr:ListElement Text="Text" Value="txt" />
						<dxxr:ListElement Text="Csv" Value="csv" />
						<dxxr:ListElement Text="Image" Value="png" />
					</Elements>
				</dxxr:ReportToolbarComboBox>
			</Items>
			<Styles>
				<LabelStyle>
				<Margins MarginLeft="3px" MarginRight="3px" />
				</LabelStyle>
			</Styles>
		</dxxr:ReportToolbar>
		<br />
		<dxxr:ReportViewer ID="ReportViewer1" runat="server" 
			onunload="ReportViewer1_Unload">
		</dxxr:ReportViewer>
	</div>
	</form>
</body>
</html>
