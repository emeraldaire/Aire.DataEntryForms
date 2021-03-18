using FormEntryDesign;
using ScheduleEntryForms.Configurations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleEntryForms.ViewModels
{
    public class VAVViewModel : ViewModelBase, IVAVViewModel
    {
        public IEquipmentConfiguration VAVConfiguration;

        public VAVViewModel(IEquipmentConfiguration vavConfiguration)
        {
            VAVConfiguration = vavConfiguration;
        }

        public async Task LoadAsync()
        {

        }
    }
}
