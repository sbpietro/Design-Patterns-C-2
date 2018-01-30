using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using ConsoleApp1.Cap2;
using ConsoleApp1.Cap3;
using ConsoleApp1.Cap4;
using ConsoleApp1.Cap5;
using ConsoleApp1.Cap6;
using ConsoleApp1.Cap7;
using ConsoleApp1.Cap8;
using System.Xml.Serialization;
using System.IO;
using ConsoleApp1.Cap9;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Capitulo 2

            //NotasMusicais notasMusicais = new NotasMusicais();
            //IList<INota> musica = new List<INota>()
            //{
            //    notasMusicais.Pega("do"),
            //    notasMusicais.Pega("re"),
            //    notasMusicais.Pega("mi"),
            //    notasMusicais.Pega("fa"),
            //    notasMusicais.Pega("sol"),
            //    notasMusicais.Pega("fa"),
            //};
            //Piano piano = new Piano();
            //piano.Toca(musica);

            #endregion

            #region Capitulo 3

            //Historico historico = new Historico();

            //Contrato c = new Contrato(DateTime.Now, "Stefano", TipoContrato.Novo);
            //historico.Adiciona(c.SalvaEstado());
            //c.Avanca();
            //historico.Adiciona(c.SalvaEstado());
            //c.Avanca();
            //historico.Adiciona(c.SalvaEstado());
            //Console.WriteLine(c.Tipo);
            //Console.WriteLine(historico.Pega(2).Contrato.Tipo);

            #endregion

            #region Capitulo 4

            //IExpressao esquerda = new Soma(new Soma(new Numero(1), new Numero(100)), new Numero(10));
            //IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            //IExpressao soma = new Soma(esquerda, direita);

            //Console.WriteLine(soma.Avalia());

            //Expression soma = Expression.Add(Expression.Constant(10), Expression.Constant(100));
            //Func<int> funcao = Expression.Lambda<Func<int>>(soma).Compile();
            //Console.WriteLine(funcao());

            #endregion

            #region Capitulo 5

            //
            //IExpressao esquerda = new Soma(new Soma(new Numero(1), new Numero(100)), new Numero(10));
            //IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            //IExpressao soma = new Soma(esquerda, direita);

            //Console.WriteLine(soma.Avalia());
            //ImpressoraVisitor impressora = new ImpressoraVisitor();
            //soma.Aceita(impressora);


            #endregion

            #region Capitulo 6

            //BRIDGES
            //IMensagem mensagem = new MensagemCliente("Stefano");
            //IEnviador enviador = new EnviaPorEmail();
            //mensagem.Enviador = enviador;
            //mensagem.Envia();

            #endregion

            #region Capitulo 7

            //COMMAND
            //FilaDeTrabalho fila = new FilaDeTrabalho();
            //Pedido pedido1 = new Pedido("Stefano", 50.0);
            //Pedido pedido2 = new Pedido("Mike", 25.0);
            //fila.Adiciona(new PagaPedido(pedido1));
            //fila.Adiciona(new PagaPedido(pedido2));

            //fila.Adiciona(new FinalizaPedido(pedido1));

            //fila.Processa();

            #endregion

            #region Capitulo 8

            //ADAPTER
            //Cliente cliente = new Cliente();
            //cliente.Nome = "Stefano";
            //cliente.Endereco = "Rua Junquilhos";
            //cliente.DataNascimento = DateTime.Now;

            //String xml = new GeradorDeXML().GeraXml(cliente);
            //Console.WriteLine(xml);

            #endregion

            #region Capitulo 9

            //facade
            //String cpf = "01920044680";
            //EmpresaFacade facade = new EmpresaFacadeSingleton().Instancia;

            //Cliente cliente = facade.BuscaCliente(cpf);

            //var fatura = facade.CriaFatura(cliente, 400);
            //facade.GeraCobranca(tipo.Boleto, fatura);

            #endregion

        }
    }
}
