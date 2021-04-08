using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleEntryForms.Configurations.EquipmentConfigurations
{
    public class IsolationConfiguration : IEquipmentConfiguration
    {
        public IElectricalConfiguration ElectricalConfiguration { get; set; }
        public IHeatingCoolingConfiguration HeatingCoolingConfiguration { get ; set; }

        public IsolationConfiguration()
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
            };
        }
    }
}
