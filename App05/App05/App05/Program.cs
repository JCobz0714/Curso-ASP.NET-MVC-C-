//TODO LO COMENTADO FUE BORRADO EN EL CURSO

/*using App05;

var estudiantes = new Estudiante[10];

estudiantes[0] = new Estudiante("Vaxi", "Drez");
estudiantes[1] = new Estudiante("Maria", "Lopez");
estudiantes[2] = new Estudiante("Nestor", "Arcila");
estudiantes[3] = new Estudiante("Joaquin", "Camino");
estudiantes[4] = new Estudiante("Roberto", "Dulanto");
estudiantes[5] = new Estudiante("Juan", "Garcia");
estudiantes[6] = new Estudiante("Luisa", "Ramirez");
estudiantes[7] = new Estudiante("Luis", "Ojeda");
estudiantes[8] = new Estudiante("Angela", "Arias");
estudiantes[9] = new Estudiante("Ramiro", "Lopez");

//Para organizar una coleccion de objetos, se puede implementar la interface
//"IComparable".
//Para hacer que el array se organice debo de llamar a una instancia del
//"Array", que es una clase utilitaria que tiene metodos como "Sort".
//Vamos a organizar cada una de las entradas del arreglo en orden alfabetico.
Array.Sort(estudiantes);

for (int i = 0; i < estudiantes.Length; i++)
{
    //No es necesario llamar al metodo ".ToString()" del objeto "Estudiante" para imprimir el contenido del
    //objeto, ya que "Console.WriteLine" tiene incorporado esa funcion.
    Console.WriteLine(estudiantes[i]);
}

var autores = new Autor[10];

for(int i = 0; i < autores.Length; i++)
{
    autores[i] = new Autor(estudiantes[i].Nombre, estudiantes[i].Apellido);
}

Array.Sort(autores);

Console.WriteLine("ESTA ES LA LISTA DE AUTORES:");

for(int i = 0; i < autores.Length; i++)
{
    Console.WriteLine(autores[i]);
}
*/

using App05;

/*
Se cargan los datos que estan en el repositorio "EstudianteRepository" a la clase "EstudiantePrinterService"
para poder utilizar el metodo para imprimir los datos que se encuentran en dicho repositorio
*/
var estudianteService = new EstudiantePrinterService(new EstudianteRepository());
estudianteService.PrintEstudiantes();

var autorService = new AutorPrinterService(new AutorRepository());
autorService.PrintAutores();