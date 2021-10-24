using System;
using System.Collections.Generic;
using System.Linq;

namespace ChoixFiliere
{

    class Program
    {
        static void Main(string[] args)
        {

            Etudiant etd = new Etudiant();
            Option opt = new Option();
            etd.setnbE();
            etd.setListE();
            opt.range();
            etd.setPetud();
            List<string> libre = new List<string>();

            for (int i = 0; i < etd.getnbE(); i++)
            {


                libre.Add(etd.nom[i]);

            }

            string[,] res = new string[etd.getnbE(), 2];
            opt.setABD(20);
            int ABD = opt.getABD();
            opt.setGL(20);
            int GL = opt.getGL();
            opt.setASR(20);
            int ASR = opt.getASR();

            int a = 0;
            int b;
            int c = 0;
            int d = 0;
            int e = 0;
            while (libre.Any())
            {
                b = 0;
                for (int i = 1; i < 4; i++)
                {
                    if (etd.Petud[c, i] == "abd" && ABD != 0)
                    {
                        res[a, b] = etd.Petud[e, 0];
                        b++;
                        res[a, b] = etd.Petud[a, i];
                        ABD--;
                        i = 4;





                    }
                    else if (etd.Petud[c, i] == "gl" && GL != 0)
                    {
                        res[a, b] = etd.Petud[e, 0];
                        b++;
                        res[a, b] = etd.Petud[a, i];
                        GL--;
                        i = 4;

                    }
                    else if (etd.Petud[c, i] == "asr" && ASR != 0)
                    {
                        res[a, b] = etd.Petud[e, 0];
                        b++;
                        res[a, b] = etd.Petud[a, i];
                        ASR--;
                        i = 4;

                    }




                }

                a++;

                libre.Remove(etd.nom[d]);
                d++;
                e++;

            }
            for (int i = 0; i < etd.getnbE(); i++)

            {
                Console.Write(res[i, 0] + "\t");
                Console.Write(res[i, 1]);
                Console.WriteLine(" ");
            }

            Console.ReadKey();
        }
    }
}
