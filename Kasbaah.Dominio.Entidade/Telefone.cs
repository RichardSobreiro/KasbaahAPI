using System;

namespace Kasbaah.Dominio.Entidade
{
	public class Telefone
	{
		public int TelefoneId { get; set; }
		public int ContatoId { get; set; }
		public string Numero { get; set; }
		public string CodigoArea { get; set; }
		public string CodigoInternacional { get; set; }
		public int Tipo { get; set; }
		public DateTime DataCadastro { get; set; }
		public bool Ativo { get; set; }
	}
}
