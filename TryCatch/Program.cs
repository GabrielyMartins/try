try
{
    Console.WriteLine("Informe o primeiro valor!");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Informe o segundo valor!");
    int b = Convert.ToInt32(Console.ReadLine());

    int r = a / b;
    Console.WriteLine($"O resultado é {r}");

}catch(DivideByZeroException e) 
{
    Console.WriteLine("Não é permitido divisão por zero!" + e.Message);
}
catch(InvalidCastException e)
{
    Console.WriteLine("Não é permitido divisão por letras!" + e.Message);
}
catch(Exception e)
{
    Console.WriteLine("Ocorreu um erro!" + e.Message);
}
finally
{
    Console.WriteLine("Aqui passa de qualquer forma!  ");
}