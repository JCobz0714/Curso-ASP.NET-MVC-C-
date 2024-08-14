namespace App05
{
    //Cargando los datos que se van a utilizar en la clase "Estudiante"
    public class EstudianteRepository : IEstudianteRepository
    {
        public Estudiante[] List()
        {
            var estudiantes = new Estudiante[10];

            estudiantes[0] = new Estudiante("Vaxi", "Drez");
            estudiantes[1] = new Estudiante("Maria", "Lopez");
            estudiantes[2] = new Estudiante("Nestor", "Arcila");
            estudiantes[3] = new Estudiante("Joaquin", "Camino");
            estudiantes[4] = new Estudiante("Roberto", "Dulanto");
            estudiantes[5] = new Estudiante("Juan", "Garcia");
            estudiantes[6] = new Estudiante("Luisa", "Ramirez");
            estudiantes[7] = new Estudiante("Luis", "Ojeda");
            estudiantes[8] = new Estudiante("Angela", "Arias");
            estudiantes[9] = new Estudiante("Ramiro", "Lopez");

            return estudiantes;
        }
    }
}
