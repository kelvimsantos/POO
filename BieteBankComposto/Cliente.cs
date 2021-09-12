using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BieteBankComposto
{
    public class Cliente
    {
        private string nome;
        private string CPF;
        private string profissao;



        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return nome;
        }
    

    public void setCpf(string CPF)
        {
            this.CPF = CPF;
        }
        public string getCPF()
        {
            return this.CPF;
        }



        public void setProfissao(string profissao)
        {
            this.profissao = profissao;
        }
        public string getProfissao()
        {
            return this.profissao;
        }
    }


}
