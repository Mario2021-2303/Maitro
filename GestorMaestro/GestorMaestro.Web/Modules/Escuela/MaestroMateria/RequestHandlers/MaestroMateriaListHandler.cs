using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GestorMaestro.Escuela.MaestroMateriaRow>;
using MyRow = GestorMaestro.Escuela.MaestroMateriaRow;

namespace GestorMaestro.Escuela;

public interface IMaestroMateriaListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class MaestroMateriaListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMaestroMateriaListHandler
{
    public MaestroMateriaListHandler(IRequestContext context)
            : base(context)
    {
    }
}