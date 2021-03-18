using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleEntryForms.Configurations
{
    public interface IEquipmentConfiguration
    {
        IElectricalConfiguration ElectricalConfiguration { get; set; }

    }
}
