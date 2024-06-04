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