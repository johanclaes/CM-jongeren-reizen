using dal.Data.UnitOfWork;
using dal;
using models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using models.Partials;
using Microsoft.Toolkit.Collections;
using System.Windows;

namespace wpf.ViewModels
{
    public class InschrijvingenViewModel : BaseViewModel
    {
        private IUnitOfWork _unitOfWork = new UnitOfWork(new GroepsreizenContext());

        private string _naamGebruiker;
        private ObservableCollection<Gebruiker> _gebruikers;
        private Gebruiker _geselecteerdeGebruiker;
        private ObservableCollection<Groepsreis> _groepsreizen;
        private ObservableCollection<Inschrijving> _ingeschrevenReizen;
        private Inschrijving _geselecteerdeIngeschrevenReis;
        private ObservableCollection<string> _landen;
        private string _geselecteerdLand;
        private ObservableCollection<string> _gemeentes;
        private string _geselecteerdeGemeente;
        private ObservableCollection<Groepsreis> _gezochteReizen;
        private Groepsreis _geselecteerdeReis;

        public string NaamGebruiker
        {
            get { return _naamGebruiker; }
            set
            {
                _naamGebruiker = value;
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<Gebruiker> Gebruikers
        {
            get { return _gebruikers; }
            set
            {
                _gebruikers = value;
                NotifyPropertyChanged();
            }
        }

        public Gebruiker GeselecteerdeGebruiker
        {
            get { return _geselecteerdeGebruiker; }
            set
            {
                _geselecteerdeGebruiker = value;
                Groepsreizen = new ObservableCollection<Groepsreis>(_unitOfWork.GroepsreisRepo.Ophalen());
                IngeschrevenReizen = new ObservableCollection<Inschrijving>(_unitOfWork.InschrijvingRepo.Ophalen(x => x.GebruikerId == GeselecteerdeGebruiker.Id));
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<Groepsreis> Groepsreizen
        {
            get { return _groepsreizen; }
            set
            {
                _groepsreizen = value;
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<Inschrijving> IngeschrevenReizen
        {
            get { return _ingeschrevenReizen; }
            set
            {
                _ingeschrevenReizen = value;
                NotifyPropertyChanged();
            }
        }

        public Inschrijving GeselecteerdeIngeschrevenReis
        {
            get { return _geselecteerdeIngeschrevenReis; }
            set
            {
                _geselecteerdeIngeschrevenReis = value;
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<string> Landen
        {
            get { return _landen; }
            set
            {
                _landen = value;
                NotifyPropertyChanged();
            }
        }

        public string GeselecteerdLand
        {
            get { return _geselecteerdLand; }
            set
            {
                _geselecteerdLand = value;
                Gemeentes = new ObservableCollection<string>(_unitOfWork.BestemmingRepo.Ophalen(x => x.Land == GeselecteerdLand).Select(y => y.Gemeente).Distinct());
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<string> Gemeentes
        {
            get { return _gemeentes; }
            set
            {
                _gemeentes = value;
                NotifyPropertyChanged();
            }
        }

        public string GeselecteerdeGemeente
        {
            get { return _geselecteerdeGemeente; }
            set
            {
                _geselecteerdeGemeente = value;
                GezochteReizen = new ObservableCollection<Groepsreis>(_unitOfWork.GroepsreisRepo.Ophalen(x => x.Bestemming.Land == GeselecteerdLand && x.Bestemming.Gemeente == GeselecteerdeGemeente));
                if (GezochteReizen.Count == 0)
                {
                    MessageBox.Show("Momenteel zijn er geen groepsreizen op deze locatie. Gelieve een andere te selecteren.", "Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
                }
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

        public Groepsreis GeselecteerdeReis
        {
            get { return _geselecteerdeReis; }
            set
            {
                _geselecteerdeReis = value;
                NotifyPropertyChanged();
            }
        }

        public InschrijvingenViewModel() 
        {
            Landen = new ObservableCollection<string>(_unitOfWork.BestemmingRepo.Ophalen().Select(x => x.Land).Distinct());
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
                case "ZoekGebruikers": return true;
                case "MaakReservering": return GeselecteerdeGebruiker != null && GeselecteerdeReis != null;
                case "ReserveerBetaling": return GeselecteerdeIngeschrevenReis != null;
                case "AnnuleerInschrijving": return GeselecteerdeIngeschrevenReis != null;
            }
            return true;
        }

        public override void Execute(object parameter)
        {
            switch (parameter.ToString())
            {
                case "ZoekGebruikers": ZoekGebruikers(); break;
                case "MaakReservering": MaakReservering(); break;
                case "ReserveerBetaling": ReserveerBetaling(); break;
                case "AnnuleerInschrijving": AnnuleerInschrijving(); break;
            }
        }

        public void ZoekGebruikers() 
        {
            if (string.IsNullOrWhiteSpace(NaamGebruiker))
                Gebruikers = new ObservableCollection<Gebruiker>(_unitOfWork.GebruikerRepo.Ophalen());
            else
                Gebruikers = new ObservableCollection<Gebruiker>(_unitOfWork.GebruikerRepo.Ophalen(x => x.Naam.Contains(NaamGebruiker) || x.Voornaam.Contains(NaamGebruiker)));
        }
        public void MaakReservering()
        {
            Groepsreis groepsreis = GeselecteerdeReis;
            Gebruiker gebruiker = GeselecteerdeGebruiker;
            var inschrijvingen = new ObservableCollection<Inschrijving>(_unitOfWork.InschrijvingRepo.Ophalen(x => x.Groepsreis == groepsreis && x.Gebruiker == gebruiker));

            if (inschrijvingen.Count == 0)
            {
                Inschrijving inschrijving = new Inschrijving() { Groepsreis = groepsreis, Gebruiker = gebruiker, Betaald = false };
                _unitOfWork.InschrijvingRepo.Toevoegen(inschrijving);
                int oke = _unitOfWork.Save();
                FoutmeldingNaSave(oke, "Er liep iets mis.", "De persoon is ingeschreven voor de groepsreis!");
            }
            else
                MessageBox.Show("De gebruiker is al ingeschreven voor deze reis!", "Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
   
        }
        public void ReserveerBetaling()
        {
            if (GeselecteerdeIngeschrevenReis.Betaald)
            {
                MessageBox.Show("Deze reis is al betaald!");
            }
            else
            {
                GeselecteerdeIngeschrevenReis.Betaald = true;
                _unitOfWork.InschrijvingRepo.ToevoegenOfAanpassen(GeselecteerdeIngeschrevenReis);
                int oke = _unitOfWork.Save();

                FoutmeldingNaSave(oke, "Er liep iets mis.", "De betaling is geregistreerd!");
            }
        }
        public void AnnuleerInschrijving()
        {
            _unitOfWork.InschrijvingRepo.Verwijderen(GeselecteerdeIngeschrevenReis.Id);
            int oke = _unitOfWork.Save();
            FoutmeldingNaSave(oke, "Er liep iets mis.", "De inschrijving is geannuleerd!");
        }

        private void FoutmeldingNaSave(int ok, string foutmelding, string succesmelding)
        {
            if (ok > 0)
            {
                MessageBox.Show(succesmelding);
                ZoekGebruikers();
                IngeschrevenReizen = new ObservableCollection<Inschrijving>(_unitOfWork.InschrijvingRepo.Ophalen(x => x.GebruikerId == GeselecteerdeGebruiker.Id));
            }
            else
            {
                MessageBox.Show(foutmelding);
            }
        }

    }
}
