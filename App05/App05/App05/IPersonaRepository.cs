namespace App05
{
    /*
    Se estan implementando todos los metodos que tiene IRepository dentro de esta
    interfaz que se llama IPersonaRepository.

    Basicamente lo que se esta haciendo es: IRepository tiene dos metodos (List y
    OrdenarList), estos dos metodos se estan agregando automaticamente a la interfaz
    IPersonaRepository, no hay necesidad de declararlos porque ya existen.

    Algo adicional que se haciendo es que, al ser una interfaz generica, le indico de que
    cuando sea implementada dicha interfaz, la clase que la implemente tiene que
    OBLIGATORIAMENTE heredar a Persona y a IComparable.

    La expresion "new()" obliga a las clases a tener obligatoriamente un constructor
    vacio o sin parametros.
    */
    public interface IPersonaRepository<T> : IRepository<T> where T : Persona, IComparable<T>, new()
    {
        IEnumerable<T> Buscar(string nombre);
        T Crear(NombreCompleto nombre);
        T CrearPorDefecto();
    }

    //
    /*
    Otra forma de implementar una interfaz generica.
    
    Tambien se puede declarar a nivel del metodo.
    */
    /*
    public interface IPersonaRepository
    {
        IEnumerable<T> Buscar<T>(string nombre) where T : Persona;
        T Crear<T>(NombreCompleto nombre) where T : Persona;
        T CrearPorDefecto<T>() where T : Persona;
    }
    */
}
