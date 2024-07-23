using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GestorMaestro.Escuela.SexoRow;

namespace GestorMaestro.Escuela;

public interface ISexoDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class SexoDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISexoDeleteHandler
{
    public SexoDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}