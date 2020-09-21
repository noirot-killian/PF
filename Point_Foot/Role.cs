using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Foot
{
    public class Role
    {
        // attributs
        private int idRole;
        private string libelle;
        private List<Profil> profils;

        // constructeurs
        public Role() { }

        public Role(int unId, string unLibelle)
        {
            this.idRole = unId;
            this.libelle = unLibelle;
            this.profils = new List<Profil>();
        }
        public Role(string unLibelle)
        {
            this.idRole = 0;
            this.libelle = unLibelle;
            this.profils = new List<Profil>();
        }

        // getters
        public int getIdRole()
        {
            return this.idRole;
        }
        public string getLibelle()
        {
            return this.libelle;
        }
        public List<Profil> getProfils()
        {
            return this.profils;
        }

        // setters
        public void setIdRole(int newIdRole)
        {
            this.idRole = newIdRole;
        }
        public void setLibelle(string newLibelle)
        {
            this.libelle = newLibelle;
        }
        public void setProfils(List<Profil> newProfils)
        {
            this.profils = newProfils;
        }
    }
}
