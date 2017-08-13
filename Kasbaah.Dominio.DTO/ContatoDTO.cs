using System.Collections.Generic;

namespace Kasbaah.Dominio.DTO
{
	class ContatoDTO
	{
		public int contatoId { get; set; }
		public int usuarioId { get; set; }
		public string tipo { get; set; }	
		List<TelefoneDTO> telefones { get; set; }
	}
}
