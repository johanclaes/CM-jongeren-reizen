using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using dal.Data.UnitOfWork;
using dal;
using models;
using wpf.ViewModels;

namespace wpf.Viewmodels
{
    public class LoginViewModel : BaseViewModel
    {
        private Gebruiker _gebruiker;
        private IUnitOfWork _unitOfWork = new UnitOfWork(new GroepsreizenContext());
        private bool _isTrue;
        public override string this[string columnName] => throw new NotImplementedException();

        public bool IsTrue
        {
            get => _isTrue;
            set => _isTrue = value;
        }
        public Gebruiker GebruikerRecord
        {
            get { return _gebruiker; }
            set
            {
                _gebruiker = value;
                NotifyPropertyChanged();
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                NotifyPropertyChanged();
            }
        }

        private string _paswoord;
        public string Password
        {
            get { return _paswoord; }
            set
            {
                _paswoord = value;
                NotifyPropertyChanged();
            }
        }

        //gebruiker zoeken
        public void LoginCommand()
        {
            if (string.IsNullOrWhiteSpace(Email))
            {
                GebruikerRecord = new Gebruiker();
            }

            else
            {
                GebruikerRecord = _unitOfWork.GebruikerRepo.Ophalen(x => x.Email == Email).FirstOrDefault();
            }


            if (GebruikerRecord.Email == Email && GebruikerRecord.Paswoord == Password)
            {
                if (GebruikerRecord.Webadmin == true)
                {
                    IsTrue = true; 
                    var vm = new MainViewModel();
                    var view = new MainWindow();
                    view.DataContext = vm;
                    view.Show();
                    
                }
            }
        }
        public override bool CanExecute(object parameter)
        {
            switch (parameter.ToString())
            {
                case "LoginCommand": return true;
            }
            return true;
        }

        public override void Execute(object parameter)
        {
            switch (parameter.ToString())
            {
                case "LoginCommand": LoginCommand(); break;
            }
        }
    }
}
