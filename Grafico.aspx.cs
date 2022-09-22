using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace prjGrafico
{
    public partial class Grafico : System.Web.UI.Page
    {
        DataSet ds;
        ClasseConexao cs;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cs = new ClasseConexao();
                ds = new DataSet();
                ds = cs.executa_sql("select * from graficos");

                Chart.Series["Series1"].ChartType = SeriesChartType.Pie;
                Chart.Palette = ChartColorPalette.Fire;
                Chart.Titles.Add("Renda Mensal");
                Chart.DataSource = ds.Tables[0].DefaultView;
                Chart.Series[0].XValueMember = "mes";
                Chart.Series[0].YValueMembers = "valor";

            }

        }
    }
}