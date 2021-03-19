using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleEntryForms.Configurations.EquipmentConfigurations
{
    class WaterSourceHeatPumpConfiguration : IEquipmentConfiguration
    {
        public IElectricalConfiguration ElectricalConfiguration { get; set; }

        public WaterSourceHeatPumpConfiguration()
        {
            SetElectricalConfiguration();
        }

        private void SetElectricalConfiguration()
        {
            ElectricalConfiguration = new ElectricalConfiguration()
            {
                VoltPhase = true,
                AuxKiloWatts = true,
                MaximumCurrentAmps = true,
                MaximumOverCurrentProtection = true
            };
        }
    }
}
