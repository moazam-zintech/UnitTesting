using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace UnitTesting.Test
{
    public class DomainTests
    {
        public static void Domain_ReturnZero_String()
        {
    
            try
            {

                //Arrange
                int n = 0;
               DomainLogic domain=new DomainLogic();


                //Action
              string result=domain.ReturnZero(n);


                //Assert
               if(result == "successfull")
                {
                    Console.WriteLine("Passed");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
