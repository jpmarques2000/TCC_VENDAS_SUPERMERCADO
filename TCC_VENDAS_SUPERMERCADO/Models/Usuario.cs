﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TCC_VENDAS_SUPERMERCADO.Models
{
    public class Usuario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string dataNascimento { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        //Verificar possibilidade de criar uma classe para enderecos
        public string cep { get; set; }
        public string rua { get; set; }
        public string bairro { get; set; }
        public string numero { get; set; }

        public class ResultadoLogin
        {
            public Usuario usuario { get; set; }

        }

    }
}
