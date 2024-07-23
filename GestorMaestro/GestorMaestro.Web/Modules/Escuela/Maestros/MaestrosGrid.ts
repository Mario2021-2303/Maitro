import { MaestrosColumns, MaestrosRow, MaestrosService } from '@/ServerTypes/Escuela';
import { Decorators, EntityGrid, QuickSearchField } from '@serenity-is/corelib';
import { MaestrosDialog } from './MaestrosDialog';

@Decorators.registerClass('GestorMaestro.Escuela.MaestrosGrid')
export class MaestrosGrid extends EntityGrid<MaestrosRow> {
    protected getColumnsKey() { return MaestrosColumns.columnsKey; }
    protected getDialogType() { return MaestrosDialog; }
    protected getRowDefinition() { return MaestrosRow; }
    protected getService() { return MaestrosService.baseUrl; }

    protected getQuickSearchFields(): QuickSearchField[] {
        return [
            { name: "", title: "All" },
            { name: "Nombre", title: "Nombre" },
            { name: "Cedula", title: "Cedula" }
        ];
    }


    constructor(container: JQuery) {
        super(container);
    }


    protected getButtons() {
        let buttons = super.getButtons();

        // Encuentra el botón "add" y cambia su texto
        buttons.forEach(button => {
            if (button.cssClass === 'add-button') {
                button.title = 'Añadir Maestro';
            }
        });

        return buttons;
    }


}