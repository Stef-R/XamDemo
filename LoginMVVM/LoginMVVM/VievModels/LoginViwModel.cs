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

        private string versionsText="Ver 0.0.0";
        private string statusText = "indtast telefonnummer";        
        private bool loginOk = false;
        private string login = "";
        
        public string VersionsText { get { return versionsText; } }
        public string StatusText
        {
            get { return statusText; }
            set
            {
                statusText = value;
                OnProertyChanged();
            }
        }
        public bool LoginOk
        {
            get { return loginOk; }
            set
            {
                loginOk = value;
                OnProertyChanged();
            }
        }
        public string Login
        {
            get { return login; }
            set
            {
                if (login != value)
                {
                    login = value;
                    OnProertyChanged();
                    if (login.Length>=8)
                    {
                        LoginOk = true;
                        StatusText = "Ok a logge ind";
                    }
                    else
                    {
                        LoginOk = false;
                        StatusText = "forsæt med at taste";

                    }
                }                
            }
        }
        
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
