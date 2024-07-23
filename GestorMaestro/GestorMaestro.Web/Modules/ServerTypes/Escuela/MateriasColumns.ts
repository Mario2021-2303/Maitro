import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { MateriasRow } from "./MateriasRow";

export interface MateriasColumns {
    IdMateria: Column<MateriasRow>;
    NombreMateria: Column<MateriasRow>;
}

export class MateriasColumns extends ColumnsBase<MateriasRow> {
    static readonly columnsKey = 'Escuela.Materias';
    static readonly Fields = fieldsProxy<MateriasColumns>();
}