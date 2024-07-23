using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GestorMaestro.Escuela.Pages;

[PageAuthorize(typeof(SexoRow))]
public class SexoPage : Controller
{
    [Route("Escuela/Sexo")]
    public ActionResult Index()
    {
        return this.GridPage("@/Escuela/Sexo/SexoPage",
            SexoRow.Fields.PageTitle());
    }
}