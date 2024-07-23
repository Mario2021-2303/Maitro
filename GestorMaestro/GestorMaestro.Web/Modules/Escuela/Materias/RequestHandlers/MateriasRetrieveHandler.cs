using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GestorMaestro.Escuela.MateriasRow>;
using MyRow = GestorMaestro.Escuela.MateriasRow;

namespace GestorMaestro.Escuela;

public interface IMateriasRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class MateriasRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMateriasRetrieveHandler
{
    public MateriasRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}