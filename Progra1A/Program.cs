static void ejercicio1()
{
    int dividendo = 0;
    int divisor = 0;
    int resultado = 0;


    Console.WriteLine("Ingrese Dividendo: ");
    dividendo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese el divisor: ");
    divisor = int.Parse(Console.ReadLine());

    if (dividendo != 0)
    {
        resultado = dividendo / divisor;
        Console.WriteLine("Resultado forma 1 =" + resultado);
        Console.WriteLine("Resultado forma 2= {0}", resultado);
        Console.WriteLine($"Resultado forma 3= {resultado}");
    }
    else
    {
        Console.WriteLine("Orale chatio, no podes poner 0 en el divisor");
    }
}

//fin del ejercicio1

static void calculadora()
{
    float a = 0.0f;
    float b = 0.0f;
    float resultado = 0.0f;
    string valor = "";
    int opcion = 0;

    //mostrar menu
  
    Console.WriteLine("1- Suma");
    Console.WriteLine("2- Resta");
    Console.WriteLine("3- Division");
    Console.WriteLine("4- Multiplicacion");
    Console.WriteLine("Ingrese la operacion que desea hacer");

    valor= Console.ReadLine();
    opcion= Convert.ToInt32(valor);

    //pedir el primer valor
    Console.WriteLine("Ingrese el primer numero ");
    valor = Console.ReadLine();
    a =Convert.ToSingle(valor);

    Console.WriteLine("Ingrese el segundo numero ");
    valor = Console.ReadLine();
    b = Convert.ToSingle(valor);  
    
    //verificar las opciones

    if (opcion== 1)
    {
        resultado = a + b;
    }
    if (opcion == 2)
    {
        resultado = a - b;
    }
    if (opcion == 3)
    {
        if (b !=0)
        {
            resultado = a / b;
        }
        else
        {
            Console.WriteLine("No debe ingresar 0");
        }
        
    }
    if (opcion == 4)
    {
        resultado = a * b;
    }
    Console.WriteLine("El resultado es "+ resultado);

}
// fin de calculadora

static void desglose()
{
    int CAN, C100, C50, C20, C10, C5;
    CAN = C100 = C50 = C20 = C10 = C5 = 0;
    string linea;

    Console.Write("Ingrese una cantidad: ");
    linea = Console.ReadLine();
    CAN = Convert.ToInt32(linea);

    if ((CAN >= 100))
    {
        C100 = (CAN / 100);
        CAN = CAN - (C100 * 100);

    }

    if ((CAN >= 50))
    {
        C50 = (CAN / C50);
        CAN = CAN - (C50 * 50);
    }
    if ((CAN >= 20))
    {
        C20 = (CAN / C20);
        CAN = CAN - (C20 * 20);
    }
    if ((C10 >= 10))
    {
        C10 = (CAN / C10);
        CAN = CAN - (C10 * 10);
    }
    if ((CAN >= 5))
    {
        C5 = (CAN / C5);
        CAN = CAN - (C5 * 5);
    }

    Console.WriteLine($"--ESTOS SON BILLETES");
    Console.WriteLine();
}

//ejercicio1();
//calculadodra();
calculadora();
desglose();