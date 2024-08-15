using System.Reflection;

namespace App06
{
    public class ReflectionEjemplo
    {
        private static void ListGenericMethods(Type type)
        {
            var metodos = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine($"Metodos son del tipo {type.Name}");
            Console.WriteLine("Nombre     |IsGeneric      |IsGenericDef      |ContainsGenParam");
            int colWidth = 12;

            foreach (var method in metodos) 
            {
                int maxNombreLength = Math.Min(method.Name.Length, colWidth);
                Console.Write(method.Name.Substring(0, maxNombreLength).PadRight(colWidth));
                Console.Write("|");
                Console.Write(method.IsGenericMethod.ToString().PadRight(colWidth));
                Console.Write("|");
                Console.Write(method.IsGenericMethodDefinition.ToString().PadRight(colWidth));
                Console.Write("|");
                Console.WriteLine(method.ContainsGenericParameters.ToString().PadRight(colWidth));
            }

            Console.WriteLine();
        }

        private static void ListTypeDetails(List<Type> types)
        {
            //El .Pad sirve para tabular un texto, puede ser ya sea a la izquierda(left) o derecha(right) y
            //el parametro que se envia es la cantidad de espacios que se desea tabular
            Console.WriteLine("Type Nombre" .PadRight(20) + "|" + "IsGenericType" .PadRight(20)
                + "|" + "IsGenericDefinition" .PadRight(20));

            foreach (var type in types)
            {
                string output = type.Name.PadRight(20) + "|";
                output += type.IsGenericType.ToString().PadRight(20) + "|";
                output += type.IsGenericTypeDefinition;

                ListGenericMethods(type);

                Console.WriteLine(output);
            }
        }

        public static void execute()
        {
            var types = new List<Type>
            {
                typeof(IProcessor<>),
                typeof(IProcessor<Cliente>),
                typeof(Processor<>),
                typeof(Processor<Cliente>),
                typeof(ClienteProcessor)
            };

            ListTypeDetails(types);

            /*
            ----------------- ESTO FUE BORRADO EN EL VIDEO DE LA CLASE -----------------

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

            //Obtener la definicion de la interfaz, es decir el "GetGenericDefinition" y compararlo con
            //la definicion generica que hice con el openInterface
            var definition = closeInterface.GetGenericTypeDefinition();

            var resultado = definition == openInterface;
            Console.WriteLine($"El resultado de las definiciones es: {resultado}");
            */
        }
    }
}
