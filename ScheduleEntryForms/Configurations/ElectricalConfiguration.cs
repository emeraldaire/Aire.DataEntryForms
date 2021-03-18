using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleEntryForms.Configurations
{
    public class ElectricalConfiguration : IElectricalConfiguration
    {

        public bool VoltPhase { get; set; } = false;
        public bool HpWatt { get; set; } = false;
        public bool KiloWatts { get; set; } = false;
        public bool AuxKiloWatts { get; set; } = false;
        public bool FanHP { get; set; } = false;
        public bool MaximumCurrentAmps { get; set; } = false;
        public bool MaximumOverCurrentProtection { get; set; } = false;
        public bool FullLoadAmps { get; set; } = false;
        public bool RatedAmps { get; set; } = false;
    }
}
