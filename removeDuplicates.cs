using System;
using System.Text;

class RemoveLetters
{   
    void RemoveDups(StringBuilder str){
        if (str.Length != 0){
            char currentLetter = str[0];
            
            for (int i = 1; i < str.Length; i++) {
                if (str[i] == currentLetter){
                 str.Remove(i,1);
                 i--;
                }
                else {
                    currentLetter = str[i];
                }
            }
        }
    }  
    
    public static void Main(string[] args)
    {
        RemoveLetters rl = new RemoveLetters();
        
        var data = new StringBuilder("AAA BBB AAA Ddddd 111 12 12333 111222");
        rl.RemoveDups(data);
        Console.WriteLine(data);

    }
}