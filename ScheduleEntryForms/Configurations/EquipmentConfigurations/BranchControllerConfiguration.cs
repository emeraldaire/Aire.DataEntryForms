using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleEntryForms.Configurations.EquipmentConfigurations
{
    public class BranchControllerConfiguration : IEquipmentConfiguration
    {
        public IElectricalConfiguration ElectricalConfiguration { get ; set; }
        public IHeatingCoolingConfiguration HeatingCoolingConfiguration { get; set; }

        public BranchControllerConfiguration()
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
                MaximumCurrentAmps = true,
                MaximumOverCurrentProtection = true
            };
        }
    }
}
