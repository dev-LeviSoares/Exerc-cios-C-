using System.Drawing;

Console.WriteLine("Digite a quantidade máxima de clientes:");
int limiteCadastro = int.Parse(Console.ReadLine());

string[] nomesClientes = new string[limiteCadastro];
string[] cpfsClientes = new string[limiteCadastro]; // O tipo "long" aceita valores maiores que tipo "int"
string[] telefonesClientes = new string[limiteCadastro];
string[] emailsClientes = new string[limiteCadastro];


void cadastrarClientes()
{
    for(int i = 0; i < limiteCadastro; i++) //Pra add um valor no array ele precisa de um indice.
    {
        Console.WriteLine("Digite o nome do novo cliente:");
        nomesClientes[i] = Console.ReadLine();
        
        while(string.IsNullOrWhiteSpace(nomesClientes[i])) //Verifica espaço em branco
        {
            Console.WriteLine("Campo vazio. Por favor adicione o nome do usuário!");
            nomesClientes[i] = Console.ReadLine();
        }
        
        Console.WriteLine("Digite o CPF do novo cliente:");
        cpfsClientes[i] = Console.ReadLine();
         
        while (string.IsNullOrWhiteSpace(cpfsClientes[i])) //Verifica espaço em branco
        {
            Console.WriteLine("Campo vazio. Por favor adicione o cpf do usuário!");
            cpfsClientes[i] = Console.ReadLine();
        }
            
        // Verificador do CPF.
        bool cpfDuplicado = false;

        for (int j = 0; j < i; j++)//Ele vai iterar sobre o array procurando um CPF igual.
        { 
            if (cpfsClientes[j] == cpfsClientes[i])
            {
                    cpfDuplicado = true;
                    break;
            }
        }

        while (cpfDuplicado)
        {
            Console.WriteLine("Esse CPF já foi cadastrado. Digite outro CPF:");
            cpfsClientes[i] = Console.ReadLine();
        }
        
        // Esse ta ligado de esse while de cima /\
        
        while (string.IsNullOrWhiteSpace(cpfsClientes[i])) //Verifica NOVAMENTE se tem espaço em branco.
        {
            Console.WriteLine("Campo vazio. Por favor adicione o cpf do usuário!");
            cpfsClientes[i] = Console.ReadLine();
        }
        
        // Esse novo verificador de duplicação ta ligado a esse while de cima /\
        
        cpfDuplicado = false; //Coloco essa variavel como falsa dnv.

        for (int j = 0; j < i; j++) //Ele vai iterar sobre o array dnv procurando um CPF igual.
        {
            if (cpfsClientes[j] == cpfsClientes[i])
            {
                cpfDuplicado = true;
                break;
            }
        }

        Console.WriteLine("Digite o telefone do novo cliente:");
        telefonesClientes[i] = Console.ReadLine();
        
        while (string.IsNullOrWhiteSpace(telefonesClientes[i])) //Verifica espaço em branco
        {
            Console.WriteLine("Campo vazio. Por favor adicione o telefone do usuário!");
            telefonesClientes[i] = Console.ReadLine();
        }

        Console.WriteLine("Digite o email do novo cliente:");
        emailsClientes[i] = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(emailsClientes[i])) //Verifica espaço em branco
        {
                Console.WriteLine("Campo vazio. Por favor adicione o email do usuário!");
                emailsClientes[i] = Console.ReadLine();
        }

    break; // Jeito de burlar o for para ele não rodar o limite de cadastro.
    }
}

void exibirMenu()
{

}
cadastrarClientes();