float salarioAntigo = 0, salarioNovo = 0, porcentagemSalario = 0;

do
{
    Console.WriteLine("Digite o seu antigo salário: ");
    salarioAntigo = float.Parse(Console.ReadLine());

} while (salarioAntigo <= 0);

do
{
    Console.WriteLine("Digite o salario com aumento: ");
    salarioNovo = float.Parse(Console.ReadLine());

} while (salarioNovo <= salarioAntigo);

porcentagemSalario = ((salarioNovo - salarioAntigo) / salarioAntigo) * 100;
Console.WriteLine($"O porcentual de aumento é {porcentagemSalario} %");
