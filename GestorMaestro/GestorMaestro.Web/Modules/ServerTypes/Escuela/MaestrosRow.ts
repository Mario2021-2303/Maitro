import { fieldsProxy } from "@serenity-is/corelib";

export interface MaestrosRow {
    IdMaestro?: number;
    Nombre?: string;
    Apellido?: string;
    IdSexo?: number;
    Cedula?: string;
    MateriaList?: number[];
    IdSexoDescripcion?: string;
}

export abstract class MaestrosRow {
    static readonly idProperty = 'IdMaestro';
    static readonly nameProperty = 'Nombre';
    static readonly localTextPrefix = 'Escuela.Maestros';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<MaestrosRow>();
}