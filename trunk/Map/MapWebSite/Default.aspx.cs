using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    Negocio.ManipularMapa manipularMapa;

    protected void Page_Load(object sender, EventArgs e)
    {
        manipularMapa = new Negocio.ManipularMapa(
            Convert.ToInt32(Image1.Width.Value), Convert.ToInt32(Image1.Height.Value));
        Image1.ImageUrl = manipularMapa.GerarMapa();
    }

    protected void btnZoomMais_Click(object sender, EventArgs e) {
        Image1.ImageUrl = manipularMapa.GerarMapaMaisZoom();
    }
    protected void btnZoomMenos_Click(object sender, EventArgs e) {
        Image1.ImageUrl = manipularMapa.GerarMapaMenosZoom();
    }
    protected void Button2_Click(object sender, EventArgs e) {
        Image1.ImageUrl = manipularMapa.MoverEsquerda();
    }
    protected void Button3_Click(object sender, EventArgs e) {
        Image1.ImageUrl = manipularMapa.MoverParaCima();
    }
    protected void Button4_Click(object sender, EventArgs e) {
        Image1.ImageUrl = manipularMapa.MoverParaBaixo();
    }
    protected void Button5_Click(object sender, EventArgs e) {
        Image1.ImageUrl = manipularMapa.MoverDireita();
    }
}
