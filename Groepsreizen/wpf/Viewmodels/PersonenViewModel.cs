using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using models;

namespace wpf.ViewModels
{
    public class PersonenViewModel : BaseViewModel
    {
        private string _naamPersoon;
        private ObservableCollection<Gebruiker> _personen;
        private Gebruiker _persoon;
        private Gebruiker _persoonRecord;
        private string _foutmeldingPersonen;

        public string NaamPersoon 
        {
            get { return _naamPersoon; }
            set
            {
                _naamPersoon = value;
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<Gebruiker> Personen
        {
            get { return _personen; }
            set
            {
                _personen = value;
                NotifyPropertyChanged();
            }
        }

        public Gebruiker Persoon
        {
            get { return _persoon; }
            set
            {
                _persoon = value;
                NotifyPropertyChanged();
            }
        }

        public Gebruiker PersoonRecord
        {
            get { return _persoonRecord; }
            set
            {
                _persoonRecord = value;
                NotifyPropertyChanged();
            }
        }

        public string FoutmeldingPersonen
        {
            get { return _foutmeldingPersonen; }
            set
            {
                _foutmeldingPersonen = value;
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
                case "PersoonAanmaken": return true;
                case "PersoonAanpassen": return true;
                case "PersoonVerwijderen": return true;
                case "FormulierLeegmaken": return true;
            }
            return true;
        }

        public override void Execute(object parameter)
        {
            switch (parameter.ToString())
            {
                case "PersoonAanmaken": PersoonAanmaken(); break;
                case "PersoonAanpassen": PersoonAanpassen(); break;
                case "PersoonVerwijderen": PersoonVerwijderen(); break;
                case "FormulierLeegmaken": FormulierLeegmaken(); break;
            }
        }

        public void PersoonAanmaken() { }
        public void PersoonAanpassen() { }
        public void PersoonVerwijderen() { }
        public void FormulierLeegmaken() { }
    }
}
