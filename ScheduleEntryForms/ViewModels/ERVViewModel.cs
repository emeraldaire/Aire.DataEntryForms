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
        public IHeatingCoolingPanelViewModelFactory _heatingCoolingPanelViewModelFactory;
        public ElectricalPanelViewModel ElectricalPanelViewModel { get; set; }
        public HeatingCoolingPanelViewModel HeatingCoolingPanelViewModel { get; set; }


        public ERVViewModel(IEquipmentConfiguration equipmentConfiguration, 
                            IElectricalPanelViewModelFactory electricalPanelViewModelFactory,
                            IHeatingCoolingPanelViewModelFactory heatingCoolingPanelViewModelFactory
                            )
        {
            _equipmentConfiguration = equipmentConfiguration;
            _electricalPanelViewModelFactory = electricalPanelViewModelFactory;
            _heatingCoolingPanelViewModelFactory = heatingCoolingPanelViewModelFactory;

            ElectricalPanelViewModel = _electricalPanelViewModelFactory.CreateViewModel(_equipmentConfiguration.ElectricalConfiguration);
            HeatingCoolingPanelViewModel = _heatingCoolingPanelViewModelFactory.CreateViewModel(_equipmentConfiguration.HeatingCoolingConfiguration);
        }

        public async Task LoadAsync()
        {

        }
    }
}
