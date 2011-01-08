using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Folha_de_Ponto.Dominio
{
    public class Cliente
    {
        public String Telefone;
        private String _telefone
        {
            get
            {
                return _telefone;
            }
            set 
            {
            
            }
        }
        private String _nome;
        public String Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (String.IsNullOrEmpty(value)) throw new Exception("Nome do Cliente não pode ser vazio");
                _nome = value;
            }
        }

        public Cliente(String nome_do_cliente)
        {
            Nome = nome_do_cliente;
        }
    }
}
