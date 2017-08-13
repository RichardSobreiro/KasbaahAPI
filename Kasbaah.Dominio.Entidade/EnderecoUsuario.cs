using System;

namespace Kasbaah.Dominio.Entidade
{
	public class EnderecoUsuario
	{
		public int EnderecoId { get; set; }
		public int UsuarioId { get; set; }
		public string TipoLogradouro { get; set; }
		public string Logradouro { get; set; }
		public int Numero { get; set; }
		public string Bairro { get; set; }
		public string Cidade { get; set; }
		public string Estado { get; set; }
		public string Pais { get; set; }
        public bool Ativo { set; get; }
	}
}
