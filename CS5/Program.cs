using System;

namespace CS5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Unidad 1: Estructuras de control II
            // Unidad 2: Funciones II
            // Sesion 12: Instruccion while 30/09/2026
            // Sintaxis: while
            // inicializacion;
            // while(expresion)
            //{
            //  Bloque de instrucciones
            //  iterador;    
            //}
            // iterador: es una instruccion que me permite repetir o terminar el ciclo.
            // ejemplo 1: Ciclo ascendente (rango: 1-3)
            // m: variable de control
            int m = 1; // inicializacion
            while(m <= 3) // expresion
            {
                //bloque de instrucciones
                Console.WriteLine($"m: {m}");
                m += 1; // Iterador
            }
            // ejercitacion
            // 1. definir un ciclo para imprimir tu nombre 5 veces
            // Nota: para la expresion, utilizar el operador <.
            // a. Ciclo ascendente
            int m = 1; // inicializacion
            while(m < 6) // expresion
            {
                //bloque de instrucciones
                Console.WriteLine("Nombre: Franco");
                m += 1; // Iterador
            }
            // b. decrementos
            int d = 3; // inicializacion
            while(d >= 1) // expresion
            {
                //bloque de instrucciones
                Console.WriteLine($"d: {d}");
                d -= 1; // Iterador
            }
            // c. Incrementos
            // Secuencia: 3 6 9 12 15 18
            int i = 3; // inicializacion
            while(i <= 18) // expresion
            {
                //bloque de instrucciones
                Console.WriteLine($"i: {i}");
                i += 3; // Iterador
            }
            //d. decrementos
            // Ejercitacion -------------------(La hice yo)--------------------
            int c = 16; // inicializacion
            while(c >= 2) // expresion
            {
                //bloque de instrucciones
                Console.WriteLine("331");
                c -= 2; // Iterador
            }
            // Actividad 1: Ciclo infinito
            // 1. Definir un ciclo infinito ascendente.
            // 2. Definir un cilco infinito descendente.
            // Nota: para la solucion, utilizar el operador de diferencia
            int ia = 1;
            while(ia != 0)
            {
                Console.WriteLine($"ia: {ia}");
                ia += 1;
            }
            int id = 0;
            while(id != 1)
            {
                Console.WriteLine($"id: {id}");
                id -= 1;
            }
        }
    }
}

/*
            Sintaxis

Inicializacion;
while (expresion para funcionamiento del ciclo)
{
    bloque de instrucciones (ya sea una o mas)
    iterador;
}