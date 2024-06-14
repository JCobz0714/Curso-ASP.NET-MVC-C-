namespace App04
{
    public class Documento : IOperaciones
    {
        private string nombre;

        public Documento(string s)
        {
            nombre = s;
        }

        //Hay que implementar los metodos de la interfaz para que no me genere ningun
        //error
        public void Cargar()
        {
            Console.WriteLine("Este metodo es para cargar un documento");
        }

        public void Guardar()
        {
            Console.WriteLine("Este metodo es para guardar un documento");
        }

        public bool NecesitaGuardar()
        {
            return false;
        }
    }
}
