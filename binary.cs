using System;

public class Converter
{
  public string ToBinary(int number)
  {
    if (number == 0){  
      return "0";  //Если на вход подаётся 0 - число конвертировать не надо
      Console.WriteLine("0");
    }
    string binaryCode = "";
    int remainder, n;
    
    n = Math.Abs(number);
    
    do{
      remainder = n%2; //Переводим число по стандартному алгоритму в двоичный вид
      n = n/2;
      if (remainder == 1){binaryCode = "1" + binaryCode;}
      else {binaryCode = "0"+binaryCode;}
    }
    while(n!=0);
    
    if (number < 0){   //Происходит проверка, отрицательное ли число
    
      string negativeBinary = "";

      char[] charArray = binaryCode.ToCharArray(); //При отрицательном числе, необходимо будет побитно изменять двоичный код. Поэтому для удобства делаем массив
      Array.Reverse(charArray); //Переворачиваем массив
      
      for (int i = 0; i < 32; i++){ 
        if (i < charArray.Length){ //Пока идёт двоичное число, меняем цифры на противоположные
          if (charArray[i] == '0'){
            negativeBinary = negativeBinary + "1";
          } else {
          negativeBinary += "0";
          }  
        }
        else {
          negativeBinary += "1"; //Заполняем оставшиеся биты единицами
        }    
      }
      
      int carry = 1;  //Для завершения преобразования двоичного числа в отрицательное двоичное, необходимо прибавить единицу
      
      charArray = negativeBinary.ToCharArray();
      
      for (int i = 0; i < charArray.Length; i++){  //Прибавление единицы и перенос разрядов при переполнении
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
      
      Array.Reverse(charArray);  //Отражение обратно в правильную форму записи
      binaryCode = new string(charArray); //Формирование строки отрицательного числа в двоичной форме
    }
    
    Console.WriteLine(binaryCode); //Вывод числа в консоль
    return binaryCode;  
  }
  
    public static void Main(string[] args)
    {
        Converter c = new Converter();
        
        int myNumber = -35;
        c.ToBinary(myNumber);
    }
}
