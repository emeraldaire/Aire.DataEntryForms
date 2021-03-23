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
        public IEquipmentConfiguration _equipmentConfiguration;
        public IElectricalPanelViewModelFactory _electricalPanelViewModelFactory;
        
        public ElectricalPanelViewModel ElectricalPanelViewModel { get; set; }


        public ERVViewModel(IEquipmentConfiguration equipmentConfiguration, 
                            IElectricalPanelViewModelFactory electricalPanelViewModelFactory)
        {
            _equipmentConfiguration = equipmentConfiguration;
            _electricalPanelViewModelFactory = electricalPanelViewModelFactory;

            ElectricalPanelViewModel = _electricalPanelViewModelFactory.CreateViewModel(_equipmentConfiguration.ElectricalConfiguration);
        }

        public async Task LoadAsync()
        {

        }
    }
}
