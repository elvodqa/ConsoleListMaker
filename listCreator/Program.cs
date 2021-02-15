using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;

            List<string> list = new List<string>();

            

            do
            {
                Console.WriteLine("1 for adding people to list");
                Console.WriteLine("2 for deleting people from the list");
                Console.WriteLine("3 for viewing the list");
                Console.WriteLine("4 for exit the app");

                menu = Convert.ToInt32(Console.ReadLine());
                
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("-----Add Person-----");
                        
                        string person = Console.ReadLine();
                        list.Add(person);
                        Console.WriteLine("-Person added-");
                        
                        break;
                    case 2:
                        Console.WriteLine("-----Delete Person-----");
                        Console.WriteLine("");
                        Console.WriteLine("Enter the person you want to delete:");
                        
                        string deletePerson = Console.ReadLine();
                        
                        if (!list.Contains(deletePerson))
                        {
                            Console.WriteLine("Person not found. Please enter again");
                            
                            break;
                        }
                            if (list.Contains(deletePerson)){
                                list.Remove(deletePerson);
                                
                                break;
                            };
                        

                        break;
                    case 3:
                        Console.WriteLine("-----View List-----");
                        foreach (var item in list)
                        {
                            Console.WriteLine(item.ToString());
                        }
                        Console.WriteLine("---------------------");
                        Console.WriteLine("---------------------");
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Wrong value");
                        break;


                }


            } while (menu != 4);


        }




    }
}

