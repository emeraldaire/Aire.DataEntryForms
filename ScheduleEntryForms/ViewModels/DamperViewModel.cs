using FormEntryDesign;
using ScheduleEntryForms.Configurations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleEntryForms.ViewModels
{
    public class DamperViewModel : ViewModelBase
    {
        public IEquipmentConfiguration EquipmentConfiguration;

        public DamperViewModel(IEquipmentConfiguration equipmentConfiguration)
        {
            EquipmentConfiguration = equipmentConfiguration;
        }

        public async Task LoadAsync() 
        {
        }
    }
}
