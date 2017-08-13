using System;
using Kasbaah.Dominio.Entidade;
using Kasbaah.Dominio.Interface;

namespace Kasbaah.Repositorio
{
	public class UsuarioRepositorio : IUsuarioRepositorio
	{
		public int Inserirsuario(Usuario usuario)
		{
			throw new NotImplementedException();
		}

		#region[CONSTANTES]
		private const string INSERIR_USUARIO = @"
			INSERT INTO Usuario(
				UsuarioId,
			    Email,
			    Senha
       			Nome
				Sobrenome
			    Profissao
				DataNascimento
				Sexo
			    DataCadastro
			    TipoUsuario
			    Ativo)
			VALUES(
				UsuarioId,
				Email,
				Senha,
				Nome,
				Sobrenome,
				Profissao,
				DataNascimento,
				Sexo,
				DataCadastro,
				TipoUsuario,
				Ativo)";
		#endregion
	}
}
