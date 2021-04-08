using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleEntryForms.Configurations
{
    public class HeatingCoolingConfiguration : IHeatingCoolingConfiguration
    {


        public bool HeatingAFUE { get; set; } = false;
        public bool HeatingNumberOfStages { get; set; } = false;
        public bool HeatingInputMBH { get; set; } = false;
        public bool HeatingOutputMBH { get; set; } = false;
        public bool HeatingMBH { get; set; } = false;
        public bool HeatingHSPF { get; set; } = false;
        public bool HeatingAuxKiloWatts { get; set; } = false;

        public bool CoolingTons { get; set; } = false;
        public bool CoolingMBH { get; set; } = false;
        public bool CoolingSEER_EER { get; set; } = false;
        public bool CoolingSEER { get; set; } = false;
    }
}
