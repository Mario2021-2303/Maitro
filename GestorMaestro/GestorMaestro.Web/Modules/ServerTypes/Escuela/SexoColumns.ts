import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { SexoRow } from "./SexoRow";

export interface SexoColumns {
    IdSexo: Column<SexoRow>;
    Descripcion: Column<SexoRow>;
}

export class SexoColumns extends ColumnsBase<SexoRow> {
    static readonly columnsKey = 'Escuela.Sexo';
    static readonly Fields = fieldsProxy<SexoColumns>();
}