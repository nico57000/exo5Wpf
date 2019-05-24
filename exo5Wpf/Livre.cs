using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace exo5Wpf
{
    [DataContract]
    class Livre : INotifyPropertyChanged
    {
        private string _auteur;
        private string _titre;
        private DateTime _Annee;
        private string _resum;

        public event PropertyChangedEventHandler PropertyChanged;

        [DataMember]
        public string Auteur
        {
            get { return _auteur; }
            set {
                if (this._auteur != value)
                {
                    this._auteur = value;
                    this.NotifyPropertyChanged("Auteur");
                }
                _auteur = value; }
        }

        
        [DataMember]
        public string Titre
        {
            get { return _titre; }
            set {
                if (this._titre != value)
                {
                    this._titre = value;
                    this.NotifyPropertyChanged("Titre");
                }
                _titre = value; }
        }


        [DataMember]
        public DateTime annee
        {
            get { return _Annee; }
            set {
                if (this._Annee != value)
                {
                    this._Annee = value;
                    this.NotifyPropertyChanged("annee");
                }
                _Annee = value; }
        }



        [DataMember]
        public string Resum
        {
            get { return _resum; }
            set {
                if (this._resum != value)
                {
                    this._resum = value;
                    this.NotifyPropertyChanged("Resum");
                }
                _resum = value; }
        }



        public Livre(string auteur, string titre, DateTime annee)
        {
            Auteur = auteur;
            Titre = titre;
            this.annee = annee;
            Resum = "Post haec indumentum regale quaerebatur et ministris fucandae purpurae tortis confessisque pectoralem tuniculam sine manicis textam, Maras nomine quidam inductus est ut appellant Christiani diaconus, cuius prolatae litterae scriptae Graeco sermone ad Tyrii textrini praepositum celerari speciem perurgebant quam autem non indicabant denique etiam idem ad usque discrimen vitae vexatus nihil fateri conpulsus est.";
        }

        public Livre()
        {
            Resum = "Post haec indumentum regale quaerebatur et ministris fucandae purpurae tortis confessisque pectoralem tuniculam sine manicis textam, Maras nomine quidam inductus est ut appellant Christiani diaconus, cuius prolatae litterae scriptae Graeco sermone ad Tyrii textrini praepositum celerari speciem perurgebant quam autem non indicabant denique etiam idem ad usque discrimen vitae vexatus nihil fateri conpulsus est.";
        }

        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

    }
    
}
