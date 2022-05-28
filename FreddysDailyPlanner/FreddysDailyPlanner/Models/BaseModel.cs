using System.ComponentModel;

namespace FreddysDailyPlanner.Models
{
    public class BaseModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
