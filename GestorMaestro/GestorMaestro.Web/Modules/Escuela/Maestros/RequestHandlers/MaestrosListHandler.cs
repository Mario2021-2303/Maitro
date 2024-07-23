using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GestorMaestro.Escuela.MaestrosRow>;
using MyRow = GestorMaestro.Escuela.MaestrosRow;

namespace GestorMaestro.Escuela;

public interface IMaestrosListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class MaestrosListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMaestrosListHandler
{
    public MaestrosListHandler(IRequestContext context)
            : base(context)
    {
    }
}