using FormEntryDesign;
using ScheduleEntryForms.Configurations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleEntryForms.ViewModels
{
    public class WaterSourceHeatPumpViewModel : ViewModelBase, IWaterSourceHeatPumpViewModel
    {
        public IEquipmentConfiguration WaterSourceHeatPumpConfiguration;
        public IElectricalInformationPanelViewModel ElectricalPanelViewModel;


        public WaterSourceHeatPumpViewModel(IEquipmentConfiguration waterSourceHeatPumpConfiguration, 
                                            IElectricalInformationPanelViewModel electricalPanelViewModel
            )
        {
            WaterSourceHeatPumpConfiguration = waterSourceHeatPumpConfiguration;
            ElectricalPanelViewModel = electricalPanelViewModel;
        }

        public async Task LoadAsync()
        {

        }
    }
}
