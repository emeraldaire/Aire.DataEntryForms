using ScheduleEntryForms.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleEntryForms.Configurations
{
    public class VFDConfiguration
    {
        public ElectricalConfiguration ElectricalConfiguration { get; set; }

        public VFDConfiguration()
        {
            SetElectricalConfiguration();
        }

        private void SetElectricalConfiguration()
        {
            ElectricalConfiguration = new ElectricalConfiguration()
            {
                VoltPhase = true,
                RatedAmps = true
            };
        }

       
    }
}
