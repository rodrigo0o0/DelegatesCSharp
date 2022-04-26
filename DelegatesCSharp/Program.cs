using DelegatesCSharp.Services;
using System;


namespace DelegatesCSharp
{
    internal class Program
    {
        //as funções devem casar com a assinatura do delegate
        delegate double BinaryNumericOperation(double n1, double n2);
        delegate double TesteOperationWithOneArgument(double n1);
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20; 
            BinaryNumericOperation op = CalculationService.Max;
            TesteOperationWithOneArgument test = new TesteOperationWithOneArgument(CalculationService.Square);
            test.Invoke(12);

            Console.WriteLine(test(100));
            Console.WriteLine(op(a, b));
            Console.ReadKey();
        }
    }
}
