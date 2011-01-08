using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Folha_de_Ponto.Dominio;

namespace Folha_de_Ponto.Teste
{
    [TestClass]
    public class Dado_Um_Cliente
    {
        [TestMethod]
        public void não_pode_criar_cliente_sem_nome()
        {
            String nome_do_cliente = "Grupo de Estudos";
            Cliente cliente = new Cliente(nome_do_cliente);
            Assert.AreEqual(nome_do_cliente, cliente.Nome);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void nome_do_cliente_não_pode_ser_vazio()
        {
            String nome_do_cliente = "";
            Cliente cliente = new Cliente(nome_do_cliente);
        }
        [TestMethod]
        public void posso_informar_telefone_do_cliente()
        {
            String telefone_do_cliente = "555555555555555555555555";
            Cliente cliente = new Cliente("o");
            cliente.Telefone = telefone_do_cliente;
            Assert.AreEqual(telefone_do_cliente,cliente.Telefone);
        }
   
    }
}
