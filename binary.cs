using System;

public class Converter
{
  public string ToBinary(int number)
  {
    if (number == 0)
      return "0";
    
    string binaryCode = "";
    int remainder, n;
    
    n = Math.Abs(number);
    
    do{
      remainder = n%2;
      n = n/2;
      if (remainder == 1){binaryCode = "1" + binaryCode;}
      else {binaryCode = "0"+binaryCode;}
    }
    while(n!=0);
    
    if (number < 0){
    
      string negativeBinary = "";

      char[] charArray = binaryCode.ToCharArray();
      Array.Reverse(charArray); 
      
      for (int i = 0; i < 32; i++){
        if (i < charArray.Length){
          if (charArray[i] == '0'){
            negativeBinary = negativeBinary + "1";
          } else {
          negativeBinary += "0";
          }  
        }
        else {
          negativeBinary += "1";
        }    
      }
      
      int carry = 1;
      
      charArray = negativeBinary.ToCharArray();
      
      for (int i = 0; i < charArray.Length; i++){
        if (carry == 1){
          if (charArray[i] == '0'){
            charArray[i] = '1';
            carry = 0;
          }
          else {
            charArray[i] = '0';
          }

        } 
      }
      
      Array.Reverse(charArray);
      binaryCode = new string(charArray);
    }
    
    Console.WriteLine(binaryCode);
    return binaryCode;  
  }
  
    public static void Main(string[] args)
    {
        Converter c = new Converter();
        
        int myNumber = -35;
        c.ToBinary(myNumber);
    }
}