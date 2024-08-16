using System.Reflection;

namespace App06
{
    public class ReflectionEjemplo
    {
        private static void ListGenericMethods(Type type)
        {
            var metodos = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static).Where(m => m.DeclaringType!.Name != "Object");
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

                //EJECUTANDO METODOS GENERICOS
                if (method.IsGenericMethod)
                {
                    Console.WriteLine("Ejecutando un metodo generico...");

                    //Obteniendo los parametros
                    var parametros = method.GetGenericArguments();

                    foreach(var parametro in parametros)
                    {
                        if (parametro.IsGenericParameter)
                        {
                            Console.WriteLine($"Parametro generico: {parametro.GenericParameterPosition} {parametro.Name}");
                        }
                    }
                    /*
                    Ejecucion del metodo
                    
                    MethodInfo es una clase propia del SDK.NET

                    Con esta expresion, se le indica que encapsule o guarde al metodo generico, y entre
                    parentesis le indico que la implementacion de este genericMethod se basa en la clase
                    concreta "Cliente"
                    */
                    MethodInfo genericMethod = method.MakeGenericMethod(typeof(Cliente));

                    /*
                    El primer parametro que exige el Invoke es la instancia de la clase, pero
                    como el metodo generico es de tipo estatico, no es necesario instanciarlo
                    para poder utilizarlo dentro del invoke.

                    Para que el invoke se ejecute, hay que pasarle un parametro. En este caso,
                    como se le indico que el parametro tiene que ser de tipo "Cliente", hay
                    que pasarle un objeto que sea de tipo "Cliente".
                    */
                    object? instancia = null;

                    if (!genericMethod.IsStatic) 
                    {
                        /*
                        Instancia va a ser del tipo que el metodo reciba como parametro.

                        El activator permite crear instancias de objetos pasandole como
                        parametro el tipo de valor generico.
                        */
                        instancia = Activator.CreateInstance(type)!;
                    }

                    genericMethod.Invoke(instancia, new[] { new Cliente("Vaxi", "Drez") });
                }
            }

            Console.WriteLine();
        }

        private static void ListTypeDetails(List<Type> types)
        {
            //El .Pad sirve para tabular un texto, puede ser ya sea a la izquierda(left) o derecha(right) y
            //el parametro que se envia es la cantidad de espacios que se desea tabular
            Console.WriteLine("Type Nombre" .PadRight(20) + "|" + "IsGenericType" .PadRight(20)
                + "|" + "IsGenericDefinition" .PadRight(20) + "|" + "Generic Arguments");

            foreach (var type in types)
            {
                string output = type.Name.PadRight(20) + "|";
                output += type.IsGenericType.ToString().PadRight(20) + "|";
                output += type.IsGenericTypeDefinition + "|";
                output += type.GetGenericArguments().Count();

                //ListGenericMethods(type);

                Console.WriteLine(output);

                ListParameterDetails(type);
            }
        }

        private static void ListParameterDetails(Type type)
        {
            var parameters = type.GetGenericArguments();
            foreach (var parameter in parameters)
            {
                if (parameter.IsGenericParameter)
                {
                    DisplayGenericParameter(parameter);
                }
                else
                {
                    DisplayTypeArgument(parameter);
                }
            }
        }

        private static void DisplayGenericParameter(Type parameter)
        {
            var constraints = parameter.GetGenericParameterConstraints();
            Console.WriteLine($"Type parameter position: {parameter.GenericParameterPosition}   " +
                $"nombre: {parameter.Name}   " +
                $"constraints: {constraints.Length}   " +
                $"attributeMask: {parameter.GenericParameterAttributes}");

            if (constraints.Any())
            {
                Console.WriteLine("   Nombre   |   Interface?   |   Class?   | Enum?   ");

                foreach (var constraint in constraints)
                {
                    Console.WriteLine("   " + constraint.Name.PadRight(16) + "|" +
                        constraint.IsInterface.ToString().PadRight(11) + "|" +
                        constraint.IsClass.ToString().PadRight(7) + "|" +
                        constraint.IsEnum.ToString().PadRight(6));
                }
            }
        }

        private static void DisplayTypeArgument(Type parameter)
        {
            Console.WriteLine($"Type argument: {parameter.Name}");
        }

        public static void execute()
        {
            var types = new List<Type>
            {
                //typeof(IProcessor<>),
                //typeof(IProcessor<Cliente>),
                //typeof(Processor<>),
                //typeof(Processor<Cliente>),
                //typeof(ClienteProcessor)
                typeof(IPipeline<,>)
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
