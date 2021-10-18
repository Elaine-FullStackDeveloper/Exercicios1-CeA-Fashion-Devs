using System;

namespace exercicio5a
{
    class Program
    {
        static void Main(string[] args)
        {
            animal animal1 = new animal();
            animal animal2 = new animal();
            animal animal3 = new animal();
            animal animal4 = new animal();
            animal animal5 = new animal();

            int ContadorCachorro = 0; 
            int ContadorGato = 0;
            int ContadorPeixe = 0;

            Console.WriteLine("Informe o nome do primeiro animal: ");
            animal1.nomeAnimal = Console.ReadLine();
            Console.WriteLine("Informe o tipo do primeiro animal (cachorro, gato ou peixe): ");
            animal1.tipoAnimal = Console.ReadLine();

            if(animal1.tipoAnimal == "cachorro") ContadorCachorro++;
            if(animal1.tipoAnimal == "gato") ContadorGato++;
            if(animal1.tipoAnimal == "peixe") ContadorPeixe++;

            Console.WriteLine("Informe o nome do segundo animal: ");
            animal2.nomeAnimal = Console.ReadLine();
            Console.WriteLine("Informe o tipo do segundo animal (cachorro, gato ou peixe): ");
            animal2.tipoAnimal = Console.ReadLine();

            if(animal2.tipoAnimal == "cachorro") ContadorCachorro++;
            if(animal2.tipoAnimal == "gato") ContadorGato++;
            if(animal2.tipoAnimal == "peixe") ContadorPeixe++;

            Console.WriteLine("Informe o nome do terceiro animal: ");
            animal3.nomeAnimal = Console.ReadLine();
            Console.WriteLine("Informe o tipo do terceiro animal (cachorro, gato ou peixe): ");
            animal3.tipoAnimal = Console.ReadLine();

            if(animal3.tipoAnimal == "cachorro") ContadorCachorro++;
            if(animal3.tipoAnimal == "gato") ContadorGato++;
            if(animal3.tipoAnimal == "peixe") ContadorPeixe++;

            Console.WriteLine("Informe o nome do quarto animal: ");
            animal4.nomeAnimal = Console.ReadLine();
            Console.WriteLine("Informe o tipo do quarto animal (cachorro, gato ou peixe): ");
            animal4.tipoAnimal = Console.ReadLine();

            if(animal4.tipoAnimal == "cachorro") ContadorCachorro++;
            if(animal4.tipoAnimal == "gato") ContadorGato++;
            if(animal4.tipoAnimal == "peixe") ContadorPeixe++;

            Console.WriteLine("Informe o nome do quinto animal: ");
            animal5.nomeAnimal = Console.ReadLine();
            Console.WriteLine("Informe o tipo do quinto animal (cachorro, gato ou peixe): ");
            animal5.tipoAnimal = Console.ReadLine();

            if(animal5.tipoAnimal == "cachorro") ContadorCachorro++;
            if(animal5.tipoAnimal == "gato") ContadorGato++;
            if(animal5.tipoAnimal == "peixe") ContadorPeixe++;

            Console.WriteLine("\n Cachorros: {0}; \n Gatos: {1} \n Peixes: {2} \n", ContadorCachorro, ContadorGato, ContadorPeixe);
        }
    }
}
