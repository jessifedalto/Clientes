using System.ComponentModel.Design;
using System.Data;
using System.Runtime.CompilerServices;

class Program {
    public static void Main(string[] args) {
        int op = 7, cod = 0;
        CadastroCliente cadastro = new CadastroCliente();

        while (op != 0) {
            try {
                Program.menu();
                op = Int32.Parse(Console.ReadLine());

            } catch(System.Exception e) {

                Console.WriteLine(e.Message);
            }
            Console.Clear();

            switch (op) {
                case 1:
                        try {
                            Console.WriteLine("Informe o nome: ");
                            String nome = Console.ReadLine();
                            if (!IsValidName(nome)) {
                                throw new Exception("O nome só pode conter letras.");
                            }
                            Console.WriteLine("Informe a data de nascimento (dd/mm/aaaa): ");
                            String data = Console.ReadLine();
                            if (!IsValidDate(data)) {
                                throw new Exception("Formato de data inválido. Use dd/mm/aaaa.");
                            }  

                            Console.WriteLine("Informe o email: ");
                            String email = Console.ReadLine();  
                            if (!IsValidEmail(email)) {
                                throw new Exception("Formato de email inválido.");
                            }

                            Cliente cliente = new Cliente(nome, cod, data, email);                       
                            cadastro.Add(cliente);
                            cod++;
                        
                        } catch (System.Exception e) {
                            Console.WriteLine(e.Message);
                        }
                    break;
                case 2:
                    try {
                        Console.WriteLine("Informe o codigo do cliente para remover: ");
                        int codRemove = Int32.Parse(Console.ReadLine());
                        cadastro.Remove(codRemove);

                    } catch (System.Exception e) {
                        Console.WriteLine(e.Message);
                    }
                    break;

                case 3:
                    try {
                        Console.WriteLine("Informe o nome que deseja pesquisar: ");
                        String nomeProc = Console.ReadLine();

                        List<Cliente> clientesEncontrados = cadastro.BuscarClientePorNome(nomeProc);
                        foreach (var clientess in clientesEncontrados) {
                            Console.WriteLine(clientess.ToString());
                        }

                    } catch (System.Exception e) {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case 4:
                    try {
                        cadastro.ListarCliente();
                    } catch (System.Exception e) {
                        Console.WriteLine(e.Message);
                    }
                    break;
                default:
                    break;
            }
        }
    }

    public static void menu() {
        Console.WriteLine("****************** M E N U ******************\n\n");
        Console.WriteLine("1 - Cadastrar cliente\n");
        Console.WriteLine("2 - Remover cliente\n");
        Console.WriteLine("3 - Buscar cliente por nome\n");
        Console.WriteLine("4 - Listar todos os clientes\n");
        Console.WriteLine("0 - SAIR\n\n");
    }   
    public static bool IsValidName(string name) {
        return System.Text.RegularExpressions.Regex.IsMatch(name, @"^[a-zA-Z\s]+$");
    }

    public static bool IsValidDate(string date) {
        DateTime result;
        return DateTime.TryParseExact(date, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out result);
    }
    public static bool IsValidEmail(string email) {
        return System.Text.RegularExpressions.Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
    }
}