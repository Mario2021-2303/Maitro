import { MateriasColumns, MateriasRow, MateriasService } from '@/ServerTypes/Escuela';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { MateriasDialog } from './MateriasDialog';

@Decorators.registerClass('GestorMaestro.Escuela.MateriasGrid')
export class MateriasGrid extends EntityGrid<MateriasRow> {
    protected getColumnsKey() { return MateriasColumns.columnsKey; }
    protected getDialogType() { return MateriasDialog; }
    protected getRowDefinition() { return MateriasRow; }
    protected getService() { return MateriasService.baseUrl; }
}