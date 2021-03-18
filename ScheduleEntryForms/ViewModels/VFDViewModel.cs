using FormEntryDesign;
using ScheduleEntryForms.Configurations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleEntryForms.ViewModels
{
    public class VFDViewModel : ViewModelBase, IVFDViewModel
    {
        public IEquipmentConfiguration VFDConfiguration;
        public IElectricalInformationPanelViewModel ElectricalPanelViewModel;

        public VFDViewModel(IEquipmentConfiguration vFDConfiguration, 
                            IElectricalInformationPanelViewModel electricalPanelViewModel)
        {
            VFDConfiguration = vFDConfiguration;
            ElectricalPanelViewModel = electricalPanelViewModel;
        }

        public async Task LoadAsync()
        {

        }

    }
}
