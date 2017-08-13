using System;

namespace Kasbaah.Dominio.Entidade
{
	public class Usuario
    {
		public int UsuarioId { get; set; }
		public string Email { get; set; }
		public string Senha { get; set; }
		public string Nome { get; set; }
        public string Sobrenome { get; set; }
		public string Profissao { get; set; }
		public DateTime DataNascimento { get; set; }
		public int Sexo { get; set; }
        public DateTime DataCadastro { get; set; }
		public int TipoUsuario { get; set; }
		public bool Ativo { get; set; }
	}
}
