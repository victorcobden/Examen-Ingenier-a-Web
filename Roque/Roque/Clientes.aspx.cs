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
    public partial class Clientes : System.Web.UI.Page
    {
        conexion cn = new conexion();
        RoqueConsulta datos = new RoqueConsulta();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)//SI NO ES EL PRIMER RETORNO
            {
                //nombre DataTextField- De que campo se va a obtener su valor
                //id DataValueFiel
                cmbTitulos.DataSource = datos.extraerdatos("Listar_titulos");
                cmbTitulos.DataTextField = "Titulo_Contacto";
                cmbTitulos.DataValueField = "Titulo_Contacto";//el campo del cual se desea obtener el valor que se haya seleccionado
                cmbTitulos.DataBind();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insertar_cliente";
            cmd.Parameters.Add("@CustomerID", SqlDbType.NChar).Value = txtAddress.Text;
            cmd.Parameters.Add("@CompanyName", SqlDbType.NVarChar).Value = txtCompanyName.Text;
            cmd.Parameters.Add("@ContactName", SqlDbType.NVarChar).Value =txtContactName.Text ;
            cmd.Parameters.Add("@ContactTitle", SqlDbType.NVarChar).Value = cmbTitulos.Text;
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value =txtAddress.Text ;
            cmd.Parameters.Add("@City", SqlDbType.NVarChar).Value =txtCity.Text ;
            cmd.Parameters.Add("@Region", SqlDbType.NVarChar).Value = txtRegion.Text;
            cmd.Parameters.Add("@PostalCode", SqlDbType.NVarChar).Value =txtPostalCode.Text ;
            cmd.Parameters.Add("@Country", SqlDbType.NVarChar).Value =txtCountry.Text ;
            cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = txtPhone.Text;
            cmd.Parameters.Add("@Fax", SqlDbType.NVarChar).Value = txtFax.Text;
            cn.conectar();
            cmd.ExecuteNonQuery();
            cn.desconectar();
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            grdClientes.DataSource = datos.extraerdatos("listar_Clientes");
            grdClientes.DataBind();
        }
    }
}