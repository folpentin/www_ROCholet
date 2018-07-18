using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace www_ROCholet.Models.BoutiqueModels
{
    public class ProduitModels
    {
        public int IdProduit;
        public string RefProduit;
        public string NomProduit;
        public string ColorisProduit;
        public string DescriptionProduit;
        public double PrixProduit;
        public double PrixProduitEnfant;
        public string ImageProduit;
        public int IdCategorie;
        public bool Nouveaute;
        public int Promotions;
    }
}