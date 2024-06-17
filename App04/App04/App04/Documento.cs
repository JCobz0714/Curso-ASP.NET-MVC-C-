namespace App04
{
    //Para heredar de multiples interfaces, se agregan precedidos por una
    //coma
    public class Documento : IOperaciones, IMensajeria, INotifyPropertyChanged
    {
        private string nombre;
        
        public string DocumentoNombre(){
            get {return nombre};
            set{nombre = value;
            Notify NotifyPropChanged("DocumentoNombre")}
        }
        
        public Documento(string s)
        {
            nombre = s;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropChanged(string propName){
            PropertyChanged(this, new PropertyChangedEventArgs(propName));
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
