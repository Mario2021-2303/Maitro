import { SexoColumns, SexoRow, SexoService } from '@/ServerTypes/Escuela';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { SexoDialog } from './SexoDialog';

@Decorators.registerClass('GestorMaestro.Escuela.SexoGrid')
export class SexoGrid extends EntityGrid<SexoRow> {
    protected getColumnsKey() { return SexoColumns.columnsKey; }
    protected getDialogType() { return SexoDialog; }
    protected getRowDefinition() { return SexoRow; }
    protected getService() { return SexoService.baseUrl; }
}