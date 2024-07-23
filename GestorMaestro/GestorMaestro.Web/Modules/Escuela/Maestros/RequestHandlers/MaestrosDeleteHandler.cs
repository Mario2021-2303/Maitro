using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GestorMaestro.Escuela.MaestrosRow;

namespace GestorMaestro.Escuela;

public interface IMaestrosDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class MaestrosDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IMaestrosDeleteHandler
{
    public MaestrosDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}