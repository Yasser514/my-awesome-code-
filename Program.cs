// See https://aka.ms/new-console-template for more information
       try { 
  
            // Taking decimal variables 
            Decimal dec1 = 2147483647M; 
            Decimal dec2 = 21458565.2996m; 
  
            // using Decimal.ToInt32(Decimal) Method 
            // Here int means Int32 
            int val1 = Decimal.ToInt32(dec1); 
              
            // using Decimal.ToInt32(Decimal) Method 
            // Here int means Int32 
            int val2 = Decimal.ToInt32(dec2); 
              
  
            // Printing the Int32 value 
            Console.WriteLine("The Int32 value "
                            + "is : {0}", val1); 
                                  
            // Printing the Int32 value 
            Console.WriteLine("The Int32 value "
                            + "is : {0}", val2); 
                          
        } 
    
        catch (OverflowException e)  
        { 
            Console.Write("Exception Thrown: "); 
            Console.Write("{0}", e.GetType(), e.Message); 
        } 
    