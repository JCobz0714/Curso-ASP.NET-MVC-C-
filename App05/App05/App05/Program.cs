using App05;

var estudiantes = new Estudiante[10];

estudiantes[0] = new Estudiante("Vaxi", "Drez");
estudiantes[1] = new Estudiante("Maria", "Lopez");
estudiantes[2] = new Estudiante("Nestor", "Arcila");
estudiantes[3] = new Estudiante("Joaquin", "Camino");
estudiantes[4] = new Estudiante("Roberto", "Dulanto");
estudiantes[5] = new Estudiante("Juan", "Garcia");
estudiantes[6] = new Estudiante("Luisa", "Ramirez");
estudiantes[7] = new Estudiante("Luis", "Ojeda");

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