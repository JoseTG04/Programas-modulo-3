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
                Console.WriteLine("Digite el primer número: ");
                num1 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite el segundo número: ");
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

        public void ComprobarNota()
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int promedio = 0;

            try
            {
                Console.WriteLine("Digite el primer número: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el segundo número: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el primer número: ");
                num3 = Convert.ToInt32(Console.ReadLine());

                promedio = (num1 + num2 + num3) / 3;

                if (promedio >= 7)
                {
                    Console.WriteLine("Promocionado");
                    Console.WriteLine($"Su calificación es: {promedio}");
                }
                else
                {
                    Console.WriteLine("Lamentable el alumno no aprobó");
                    Console.WriteLine($"Su calificación es: {promedio}");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ha ocurrido el siguiente error: {ex.Message} al promediar las notas");
            }
            

        }

        public void ComprobarDigitos()
        {
            int num1 = 0;


            try
            {
                Console.WriteLine("Digite un número entero positivo del 1 al 99");
                num1 = Convert.ToInt32(Console.ReadLine());

                if (num1 < 10)
                {
                    Console.WriteLine("El número ingresado tiene un dígito");
                }
                else if (num1 > 99)
                {
                    Console.WriteLine($"El número ingresado: {num1} no es válido");
                }
                else
                {
                    Console.WriteLine("El número ingresado tienes dos dígitos");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ha ocurrido el siguiente error: {ex.Message} al comprobar los dígitos");
            }
            

        }
    }
}
