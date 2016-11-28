using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LoginMVVM.VievModels 
{
    public class LoginViwModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // simple func

        public virtual void OnProertyChanged([CallerMemberName] string propertyName = "")
        {
            var ev = PropertyChanged;
            if (ev != null)
            {
                ev(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
