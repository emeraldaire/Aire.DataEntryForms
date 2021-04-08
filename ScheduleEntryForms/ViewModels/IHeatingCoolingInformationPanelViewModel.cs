using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ScheduleEntryForms.ViewModels
{
    public interface IHeatingCoolingInformationPanelViewModel
    {
        string HeatingAFUE {get; set;}
        string HeatingNumberOfStages {get; set; }
        string HeatingInputMBH {get; set; }
        string HeatingOutputMBH {get; set; }
        string HeatingMBH {get; set; }
        string HeatingHSPF {get; set; }
        string HeatingAuxKiloWatts {get; set; }

        string CoolingTons {get; set; }
        string CoolingMBH {get; set; }
        string CoolingSEER_EER {get; set; }
        string CoolingSEER {get; set; }

        ICommand TestDataCommand { get; set; }


    }
}
