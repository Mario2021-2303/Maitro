import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { SexoRow } from "./SexoRow";

export namespace SexoService {
    export const baseUrl = 'Escuela/Sexo';

    export declare function Create(request: SaveRequest<SexoRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<SexoRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<SexoRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<SexoRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<SexoRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<SexoRow>>;

    export const Methods = {
        Create: "Escuela/Sexo/Create",
        Update: "Escuela/Sexo/Update",
        Delete: "Escuela/Sexo/Delete",
        Retrieve: "Escuela/Sexo/Retrieve",
        List: "Escuela/Sexo/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>SexoService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}