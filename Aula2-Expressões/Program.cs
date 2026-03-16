/*
1. Faça um programa que receba o salário atual de um
funcionário e calcule e mostre o novo salário, sabendo-
se que ele recebeu um aumento de 15%. O programa
deve mostrar o valor do aumento e o novo salário do
funcionário.
*/
/*
double salario, novosalario, aumento;

Console.Write("Digite o salario atual: ");
salario = double.Parse(Console.ReadLine());

aumento = salario * 0.15;

novosalario = salario + aumento;

Console.WriteLine("O novo salário é: {0} ", novosalario);
*/
/*
2. Faça um programa que receba a distância percorrida
por um carro (em km) e a quantidade de
combustível gasta (em litros). Calcule e mostre o
consumo médio do carro, em km por litro.  
consumo = distancia/combustivel
*/
/*
double km, litro, consumo;

Console.Write("Digite os kms percorridos: ");
km = double.Parse(Console.ReadLine());
Console.Write("Digite os litros gastos: ");
litro = double.Parse(Console.ReadLine());

consumo = km / litro;

Console.WriteLine("Você percorreu {0}km por litro", consumo);

/*
3. Uma loja paga aos seus vendedores um salário fixo mais
uma comissão de 5% sobre o valor das vendas
realizadas no mês.
- Faça um programa que receba:
    - o salário fixo do vendedor;
    - o valor total das vendas no mês.
- Calcule e mostre:
    - o valor da comissão;
    - o salário final do vendedor.
*/
/*
double salario, novosalario, comissao, vendas;

Console.Write("Digite seu salario atual: ");
salario = double.Parse(Console.ReadLine());

Console.Write("Digite o valor total das suas vendas no mês: ");
vendas = double.Parse(Console.ReadLine());

comissao = vendas * 0.05;
novosalario = salario + comissao;

Console.WriteLine($"Valor da comissão: {comissao:C} Salário final do vendedor: {novosalario:C}");
*/
/*
4. Fazer um programa que leia o valor de um salário a ser
pago e informe a quantidade mínima de notas que
precisarão ser sacadas no banco para pagar o funcionário.
As notas disponíveis são: 200, 100, 50, 20, 10, 5, 2 reais e 1
real
- Exemplo:
    - Entrada: 158
    - Saída: 1 de 100, 1 de 50, 1 de 5, 1 de 2 e 1 de 1 real

*/
/*
int salario, n200, n100, n50, n20, n10, n5, n2, n1;

Console.Write("Digite seu salario: ");
salario = int.Parse(Console.ReadLine());

n200 = (salario / 200);
n100 = (salario % 200) / 100;
n50 = ((salario % 200) % 100) / 50;
n20 = (((salario % 200) % 100) % 50) / 20;
n10 = ((((salario % 200) % 100) % 50) % 20) / 10;
n5 = (((((salario % 200) % 100) % 50) % 20) % 10) / 5;
n2 = ((((((salario % 200) % 100 ) % 50) % 20) % 10) % 5) / 2;
n1 = (((((((salario % 200) % 100 ) % 50) % 20) % 10) % 5) % 2)/ 1;

Console.WriteLine($"{n200} de 200, {n100} de 100, {n50} de 50, {n10} de 10, {n5} de 5, {n2} de 2 e {n1} de 1 real");
*/
/*
5. Faça um programa que leia quantidade de dias sem
acidentes em uma empresa. Depois apresente os dias sem
acidentes separados em anos, meses e dias.
Considere que 1 ano tem 365 dias e um mês tem 30 dias
- Exemplo:
    - Entrada: 400 dias
    - Saída: 1 ano, 1 mês e 5 dias
*/
int acidente, ano, mes, dia;

Console.Write("Digite a quantidade de dias sem acidentes: ");
acidente = int.Parse(Console.ReadLine());

ano = (acidente / 365);
mes = (acidente % 365)/ 30;
dia = (acidente % 365)% 30;


Console.WriteLine($" {ano} ano, {mes} mês e {dia} dias");
Console.ReadKey();

