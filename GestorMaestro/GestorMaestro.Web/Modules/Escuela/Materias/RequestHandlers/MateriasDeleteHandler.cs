using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GestorMaestro.Escuela.MateriasRow;

namespace GestorMaestro.Escuela;

public interface IMateriasDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class MateriasDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IMateriasDeleteHandler
{
    public MateriasDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}