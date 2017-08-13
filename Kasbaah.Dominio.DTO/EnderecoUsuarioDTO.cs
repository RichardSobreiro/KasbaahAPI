namespace Kasbaah.Dominio.DTO
{
	class EnderecoUsuarioDTO
	{
		public int enderecoId { get; set; }
		public int usuarioId { get; set; }
		public string tipoLogradouro { get; set; }
		public string logradouro { get; set; }
		public int numero { get; set; }
		public string bairro { get; set; }
		public string cidade { get; set; }
		public string estado { get; set; }
		public string pais { get; set; }
	}
}
