using ScheduleEntryForms.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleEntryForms.ViewModels
{
    public class ElectricalPanelViewModelFactory : IElectricalPanelViewModelFactory
    {
        public ElectricalPanelViewModelFactory()
        {

        }

        public ElectricalPanelViewModel CreateViewModel(IElectricalConfiguration electricalConfiguration)
        {
            return new ElectricalPanelViewModel(electricalConfiguration);
        }

    }
}
