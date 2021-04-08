using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleEntryForms.Configurations.EquipmentConfigurations
{
    public class VAVConfiguration : IEquipmentConfiguration
    {
        public IElectricalConfiguration ElectricalConfiguration { get; set; }
        public IHeatingCoolingConfiguration HeatingCoolingConfiguration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public VAVConfiguration()
        {
            SetElectricalConfiguration();
        }

        private void SetElectricalConfiguration()
        {
            ElectricalConfiguration = new ElectricalConfiguration()
            {
                FanHP = true,
                KiloWatts = true,
                VoltPhase = true,
                FullLoadAmps = true
            };
        }
    }
}
