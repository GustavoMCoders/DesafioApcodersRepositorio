using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace DesafioApcodersRepositorio
{
    class Program
    {

       


        static void Main(string[] args)
        {
            // INSIRA A CONExão do BANCO DE DADOS NAS " " ABAIXO
            SqlConnection conn = new SqlConnection(@" ");
            SqlCommand cmd = new SqlCommand();

            int loop1 = 10;

            while (loop1 == 10)
            {

                Console.WriteLine("O que você deseja fazer? Escolha pelo número");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("1 - Cadastrar Inquilinos");
                Console.WriteLine("2 - Visualizar Inquilinos");
                Console.WriteLine("3 - Cadastrar Unidades");
                Console.WriteLine("4 - Visualizar Unidades");
                Console.WriteLine("5 - Cadastrar Despesas");
                Console.WriteLine("6 - Edição Despesas");
                Console.WriteLine("7 - Visualizar Despesas");
                Console.WriteLine("8 - Sair do Programa");

                int valor1 = Convert.ToInt32(Console.ReadLine());


                if (valor1 == 1)
                {
                    Console.Clear();
                    conn.Open();

                    var inserir = "";
                    Console.WriteLine("DIGITE NOME");
                    string nomeinq = Console.ReadLine();
                    Console.WriteLine("DIGITE IDADE");
                    string idadeinq = Console.ReadLine();
                    Console.WriteLine("DIGITE SEXO");
                    string sexoinq = Console.ReadLine();
                    Console.WriteLine("DIGITE TELEFONE");
                    string telefoneinq = Console.ReadLine();
                    Console.WriteLine("DIGITE EMAIL");
                    string emailinq = Console.ReadLine();
                    Console.Clear();

                    inserir = "INSERT INTO Inquilinos (nomeinquilino, idadeinquilino, sexoinquilino, telefoneinquilino, emailinquilino ) VALUES (@nomeiq, @idadeinq, @sexoinq, @telefoneinq, @emailinq)";

                    conn.Close();

                }

                else if (valor1 == 2)
                {
                    Console.Clear();
                    conn.Open();

                    cmd = new SqlCommand("SELECT * FROM Inquilinos", conn);

                    cmd.ExecuteNonQuery();
                    Console.WriteLine(cmd);


                    conn.Close();

                }

                else if (valor1 == 3)
                {


                    Console.Clear();
                    conn.Open();

                    var inserir3 = "";
                    Console.WriteLine("DIGITE NÚMERO DE IDENTIFICAÇÃO");
                    int idenuni = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("DIGITE PROPRIETÁRIO");
                    string propriuni = Console.ReadLine();
                    Console.WriteLine("DIGITE CONDOMINÍO");
                    string condomuni = Console.ReadLine();
                    Console.WriteLine("DIGITE ENDEREÇO DO CONDOMINÍO");
                    string enderuni = Console.ReadLine();
                    Console.Clear();

                    inserir3 = "INSERT INTO Unidades (identificaçao, proprietario, condominio, endereçocondominio) VALUES (@idenui, @propriuni, @condomuni, @enderuni)";

                    conn.Close();

                }

                else if (valor1 == 4)
                {
                    Console.Clear();
                    conn.Open();

                    cmd = new SqlCommand("SELECT * FROM Unidades", conn);

                    cmd.ExecuteNonQuery();
                    Console.WriteLine(cmd);


                    conn.Close();
                }

                else if (valor1 == 5)
                {
                    Console.Clear();
                    conn.Open();

                    var inserir5 = "";
                    Console.WriteLine("DIGITE DESCRIÇÃO");
                    string descrides = Console.ReadLine();
                    Console.WriteLine("DIGITE TIPO DE DESPESA");
                    string tipodes = Console.ReadLine();
                    Console.WriteLine("DIGITE O VALOR");
                    string valordes = Console.ReadLine();
                    Console.WriteLine("DIGITE A DATA DE VENCIMENTO");
                    string vencides = Console.ReadLine();
                    Console.WriteLine("DIGITE O STATUS DO PAGAMENTO");
                    string statusdes = Console.ReadLine();

                    inserir5 = "INSERT INTO DespesasUnidades (descriçao, tipodespesa, valor, vencimentofatura, statuspagamento ) VALUES (@descrides, @tipodes, @valordes, @vencides, @statusdes)";

                    conn.Close();

                }

                else if (valor1 == 6)
                {

                    Console.WriteLine("Escolha o usúario que deseja alterar");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");

                    Console.Clear();
                    conn.Open();

                    cmd = new SqlCommand("SELECT * FROM DespesasUnidades", conn);

                    cmd.ExecuteNonQuery();
                    Console.WriteLine(cmd);

                    var id = Console.ReadLine();

                    Console.WriteLine("DIGITE DESCRIÇÃO");
                    string descrides2 = Console.ReadLine();
                    Console.WriteLine("DIGITE TIPO DE DESPESA");
                    string tipodes2 = Console.ReadLine();
                    Console.WriteLine("DIGITE O VALOR");
                    string valordes2 = Console.ReadLine();
                    Console.WriteLine("DIGITE A DATA DE VENCIMENTO");
                    string vencides2 = Console.ReadLine();
                    Console.WriteLine("DIGITE O STATUS DO PAGAMENTO");
                    string statusdes2 = Console.ReadLine();

                    var update = id;
                    update = "UPDATE DespesasUnidades SET(descriçao, tipodefesa, valor, vencimentofatura, statuspagamento ) VALUES (@descrides2, @tipodes2, @valordes2, @vencides2, @statusdes2)";

                    conn.Close();


                }

                else if (valor1 == 7)
                {

                    Console.Clear();
                    conn.Open();

                    cmd = new SqlCommand("SELECT * FROM DespesasUnidades", conn);

                    cmd.ExecuteNonQuery();
                    Console.WriteLine(cmd);


                    conn.Close();

                    //não sei usar um filtro


                }

                else if (valor1 == 8)
                {
                    loop1 = 11;
                }

                Console.WriteLine("Aperte qualquer botão para prosseguir");
                Console.ReadKey();
                Console.Clear();

            }

        }

        public static Int32 ExecuteNonQuery(String connectionString, String commandText,
          CommandType commandType, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {   
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
