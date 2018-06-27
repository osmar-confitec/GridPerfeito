using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace WebSite1
{
    /// <summary>
    /// Descrição resumida de Clientes
    /// </summary>

    /// 
    public class Clientes
    {

        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public Clientes()
        {
            Id = Guid.NewGuid();
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }

}