using MyRequest = GestorMaestro.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<GestorMaestro.Administration.UserRow>;
using MyRow = GestorMaestro.Administration.UserRow;

namespace GestorMaestro.Administration;
public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
{
    public UserListHandler(IRequestContext context)
         : base(context)
    {
    }
}