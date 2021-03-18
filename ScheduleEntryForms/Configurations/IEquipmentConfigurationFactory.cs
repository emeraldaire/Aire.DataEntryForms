using ScheduleEntryForms.Enums;

namespace ScheduleEntryForms.Configurations
{
    public interface IEquipmentConfigurationFactory
    {
        IEquipmentConfiguration CreateEquipmentConfiguration(EquipmentProfileType equipmentProfileType);
    }
}