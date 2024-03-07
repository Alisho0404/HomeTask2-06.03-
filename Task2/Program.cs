int count=0;  
System.Console.WriteLine("Enter words"); 
System.Console.WriteLine("---------------------");
 while (true)
{
    string word=Console.ReadLine(); 
    if (word=="end")
    { 
       break;        
    }
    count++;
    
} 
System.Console.WriteLine("Count of word except <end> is: "+count);