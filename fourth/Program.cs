using System.Reflection.Emit;

namespace fourth
{
    enum WeekDays
    { 
        monday,
        tuesday,
        wednesday,
        thrisday,
        friday,
        saturday
    }

    enum season
    { 
        spring,
        summer,
        autumn,
        winter
    }

    [Flags]
    enum permission 
    {
        read = 0b1000,
        write = 0b0100,
        delete = 0b0010,
        excute = 0b0001
    }

    enum Colors
    { 
        RED,
        GREEN, 
        BLUE
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            #region 1
            #region box,unbox
            ////boxing ==> from value type to reference type (safe) cause all integar(value) are object(reference)
            //int x = 5;
            //object obj = x;
            //Console.WriteLine(obj);
            ////unboxing ==> from reference to value type not safe casue all oblect not integar
            //object obj1 = 5;
            //int x2 = (int)obj1;
            //Console.WriteLine(x2);
            #endregion
            #region null
            //int doesnt accept null, but int? accept int
            //int default value is 0 and default vaule of reference type is null
            //int?.length return null if it is null and return value if it doesnt null
            //int?.length ?? 0 if its null return 0 and if it doesnt return length
            #endregion
            #region accessmodifier
            //for class and struct ==> public(use every where) and internal(only use in same project)
            //in class public internal private(only use in class)
            //in interface public and inernal
            #endregion
            #endregion

            #region 2
            //foreach (string Label in Enum.GetNames(typeof(WeekDays)))
            //{ 
            //    Console.WriteLine(Label);
            //}
            #endregion
            #region 3
            //Console.WriteLine("ENTER season...");
            //bool test = Enum.TryParse(Console.ReadLine(), true, out season s1);
            //if (test & (int)s1 < 4)
            //{
            //    string output = s1 switch
            //    {
            //        season.spring => "march to may",
            //        season.summer => "june to august",
            //        season.autumn => "September to November",
            //        season.winter => "December to February",
            //        _ => "INVALID"
            //    };
            //    Console.WriteLine($"season is {s1} and his range {output}");
            //}
            //else { Console.WriteLine($"INVALID INPUT"); }
            #endregion
            #region 4
            //permission p = permission.read;
            //add(ref p, permission.write);
            //Console.WriteLine(p);            
            //remove(ref p, permission.write);
            //Console.WriteLine(p);
            //Console.WriteLine(check(p, permission.write));
            #endregion
            #region 5
            //Console.WriteLine("Enter a color name:");
            //string userInput = Console.ReadLine();

            //if (Enum.TryParse(userInput, true, out Colors color))
            //{               
            //        Console.WriteLine($"{color} is a primary color.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid color name. Please enter Red, Green, or Blue.");
            //}
        }
            #endregion
        
        static void add(ref permission p, permission toadd)
        {
            p |= toadd;
        }       
        static void remove(ref permission p, permission toremove)
        {
            p &= ~toremove;
        }    
        static bool check(permission p, permission tocheck)
        {
            return (p & tocheck) == tocheck;
        }
    }
}
