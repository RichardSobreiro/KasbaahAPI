using System;

namespace Kasbaah.Dominio.Entidade
{
	public class Contato
	{
		public int ContatoId { get; set; }
		public int UsuarioId { get; set; }
		public int Tipo { get; set; }
		public DateTime DataCadastro { get; set; }
		public bool Ativo { get; set; }
	}
}
