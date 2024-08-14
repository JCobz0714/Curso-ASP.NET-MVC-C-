namespace App05
{
    public class AutorRepository : IAutorRepository
    {
        public Autor[] List()
        {
            var autores = new Autor[10];

            autores[0] = new Autor("Vaxi", "Drez");
            autores[1] = new Autor("Maria", "Lopez");
            autores[2] = new Autor("Nestor", "Arcila");
            autores[3] = new Autor("Joaquin", "Camino");
            autores[4] = new Autor("Roberto", "Dulanto");
            autores[5] = new Autor("Juan", "Garcia");
            autores[6] = new Autor("Luisa", "Ramirez");
            autores[7] = new Autor("Luis", "Ojeda");
            autores[8] = new Autor("Angela", "Arias");
            autores[9] = new Autor("Ramiro", "Lopez");

            return autores;
        }
    }
}
