using models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf.ViewModels
{
    public class InschrijvingenViewModel : BaseViewModel
    {
        private string _naamDeelnemer;
        private ObservableCollection<Gebruiker> _gezochteDeelnemers;
        private Gebruiker _selectedDeelnemer;
        private ObservableCollection<Groepsreis> _ingeschrevenReizen;
        private Groepsreis _selectedIngeschrevenReis;
        private ObservableCollection<Bestemming> _landen;
        private Bestemming _selectedLand;
        private ObservableCollection<Bestemming> _gemeentes;
        private Bestemming _selectedGemeente;
        private ObservableCollection<Groepsreis> _gezochteReizen;
        private Groepsreis _selectedReis;
        private string _errorInschrijving;

        public string NaamDeelnemer
        {
            get { return _naamDeelnemer; }
            set
            {
                _naamDeelnemer = value;
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<Gebruiker> GezochteDeelnemers
        {
            get { return _gezochteDeelnemers; }
            set
            {
                _gezochteDeelnemers = value;
                NotifyPropertyChanged();
            }
        }

        public Gebruiker SelectedDeelnemer
        {
            get { return _selectedDeelnemer; }
            set
            {
                _selectedDeelnemer = value;
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<Groepsreis> IngeschrevenReizen
        {
            get { return _ingeschrevenReizen; }
            set
            {
                _ingeschrevenReizen = value;
                NotifyPropertyChanged();
            }
        }

        public Groepsreis SelectedIngeschrevenReis
        {
            get { return _selectedIngeschrevenReis; }
            set
            {
                _selectedIngeschrevenReis = value;
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<Bestemming> Landen
        {
            get { return _landen; }
            set
            {
                _landen = value;
                NotifyPropertyChanged();
            }
        }

        public Bestemming SelectedLand
        {
            get { return _selectedLand; }
            set
            {
                _selectedLand = value;
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<Bestemming> Gemeentes
        {
            get { return _gemeentes; }
            set
            {
                _gemeentes = value;
                NotifyPropertyChanged();
            }
        }

        public Bestemming SelectedGemeente
        {
            get { return _selectedGemeente; }
            set
            {
                _selectedGemeente = value;
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<Groepsreis> GezochteReizen
        {
            get { return _gezochteReizen; }
            set
            {
                _gezochteReizen = value;
                NotifyPropertyChanged();
            }
        }

        public Groepsreis SelectedReis
        {
            get { return _selectedReis; }
            set
            {
                _selectedReis = value;
                NotifyPropertyChanged();
            }
        }

        public string ErrorInschrijving
        {
            get { return _errorInschrijving; }
            set
            {
                _errorInschrijving = value;
                NotifyPropertyChanged();
            }
        }

        public override string this[string columnName]
        {
            get
            {
                return "";
            }
        }

        public override bool CanExecute(object parameter)
        {
            switch (parameter.ToString())
            {
                case "ZoekDeelnemer": return true;
                case "MaakReservering": return true;
                case "ReserveerBetaling": return true;
                case "AnnuleerInschrijving": return true;
            }
            return true;
        }

        public override void Execute(object parameter)
        {
            switch (parameter.ToString())
            {
                case "ZoekDeelnemer": ZoekDeelnemer(); break;
                case "MaakReservering": MaakReservering(); break;
                case "ReserveerBetaling": ReserveerBetaling(); break;
                case "AnnuleerInschrijving": AnnuleerInschrijving(); break;
            }
        }

        public void ZoekDeelnemer() { }
        public void MaakReservering() { }
        public void ReserveerBetaling() { }
        public void AnnuleerInschrijving() { }
    }
}
