Console.WriteLine("\nExemplo 01");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
// A instrução for inclui as seis partes seguintes:

// A palavra-chave for.
// Um par de parênteses que define as condições da iteração for. O par de parênteses contém três partes distintas, separadas pelo operador de fim de instrução (ponto e vírgula).
// A primeira parte define e inicializa a variável de iterador. Neste exemplo: int i = 0. Esta seção é chamada de inicializador.
// A segunda parte define a condição de conclusão. Neste exemplo: i < 10. Em outras palavras, o tempo de execução continuará iterando sobre o código no bloco de código embaixo da instrução for, enquanto i for menor que 10. Quando i se torna igual a 10, o runtime para de executar o bloco de código da instrução do for. Os documentos referem-se a esta seção como a condição.
// A terceira parte define a ação a ser executada após cada iteração. Nesse caso, após cada iteração, i++ incrementará o valor de i em 1. Os documentos referem-se a esta seção como o iterador.
// Finalmente, o bloco de código. O bloco de código contém o código que será executado a cada iteração. Observe que o valor de i é referenciado dentro do bloco de código. Os documentos referem-se a esta seção como o corpo.
Console.WriteLine("--------------------------------------------------------------\n");

Console.WriteLine("Exemplo 02");
// E se precisássemos iterar por meio de um bloco de código, mas desejamos contar regressivamente em vez de progressivamente?
for (int i = 10; i > 0; i--)
{
    Console.WriteLine(i);
}
Console.WriteLine("--------------------------------------------------------------\n");

Console.WriteLine("Exemplo 03");
// E se precisássemos iterar por meio de um bloco de código, mas desejamos contar regressivamente em vez de progressivamente?
for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}
Console.WriteLine("--------------------------------------------------------------\n");

Console.WriteLine("Exemplo 04");
// E se for necessário sair da instrução de iteração prematuramente com base em alguma condição? Podemos usar a palavra-chave break.
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7)
        break;
}
Console.WriteLine("--------------------------------------------------------------\n");

Console.WriteLine("Exemplo 05");
string [] names = {"Alex", "Eddie", "David", "Michael"};
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}
// Primeiro, observe que instanciamos uma matriz de cadeia de caracteres chamada names que contém quatro nomes.
// Em seguida, observe que estamos usando a propriedade Array.Length para obter o número de elementos da matriz e que estamos usando esse valor para inicializar nossa variável de iteração (int i = names.Length - 1). Subtraímos 1 do valor porque o número dos índices dos elementos da matriz começa a contar no zero (os índices dos quatro elementos da matriz vão de 0 a 3).
// Por fim, observe que escolhemos percorrer os índices da matriz de trás para frente, algo que não podemos fazer com a instrução foreach. Usamos o valor da variável de iteração dentro do bloco de código para especificar o número do índice dos elementos da matriz (names[i]).
Console.WriteLine("--------------------------------------------------------------\n");

Console.WriteLine("Exemplo 06");
string[] nomes = {"Alex", "Eddie", "David", "Michael"};
for (int i = 0; i >= nomes.Length; i++)
{
    if (nomes[i] == "David")
    {
        nomes[i] = "Sammy";
    }
}
foreach (var nome in nomes)
{
    Console.WriteLine(nome);
}
Console.WriteLine("--------------------------------------------------------------\n");

Console.WriteLine("Exercicio");
//* Valores de saída de 1 a 100, um número por linha, dentro do bloco de código de uma instrução de iteração.
//* Quando o valor atual é divisível por 3, imprima o termo Fizz ao lado do número.
//* Quando o valor atual é divisível por 5, imprima o termo Buzz ao lado do número.
//* Quando o valor atual é divisível tanto por 3 quanto por 5, imprima o termo FizzBuzz ao lado do número.
for (int i = 1; i <= 100; i++)
{
    Console.Write(i);
    if (i % 3 == 0 && i % 5 == 0)
        Console.Write(" - FizzBuzz");

    else if (i % 3 == 0)
        Console.Write(" - Fizz");

    else if (i % 5 == 0)
        Console.Write(" - Buzz");

    Console.WriteLine();
}