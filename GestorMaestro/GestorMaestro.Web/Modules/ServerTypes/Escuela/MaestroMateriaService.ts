import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { MaestroMateriaRow } from "./MaestroMateriaRow";

export namespace MaestroMateriaService {
    export const baseUrl = 'Escuela/MaestroMateria';

    export declare function Create(request: SaveRequest<MaestroMateriaRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<MaestroMateriaRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<MaestroMateriaRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<MaestroMateriaRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<MaestroMateriaRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<MaestroMateriaRow>>;

    export const Methods = {
        Create: "Escuela/MaestroMateria/Create",
        Update: "Escuela/MaestroMateria/Update",
        Delete: "Escuela/MaestroMateria/Delete",
        Retrieve: "Escuela/MaestroMateria/Retrieve",
        List: "Escuela/MaestroMateria/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>MaestroMateriaService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}