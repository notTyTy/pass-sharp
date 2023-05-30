using System.Runtime;
using System.IO;

public class password
{
    public static void Main()
    {
        Console.WriteLine("Please input the service you're using");
        var service =  Console.ReadLine(); //User service e.g gmail
        if(string.IsNullOrEmpty(service) is false)
        {
            Console.WriteLine("Please Input a username");
            var username = Console.ReadLine(); // will create a StreamWriter for username data
            {
                if(string.IsNullOrEmpty(username) is false)
                {
                    string line;
                    try
                    {
                        StreamWriter sw = new StreamWriter("username.txt", true);
                        sw.WriteLine(username);
                        sw.Close();
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Exception" + e.Message);
                    }
                }

            }
            if(string.IsNullOrEmpty(username) is false) // will run the current container if a string is added
            {
                Console.WriteLine("Would you like a password to be generated for you? y/n only");
                var response = Console.ReadLine().ToLower();
                if(response == "y")
                {
                    PasswordGen passwordCharacters = new PasswordGen();
                    string passwordCharacterList = passwordCharacters.CharacterList;
                    int passwordCharacterLength = passwordCharacters.CharacterList.Length;
                    
                    var rand = new Random();
                    int lengthRange = rand.Next(0, 53);
                    char chosenChar = passwordCharacterList[lengthRange]; //chooses a random character using math
                    var chosenCharStr = chosenChar.ToString();
                    int chosenCharStrLength = chosenCharStr.Length;
                    
                    Console.WriteLine(chosenCharStrLength);
                    
                    
                    Console.WriteLine(); //random character choice works
                    
                    //Console.WriteLine(passwordCharacterList); //tests to see if other class works
                    //create a class and import it here for password generation, inclusion of special characters, integers and letters
                    
                    PasswordGen.StaticPasswordGen();
                }
                else if(response == "n")
                {
                    Console.WriteLine("Please input your password");
                    var inputPassword = Console.ReadLine(); //will add to StreamWriter to save username
                }
                else
                {
                    Console.WriteLine("Please try again and input y/n only");
                }
            }
            if(string.IsNullOrEmpty(username)) //If the user does not input anything
            {
                Console.WriteLine("Please input a valid username");
            }
        }
    }
}

public class PasswordGen
{
    public string CharacterList = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
    
    public static void StaticPasswordGen()
    {
        PasswordGen passwordCharacters = new PasswordGen();
        string passwordCharacterList = passwordCharacters.CharacterList;
        int passwordCharacterLength = passwordCharacterList.Length;
    }
}