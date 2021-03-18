using FormEntryDesign;
using ScheduleEntryForms.Configurations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleEntryForms.ViewModels
{
    public class ERVViewModel : ViewModelBase, IERVViewModel
    {
        public IEquipmentConfiguration EquipmentConfiguration;
        public IElectricalInformationPanelViewModel ElectricalPanelViewModel;

        public ERVViewModel(IEquipmentConfiguration equipmentConfiguration, IElectricalInformationPanelViewModel electricalPanelViewModel)
        {
            EquipmentConfiguration = equipmentConfiguration;
            ElectricalPanelViewModel = electricalPanelViewModel;
        }

        public async Task LoadAsync()
        {

        }
    }
}
