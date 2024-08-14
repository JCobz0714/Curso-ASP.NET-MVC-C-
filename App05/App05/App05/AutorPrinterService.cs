namespace App05
{
    public class AutorPrinterService
    {
        private readonly IRepository<Autor> _autorRepository;

        public AutorPrinterService(IRepository<Autor> autorRepository)
        {
            _autorRepository = autorRepository;
        }

        public void PrintAutores()
        {
            //Convertir la variable a tipo array para que el Array.Sort lo
            //reconozca
            var autores = _autorRepository.List().ToArray();
            Array.Sort(autores);

            Console.WriteLine("Imprimiendo lista de Autores desde el metodo PrintAutores: ");

            for (int i = 0; i < autores.Length; i++)
            {
                Console.WriteLine(autores[i]);
            }
        }
    }
}
