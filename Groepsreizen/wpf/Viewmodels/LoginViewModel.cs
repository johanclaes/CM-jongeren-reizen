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
using System.Windows;

namespace wpf.Viewmodels
{
    public class LoginViewModel : BaseViewModel
    {
        private Gebruiker _gebruiker;
        private IUnitOfWork _unitOfWork = new UnitOfWork(new GroepsreizenContext());
        private string _foutmelding;
        public override string this[string columnName] => throw new NotImplementedException();

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
        public string Foutmelding
        {
            get { return _foutmelding; }
            set
            {
                _foutmelding = value;
                NotifyPropertyChanged();
            }
        }

        //gebruiker zoeken
        public void LoginCommand()
        {

                GebruikerRecord = _unitOfWork.GebruikerRepo.Ophalen(x => x.Email == Email).FirstOrDefault();

            if (GebruikerRecord == null)
            {
                Foutmelding = "De gebruiker is niet gevonden";
            }
            else
            {
                if (GebruikerRecord.Email == Email && GebruikerRecord.Paswoord == Password)
                {
                    if (GebruikerRecord.Webadmin == true)
                    {
                        var vm = new MainViewModel();
                        var view = new MainWindow();
                        view.DataContext = vm;
                        App.Current.Windows[0].Visibility = Visibility.Collapsed;
                        view.Show();
                        
                    }
                    else
                    {
                        Foutmelding = "De gebruiker is geen admin.";
                    }
                }
                else
                {
                    Foutmelding = "Het wachtwoord is niet correct.";
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
