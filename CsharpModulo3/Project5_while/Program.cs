Console.WriteLine("Exemplo 01");
// A instrução do-while executa uma instrução ou um bloco de instruções, enquanto uma expressão booliana avalia para true. Já que a expressão é avaliada após cada execução do loop, um loop do-while executa uma ou mais vezes.

Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);

// Também é importante observar que o código dentro do bloco de código está influenciando a continuação ou não continuação da iteração pelo bloco de código. O fato do bloco de código influenciar os critérios de saída é um dos principais motivos para usar as instruções do-while ou while em vez de uma das outras instruções de iteração. Tanto foreach quanto for dependem de fatores externos ao bloco de código para determinar o número de iterações que ocorrerão.
Console.WriteLine("--------------------------------------------------------------\n");

Console.WriteLine("Exemplo 02");
Random random1 = new Random();
int current1 = random1.Next(1, 11);

while (current1 >= 3)
{
    Console.WriteLine(current1);
    current1 = random1.Next(1, 11);
}
Console.WriteLine($"Last number: {current1}");

//Nossa instrução while vai iterar com base na expressão booliana (current >= 3). Não sabemos qual valor será atribuído a current, mas existe a possibilidade de que afete nosso loop while:

// Se current for inicializada com um valor maior ou igual a 3, a expressão booliana retornará true e o fluxo de execução vai entrar no bloco de código. Dentro do bloco de código, a primeira coisa que fazemos é escrever o valor de current no console. Em seguida, ainda dentro do bloco de código, atualizamos o valor de current com um novo valor aleatório. Neste ponto, o controle volta para a parte superior da instrução while em que a expressão booliana é avaliada. Esse processo continua até que a expressão booliana retorne false e o fluxo de execução seja interrompido pelo bloco de código.
// Se current for inicializada (na parte superior do nosso código) com um valor menor que 3, então a expressão booliana retornará false e o bloco de código jamais será executado.
// A última linha do código escreve o valor de current no console. Esse código é executado independentemente de o bloco de código da iteração ter sido executado ou não, e é a nossa chance de escrever o valor final de current no console. 
Console.WriteLine("--------------------------------------------------------------\n");

Console.WriteLine("Exemplo 03");
// Em alguns casos, queremos pôr fim ao restante do código no bloco de código e continuar para a próxima iteração. Podemos fazer isso usando a instrução continue.
Random random2 = new Random();
int current2 = random2.Next(1, 11);

do
{
    current2 = random2.Next(1, 11);

    if (current2 >= 8) continue;

    Console.WriteLine(current2);
} while (current2 != 7);
// A primeira coisa que fazemos dentro do bloco de código é atribuir um novo valor aleatório a current. Em seguida, verificamos se current é maior ou igual a 8. Se essa expressão retornar true, a palavra-chave continue transferirá o controle para o final do bloco de código e while será avaliada como (current != 7). Assim, o loop continuará iterando enquanto o valor de current não for igual a 7.
Console.WriteLine("--------------------------------------------------------------\n");

Console.WriteLine("Exercicio");
// Você deve usar a instrução do-while ou a instrução while como um loop de jogo externo.
// O herói e o monstro começarão com dez pontos de integridade.
// Todos os ataques serão um valor entre 1 e 10.
// O herói atacará primeiro.
// Imprima a quantidade de integridade que o monstro perdeu e a integridade que resta a ele.
// Se a integridade do monstro for maior que zero, ele poderá atacar o herói.
// Imprima a quantidade de integridade que o herói perdeu e a integridade que resta a ele.
// Continue esta sequência de ataque até que a integridade do monstro ou do herói seja zero ou menos.
// Imprima quem foi o vencedor.

Random randomA = new Random();
int atackHerói = 0;
int atackMonstro = 0;
int lifeHerói = 10;
int lifeMonstro = 10;

int cont = 3;

do
{
    atackHerói = randomA.Next(1, cont);
    lifeMonstro = lifeMonstro - atackHerói;
    Console.WriteLine($"Atack do Herói: {atackHerói} Life Mostro: {lifeMonstro}");

    if (lifeMonstro <= 0) continue;

    atackMonstro = randomA.Next(1, cont);
    lifeHerói = lifeHerói - atackMonstro;
    Console.WriteLine($"Atack do Mostro: {atackMonstro} Life Herói: {lifeHerói}");

    Console.WriteLine();
    cont = cont + 2;

} while (lifeHerói > 0 && lifeMonstro > 0);

Console.WriteLine(lifeHerói > lifeMonstro ? "Hero wins!" : "Monster wins!");
// Add a variavel cont para ficar mais dinamico
Console.WriteLine("--------------------------------------------------------------\n");

Console.WriteLine("Exercicio");
Console.WriteLine("A instrução for: executa seu corpo enquanto uma expressão Booliana especificada (a condição) é avaliada como verdadeira.");
Console.WriteLine("A instrução foreach: enumera os elementos de uma coleção e executa o corpo para cada um deles.");
Console.WriteLine("A instrução do-while: executa condicionalmente o corpo uma ou mais vezes.");
Console.WriteLine("A instrução while: executa condicionalmente o corpo zero ou mais vezes.\n");
// string nome = "";
// int number = 0;
// string[] nomes = new String[];
// do
// {
//     Console.WriteLine("Digite um nome: ");
//     nome = Console.ReadLine();
//     Console.WriteLine(nome);
//     number++;
// } while (number <= 5);

Console.WriteLine("Ao usar uma instrução Console.ReadLine() para obter a entrada do usuário, é prática comum utilizar uma cadeia de caracteres do tipo anulável (designada string?) para a variável de entrada e, em seguida, avaliar o valor inserido pelo usuário. O código de exemplo a seguir utiliza uma cadeia de caracteres do tipo anulável para capturar a entrada do usuário. A iteração continuará enquanto o valor fornecido pelo usuário for nulo:");
// A função fica aguardando o Usuario digitar algum valor

// strind? readResult; // A variável readResult é do tipo anulável.
// Console.WriteLine("Enter a string:");
// do
// {
//     readResult = Console.ReadLine();
// } while (readResult == null);

string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);



