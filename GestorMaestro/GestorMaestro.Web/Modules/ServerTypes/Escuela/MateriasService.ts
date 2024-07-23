import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { MateriasRow } from "./MateriasRow";

export namespace MateriasService {
    export const baseUrl = 'Escuela/Materias';

    export declare function Create(request: SaveRequest<MateriasRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<MateriasRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<MateriasRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<MateriasRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<MateriasRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<MateriasRow>>;

    export const Methods = {
        Create: "Escuela/Materias/Create",
        Update: "Escuela/Materias/Update",
        Delete: "Escuela/Materias/Delete",
        Retrieve: "Escuela/Materias/Retrieve",
        List: "Escuela/Materias/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>MateriasService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}