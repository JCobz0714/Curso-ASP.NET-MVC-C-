namespace App04
{
    //Las interfaces solo permiten crear metodos abstractos, la logica la implementara
    //la clase hijo
    public interface IOperaciones
    {
        //Declarando los metodos SIN la implementacion
        void Guardar();
        void Cargar();
        bool NecesitaGuardar();
    }
}
