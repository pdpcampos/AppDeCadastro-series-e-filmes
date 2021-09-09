using System;

namespace DIO.series
{
    class Program
    {
        static serieRepositorio repositorio = new serieRepositorio();
        static void Main(string[] args)
        {
           string opcaoUsuario = ObterOpcaoUsuario();
           while (opcaoUsuario.ToUpper() != "x" )
           {
               switch (opcaoUsuario)
               {
                   case "1":
						ListarSeries();
						break;
					case "2":
						InserirSerie();
						break;
					case "3":
						AtualizarSerie();
						break;
					case "4":
						ExcluirSerie();
						break;
					case "5":
						VisualizarSerie();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
               }
               opcaoUsuario = ObterOpcaoUsuario();

           }
           Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
        }

        private static void ExcluirSerie()
        {
            Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			repositorio.exclui(indiceSerie);
        } 
        private static void  VisualizarSerie()
        {
            Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			var serie = repositorio.retornaPorId(indiceSerie);

			Console.WriteLine(serie);
        }   

        private static void  AtualizarSerie ()
        {
            Console.Write("digite o id da serie");
            int indiceSerie = int.Parse(Console.ReadLine());

			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			foreach (int i in Enum.GetValues(typeof( genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

			Serie atualizaSerie = new Serie(id: indiceSerie,
										genero: (genero)entradaGenero,
										Titulo: entradaTitulo,
										Ano: entradaAno,
										Descricao: entradaDescricao);

			repositorio.atualiza(indiceSerie, atualizaSerie);

        }

        private static void ListarSeries()
        {
            Console.WriteLine("Listar séries");

			var lista = repositorio.lista();

			if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
				return;
            }
              foreach (var serie in lista)
              {
                Console.WriteLine("#ID {0}: - {1} " , serie.retornaId(), serie.retornaTitulo());  
            }       
        }
        private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");

			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			foreach (int i in Enum.GetValues(typeof(genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

			Serie novaSerie = new Serie(id: repositorio.proximoId(),
										genero: (genero)entradaGenero,
										Titulo: entradaTitulo,
										Ano: entradaAno,
										Descricao: entradaDescricao);

			repositorio.insere(novaSerie);
        }
        



         
        
         private static string  ObterOpcaoUsuario() 
        {
            Console.WriteLine();
			Console.WriteLine("DIO Séries a seu dispor!!!");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar séries");
			Console.WriteLine("2- Inserir nova série");
			Console.WriteLine("3- Atualizar série");
			Console.WriteLine("4- Excluir série");
			Console.WriteLine("5- Visualizar série");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
        }
    }
}
