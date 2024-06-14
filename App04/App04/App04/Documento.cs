namespace App04
{
    //Para heredar de multiples interfaces, se agregan precedidos por una
    //coma
    public class Documento : IOperaciones, IMensajeria
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

        public void EnviarEmail(){
            Console.WriteLine("Enviar correo electronico por gmail");
        }

        public void EnviarMensajeTexto(){
            Console.WriteLine("Enviar mensaje de texto por iphone");
        }

        public void EnviarNotification(){
            Console.WriteLine("Enviar Notification por login");
        }
    }
}
