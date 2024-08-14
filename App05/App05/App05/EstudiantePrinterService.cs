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
        private readonly IEstudianteRepository _estudianteRepository;

        public EstudiantePrinterService(IEstudianteRepository estudianteRepository)
        {
            _estudianteRepository = estudianteRepository;
        }

        public void PrintEstudiantes()
        {
            var estudiantes = _estudianteRepository.List();
            Array.Sort(estudiantes);

            Console.WriteLine("Imprimiendo lista de Estudiantes desde el metodo PrintEstudiantes: ");

            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine(estudiantes[i]);
            }
        }
    }
}
