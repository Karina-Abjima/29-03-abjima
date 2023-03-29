using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace practice
{   
    class A
    {
        public static string a, f = "";
         public static string l_name,  full_name,  f_name="";
        public string full_string;
         public static int sum1,sum2=0,sum3=0;


        public  string Swtch(string a)
        {
            
            switch (a)//switch
            {
                case "cleaning":
                        f="cleaning will be done";
                    break;
                   
                case "road construction":
                         f="construction will be done";
                    break;
                default:
                    f = a;break;
            }return f;
            //Console.WriteLine("done");
        }
        public string Str_con(string f_name,string l_name)
        {
            full_name = $"your name is {f_name} {l_name}";//can be done using + operator too
            return full_name;
        }

        public string Appending()
        {   
            Console.WriteLine("enter initial string");
            string appender = Console.ReadLine();   //string appending 
            string checker = "Y"; //to check if user wanna enter more
            string dummy;//dummy string if they want to add more


            StringBuilder sb = new StringBuilder();//it prevents to generate multiple copies of a string just to add more to it 
            sb.Append(appender+" ");//appending string to builder

            Console.WriteLine("type y for adding more to it");
             checker = Console.ReadLine();

            while (checker.Equals("y")||(checker.Equals("Y")))
                {
                
                Console.WriteLine("enter another to add to string");   
                dummy = Console.ReadLine();
                sb.Append(dummy+" ");//or use appendline to add a line break
                Console.WriteLine("type y for adding more to it");
                checker = Console.ReadLine();


            }

            full_string = sb.ToString();//converting string builder into one
             return full_string;
        }
        public void Sum()
        { 
        }
        public void Sum(ref int sum1,ref int sum2)
        { sum1 = sum2 + 4;
            Console.WriteLine(sum1);
        }

        public void Sum(out int sum1,out int sum2, out int sum3)
        {
            sum1 = sum2 + sum3;
            sum2 = sum1 + sum3;
            sum3=sum1+sum2;
            Console.WriteLine(sum1);
        }
        public static void Main(String[] args)
        {    string ans;
            A ob=new A();
            //switch statement
            Console.WriteLine("Switch:");
            Console.WriteLine("enter problem:- cleaning or road construction");
            a = Console.ReadLine();
            Console.WriteLine( ob.Swtch(a));

            //string concat and interpol
            Console.WriteLine("string concat and interpolition:");
            Console.WriteLine("enter first name");
            f_name = Console.ReadLine();
            Console.WriteLine("enter last name");
            l_name = Console.ReadLine();
            Console.WriteLine(ob.Str_con(f_name, l_name));
               

            //string builder
            
            Console.WriteLine("String builder:");
            Console.WriteLine("wanna append a string? type \ny for yes and \nn for no");

            ans = Console.ReadLine();
            if ((ans.Equals("y"))||( ans.Equals("Y")))//checks string 
            {
                Console.WriteLine(ob.Appending());
               
            }

            //method overloading
            Console.WriteLine("method overloading");
            Console.WriteLine("enter how many numbers you have to add 2 or 3");
            a= Console.ReadLine();

            if (a.Equals("2"))
            {
                Console.WriteLine("enter 2 numbers");
                sum1 = Convert.ToInt32(Console.ReadLine());// converting to int
                sum2 = Convert.ToInt32(Console.ReadLine());
                ob.Sum(ref sum1, ref sum2);//ref and out
            }
            else if (a.Equals("3"))
            {
                Console.WriteLine("enter 3 numbers");
                sum1 = Convert.ToInt32(Console.ReadLine());// converting to int
                sum2 = Convert.ToInt32(Console.ReadLine());
                sum2 = Convert.ToInt32(Console.ReadLine());
                ob.Sum(out sum1, out sum2, out sum3);//ref and out

            }
            else
                Console.WriteLine("enter valid number");

    }
        


        }

 }

