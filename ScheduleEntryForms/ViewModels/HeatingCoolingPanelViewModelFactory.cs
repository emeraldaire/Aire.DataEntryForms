using ScheduleEntryForms.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleEntryForms.ViewModels
{
    public class HeatingCoolingPanelViewModelFactory : IHeatingCoolingPanelViewModelFactory
    {
        public HeatingCoolingPanelViewModelFactory()
        {

        }


        public HeatingCoolingPanelViewModel CreateViewModel(IHeatingCoolingConfiguration heatingCoolingConfiguration)
        {
            return new HeatingCoolingPanelViewModel(heatingCoolingConfiguration);
        }
    }
}
