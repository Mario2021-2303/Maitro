import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { MaestrosRow } from "./MaestrosRow";

export namespace MaestrosService {
    export const baseUrl = 'Escuela/Maestros';

    export declare function Create(request: SaveRequest<MaestrosRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<MaestrosRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<MaestrosRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<MaestrosRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<MaestrosRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<MaestrosRow>>;

    export const Methods = {
        Create: "Escuela/Maestros/Create",
        Update: "Escuela/Maestros/Update",
        Delete: "Escuela/Maestros/Delete",
        Retrieve: "Escuela/Maestros/Retrieve",
        List: "Escuela/Maestros/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>MaestrosService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}