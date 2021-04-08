using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ScheduleEntryForms.Configurations.EquipmentConfigurations
{
    public class RTUHeatPumpConfiguration : IEquipmentConfiguration
    {
        public IElectricalConfiguration ElectricalConfiguration { get; set; }
        public IHeatingCoolingConfiguration HeatingCoolingConfiguration { get ; set; }

        public RTUHeatPumpConfiguration()
        {
            SetElectricalConfiguration();
            SetHeatingCoolingConfiguration();
        }

        private void SetHeatingCoolingConfiguration()
        {
            HeatingCoolingConfiguration = new HeatingCoolingConfiguration()
            {
            };
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
