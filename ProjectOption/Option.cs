using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOption
{
    class Option
    {
        int nbA; 
        int nbG; 
        int nbR; 


        public void  setnbA(int nbA)

        {
            this.nbA = nbA;


        }
        public void setnbG(int nbG)
        {


            this.nbG = nbG;

        }
       public  void setnbR(int nbR)
        {


            this.nbR = nbR;

        }

        public int getnbA()
        { return nbA; }
        public int getnbG()
        { return nbG; }
        public int getnbR()
        { return nbR; }


        Etudiant etd = new Etudiant();
        
        
        public void range()
        {
            for (int i = etd.getnbE() - 1; i >= 1; i--)
                for (int j = 2; j <= i; j++)
                {


                    int tempNote = etd.note[j - 1];
                    etd.note[j - 1] = etd.note[j];
                    etd.note[j] = tempNote;



                    string tempNom = etd.nom[j - 1];
                    etd.nom[j - 1] = etd.nom[j];
                    etd.nom[j] = tempNom;

                }
        }
         



         





















        }
}
