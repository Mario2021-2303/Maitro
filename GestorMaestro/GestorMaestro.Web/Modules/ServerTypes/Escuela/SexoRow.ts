import { fieldsProxy } from "@serenity-is/corelib";

export interface SexoRow {
    IdSexo?: number;
    Descripcion?: string;
}

export abstract class SexoRow {
    static readonly idProperty = 'IdSexo';
    static readonly nameProperty = 'Descripcion';
    static readonly localTextPrefix = 'Escuela.Sexo';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<SexoRow>();
}