using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Roque
{
    public partial class Productos : System.Web.UI.Page
    {
        conexion cn = new conexion();
        RoqueConsulta datos = new RoqueConsulta();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)//SI NO ES EL PRIMER RETORNO
            {
                //nombre DataTextField- De que campo se va a obtener su valor
                //id DataValueFiel
                cmbCategorias.DataSource = datos.extraerdatos("Listar_Categorias");
                cmbCategorias.DataTextField = "CategoryName";
                cmbCategorias.DataValueField = "CategoryID";//el campo del cual se desea obtener el valor que se haya seleccionado
                cmbCategorias.DataBind();
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            double precioini = double.Parse(txtRangoInicial.Text);
            double preciofin = double.Parse(txtRangoFinal.Text);
            grdProductos.DataSource = datos.extraerdatos("Listar_Categoriasxprecio","@IdCatergoria", cmbCategorias.SelectedValue, "@RangoInicial", precioini, "@RangoFinal", preciofin);
            grdProductos.DataBind();

        }

        protected void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            grdProductos.DataSource = datos.extraerdatos("Listar_por_categoria", "@id_categoria", cmbCategorias.SelectedValue);
            grdProductos.DataBind();
        }
    }
}