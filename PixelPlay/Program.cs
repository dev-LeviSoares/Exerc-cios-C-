using System;
using System.Drawing;

// Quantidade máxima de usuários cadastrados.

Console.WriteLine("Digite a quantidade máxima de clientes:");
int limiteCadastro = int.Parse(Console.ReadLine());


/*int limiteCadastro = 0;
bool verificadorCadastrosMaximo = false;

while (verificadorCadastrosMaximo)
{
    if (int.TryParse(entrada, out limiteCadastro))
    {
        Console.WriteLine("Número de cadastros definido!");
        verificadorCadastrosMaximo = true;
    }
    else
    {
        Console.WriteLine("Campo vazio. Por favor adicione a quantidade máxima de cadastros!");
    }
}
*/

// Variáveis globais.

// Variáveis de usuário:
string[] nomesClientes = new string[limiteCadastro];
string[] cpfsClientes = new string[limiteCadastro];
string[] telefonesClientes = new string[limiteCadastro];
string[] emailsClientes = new string[limiteCadastro];

int totalClientes = 0;

// Variáveis de itens:
List<long> codigoItem = new List<long>();
List<string> tituloItem = new List<string>();
List<string> tipoItem = new List<string>();
List<string> generoItem = new List<string>();
List<double> valorDiaria = new List<double>();
List<bool> status = new List<bool>();

List<double> locacaoValores = new List<double>();

//==================================================================

/*void cadastrarClientes()
{
    Console.Clear();
    Console.WriteLine("=====================");
    Console.WriteLine("===== PixelPlay =====");
    Console.WriteLine("=====================");
    Console.WriteLine("Cadastro de Clientes");
    Console.WriteLine("=====================");

    for (int i = 0; i < limiteCadastro; i++) //Pra add um valor no array ele precisa de um indice.
    {
        Console.WriteLine("----------------------");
        Console.WriteLine("Digite o nome do novo cliente:");
        nomesClientes[i] = Console.ReadLine();
        
        while(string.IsNullOrWhiteSpace(nomesClientes[i])) //Verifica espaço em branco
        {
            Console.WriteLine("Campo vazio. Por favor adicione o nome do usuário!");
            nomesClientes[i] = Console.ReadLine();
        }

//==================================================================

        Console.WriteLine("----------------------");
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

//==================================================================

        Console.WriteLine("----------------------");
        Console.WriteLine("Digite o telefone do novo cliente:");
        telefonesClientes[i] = Console.ReadLine();
        
        while (string.IsNullOrWhiteSpace(telefonesClientes[i])) //Verifica espaço em branco
        {
            Console.WriteLine("Campo vazio. Por favor adicione o telefone do usuário!");
            telefonesClientes[i] = Console.ReadLine();
        }

//==================================================================

        Console.WriteLine("----------------------");
        Console.WriteLine("Digite o email do novo cliente:");
        emailsClientes[i] = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(emailsClientes[i])) //Verifica espaço em branco
        {
                Console.WriteLine("Campo vazio. Por favor adicione o email do usuário!");
                emailsClientes[i] = Console.ReadLine();
        }

    break; // Jeito de burlar o for para ele não rodar o limite de cadastro.
    }
}*/

void cadastrarClientes()
{
    Console.Clear();
    Console.WriteLine("=====================");
    Console.WriteLine("===== PixelPlay =====");
    Console.WriteLine("=====================");
    Console.WriteLine("Cadastro de Clientes");
    Console.WriteLine("=====================");

    if (totalClientes >= limiteCadastro)
    {
        Console.WriteLine("Limite máximo de cadastros atingido!");
        Console.ReadKey();
        return; //Fecha quando atinge o máximo de clientes
    }

    int i = totalClientes; // Posição correta no array. Vai atualizando sempre que cadastrar um usuario

    Console.WriteLine("----------------------");
    Console.WriteLine("Digite o nome do novo cliente:");
    nomesClientes[i] = Console.ReadLine();
    while (string.IsNullOrWhiteSpace(nomesClientes[i])) //Verificador de espaço em branco
    {
        Console.WriteLine("Campo vazio. Por favor adicione o nome do usuário!");
        nomesClientes[i] = Console.ReadLine();
    }
    
    //==================================================================

    Console.WriteLine("----------------------");
    Console.WriteLine("Digite o CPF do novo cliente:");
    cpfsClientes[i] = Console.ReadLine();

    while (string.IsNullOrWhiteSpace(cpfsClientes[i]))
    {
        Console.WriteLine("Campo vazio. Por favor adicione o CPF do usuário!");
        cpfsClientes[i] = Console.ReadLine();
    }

    // Verificador de CPF duplicado
    bool cpfDuplicado = false;
    for (int j = 0; j < totalClientes; j++)
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

        cpfDuplicado = false;
        for (int j = 0; j < totalClientes; j++)
        {
            if (cpfsClientes[j] == cpfsClientes[i])
            {
                cpfDuplicado = true;
                break;
            }
        }
    }


    //==================================================================

    Console.WriteLine("----------------------");
    Console.WriteLine("Digite o telefone do novo cliente:");
    telefonesClientes[i] = Console.ReadLine();
    while (string.IsNullOrWhiteSpace(telefonesClientes[i]))
    {
        Console.WriteLine("Campo vazio. Por favor adicione o telefone do usuário!");
        telefonesClientes[i] = Console.ReadLine();
    }

    //==================================================================

    Console.WriteLine("----------------------");
    Console.WriteLine("Digite o email do novo cliente:");
    emailsClientes[i] = Console.ReadLine();
    while (string.IsNullOrWhiteSpace(emailsClientes[i]))
    {
        Console.WriteLine("Campo vazio. Por favor adicione o email do usuário!");
        emailsClientes[i] = Console.ReadLine();
    }

    totalClientes++; // Avança o contador de clientes cadastrados
    Console.WriteLine("Cliente cadastrado com sucesso!");
    
    Console.WriteLine("====================");
    
    Console.WriteLine("Resumo dos clientes cadastrados:");
    for (int j = 0; j < totalClientes; j++)
    {
        Console.WriteLine($"[{j + 1}°] {nomesClientes[j]} - CPF: {cpfsClientes[j]}");
    }
    Console.ReadKey();
}



void cadastrarItens()
{
    Console.Clear();
    Console.WriteLine("=====================");
    Console.WriteLine("===== PixelPlay =====");
    Console.WriteLine("=====================");
    Console.WriteLine("Cadastro de Itens");
    Console.WriteLine("=====================");

    Random numAleatorio = new Random();
    int codigo = numAleatorio.Next(1000, 9999); //Gera um código e atribui a variavel codigo.
    codigoItem.Add(codigo);

    //==================================================================

    Console.WriteLine("Digite o título do Item:");
    string titulo = Console.ReadLine();
    while (string.IsNullOrWhiteSpace(titulo)) //Verifica espaço em branco
    {
        Console.WriteLine("Campo vazio. Por favor adicione o título do item!");
        titulo = Console.ReadLine();
    }
    tituloItem.Add(titulo.ToUpper());

    //==================================================================

    Console.WriteLine("Digite o tipo (Filme ou Jogo):");
    string tipo = Console.ReadLine();
    tipoItem.Add(tipo.ToUpper());

    //==================================================================

    Console.WriteLine("Digite o gênero(Ação, Comédia, Terror, RPG, etc.):");
    string genero = Console.ReadLine();
    generoItem.Add(genero.ToUpper());

    //==================================================================

    Console.WriteLine("Digite o valor da diária desse item:");
    double valor;

    while (!double.TryParse(Console.ReadLine(), out valor) || valor <= 0)  // Repete enquanto for verdadeira
    { // O ! vai inverter o resultado do TryParse.
        Console.WriteLine("Valor inválido. Digite um valor positivo!"); 
    }

    valorDiaria.Add(valor);

    //==================================================================

    bool statusItem = true;
    status.Add(true);
}

void realizarLocação()
{
    Console.Clear();
    Console.WriteLine("=====================");
    Console.WriteLine("===== PixelPlay =====");
    Console.WriteLine("=====================");
    Console.WriteLine("Locação de Itens");
    Console.WriteLine("=====================");

    Console.WriteLine("Digite o CPF do usuário que irá locar o filme/jogo:");
    string cpfProcurado = Console.ReadLine().Trim();
   
    int indice = Array.IndexOf(cpfsClientes, cpfProcurado); //(Array que esta armazenado, valor que será caçado)
    Console.WriteLine($"Você digitou {cpfProcurado}");
    
    if(indice != -1)
    {
        Console.WriteLine($"Cliente: " +
            $"{nomesClientes[indice]}");
    }
    else
    {
        Console.WriteLine("CPF não encontrado.");
    }

    Console.WriteLine("Lista com filmes/jogos disponíveis:");
    for(int i = 0; i < tituloItem.Count; i++)
    {
        if (status[i] == true)
        {
            Console.WriteLine($"{i + 1}° {tituloItem[i]} -  Valor da diária R$ {valorDiaria[i]}");
        }
    }
    
    Console.WriteLine("Digite o nome do filme/jogo que irá locar:");
    string item = Console.ReadLine();

    int ind = tituloItem.IndexOf(item); //Busca indice referente ao item digitado
    Console.WriteLine($"Você digitou: {item}");
    
    if (ind != -1)
    {
        Console.WriteLine($"Código do item: {codigoItem[ind]}");
    }
    else
    {
        Console.WriteLine("Item não encontrado.");
    }

    Console.WriteLine("Você quer alugar por quantos dias?");
    int diasAluguel = int.Parse(Console.ReadLine());

    double valorTotal;

    valorTotal = valorDiaria[ind] * diasAluguel;

    Console.WriteLine("Você confirma a locação desse item? (S/N)");
    string confirmacao = Console.ReadLine();

    if (confirmacao.ToUpper() == "S")
    {
        status[ind] = false;
        locacaoValores.Add(valorTotal);
        Console.WriteLine("Locação realizada com sucesso!");
        Console.WriteLine($"Cliente: {nomesClientes[indice]}");
        Console.WriteLine($"Item: {tituloItem[ind]}");
        Console.WriteLine($"Dias: {diasAluguel}");
        Console.WriteLine($"Valor total: R$ {valorTotal:F2}");
        Console.WriteLine($"Data da locação: {DateTime.Now}");
    }
    else
    {
        Console.WriteLine("Voltando ao menu...");
    }
    Console.ReadKey();

}

void exibirMenu()
{
    Console.Clear();
    Console.WriteLine("=====================");
    Console.WriteLine("===== PixelPlay =====");
    Console.WriteLine("=====================");
    Console.WriteLine("Menu de opções:");
    Console.WriteLine("=====================");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Cadastrar itens (Filmes e Jogos)");
    Console.WriteLine("3 - Realizar locação");
    Console.WriteLine("4 - Devolver item");
    Console.WriteLine("5 - Relátorios gerais");
    Console.WriteLine("=====================");
    Console.WriteLine("DIGITE UMA OPÇÃO:");
}

//==================================================================

int opcao = 0;

do {
    exibirMenu();
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            cadastrarClientes();
            break;
        case 2:
            cadastrarItens();
            break;
        case 3:
            realizarLocação();
            break;
        case 4:

            break;
        case 5:

            break;
        case 0:
            Console.WriteLine("Finalizando sistema...");
            break;
        default:
            Console.WriteLine("Opção inválida.Tente novamente!");
            break;
    }
    
}while (opcao != 0);
