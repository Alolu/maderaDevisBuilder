using System.ComponentModel;

namespace MaderaDevisBuilder.Models { 

    public class LoginViewModel : INotifyPropertyChanged
    {
        private string _username;
        private string _password;
        private bool _invalidCredentials;

        public bool invalidCredentials
        {
            get => _invalidCredentials;
            set
            {
                if (value == _invalidCredentials) return;
                _invalidCredentials = value;
                OnPropertyChanged(nameof(_invalidCredentials));
            }
        }

        public string Username
        {
            get => _username;
            set
            {
                if (value == _username) return;
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (value == _password) return;
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public bool CheckCredentials()
        {
            if (Username == "lol" && Password == "lol") return true;
            invalidCredentials = true;
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
