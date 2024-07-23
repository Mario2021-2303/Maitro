using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GestorMaestro.Escuela.MaestroMateriaRow;

namespace GestorMaestro.Escuela;

public interface IMaestroMateriaDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class MaestroMateriaDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IMaestroMateriaDeleteHandler
{
    public MaestroMateriaDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}