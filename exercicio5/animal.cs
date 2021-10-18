using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio5a
{
    public class animal
    {
        private string nome;
        private string tipo;

        public string nomeAnimal
        {
            get { return nome; }
            set { nome = value; }
        }

        public string tipoAnimal
        {
            get { return tipo; }
            set {
                if(value == "cachorro" || value == "gato" || value == "peixe")
                {
                    tipo = value;
                }else
                     {
                         tipo = "peixe";
                     }
            }
        }
        
    }
}
