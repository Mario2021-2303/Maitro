import { SexoForm, SexoRow, SexoService } from '@/ServerTypes/Escuela';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GestorMaestro.Escuela.SexoDialog')
export class SexoDialog extends EntityDialog<SexoRow, any> {
    protected getFormKey() { return SexoForm.formKey; }
    protected getRowDefinition() { return SexoRow; }
    protected getService() { return SexoService.baseUrl; }

    protected form = new SexoForm(this.idPrefix);
}