namespace App05
{
    /*
     Esta clase de tipo "PrinterService", como su nombre lo indica, es el encargado de llamar el
    repositorio y de imprimir su data
     */

    /*
     EXPLICIT DEPENDENCY PRINCIPLE

    Se refiere a que una clase explicitamente requiere de ciertos objetos de manera OBLIGATORIA para que
    pueda trabajar correctamente, y estos objetos usualmente pasan a la clase por medio de metodos,
    propiedades o tambien usando el constructor de la clase.
     */
    public class EstudiantePrinterService
    {
        /*
         Cuando se habla de repositorio(repository) en programacion, se refiere a un origen de datos. El
        repositorio es el que administra o que tiene la data, el que entrega la data.

        Con esto, suponemos que la interfaz "IEstudianteRepository", es la que se encarga de entregar o de
        cargar la data que se necesita para poder imprimir la data de "Estudiante"
         */
        private readonly IRepository<Estudiante> _estudianteRepository;

        public EstudiantePrinterService(IRepository<Estudiante> estudianteRepository)
        {
            _estudianteRepository = estudianteRepository;
        }

        //Si no recibe ningun parametro, la variable "max" va a valer 100
        public void PrintEstudiantes(int max = 100)
        {
            /*
            El metodo "Take" indica cuantos elementos se van a tomar para
            crear la coleccion. Entonces, lo que se hace aqui es crear la
            coleccion del tamaño que se le indique o se le envie al metodo

            Cuando se utiliza un ToArray(), se crea una coleccion nueva que
            sale de la pre-existente, lo cual sobrecarga la memoria y hace
            al programa mucho mas pesado
            */
            var estudiantes = _estudianteRepository.List().Take(max);//.ToArray();

            //Si no se utilizara este "Array.Sort", no es necesario convertir
            //a un array, se puede dejar como un "IEnumerable", y se puede
            //hacer la impresion de los elementos
            //Array.Sort(estudiantes);

            //Console.WriteLine("Imprimiendo lista de Estudiantes desde el metodo PrintEstudiantes: ");

            //Mientras que i sea menor a la longitud del array y menor que el
            //valor del parametro
            //for (int i = 0; i < estudiantes.Length && i < max; i++)
            //{
            //Console.WriteLine(estudiantes[i]);
            //}

            //for (int i = 0; i < estudiantes.Length; i++)
            //{
            //Console.WriteLine(estudiantes[i]);
            //}

            //Llamando el metodo para imprimir la lista IEnumerable de estudiantes
            PrintEstudiantesConsola(estudiantes);
        }

        //Para imprimir la lista de tipo IEnumerable de estudiantes
        private void PrintEstudiantesConsola(IEnumerable<Estudiante> estudiantes)
        {
            Console.WriteLine("Estudiantes: ");

            foreach (var estudiante in estudiantes)
            {
                Console.WriteLine(estudiante);
            }
        }
    }
}
