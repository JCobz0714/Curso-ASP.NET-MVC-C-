namespace App05
{
    /*
    Para poder declarar una clase o una interfaz de tipo generica, se tiene
    que agregar la notacion diamante al costado del nombre de la clase o de
    la interfaz, y dentro de la notacion diamante, colocar la letra "T", que es
    una representacion de que se trata de un componente generico y este puede
    tomar cualquier valor
     */

    /*
    Donde T tiene que ser de tipo IComparable, debe de derivar de IComparable

    Con esto indicamos que, aquellas clases que implementen la interfaz IRepository,
    tienen que obligatoriamente implementar el IComparable
    */
    public interface IRepository<T> where T : Persona, IComparable<T>
    {
        //La "T" representa a una clase o interfaz generico
        IEnumerable<T> List();
        IEnumerable<T> OrdenarList();
    }
}
