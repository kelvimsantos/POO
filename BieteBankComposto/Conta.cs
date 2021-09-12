using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BieteBankComposto
{
    class Conta
    {
        private double saldo;
        private int agencia;
        private int numero;
        private Cliente titular;

        //poderia criar o cliente de uma vez
        //" public Cliente titular =  new Cliente();"
        //assim ao criar conta ja teria 1 cliente criado

        //=====================================================
        public void depositar(double valor)
        {
            this.saldo += valor;
            Console.WriteLine("o valor depositado foi de R$" + valor);
            Console.WriteLine("o saldo atual : R$" + saldo);
        }
        //=====================================================
        public bool sacar(double valor) 
        {
            if ( this.saldo >= valor)
            {

                Console.WriteLine("seu saldo era de R$" + saldo);
                    this.saldo -= valor;
                Console.WriteLine("voce sacou R$" + valor);
                Console.WriteLine("seu saldo atual é de R$" + saldo);
                return true; 
            }
            else
            {
                Console.WriteLine("você não tem essa quantia ,seu saldo é R$" + saldo);
                return false; }
        }
        //=====================================================
        public bool transferir(double valor, Conta destino)
        {
            if (valor < saldo) 
            {
                this.saldo -= valor;
                destino.depositar(valor);
                Console.WriteLine("o valor R$" + valor + " foi transferido");
                Console.WriteLine("seu saldo atual agora é de  R$" + saldo + " !");
                return true;
            }
            //else
            Console.WriteLine("sem saldo suficiente , saldo de RS" + saldo);
            return false;
        }
        //=====================================================
        public double getSaldo()
        {
            Console.WriteLine("seu saldo é de R$" + this.saldo);
            return this.saldo;
        }

        //=====================================================
        public int getNumero()
        {
            Console.WriteLine("seu numero é " + this.numero);
            return this.numero;
        }
        //----------------------------------------
        public void setNumero(int num)
        {
            if (num > 0)
            {
                Console.WriteLine("seu novo numero é é de R$" + num);
                this.numero = num;
            }
            else { Console.WriteLine("impossivel inserir esse tipo de numero"); }

            //possivel fazer a validação aqui dentro mesmo ,  se existe numero da conta dentro de um banco
        }


        //========================================================
        public int getAgencia()
        {
            Console.WriteLine("sua agencia é " + this.agencia);
            return this.agencia;
        }
        //----------------------------------------
        public void setAgencia(int ag)
        {
            if (ag > 0)
            {
                Console.WriteLine("seu novo numero é é de R$" + this.agencia);
            
            this.agencia = ag;
            }
            else { Console.WriteLine("impossivel inserir esse tipo de numero de agencia"); }

            //possivel fazer a validação aqui dentro mesmo ,  se existe numero da conta dentro de um banco
        }
        
        //========================================================

        public void setTitular(Cliente titular) 
        {
            this.titular = titular;
        }

        public Cliente getTitular() 
        {
            return titular; ;
        }
    }
}
