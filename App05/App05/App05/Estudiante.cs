namespace App05
{
    public class Estudiante : IComparable
    {
        //Propiedades que a futuro van a aceptar nulls
        public string? Nombre { get; set; }

        public string? Apellido { get; set; }

        public Estudiante(string? nombre, string? apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        //Heredando de la clase "object", cogemos este metodo ToString()
        public override string ToString()
        {
            //Imprime los valores determinados de cada clase, en este caso,
            //los valores de la clase "Estudiante.cs"
            return $"{Nombre} {Apellido}";
        }

        public int CompareTo(object? obj)
        {
            if (obj is null) return 1;

            //Si obj es de tipo estudiante, entonces quiero que lo instancie o que haga una representacion de
            //este objeto tipo Estudiante
            //Primero se verifica si el objeto es de tipo Estudiante, si lo es
            //se instancia un objeto tipo estudiante llamado "miEstudiante" con
            //los valores que tiene el parametro "obj"
            if (obj is Estudiante miEstudiante)
            {
                //Si se repiten apellidos, hacer la comparacion por el nombre
                if (miEstudiante.Apellido == this.Apellido)
                {
                    return this.Nombre!.CompareTo(miEstudiante.Nombre);
                }
                //Si los apellidos no son iguales, comparar y organizar por apellido
                return this.Apellido!.CompareTo(miEstudiante.Apellido);
            }
            //Mostrar una excepcion si el objeto no es de tipo "Estudiante"
            throw new ArgumentException("No es un objeto de tipo Estudiante", nameof(obj));
        }
    }
}
