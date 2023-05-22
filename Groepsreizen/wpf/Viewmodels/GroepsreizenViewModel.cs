﻿using dal.Data.UnitOfWork;
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
        private string _errorsGroepsreizen;
        private string _naamMonitor;
        private ObservableCollection<Gebruiker> _monitoren;
        private ObservableCollection<Gebruiker> _hoofdmonitoren;
        private Gebruiker _selectedHoofdmonitoren;
        private ObservableCollection<Bestemming> _bestemmingen;
        private Bestemming _geselecteerdeBestemming;
        private ObservableCollection<OpleidingType> _opleidingTypes;

        public string NaamReis
        {
            get { return _naamReis; }
            set
            {
                _naamReis = value;
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
                GroepsreisRecordInstellen();
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

        public string ErrorsGroepsreizen
        {
            get { return _errorsGroepsreizen; }
            set
            {
                _errorsGroepsreizen = value;
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

        public Gebruiker SelectedHoofdmonitor
        {
            get { return _selectedHoofdmonitoren; }
            set
            {
                _selectedHoofdmonitoren = value;
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
        public ObservableCollection<Gebruiker> Monitoren
        {
            get { return _monitoren; }
            set
            {
                _monitoren = value;
                NotifyPropertyChanged();
            }
        }
        public ObservableCollection<OpleidingType> Opleiding
        {
            get { return _opleidingTypes; }
            set
            {
                _opleidingTypes = value;
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
                case "UpdateReis": return true;
                case "MaakNieuweReis": return true;
                case "MaakVeldenLeeg": return true;
                case "ZoekMonitor": return true;
                case "ZoekMonitorViaOpleiding": return true;
                case "VoegMonitorToe": return true;
                case "VerwijderMonitor": return true;
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
                case "MaakVeldenLeeg": MaakVeldenLeeg(); break;
                case "ZoekMonitor": ZoekMonitor(); break;
                case "ZoekMonitorViaOpleiding": ZoekMonitorViaOpleiding(); break;
                case "VoegMonitorToe": VoegMonitorToe(); break;
                case "VerwijderMonitor": VerwijderMonitor(); break;
            }
        }

        public void ZoekReis()
        {
            if (!string.IsNullOrEmpty(NaamReis))
            {
                GezochteReizen = new ObservableCollection<Groepsreis>(_unitOfWork.GroepsreisRepo.Ophalen(x => x.Naam.Contains(NaamReis)));
            }
            else
            {

            }
        }
        public void UpdateReis() { }
        public void MaakNieuweReis() { }
        public void MaakVeldenLeeg() { }
        public void ZoekMonitor()
        {
            if (NaamMonitor != null)
            {
                Opleiding = new ObservableCollection<OpleidingType>(_unitOfWork.OpleidingTypeRepo.Ophalen(x => x.Naam.Contains(NaamMonitor)));
                Monitoren = new ObservableCollection<Gebruiker>(_unitOfWork.GebruikerRepo.Ophalen(x => x.Monitorbrevet == true));
            }
            else
            {

            }
        }

        public void ZoekMonitorViaOpleiding()
        {
            if (NaamMonitor != null)
            {

                
            }
        }
        public void VoegMonitorToe() { MessageBox.Show("test3"); }
        public void VerwijderMonitor() { }
        public void GroepsreisRecordInstellen()
        {
            if (GeselecteerdeReis != null)
            {
                GroepsreisRecord = GeselecteerdeReis;
            }
            else
            {
                GroepsreisRecord = new Groepsreis();
            }
        }
        public GroepsreizenViewModel()
        {
            Bestemmingen = new ObservableCollection<Bestemming>(_unitOfWork.BestemmingRepo.Ophalen());
        }
    }
}
