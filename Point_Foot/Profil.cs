using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Foot
{
    public class Profil
    {
        // attributs
        private int idProfil;
        private string nom;
        private string prenom;
        private DateTime dateNaiss;
        private string mail;
        private string pseudo;
        private string mdp;
        private int score;
        private List<Role> roles;

        // constructeurs
        public Profil() { }

        public Profil(int unId, string unNom, string unPrenom, DateTime uneDateNaiss, string unMail, string unPseudo, string unMdp, int unScore)
        {
            this.idProfil = unId;
            this.nom = unNom;
            this.prenom = unPrenom;
            this.dateNaiss = uneDateNaiss;
            this.mail = unMail;
            this.pseudo = unPseudo;
            this.mdp = unMdp;
            this.score = unScore;
            this.roles = new List<Role>();
        }
        public Profil(string unNom, string unPrenom, DateTime uneDateNaiss, string unMail, string unPseudo, string unMdp, int unScore)
        {
            this.idProfil = 0;
            this.nom = unNom;
            this.prenom = unPrenom;
            this.dateNaiss = uneDateNaiss;
            this.mail = unMail;
            this.pseudo = unPseudo;
            this.mdp = unMdp;
            this.score = unScore;
            this.roles = new List<Role>();
        }

        // getters
        public int getIdProfil()
        {
            return this.idProfil;
        }
        public string getNom()
        {
            return this.nom;
        }
        public string getPrenom()
        {
            return this.prenom;
        }
        public DateTime getDateNaiss()
        {
            return this.dateNaiss;
        }
        public string getMail()
        {
            return this.mail;
        }
        public string getPseudo()
        {
            return this.pseudo;
        }
        public string getMdp()
        {
            return this.mdp;
        }
        public int getScore()
        {
            return this.score;
        }
        public List<Role> getRoles()
        {
            return this.roles;
        }

        // setters
        public void setIdProfil(int newIdProfil)
        {
            this.idProfil = newIdProfil;
        }
        public void setNom(string newNom)
        {
            this.nom = newNom;
        }
        public void setPrenom(string newPrenom)
        {
            this.prenom = newPrenom;
        }
        public void setDateNaiss(DateTime newDateNaiss)
        {
            this.dateNaiss = newDateNaiss;
        }
        public void setMail(string newMail)
        {
            this.mail = newMail;
        }
        public void setPseudo(string newPseudo)
        {
            this.pseudo = newPseudo;
        }
        public void setMdp(string newMdp)
        {
            this.mdp = newMdp;
        }
        public void setScore(int newScore)
        {
            this.score = newScore;
        }
        public void setRoles(List<Role> newRoles)
        {
            this.roles = newRoles;
        }

        // Autres méthodes
        public string afficherProfil()
        {
            return this.idProfil + "\n" + this.nom + "\n" + this.prenom + "\n" + this.dateNaiss + "\n" + this.mail + "\n" + this.pseudo + "\n" + this.mdp + "\n" + this.score;
        }
        public override string ToString()
        {
            return this.nom;
        }
    }
}
