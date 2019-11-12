using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex4();
        }


        public static void Ex4()
        {
            HashSet<string> conjA = new HashSet<string>();
            HashSet<string> conjB = new HashSet<string>();

            conjA.Add("Bahia");
            conjA.Add("Flamengo");
            conjA.Add("Palmeiras");
            conjA.Add("Sport");
            conjA.Add("Bragantino");
            conjA.Add("Botafogo");
            conjB.Add("Bragantino");
            conjB.Add("Fluminense");
            conjB.Add("Botafogo");

            //conjA.UnionWith(conjB);
            //conjA.IntersectWith(conjB);
            conjA.ExceptWith(conjB);

            foreach (string obj in conjA)
            {
                Console.WriteLine("Conjunto A "+obj);
            }
            Console.WriteLine("************************");

            foreach (string obj in conjB)
            {
                Console.WriteLine("Conjunto B " + obj);
            }
            Console.WriteLine("************************");



        }
        public static void Ex3()
        {

            int n = int.Parse(Console.ReadLine());

            double[,] mat = new double[n, n];
            double[] vet = new double[n];
            string[] ent = new string[n];

                                 
            int negativo = 0;

            for (int i = 0; i < mat.GetLength(0); i++)
            {

                ent = Console.ReadLine().Split(' ');

                for (int j = 0; j < mat.GetLength(1); j++)
                {

                    mat[i, j] = double.Parse(ent[j]);

                    if (mat[i,j] < 0)
                    {                        
                        negativo++;
                    }

                    if (i == j)
                    {
                        vet[i] = mat[i, j];
                    }
                    
                }
            }

            Console.WriteLine("Main diagonal: ");
            foreach (double obj in vet)
            {
                Console.Write(obj+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("Negative numbers = "+negativo);
           

        }

        static bool Predicado(string s)
        {
            return s == "Eros";
        }
        public static void Ex2()
        {
            List<string> list = new List<string>();

            list.Add("Afonsinho");
            list.Add("Adriano");
            list.Add("Eros");
            list.Add("Valéria");
            list.Add("Teste");
            list.Insert(0,"Phill");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("****************************************************");

            Console.WriteLine("Count: "+list.Count);
            Console.WriteLine("list.Find: " + list.Find(x => x.Contains("A")) );
            Console.WriteLine("list.FindLast: " + list.FindLast(x => x.Contains("A")));
            Console.WriteLine("list.FindIndex: " + list.FindIndex(x => x.Equals("Eros")));
            Console.WriteLine("list.FindIndex: " + list.FindIndex(x => x.Substring(0) == "A"));
           
            Console.WriteLine("****************************************************");

            string s = list.Find(Predicado);

            Console.WriteLine("xxxx" + s);


            List<string> list2 = list.FindAll(x => x[0] == 'A');

            foreach (string obj2 in list2)
            {
                Console.WriteLine("list2 :"+obj2 );
            }


        }

        public static void Ex1()
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("I - INCLUSÃO DE PRODUTOS");
            Console.WriteLine("E - EXCLUSÃO DE PRODUTOS");
            Console.WriteLine("L - LISTAR TODOS");
            Console.WriteLine("S - SAIR");
            Console.WriteLine("**********************************************");

            String comando = "";
            bool press = true;
            while (press)
            {
                comando = Console.ReadLine();

                if (comando.Equals("I"))
                {
                    Console.WriteLine("Incluir");

                }
                else if (comando.Equals("E"))
                {
                    Console.WriteLine("Excluir");

                }
                else if (comando.Equals("L"))
                {
                    Console.WriteLine("Listar");

                }
                else if (comando.Equals("S"))
                {
                    Console.WriteLine("Sair");
                    press = false;
                }
                else
                    Console.WriteLine("Opção inválida");


            }



            Console.Read();



            Produto p = new Produto("Televisao", 10, 1999.99F);
            Produto p1 = new Produto("Geladeira", 5, 399.99F);
            Produto p2 = new Produto("Notebook", 2, 725.99F);


            Console.WriteLine("Hello World!   " + p1);


        }

    }
}
