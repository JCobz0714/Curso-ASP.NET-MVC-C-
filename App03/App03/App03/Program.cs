/*
using App03;

var objeto = new ClassFuncion();

MiDelegate f = objeto.func1;
Console.WriteLine($"El resultado es {f(10, 100)}");

f = objeto.func2;
Console.WriteLine($"El resultado es {f(56, 78)}");

var objeto2 = new MiClase();
f = objeto2.InstanciaDeMetodo;
Console.WriteLine($"El resultado de la formula es {f(89, 100)}");

public delegate string MiDelegate(int arg1, int arg2);
*/

/*
//Como es un delegate anonimo, puedo agregarle la logica que yo quiera
//Primero hay que definir el delegate antes de declararlo
//Un delegate anonimo es un delegate al cual no se le agrega la logica
//de un metodo ya existente, sino que tiene su propia logica
MiDelegado f = delegate (int i, string s)
{
    return i + 100;
};

//Llamando al delegate
int resultado = f(250, "Es Jacobo Osorio");

//Delegates anonimos
public delegate int MiDelegado(int i, string s);
*/

/*
static void func1(int arg1, int arg2)
{
    string resultado = (arg1 + arg2).ToString();
    Console.WriteLine(resultado);
};

static void func2(int arg1, int arg2)
{
    string resultado = (arg1 * arg2).ToString();
    Console.WriteLine(resultado);
};

MiDelegado f1 = func1;
MiDelegado f2 = func2;

//Crear un delegado que concatene esos dos delegados
MiDelegado f1f2 = f1 + f2;

//Parametros que van a ingresar a ejecucion del delegate
int arg1 = 10;
int arg2 = 20;

Console.WriteLine("La implementacion del primer delegate");
f1(arg1, arg2);

Console.WriteLine("La implementacion del segundo delegate");
f2(arg1, arg2);

//Al llamar a la variable f1f2, se van a ejecutar dos funciones al mismo tiempo, en vez
// de ejecutar una por una
Console.WriteLine("Se estan ejecutando el primer y segundo delegate al mismo tiempo");
f1f2(arg1, arg2);

//Si se quiere ignorar o quitar un metodo que esta en el delegate al momento de la
//ejecucion, se tiene que restar, y a partir de ahi, el delegate ejecuta con lo que
//se queda (En este caso, como se resto el f2 de la variable f1f2 que antes valia
//f1 + f2, queda solamente al final el f1 para ser ejecutado)
//Al final se ejecuta la funcion que queda de la diferencia de esas dos funciones

//f1f2 = f1f2 - f2;
f1f2 -= f2;
Console.WriteLine("Ejecutando la concatenacion pero sin el f2");
f1f2(arg1, arg2);

//Delegates compuestos
public delegate void MiDelegado(int arg1, int arg2);
*/

//EVENTOS Y EVENTOS ENCADENADOS

using App03;

//Los eventos se ejecutan de manera secuencial, la secuencia depende de la
//implementacion del metodo (el orden de implementacion)

var obj = new EventPublisher();
/* Cuando se ejecute el evento de valueChanged que es simplemente cambiar el valor de
una variable, se va a realizar ese cambio del valor de la variable y se va a ejecutar
tambien la logica del metodo "obj_valueChanged" que lo que hace es simplemente
imprimir un mensaje */
obj.valueChanged += new MiEventoHandler(obj_valueChanged1);

//Tambien se puede escribir el delegate de la siguiente forma (con un delegate anonimo)
obj.valueChanged += delegate (string value)
{
    Console.WriteLine($"Se esta disparando el evento handler 1 {value}");
};

//Este metodo captura el evento, mas especificamente capturando el valor de la
//propiedad que cambio
void obj_valueChanged1(string value)
{
    Console.WriteLine($"Se esta disparando el evento handler 2 {value}");
}

obj.valueChanged += new MiEventoHandler(obj_valueChanged2);

void obj_valueChanged2(string value)
{
    Console.WriteLine($"Se esta disparando el evento handler 3 {value}");
}

string str;

do
{
    Console.WriteLine("Ingrese un valor: ");
    str = Console.ReadLine();

    if (!str.Equals("salir"))
    {
        obj.val = str;
    }
} while(!str.Equals("salir"));

Console.WriteLine("Culmino el programa porque escribio 'salir'");

//Para trabajar con eventos, hay que declarar un delegate
public delegate void MiEventoHandler(string value);