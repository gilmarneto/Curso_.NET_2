// data: 19/12/2024

// 1º - Exibir o Zero do final
double num1 = 8.50;
// ex 01
Console.WriteLine(num1); 
// ex 02
Console.WriteLine(num1.ToString("F2")); // para exibir o zero usamos o ToString(F2)

// VEJA A DIFERENÇA NA SAÍDA DO CONSOLE

// 2º - Calcular porcentagem
double num2 = 9.50;
double porcentagem = 10.0;
double formula = num2*(porcentagem/100);

Console.WriteLine(formula.ToString("F2"));

// 3º - Valor de um produto que custa R$ 4.50, com 10% de desconto 
double valor = 4.50;
double porcentagemDesconto = 10.0;
double desconto = valor*(porcentagemDesconto/100);

Console.WriteLine($"Valor total sem desconto: R$ {valor.ToString("F2")}");
Console.WriteLine($"Valor total com desconto: R$ {(valor - desconto).ToString("F2")}");