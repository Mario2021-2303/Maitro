import { MateriasForm, MateriasRow, MateriasService } from '@/ServerTypes/Escuela';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GestorMaestro.Escuela.MateriasDialog')
export class MateriasDialog extends EntityDialog<MateriasRow, any> {
    protected getFormKey() { return MateriasForm.formKey; }
    protected getRowDefinition() { return MateriasRow; }
    protected getService() { return MateriasService.baseUrl; }

    protected form = new MateriasForm(this.idPrefix);
}