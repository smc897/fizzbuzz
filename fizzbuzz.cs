using System;
namespace fizzbuzz{
 public class buzz{
  public static void Main(String[] args){
   for(int i=0;i<30;i++){
    Console.WriteLine(output(i));
   }
  
  }

  public static String output(int num){
   if((num%3==0)&&(num%5==0)) return "fizzbuzz";
   else if(num%5==0) return "buzz";
   else if(num%3==0) return "fizz";
   return "";
  }
 }
}