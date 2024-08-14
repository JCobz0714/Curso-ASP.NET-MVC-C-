namespace App05
{
    public class Estudiante : IComparable<Estudiante>
    {
        //Propiedades que a futuro van a aceptar nulls
        public string? Nombre { get; set; }

        public string? Apellido { get; set; }

        //Las variables estaticas nunca se resetean, siempre mantienen su valor
        //en el tiempo de ejecucion del programa
        public static int estudianteCount = 0;

        public Estudiante(string? nombre, string? apellido)
        {
            Nombre = nombre;
            Apellido = apellido;

            //Cada vez que se genere un nuevo objeto de estudiante, la variable
            //estudianteCount se incremente en 1
            estudianteCount++;
        }

        //Heredando de la clase "object", cogemos este metodo ToString()
        public override string ToString()
        {
            //Imprime los valores determinados de cada clase, en este caso,
            //los valores de la clase "Estudiante.cs"
            return $"{Nombre} {Apellido}";
        }

        public int CompareTo(Estudiante? miEstudiante)
        {
            //Si obj es de tipo estudiante, entonces quiero que lo instancie o que haga una representacion de
            //este objeto tipo Estudiante
            //Primero se verifica si el objeto es de tipo Estudiante. Si lo es,
            //se instancia un objeto tipo estudiante llamado "miEstudiante" con
            //los valores que tiene el parametro "obj"

            //Si se repiten apellidos, hacer la comparacion por el nombre
            if (miEstudiante?.Apellido == this.Apellido)
            {
                return this.Nombre!.CompareTo(miEstudiante?.Nombre);
            }

            //Si los apellidos no son iguales, comparar y organizar por apellido
            return this.Apellido!.CompareTo(miEstudiante?.Apellido);

            //Mostrar una excepcion si el objeto no es de tipo "Estudiante"
            //throw new ArgumentException("No es un objeto de tipo Estudiante", nameof(miEstudiante));
        }
    }

    //Los record son muy similares a las clases, cumplen el mismo objetivo que es
    //el almacenamiento de data
    public record NombreCompleto(string nombre, string apellido);
}
