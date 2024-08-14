namespace App05
{
    /*
    Para poder declarar una clase o una interfaz de tipo generica, se tiene
    que agregar la notacion diamante al costado del nombre de la clase o de
    la interfaz, y dentro de la notacion diamante, colocar la letra "T", que es
    una representacion de que se trata de un componente generico y este puede
    tomar cualquier valor
     */
    public interface IRepository<T>
    {
        //La "T" representa a una clase o interfaz generico
        IEnumerable<T> List();
    }
}
