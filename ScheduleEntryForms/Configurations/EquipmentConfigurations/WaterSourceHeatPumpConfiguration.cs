using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleEntryForms.Configurations.EquipmentConfigurations
{
    public class WaterSourceHeatPumpConfiguration : IEquipmentConfiguration
    {
        public IElectricalConfiguration ElectricalConfiguration { get; set; }
        public IHeatingCoolingConfiguration HeatingCoolingConfiguration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
