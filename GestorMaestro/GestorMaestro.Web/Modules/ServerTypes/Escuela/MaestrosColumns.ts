import { MateriaListFormatter } from "@/Escuela/Maestros/MateriaListFormatter";
import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { MaestrosRow } from "./MaestrosRow";

export interface MaestrosColumns {
    IdMaestro: Column<MaestrosRow>;
    Nombre: Column<MaestrosRow>;
    Apellido: Column<MaestrosRow>;
    IdSexoDescripcion: Column<MaestrosRow>;
    Cedula: Column<MaestrosRow>;
    MateriaList: Column<MaestrosRow>;
}

export class MaestrosColumns extends ColumnsBase<MaestrosRow> {
    static readonly columnsKey = 'Escuela.Maestros';
    static readonly Fields = fieldsProxy<MaestrosColumns>();
}

[MateriaListFormatter]; // referenced types