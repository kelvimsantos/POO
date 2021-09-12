using System;

namespace BieteBankComposto
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////cria cliente//////////////////
            Cliente kelvim = new Cliente();
            kelvim.setNome("KELVIM A. Santos");
            kelvim.setCpf("114.098.206-02");
            kelvim.setProfissao( "analista e desenvolvedor Software");
            
            ////////cria conta//////////////////
            Conta contaKelvim = new Conta();
            contaKelvim.setAgencia(031);
            contaKelvim.setNumero(123);
            contaKelvim.setTitular(kelvim); //aqui é feita a ligação de cliente a variavel titular do tipo cliente por meio de referencia.
            //=---------------------------=------------------------=

            Console.WriteLine(contaKelvim.getTitular().getNome());//quando ficou privado não tem mais como acessar o a referencia de cliente dentro da classe,deve ser diretamente
            Console.WriteLine(contaKelvim.getTitular().getNome());//acesso por meio de metodos e não atributos,agora que eles estao privados
         
            contaKelvim.depositar(100);

            ///////////////////////////
            //outra forma de criar um cliente dentro ja da conta
            //mais rapido de ser criada ,mas  demora mais se voce quiser acessar ela pq não temreferencia
           
            Conta contaMax = new Conta();

            //contaMax.titular = new Cliente();
           

            //contaMax.titular.nome = "maxwell A. Santos";
            Cliente max = new Cliente();
            contaMax.setTitular(max);  //agora que os atributos estao privados acessamos metodos e não mais atributos
            Console.WriteLine(contaMax.getTitular().getNome());
            //----------------------------------------------------------------------

            //ou usando da outra maneira o titular voce criaria  uma referencia 
            //ao criar um titular dessa forma voce cria uma referencia para titular
            //mais demorado de criar , mas é mais rapido para acessar por que tem a referencia que seria um atalho

            contaMax.getSaldo();

            //////////////////////////////
            ///
        }
    }
}
