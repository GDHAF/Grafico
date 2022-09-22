<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Grafico.aspx.cs" Inherits="prjGrafico.Grafico" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Chart ID="Chart" runat="server">

                <series>

                    <asp:Series Name="Series1"></asp:Series>

                </series>

                <chartareas>

                    <asp:ChartArea Name="ChartArea1" Area3DStyle-Enable3D="true"></asp:ChartArea>

                </chartareas>

            </asp:Chart>

        </div>
    </form>
</body>
</html>
