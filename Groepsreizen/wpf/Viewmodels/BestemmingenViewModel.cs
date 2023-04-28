using models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf.ViewModels
{
    public class BestemmingenViewModel : BaseViewModel
    {
        private ObservableCollection<Bestemmingstype> _bestemmingsTypes;
        private Bestemmingstype _selectedBestemmingsTypes;
        private Bestemming _bestemmingRecord;
        private ObservableCollection<Bestemming> _bestemmingen;
        private Bestemming _selectedBestemming;
        private string _nieuwBestemmingtype;
        private string _foutmeldingBestemming;

        public ObservableCollection<Bestemmingstype> BestemmingsTypes
        {
            get { return _bestemmingsTypes; }
            set
            {
                _bestemmingsTypes = value;
                NotifyPropertyChanged();
            }
        }

        public Bestemmingstype SelectedBestemmingsType
        {
            get { return _selectedBestemmingsTypes; }
            set
            {
                _selectedBestemmingsTypes = value;
                NotifyPropertyChanged();
            }
        }

        public Bestemming BestemmingRecord
        {
            get { return _bestemmingRecord; }
            set
            {
                _bestemmingRecord = value;
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<Bestemming> Bestemmingen
        {
            get { return _bestemmingen; }
            set
            {
                _bestemmingen = value;
                NotifyPropertyChanged();
            }
        }

        public Bestemming SelectedBestemming
        {
            get { return _selectedBestemming; }
            set
            {
                _selectedBestemming = value;
                NotifyPropertyChanged();
            }
        }

        public string NieuwBestemmingtype
        {
            get { return _nieuwBestemmingtype; }
            set
            {
                _nieuwBestemmingtype = value;
                NotifyPropertyChanged();
            }
        }

        public string FoutmeldingBestemming
        {
            get { return _foutmeldingBestemming; }
            set
            {
                _foutmeldingBestemming = value;
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
                case "MaakBestemming": return true;
                case "UpdateBestemming": return true;
                case "VeldenLeegmaken": return true;
                case "BestemmingstypeToevoegen": return true;
            }
            return true;
        }

        public override void Execute(object parameter)
        {
            switch (parameter.ToString())
            {
                case "MaakBestemming": MaakBestemming(); break;
                case "UpdateBestemming": UpdateBestemming(); break;
                case "VeldenLeegmaken": VeldenLeegmaken(); break;
                case "BestemmingstypeToevoegen": BestemmingstypeToevoegen(); break;
            }
        }

        public void MaakBestemming() { }
        public void UpdateBestemming() { }
        public void VeldenLeegmaken() { }
        public void BestemmingstypeToevoegen() { }
    }
}
