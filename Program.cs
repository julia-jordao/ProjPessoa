using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PExerc_
{
    internal class Pessoa
    {
        String nome, data, cpf, numero;

        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public void setData(String data)
        {
            this.data = data;
        }
        public void setDoc(String cpf)
        {
            this.cpf = cpf;
        }
        public void setNumero(String numero)
        {
            this.numero = numero;
        }
        public string getNome()
        {
            return nome;
        }
        public string getData()
        {
            return data;
        }
        public string getDoc()
        {
            return cpf;
        }
        public string getNumero()
        {
            return numero;
        }
    }
}
