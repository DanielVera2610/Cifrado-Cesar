using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CifradoCesar
{
    class Cesar
    {
        private string _strMcla; //Cadena, mensaje en clave 

        public string Mcla
        {
            get { return _strMcla; }
            set { _strMcla = value; }

        }

        private int _intLlave;

        public int Llave
        {
            get { return _intLlave; }
            set { _intLlave = value; }
        }

        char[] Ingles;
        public Cesar()
        {
            //Alfabeto en inglés
            Ingles = new char[] {'A','B','C','D','E','F','G','H','I','J','K','L','M','N'
                ,'O','P','Q','R','S','T','U','V','W','X','Y','Z'};
        }
        public string Cifrar_Descifrar(int [,] M, bool bandera)
        {
            string resultado = "";
            //Obtención del equivalente numerico correspondiente
            for (int i = 0; i < Mcla.Length; i++)
            {
                M[0, i] = Array.IndexOf(Ingles, Mcla[i]); //Agrega las equivalencias en la primera fila
                M[1, i] = Llave; //Agrega la llave fija en la segunda fila
            }

            //Recorre la matriz y realiza los calculos correspondientes
            for (int col = 0; col < M.GetLength(1); col++)
            {
                if (bandera)
                {
                    M[2, col] = M[0, col] + M[1, col]; //Suma cada elemento del mensaje en claro con la llave fija 
                }
                else
                {
                    M[2, col] = M[0, col] - M[1, col];
                    if (M[2,col] < 0)
                    {
                        M[2, col] = 26 + M[2, col];
                    }
                }
                M[3, col] = M[2, col] % 26; //Obtiene el modulo de cada elemento de la suma anterior 
                resultado += Ingles.GetValue(M[3,col]); //Se obtiene el cripto correspondiente
            }
            return resultado;
        }
    }
}
