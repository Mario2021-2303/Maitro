using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GestorMaestro.Escuela.Pages;

[PageAuthorize(typeof(MaestrosRow))]
public class MaestrosPage : Controller
{
    [Route("Escuela/Maestros")]
    public ActionResult Index()
    {
        return this.GridPage("@/Escuela/Maestros/MaestrosPage",
            MaestrosRow.Fields.PageTitle());
    }
}