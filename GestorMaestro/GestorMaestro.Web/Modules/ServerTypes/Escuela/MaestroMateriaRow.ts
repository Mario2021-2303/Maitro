import { fieldsProxy } from "@serenity-is/corelib";

export interface MaestroMateriaRow {
    IdMaestro?: number;
    IdMateria?: number;
    IdMaestroNombre?: string;
    IdMateriaNombreMateria?: string;
}

export abstract class MaestroMateriaRow {
    static readonly idProperty = 'IdMaestro';
    static readonly localTextPrefix = 'Escuela.MaestroMateria';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<MaestroMateriaRow>();
}