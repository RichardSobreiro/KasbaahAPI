using System;
using System.Collections.Generic;

namespace Kasbaah.Dominio.DTO
{
	public class UsuarioDTO
    {
		public int usuarioId { get; set; }
		public string email { get; set; }
		public string senha { get; set; }
		public string nome { get; set; }
		public string sobrenome { get; set; }
		public string profissao { get; set; }
		public DateTime dataNascimento { get; set; }
		public string sexo { get; set; }
		public DateTime dataCadastro { get; set; }

		EnderecoUsuarioDTO endereco { get; set; }
		ContatoDTO contato { get; set; }
	}
}
