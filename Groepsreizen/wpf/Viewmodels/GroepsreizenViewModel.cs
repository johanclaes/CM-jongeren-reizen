using dal.Data.UnitOfWork;
using dal;
using models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace wpf.ViewModels
{
    public class GroepsreizenViewModel : BaseViewModel
    {
        private IUnitOfWork _unitOfWork = new UnitOfWork(new GroepsreizenContext());

        private string _naamReis;
        private ObservableCollection<Groepsreis> _gezochteReizen;
        private Groepsreis _geselecteerdeReis;
        private Groepsreis _groepsreisRecord;
        private string _naamMonitor;
        private ObservableCollection<Monitor> _monitoren;
        private ObservableCollection<Gebruiker> _hoofdmonitoren;
        private Gebruiker _geselecteerdeHoofdmonitor;
        private ObservableCollection<Bestemming> _bestemmingen;
        private Bestemming _geselecteerdeBestemming;
        private OpleidingType _opleidingType;
        private ObservableCollection<Opleiding> _opleidingen;
        private ObservableCollection<GebruikerOpleiding> _gebruikerOpleiding;
        private ObservableCollection<Gebruiker> _gebruikers;
        private Gebruiker _geselecteerdeGebruiker;
        private Monitor _monitorRecord;
        private string _foutmeldingen;
        private Monitor _geselecteerdeMonitor;
        private ObservableCollection<Gebruiker> _gezochteGebruikers;

        public string NaamReis
        {
            get { return _naamReis; }
            set
            {
                _naamReis = value;
                NotifyPropertyChanged();
            }
        }
        public string Foutmeldingen
        {
            get { return _foutmeldingen; }
            set
            {
                _foutmeldingen = value;
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
                GroepsreisRecord = GeselecteerdeReis;
                if (GeselecteerdeReis != null)
                {
                    GeselecteerdeBestemming = GeselecteerdeReis.Bestemming;
                        // Monitoren om de listbox op te vullen
                    Monitoren = new ObservableCollection<Monitor>(_unitOfWork.MonitorRepo.Ophalen().Where(x => x.GroepsreisId.Equals(GeselecteerdeReis.Id)));
                    Hoofdmonitoren = new ObservableCollection<Gebruiker>();
                    foreach (var item in Monitoren)                         // hoofdmonitoren om de combobox list op te vullen
                    {
                        Gebruiker gebruiker = new Gebruiker();
                        gebruiker = _unitOfWork.GebruikerRepo.Ophalen().Where(x => x.Id.Equals(item.GebruikerId)).FirstOrDefault();
                        if (gebruiker.Hoofdmonitorbrevet == true)
                        {
                            Hoofdmonitoren.Add(gebruiker);
                        }
                        if (item.Hoofdmonitor)                              // de selectie in combobox invullen
                        {
                            GeselecteerdeHoofdmonitor = gebruiker;
                        }
                    }
                    
                }
               
                NotifyPropertyChanged();
            }
        }

        public Groepsreis GroepsreisRecord
        {
            get { return _groepsreisRecord; }
            set
            {
                _groepsreisRecord = value;
                NotifyPropertyChanged();
            }
        }

        public string NaamMonitor
        {
            get { return _naamMonitor; }
            set
            {
                _naamMonitor = value;
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<Gebruiker> Hoofdmonitoren
        {
            get { return _hoofdmonitoren; }
            set
            {
                _hoofdmonitoren = value;
                NotifyPropertyChanged();
            }
        }

        public Gebruiker GeselecteerdeHoofdmonitor
        {
            get { return _geselecteerdeHoofdmonitor; }
            set
            {
                _geselecteerdeHoofdmonitor = value;
                NotifyPropertyChanged();
            }
        }
        public ObservableCollection<Bestemming> Bestemmingen
        {
            get
            {
                return _bestemmingen;
            }
            set
            {
                _bestemmingen = value;
                NotifyPropertyChanged();
            }
        }
        public Bestemming GeselecteerdeBestemming
        {
            get
            {
                return _geselecteerdeBestemming;
            }
            set
            {
                _geselecteerdeBestemming = value;
                NotifyPropertyChanged();
            }
        }
        public ObservableCollection<Monitor> Monitoren
        {
            get { return _monitoren; }
            set
            {
                _monitoren = value;
                NotifyPropertyChanged();
            }
        }

        public OpleidingType OpleidingsType
        {
            get { return _opleidingType; }
            set
            {
                _opleidingType = value;
                NotifyPropertyChanged();
            }
        }
        public ObservableCollection<GebruikerOpleiding> GebruikerOpleiding
        {
            get
            {
                return _gebruikerOpleiding;
            }
            set
            {
                _gebruikerOpleiding = value;
                NotifyPropertyChanged();
            }
        }
        public ObservableCollection<Opleiding> Opleidingen
        {
            get
            {
                return _opleidingen;
            }
            set
            {
                _opleidingen = value;
                NotifyPropertyChanged();
            }
        }
        public ObservableCollection<Gebruiker> Gebruikers
        {
            get
            {
                return _gebruikers;
            }
            set
            {
                _gebruikers = value;
                NotifyPropertyChanged();
            }
        }
        public Gebruiker GeselecteerdeGebruiker
        {
            get
            {
                return _geselecteerdeGebruiker;
            }
            set
            {
                _geselecteerdeGebruiker = value;
                NotifyPropertyChanged();
            }
        }
        public Monitor MonitorRecord
        {
            get
            {
                return _monitorRecord;
            }
            set
            {
                _monitorRecord = value;
                NotifyPropertyChanged();
            }
        }
        public Monitor GeselecteerdeMonitor
        {
            get
            {
                return _geselecteerdeMonitor;
            }
            set
            {
                _geselecteerdeMonitor = value;
                NotifyPropertyChanged();
            }
        }
        public ObservableCollection<Gebruiker> GezochteGebruikers
        {
            get
            {
                return _gezochteGebruikers;
            }
            set
            {
                _gezochteGebruikers = value;
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
                case "ZoekReis": return true;
                case "UpdateReis": return GroepsreisRecord != null;
                case "MaakNieuweReis": return true;
                case "FormulierLeegmaken": return true;
                case "ZoekMonitor": return NaamMonitor != string.Empty;
                case "ZoekMonitorViaOpleiding": return NaamMonitor != string.Empty;
                case "VoegMonitorToe": return GeselecteerdeGebruiker != null;
                case "VerwijderMonitor": return GeselecteerdeMonitor != null;
                case "HoofdmonitorToevoegen": return GeselecteerdeHoofdmonitor != null;
            }
            return true;
        }

        public override void Execute(object parameter)
        {
            switch (parameter.ToString())
            {
                case "ZoekReis": ZoekReis(); break;
                case "UpdateReis": UpdateReis(); break;
                case "MaakNieuweReis": MaakNieuweReis(); break;
                case "FormulierLeegmaken": FormulierLeegmaken(); break;
                case "ZoekMonitor": ZoekMonitor(); break;
                case "ZoekMonitorViaOpleiding": ZoekMonitorViaOpleiding(); break;
                case "VoegMonitorToe": VoegMonitorToe(); break;
                case "VerwijderMonitor": VerwijderMonitor(); break;
                case "HoofdmonitorToevoegen": VoegHoofdmonitorToe(); break;
            }
        }

        // constructor 
        public GroepsreizenViewModel()
        {
            GroepsreisRecord = new Groepsreis();
            GroepsreisRecord.Startdatum = DateTime.Now;
            GroepsreisRecord.Einddatum = DateTime.Now;
            Hoofdmonitoren = new ObservableCollection<Gebruiker>();
            Bestemmingen = new ObservableCollection<Bestemming>(_unitOfWork.BestemmingRepo.Ophalen());
            Foutmeldingen = "";
        }





        // de vele knoppen

        public void ZoekReis()
        {
            if (!string.IsNullOrEmpty(NaamReis))
            {
                GezochteReizen = new ObservableCollection<Groepsreis>(_unitOfWork.GroepsreisRepo.Ophalen(x => x.Naam.Contains(NaamReis)));
            }
            else
            {
                Foutmeldingen = "Geef een naam van een reis in!";
            }
        }
        public void UpdateReis()
        {
            if (GeselecteerdeReis != null)
            {
                _unitOfWork.GroepsreisRepo.ToevoegenOfAanpassen(GroepsreisRecord);
                int oke = _unitOfWork.Save();

                FoutmeldingNaSave(oke, "De reis is niet aangepast!", "De reis is aangepast!");
            }
            else
            {
                Foutmeldingen = "Eerst een reis selecteren!";
            }
        }
        public void MaakNieuweReis()
        {

            if (GeselecteerdeBestemming != null)
            {
                GroepsreisRecord.BestemmingId = GeselecteerdeBestemming.Id;
                if (GroepsreisRecord.IsGeldig())
                {
                    _unitOfWork.GroepsreisRepo.Toevoegen(GroepsreisRecord);
                    int oke = _unitOfWork.Save();

                    FoutmeldingNaSave(oke, "De reis is niet toegevoegd!", "De reis is toegevoegd!");
                }
            }
            else
            {
                Foutmeldingen = "Kies eerst een bestemming!";
            }

        }
        public void ZoekMonitor()
        {
            if (NaamMonitor != null)
            {
                GezochteGebruikers = new ObservableCollection<Gebruiker>(_unitOfWork.GebruikerRepo.Ophalen(x => x.Monitorbrevet == true && (x.Naam.Contains(NaamMonitor) || x.Voornaam.Contains(NaamMonitor))));
            }
            else
            {
                GezochteGebruikers = new ObservableCollection<Gebruiker>(_unitOfWork.GebruikerRepo.Ophalen(x => x.Monitorbrevet == true));
            }
        }

        public void ZoekMonitorViaOpleiding()
        {
            if (NaamMonitor != null)
            {
                if (NaamMonitor != null)
                {
                    OpleidingsType = _unitOfWork.OpleidingTypeRepo.Ophalen(x => x.Naam.Contains(NaamMonitor)).FirstOrDefault();
                    Opleidingen = new ObservableCollection<Opleiding>(_unitOfWork.OpleidingRepo.Ophalen(x => x.OpleidingTypeId.Equals(OpleidingsType.Id)));




                    List<int> PKOpleidingLijst = new List<int>();
                    foreach (var item in Opleidingen)                           // we lussen door alle opleiding en maken lijst van PK van gezochte cucsus
                    {
                        if (item.OpleidingTypeId == OpleidingsType.Id)
                        {
                            PKOpleidingLijst.Add(item.Id);
                        }
                    }
                    GebruikerOpleiding = new ObservableCollection<GebruikerOpleiding>(_unitOfWork.GebruikerOpleidingRepo.Ophalen());



                    GezochteGebruikers = new ObservableCollection<Gebruiker>();
                    foreach (var item in GebruikerOpleiding)
                    {
                        if (PKOpleidingLijst.Contains(item.OpleidingId))
                        {
                            Gebruiker monitor = new Gebruiker();
                            monitor = _unitOfWork.GebruikerRepo.Ophalen(x => x.Id.Equals(item.GebruikerId)).FirstOrDefault();
                            GezochteGebruikers.Add(monitor);
                        }
                    }



                }
            }
        }
        public void VoegMonitorToe()
        {
            if (GeselecteerdeGebruiker != null && GeselecteerdeReis != null)
            {
                MonitorRecord = new Monitor();
                MonitorRecord.GebruikerId = GeselecteerdeGebruiker.Id;
                MonitorRecord.GroepsreisId = GeselecteerdeReis.Id;
                MonitorRecord.Hoofdmonitor = false;
            }
            if (GeselecteerdeGebruiker.Hoofdmonitorbrevet == true)
            {
                if (Hoofdmonitoren != null)
                {
                    Hoofdmonitoren.Add(GeselecteerdeGebruiker);
                }
                else
                {
                    Hoofdmonitoren = new ObservableCollection<Gebruiker>();
                    Hoofdmonitoren.Add(GeselecteerdeGebruiker);
                }
            }
            if (MonitorRecord.IsGeldig())
            {
                _unitOfWork.MonitorRepo.Toevoegen(MonitorRecord);
                int oke = _unitOfWork.Save();

                FoutmeldingNaSave(oke, "De Monitor is niet toegevoegd!", "De monitor is toegevoegd!");
            }
            if (GeselecteerdeReis != null)
            {
                Monitoren = new ObservableCollection<Monitor>(_unitOfWork.MonitorRepo.Ophalen().Where(x => x.GroepsreisId.Equals(GeselecteerdeReis.Id)));
            }
            GeselecteerdeGebruiker = null;

        }
        public void VerwijderMonitor()
        {
            if (GeselecteerdeMonitor != null)
            {
                _unitOfWork.MonitorRepo.Verwijderen(GeselecteerdeMonitor);
                int oke = _unitOfWork.Save();
                FoutmeldingNaSave(oke, "De monitor is niet verwijderd!", "De monitor is verwijderd!");
                Monitoren = new ObservableCollection<Monitor>(_unitOfWork.MonitorRepo.Ophalen().Where(x => x.GroepsreisId.Equals(GeselecteerdeReis.Id)));
            }
            else
            {
                Foutmeldingen = "Er is geen monitor geselecteerd";
            }

        }
        public void VoegHoofdmonitorToe()
        {
            if (GeselecteerdeHoofdmonitor != null)
            {
                Foutmeldingen = "";
                foreach (var item in Monitoren)
                {
                    if (item.Hoofdmonitor == true)
                    {
                        item.Hoofdmonitor = false;
                        _unitOfWork.MonitorRepo.Aanpassen(item);
                        int correct = _unitOfWork.Save();
                        FoutmeldingNaSave(correct, "De hoofdmonitor = niet aangepast!", "De hoofdmonitor = aangepast!");
                    }
                }
                    Monitor hoofdmonitor = _unitOfWork.MonitorRepo.Ophalen(x => x.GebruikerId == GeselecteerdeHoofdmonitor.Id).FirstOrDefault();
                    hoofdmonitor.Hoofdmonitor = true;
                    _unitOfWork.MonitorRepo.Aanpassen(hoofdmonitor);
                    int oke = _unitOfWork.Save();
                    FoutmeldingNaSave(oke, "De hoofdmonitor is niet aangepast!", "De hoofdmonitor is aangepast!");
            }
            else
            {
                Foutmeldingen = "Eerst een hoofdmonitor kiezen!";
            }
        }

        private void FoutmeldingNaSave(int ok, string foutmelding, string succesmelding)
        {
            if (ok > 0)
            {
                Foutmeldingen = succesmelding;
            }
            else
            {
                Foutmeldingen = foutmelding;
            }
        }
        public void FormulierLeegmaken()
        {
            GeselecteerdeReis = null;
            GeselecteerdeGebruiker = null;
            GeselecteerdeMonitor = null;
            GezochteGebruikers = null;
            GroepsreisRecord = null;
            MonitorRecord = null;
            GezochteReizen = null;
            Foutmeldingen = string.Empty;
            NaamReis = string.Empty;
            Monitoren = null;
            Hoofdmonitoren = null;
            GeselecteerdeHoofdmonitor = null;
            GeselecteerdeBestemming = null;
        }
    }
}