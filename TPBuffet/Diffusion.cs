using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPBuffet
{
      public abstract class Diffusion
    {


        protected String titre;
        protected int annee;

        public Diffusion(string titre, int annee)
        {
            this.titre = titre;
            this.annee = annee;
        }

        public string getTitre()
        {
            return this.titre;

        }

        public int getAnnee()
        {

            return this.annee;

        }
        public abstract String getInfos();
    }

    public class Film : Diffusion
    {

        private int recette;

        public Film(int recette, String titre, int annee) : base(titre, annee)
        {
            this.recette = recette;
        }

        public override string getInfos()
        {
            return base.annee + " " + base.titre + "(recette " + this.recette + ")";
        }
        

            public int getRecette()
        {
            return this.recette;
        }
    }


    public class Serie : Diffusion
    {
        private int nbEpisodes;

        public Serie(int nbEpisodes, String titre, int annee) : base(titre, annee)
        {
            this.nbEpisodes = nbEpisodes;
        }

        public int getEpisodes()
        {
            return this.nbEpisodes;
        }

             public override string getInfos()
        {
            return base.annee + " " + base.titre + "(nb Episodes " + this.nbEpisodes + ")";
        }
    } 
    
}

