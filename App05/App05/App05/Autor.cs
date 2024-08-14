namespace App05
{
    //Quiero que la interfaz IComparable trabaje con datos de tipo "Autor"
    public class Autor : IComparable<Autor>
    {

        public string? Nombre { get; set; }

        public string? Apellido { get; set; }

        public Autor(string? nombre, string? apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }

        /*
        public int CompareTo(object? obj)
        {
            if(obj is null) return 1;

            //Comparar sobre el nombre completo, comparandolo con el metodo ToString
            if(obj is Autor miAutor)
            {
                return this.ToString().CompareTo(miAutor.ToString());
            }

            throw new ArgumentException("No es un tipo Autor", nameof(obj));
        }
        */

        //Hay que indicar que el tipo de parametro que va a recibir es un tipo Autor
        public int CompareTo(Autor? miAutor)
        {
            //Con esto, evitamos hacer varios casteos o cambios de tipo de dato innecesarios
            return this.ToString().CompareTo(miAutor?.ToString());
        }
    }
}
