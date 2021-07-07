using System;

namespace sorteioGrupoVersao1
{
	public class Program
	{
		public static void Main()
		{
			string[] alunos = new string[] { "Aluno1","Aluno2", "Aluno3", "Aluno4", "Aluno5", "Aluno6", "Aluno7", "Aluno8",
												"Aluno9", "Aluno10", "Aluno11", "Aluno12", "Aluno13", "Aluno14", "Aluno15",
													"Aluno16", "Aluno17", "Aluno18", "Aluno19", "Aluno20" };

			Random sorteio = new Random();
			for (int i = 0; i < alunos.Length - 1; i++)
			{
				int j = sorteio.Next(i, alunos.Length);
				var temp = alunos[i];
				alunos[i] = alunos[j];
				alunos[j] = temp;
			}

			int y = 0, grupo = 1;
			foreach (string x in alunos)
			{
				if (y % 4 == 0)
				{
					Console.WriteLine("\n\nGrupo " + grupo + ":");
					grupo++;
				}
				Console.WriteLine(" > " + x);
				y++;
			}
		}
	}
}
