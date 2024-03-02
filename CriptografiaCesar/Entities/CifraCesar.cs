using System;

namespace CriptografiaCesar.Entities
{
    internal class CifraCesar : ICriptografar, IDescriptografar
    {
        private string Texto;
        private int NumeroCaracteres = 0;
        private int Num = 0;
        public string Criptografar(string texto)
        {
            NumeroCaracteres = texto.Length;
            for (int i = 0; i < NumeroCaracteres; i++)
            {
                Num = Convert.ToInt16(texto[i]) + 3;
                Texto += Convert.ToChar(Num);
            }
            return Texto;
        }

        public string Descriptografar(string texto)
        {
            NumeroCaracteres = texto.Length;
            for (int i = 0; i < NumeroCaracteres; i++)
            {
                Num = Convert.ToInt16(texto[i]) - 3;
                Texto += Convert.ToChar(Num);
            }
            return Texto;
        }

        public override string ToString()
        {
            return "O seu texto ficou: " + Texto;
        }
    }
}
