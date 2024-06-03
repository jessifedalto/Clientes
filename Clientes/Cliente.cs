public class Cliente {
    private String Nome;
    private int codigo;
    private String nascimento;
    private String email;

    public Cliente(String nome, int cod, String nascimento, String email) {
        this.Nome = nome;
        this.codigo = cod;
        this.nascimento = nascimento;
        this.email = email;
    }   
    
    public override string ToString() {
        return $"Codigo: {this.codigo}\nNome: {this.Nome} \nEmail: {this.email} \nData de Nascimento: {this.nascimento}";
    }

    public string getNome(){
        return this.Nome;
    }

    public int getCodigo(){
        return this.codigo;
    }

    public String getNascimento() {
        return this.nascimento;
    }

    public string getEmail () {
        return this.email;
    }
}