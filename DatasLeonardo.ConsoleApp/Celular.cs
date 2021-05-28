using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatasLeonardo
{
    public class Celular
    {
        public string Traducao { get; private set; }
        List<Char> lista = new List<char>();
        public Celular()
        {
            
        }
        public Celular(string valorTraduzir)
        {
            Traducao = "";
            PreencherListaComValores(valorTraduzir);
            CriarCodigo();
        }

        private void CriarCodigo()
        {
            int aux = 99;
            for (int i = 0; i < lista.Count; i++)
            {
                if (GruposLista(lista[i]) == aux)
                {
                    Traducao += "_";
                }

                Traducao += PegarNumeroDesejado(lista[i]);
                aux = GruposLista( lista[i]);
            }
        }
        private int GruposLista(char identificador)
        {
            if (identificador == 'A' || identificador == 'B' || identificador == 'C')
            {
                return 0;
            }
            else if (identificador == 'D' || identificador == 'E' || identificador == 'F')
            {
                return 1;
            }
            else if (identificador == 'G' || identificador == 'H' || identificador == 'I')
            {
                return 2;
            }
            else if (identificador == 'J' || identificador == 'K' || identificador == 'L')
            {
                return 3;
            }
            else if (identificador == 'M' || identificador == 'N' || identificador == 'O')
            {
                return 4;
            }
            else if (identificador == 'P' || identificador == 'Q' || identificador == 'R' || identificador == 'S')
            {
                return 5;
            }
            else if (identificador == 'T' || identificador == 'U' || identificador == 'V')
            {
                return 6;
            }
            else if (identificador == 'W' || identificador == 'X' || identificador == 'Y' || identificador == 'Z')
            {
                return 7;
            }
            else return 8;
        }

        private string PegarNumeroDesejado(char identificador)
        {
            switch (identificador)
            {
                case 'A': return "2";
                case 'B': return "22";
                case 'C': return "222";
                case 'D': return "3";
                case 'E': return "33";
                case 'F': return "333";
                case 'G': return "4";
                case 'H': return "44";
                case 'I': return "444";
                case 'J': return "5";
                case 'K': return "55";
                case 'L': return "555";
                case 'M': return "6";
                case 'N': return "66";
                case 'O': return "666";
                case 'P': return "7";
                case 'Q': return "77";
                case 'R': return "777";
                case 'S': return "7777";
                case 'T': return "8";
                case 'U': return "88";
                case 'V': return "888";
                case 'W': return "9";
                case 'X': return "99";
                case 'Y': return "999";
                case 'Z': return "9999";
                case ' ': return "0";
                default: return "@";
            }
        }

        private void PreencherListaComValores(string aux)
        {
            if (aux.Length <= 255)
            {
                for (int i = 0; i < aux.Length; i++)
                {
                    lista.Add(Convert.ToChar(aux.Substring(i, 1).ToUpper() ));
                }
            }
            else Traducao += "Valor Muito grande";
        }
    }
}