using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GestorMaestro.Escuela.MateriasRow>;
using MyRow = GestorMaestro.Escuela.MateriasRow;

namespace GestorMaestro.Escuela;

public interface IMateriasListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class MateriasListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMateriasListHandler
{
    public MateriasListHandler(IRequestContext context)
            : base(context)
    {
    }
}