// už zadá kolik chce čtvtců a program vygeneruje náhodné čtverce 

  

using System; 

  

public class HelloWorld 

{ 

     

    public static void Main(string[] args) 

    { 

        Random nahoda = new Random(); 

        double nahodCislo,  pocetCtveru,obvod,obsah; 

        Console.WriteLine ("zadej kolik ches ctvercu"); 

        double pocetCtvercu = double.Parse(Console.ReadLine()); 

         

        for (int i=1; i<=pocetCtvercu; i++) 

        { 

            nahodCislo  = nahoda.Next(1, 100); 

            obvod= nahodCislo*4; 

            obsah= nahodCislo*nahodCislo; 

            Console.WriteLine(i+". ctverec ma obvod " +obvod+"cm a obsah "+obsah+"cm"); 

        } 

         

    } 

} 
