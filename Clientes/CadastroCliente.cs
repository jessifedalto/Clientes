using System.ComponentModel;

public class CadastroCliente {
    private List<Cliente> clientes = new List<Cliente>();

    public void Add(Cliente cliente){
        clientes.Add(cliente);
    }

    public void Remove(int cliente){
        // foreach(var cli in clientes) {
        //    if (cli.getCodigo() == cliente){}
        //    {
        //     clientes.Remove(cli);

        //    };
        // }
        for (int i = clientes.Count - 1; i >= 0; i--) {
            if (clientes[i].getCodigo() == cliente) {
                clientes.RemoveAt(i);
        
            }
        }

    }
    public void ListarCliente() {
        foreach(var cliente in clientes) {
            Console.WriteLine(cliente.ToString());
        }
    }

    public List<Cliente> BuscarClientePorNome(string nome) {
        return clientes.Where(x => x.getNome().Equals(nome, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}