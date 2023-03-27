class OperacionesAritmeticas{
    //Propiedades - Atributos
    public int numero_uno { get; set; }
    public int numero_dos { get; set; }
    public int operation { get; set; }
    //Metodos (Funciones o Acciones)
    public int sumar_num (int n1, int n2){
        //Operaciones
        int ResultadoSuma = n1 + n2;
        //Salida - Impresa o Return
        return ResultadoSuma;
    }
    public int restar_num (int n1, int n2){
        //Operaciones
        int ResultadoResta = n1 - n2;
        //Salida - Impresa o Return
        return ResultadoResta;
    }
    public int multiplicar_numeros (int n1, int n2){
        int ResultadoMultiplicacion = n1 * n2;
        return ResultadoMultiplicacion;
    }
    public float dividir_numeros (int n1, int n2){
        float ResultadoDivision = n1 / n2;
        return ResultadoDivision;
    }
<<<<<<< HEAD
    public void PrintSuma(){
        int ResultadoOperacion = sumar_num(numero_uno, numero_dos);
        Console.WriteLine($"La suma es {ResultadoOperacion}");
    }
    public void PrintResta(){
        int ResultadoOperacion = restar_num(numero_uno, numero_dos);
        Console.WriteLine($"La resta es {ResultadoOperacion}");
    }
    public void PrintMultiplicacion(){
        int ResultadoOperacion = multiplicar_numeros(numero_uno, numero_dos);
        Console.WriteLine($"La multiplicacion es {ResultadoOperacion}");
    }
    public void PrintDivision(){
        float ResultadoOperacion = dividir_numeros(numero_uno, numero_dos);
        Console.WriteLine($"La division es {ResultadoOperacion}");
    }
    public void printResultado(){
        switch (operation)
        {
            case 1:
                PrintSuma();
                break;
            case 2:
                PrintResta();
                break;
            case 3:
                PrintMultiplicacion();
                break;
            case 4:
                PrintDivision();
                break;
            default:
                Console.WriteLine("Operación inválida");
                break;
        }
    }



=======
    public void operacion_num (){
        if (operation == 1)
        {
            sumar_num();
        }
        else if (operation == 2)
        {
            restar_num();
        }
        else if (operation == 3)
        {
            multiplicar_numeros();
        }
        else if (operation == 4)
        {
            dividir_numeros();
        }
        else
        {
            Console.WriteLine("Operación inválida");
        }
    }
>>>>>>> 5bd8e7133e28baac79dbb1cd58bd8ee44a66ae8c
    //Metodo constructor - no se ve pero siempre se llama igual que la clase
}