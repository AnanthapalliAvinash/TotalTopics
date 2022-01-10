using System.Collections.Generic;
using System.Text;
using System;
namespace AvinashException
{
    class UserException
    {

        class AvinashExceptoin : Exception
        {
            public AvinashExceptoin(String Message) : base(Message)
            {

            }
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                String name = "";
                try
                {
                    if (name.Length > 0)
                    {
                    Console.WriteLine("Name:{0}",name);
                    }
                  else
                    throw new AvinashExceptoin("String Length cannot be zero");
            }
                catch (AvinashExceptoin e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }
    
}
