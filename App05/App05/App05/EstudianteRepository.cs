namespace App05
{
    //Cargando los datos que se van a utilizar en la clase "Estudiante"
    public class EstudianteRepository : IPersonaRepository<Estudiante>
    {
        //Declarando un arreglo que represente los nombres de los estudiantes.
        /*
        Se crea un tipo de dato llamado "NombreCompleto". Dentro de la clase
        EstudianteRepository, creamos una variable/objeto/coleccion de 10
        elementos de nombres, y se esta cargando la data en el constructor
        de la clase
        */
        private NombreCompleto[] _nombres = new NombreCompleto[10];

        public EstudianteRepository()
        {
            //Como es de tipo "record", no necesito definir el tipo
            _nombres[0] = new ("Vaxi", "Drez");
            _nombres[1] = new ("Maria", "Lopez");
            _nombres[2] = new ("Nestor", "Arcila");
            _nombres[3] = new ("Joaquin", "Camino");
            _nombres[4] = new ("Roberto", "Dulanto");
            _nombres[5] = new ("Juan", "Garcia");
            _nombres[6] = new ("Luisa", "Ramirez");
            _nombres[7] = new ("Luis", "Ojeda");
            _nombres[8] = new ("Angela", "Arias");
            _nombres[9] = new ("Ramiro", "Lopez");
        }

        public IEnumerable<Estudiante> Buscar(string nombre)
        {
            /*
            El metodo Where pertenece a la coleccion de Link. Link es una herramienta
            que permite hacer busquedas dentro de colecciones de datos.

            Este return lo que hace es devolverme la busqueda de un determinado
            estudiante pasandole como parametro el nombre. 
            */
            return List().Where(estudiante => estudiante.Nombre!.Contains(nombre)
            || estudiante.Apellido!.Contains(nombre));
        }

        public Estudiante Crear(NombreCompleto nombre)
        {
            return new Estudiante(nombre.nombre, nombre.apellido);
        }

        public Estudiante CrearPorDefecto()
        {
            return new Estudiante();
        }

        //Trabajar con un tipo IEnumerable porque es mas dinamico que un array
        public IEnumerable<Estudiante> List()
        {
            int index = 0;

            while(index < _nombres.Length)
            {
                /*
                Lo que hace el "yield" en este caso es agregar el elemento
                generado de "Estudiante" al interior de la coleccion
                "IEnumerable<Estudiante>" dinamicamente
                */
                yield return new Estudiante(_nombres[index].nombre, _nombres[index].apellido);
                index++;
            }
        }

        public IEnumerable<Estudiante> OrdenarList()
        {
            var estudiantes = List().ToList();
            estudiantes.Sort();
            return estudiantes;
        }
    }
}
