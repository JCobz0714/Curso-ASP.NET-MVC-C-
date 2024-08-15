namespace App06
{
    public class ReflectionEjemplo
    {
        public static void execute()
        {
            var openInterface = typeof(IProcessor<>);

            //Evaluar si la definicion del componente(En este caso, de la interfaz), fue
            //hecha de manera generica, en este caso debe retornar true porque la definicion
            //del componente fue de forma generica
            Console.WriteLine($"El IProcessor<> es generico? {openInterface.IsGenericType}");

            //Comprobar si el componente se esta implementando de forma generica o
            //concreta, en este caso debe retornar true porque la implementacion es generica
            Console.WriteLine($"El IProcessor<> su definicion es generica? {openInterface.IsGenericTypeDefinition}");

            var closeInterface = typeof(IProcessor<Cliente>);
            Console.WriteLine($"El IProcessor<Cliente> es generico? {closeInterface.IsGenericType}");

            //Al momento de invocar un objeto de tipo IProcessor donde ya le estoy pasando "Cliente",
            //por ende, debe retornar false
            Console.WriteLine($"El IProcessor<Cliente> es generico? {closeInterface.IsGenericTypeDefinition}");
        }
    }
}
