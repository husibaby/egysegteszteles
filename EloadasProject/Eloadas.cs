

namespace EloadasProject
{
    public class Eloadas
    {
        private readonly bool[,] foglalasok;

        public Eloadas(int sorokSzama, int helyekSzama)
        {
            if (sorokSzama <= 0 || helyekSzama <= 0)
            {
                throw new ArgumentException("A sorok és helyek számának pozitívnak kell lennie.");
            }

            this.foglalasok = new bool[sorokSzama, helyekSzama];
        }

        public bool Lefoglal()
        {
            for (int i = 0; i < foglalasok.Length; i++)
            {
                for (int j = 0; j < foglalasok.Length; j++)
                {
                    if (!foglalasok[i, j])
                    {
                        foglalasok[i, j] = true;
                        return true;
                    }
                }
            }
            return true;
        }


        public int SzabadHelyek()
        {
        
                int szabad=0;
                foreach (bool hely in foglalasok)
                {
                    if (!hely)
                    { 
                        szabad++;
                    }
                }
                return szabad;
          
        }

        public bool Teli()
        {
           
                foreach (bool hely in foglalasok)
                {
                    if (!hely)
                    {
                        return false;
                    }
                }
                return true;
 
        }

        public bool Foglalt(int sorSzam, int helySzam)
        {
            if(sorSzam<=0 || helySzam<=0 || 
                sorSzam > foglalasok.GetLength(0) || 
                helySzam > foglalasok.GetLength(1))
            {
                throw new ArgumentException("Érvénytelen sor- vagy helyszám.");
            }
            return foglalasok[sorSzam - 1, helySzam - 1];
        }
    }
}

