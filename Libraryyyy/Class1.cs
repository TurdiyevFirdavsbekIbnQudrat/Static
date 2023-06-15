using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Libraryyyy
{
   
   public class Person
        {

        public Person? jufti;
        public bool Oilalimi { get; set; }
        public string Ism { get; set; }

        public static void OilaMumkinmi(Person p1, Person p2)
        {   
            
                if((p1.Oilalimi==false) && (p2.Oilalimi == false))
            {
                p1.jufti = p2;
                p2.jufti = p1;
                
            }
            else
            {
                if (p1.Oilalimi == true)
                    Console.WriteLine($"{p1.Ism} Oilali");
                  
                if (p2.Oilalimi == true )
                    Console.WriteLine($"{p2.Ism} Oilali");
            }
        }

        public void OilasiBor(Person person) 
        {  
                Console.WriteLine($"{person.jufti.Ism} va {this.jufti.Ism} turmush qurishdi"); 
        }
        }
}