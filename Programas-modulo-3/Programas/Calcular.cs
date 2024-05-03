namespace Programas_modulo_3.programas
{
    public class Calcular
    {
        public void OperacionesCondicionadas()
        {
            decimal num1 = 0;
            decimal num2 = 0;
            decimal suma = 0;
            decimal resta = 0;
            decimal producto= 0;
            decimal cociente = 0;

            try
            {
                Console.WriteLine("Digite el primer número entero: ");
                num1 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite el segundo número entero: ");
                num2 = Convert.ToDecimal(Console.ReadLine());   

                if (num1 > num2)
                {
                    suma = num1 + num2;
                    resta = num1 - num2;
                    Console.WriteLine($"El resultado de la suma es: {suma}");
                    Console.WriteLine($"El resultado de la resta es: {resta}");

                }
                else if (num2 > num1)
                {
                    producto = num1 * num2;
                    cociente = num1 / num2;
                    Console.WriteLine($"El resultado del producto es: {producto}");
                    Console.WriteLine($"El resultado de la división es: {cociente}");

                }
                else if (num1 == num2)
                {
                    Console.WriteLine("Como los números son iguales se presentan todas las operaciones");
                    suma = num1 + num2;
                    resta = num1 - num2;
                    Console.WriteLine($"El resultado de la resta es: {resta}");
                    Console.WriteLine($"El resultado de la suma es: {suma}");

                    producto = num1 * num2;
                    cociente = num1 / num2;
                    Console.WriteLine($"El resultado del producto es: {producto}");
                    Console.WriteLine($"El resultado de la división es: {cociente}");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ha ocurrido el siguiente error: {ex.Message} al realizar las operaciones");
                             
            }
            
            
        }
    }
}
