using System;
using System.ComponentModel;
using System.Dynamic;
using Test_with_commands;


namespace Tests_with_commands
{


    class Program
    {

        
        static void Main(string[] args)
        {

           
            
                Console.WriteLine("Plese, write the command listet below: \n" +
                " 'Add ticks/mosquitos/flies' - for adding \n" +
                " 'Kill ticks /mosquitos/flies' - for killing \n" +
                " 'Count all' - for counting all insects \n" +
                " 'Kill all' - for killing all insects");


                int ticksCountPlus = 0;
                int mosquitoesCountPlus = 0;
                int fliesCountPlus = 0;
                string AddCommand = Console.ReadLine();

                
                if (AddCommand == "Add ticks")
                
                Console.WriteLine("Please, write the number of ticks that you're want to add?");


                ticksCountPlus = Convert.ToInt32(Console.ReadLine());
                House TicksAdd = new House(ticksCountPlus);
                TicksAdd.StoreTicksSum(ticksCountPlus);

                Console.WriteLine($"{ticksCountPlus} ticks was added");
                Console.WriteLine($"ticks total number: {TicksAdd.CurrentTicksSum}");
            

            if (AddCommand.Contains($"Kill ticks"))
                {
                    Console.WriteLine("Please, write the number of ticks that you're want to kill?");
                    int ticks_count_mines = Convert.ToInt32(Console.ReadLine());
                    House TicksKilling = new House(ticksCountPlus);
                    TicksKilling.KillTicks(ticks_count_mines);

                    Console.WriteLine($"{ticks_count_mines} ticks was excluded");
                    Console.WriteLine($"ticks total number: {TicksKilling.CurrentTicksSum}");
                

                }

                else if (AddCommand.Contains($"Kill all"))
                {

                }

            /*do
            { 
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);*/



            /*int programStatus = 1;
            while (programStatus > 1)
            {

            }*/



            /*House TicksAdd = new House(0);
                TicksAdd.StoreTicksSum(ticksCountPlus);

                Console.WriteLine($"{ticksCountPlus} ticks was added");
                Console.WriteLine($"ticks total number: {TicksAdd.CurrentTicksSum}");*/



            /*House MosquitoesCountPlus = new House(0);
            int mosquitoes_add = Convert.ToInt32(Console.ReadLine());*/

            /* string AddCommand = Convert.ToInt32(Console.ReadLine());
             *//*if (AddCommand == Convert.ToInt32(IncomingCommand(Commands.Add, AnimalsEnum.ticks)))*//*

             if (AddCommand == IncomingCommand(Commands.Add))
             {
                 if (AddCommand == Convert.ToInt32(AnimalTypes()))) 
                 {
                     Console.WriteLine($"{AddCommand}");
                 }

             }*/


            

        }

        /*static void TicksPlus()
        {

        }*/
        /*private static bool IncomingCommand(Commands command)
        {


            if (command == Commands.Add)
            {

                *//*House TicksAdd = new House(0);
                TicksAdd.StoreTicksSum(ticksCountPlus);*//*

            }

            else if (command == Commands.Kill)
            {

            }

        }*/

        /*static void AnimalTypes(AnimalsEnum animal)
        {
            if (animal == AnimalsEnum.ticks)
            {

            }
        }*/

        interface IAlive
        {
            int CurrentTicksSum { get; }
            void StoreTicksSum(int sum);
            void KillTicks(int sum);
        }
        interface IInsect /*ITicks*/
        {
            int TicksAdd { get; }
            int MosquitoesAdd { get; }
            int FliesAdd { get; }
        }
        /*interface IMosquitoes
        {
            
        }
        interface IFlies
        {
            
        }
*/
        class House : IAlive, IInsect/*, IMosquitoes, IFlies*/
        {
            private int TicksSum;
            private int MosquitoesSum;
            private int FliesSum;
            private int v;

            public House(int sumOfTicks, int sumOfMosquitoes, int sumOfFlies)
            {
                
                this.TicksSum = sumOfTicks;
                this.MosquitoesSum = sumOfMosquitoes;
                this.FliesSum = sumOfFlies;

            }

            public House(int v)
            {
                this.v = v;
            }

            public int CurrentTicksSum { get { return TicksSum; } }

            public int TicksAdd { get; }

            public int MosquitoesAdd { get; }

            public int FliesAdd { get; }

            public void StoreTicksSum(int sumOfTicks)
            {
                TicksSum += sumOfTicks;
            }
            public void StoreMosquitoesSum(int sum)
            {
                MosquitoesSum += sum;
            }
            public void StoreFliesSum(int sum)
            {
                FliesSum += sum;
            }


            public void KillTicks(int sum)
            {
                if (TicksSum >= sum)
                {
                    TicksSum -= sum;

                }
                else if (MosquitoesSum >= sum)
                {
                    MosquitoesSum -= sum;
                }
                else if (FliesSum >= sum)
                {
                    FliesSum -= sum;
                }
                else
                {
                    Console.WriteLine("You can't kill any ticks");
                }
            }
        }
    }
}
