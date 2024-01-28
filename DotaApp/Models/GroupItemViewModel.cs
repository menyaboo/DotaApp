using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaApp.Models
{
    public class GroupItemViewModel : INotifyPropertyChanged
    {
        private string _groupName;
        public string GroupName
        {
            get { return _groupName; }
            set
            {
                if (_groupName != value)
                {
                    _groupName = value;
                    OnPropertyChanged(nameof(GroupName));
                }
            }
        }

        private List<string> _itemNames;
        public List<string> ItemNames
        {
            get { return _itemNames; }
            set
            {
                if (_itemNames != value)
                {
                    _itemNames = value;
                    OnPropertyChanged(nameof(ItemNames));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
