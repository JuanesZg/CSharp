// //Suma en programacion estructurada
// Console.WriteLine("Numero Uno");
// int num_uno = int.Parse(Console.ReadLine());

// Console.WriteLine("Numero Dos");
// int num_dos = int.Parse(Console.ReadLine());

<<<<<<< HEAD
// Console.WriteLine("Que operacion desea realizar?\n1. Suma\n2. Resta\n3. Multiplicacion\n4. Division");
// int opera = int.Parse(Console.ReadLine());

// //Se crea un objeto o instancia a partir de la clase
// var operacion_uno = new OperacionesAritmeticas(){
//     numero_uno = num_uno,
//     numero_dos = num_dos,
//     operation = opera
// };

// Puedo tener varios objetos o instancias referidos de la misma clase
// var operacion_dos = new OperacionesAritmeticas(){
//    numero_uno = num_uno,
//    numero_dos = num_dos
// };

//Para mostrar los resultados de la suma, se debe hacer la operacion a traves
//Del Objeto ya que es la que ahora tiene los atributos

// operacion_uno.printResultado();

//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Console.WriteLine("Cuántos días planea hospedarse en el hotel?");
int diasEnHotel = int.Parse(Console.ReadLine());

Console.WriteLine("Que tipo de habitación desea?\n- 'Individual'\n- 'Doble'\n- 'Familiar'");
string TarifaHabitacion = (Console.ReadLine());

var Hotel_Uno = new TarifasHoteleras(){
    diasEstadia = diasEnHotel,
    Tarifa = TarifaHabitacion
};

Hotel_Uno.printOperacionTarifas();


=======
Console.WriteLine("Digite la operación que desea realizar\n1. Suma\n2. Resta\n3. Multiplicación\n4. División\n0. Salir");
int opera = int.Parse(Console.ReadLine());

//Se crea un objeto o instancia a partir de la clase
var operacion_uno = new OperacionesAritmeticas(){
    numero_uno = num_uno,
    numero_dos = num_dos,
    operation = opera
};
//Puedo tener varios objetos o instancias referidos de la misma clase
var operacion_dos = new OperacionesAritmeticas(){
    numero_uno = num_uno,
    numero_dos = num_dos,
    operation = opera
};

//Para mostrar los resultados de la suma, se debe hacer la operacion a traves
//Del Objeto ya que es la que ahora tiene los atributos
>>>>>>> 5bd8e7133e28baac79dbb1cd58bd8ee44a66ae8c
