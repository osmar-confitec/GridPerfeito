using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSite1;

public partial class _Default : Page
{

    public _Default()
    {
        PopularClientes();
        PageSize = 10;
        PageIndex = 1;

    }

    private List<Clientes> Clientes { get; set; }

    private int PageIndex { get; set; }

    private int PageSize { get; set; }

    private void LoadAll()
    {
        //GridClientes.DataSource = new List<Clientes>();
        //GridClientes.DataSource = Clientes.Skip((PageIndex - 1) * PageSize)
        //           .Take(PageSize).ToList();
        GridClientes.DataSource = Clientes.Skip((PageIndex - 1) * PageSize)
                  .Take(PageSize).ToList();

    }

    private void BindGrid()
    {
        GridClientes.PageIndex = PageIndex;
        GridClientes.VirtualItemCount = Clientes.Count();

        GridClientes.DataBind();
    }

    private void PopularClientes()
    {
        Clientes = new List<Clientes>();
        var cont = 1000;
        do
        {

            Clientes.Add(new Clientes { Cpf = "21371885893", Nome = "chuchu" });
            cont--;
        } while (cont != 0);
    }

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            LoadAll();
            BindGrid();
        }

    }

    protected void GridClientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        PageIndex = e.NewPageIndex;
        LoadAll();

        BindGrid();
    }
}