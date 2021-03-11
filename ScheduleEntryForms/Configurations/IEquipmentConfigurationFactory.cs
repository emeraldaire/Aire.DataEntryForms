using ScheduleEntryForms.Enums;

namespace ScheduleEntryForms.Configurations
{
    public interface IEquipmentConfigurationFactory
    {
        object CreateConfiguration(EquipmentProfileType equipmentProfileType);
    }
}