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
            if(string.IsNullOrEmpty(username) is false)
            {
                Console.WriteLine("Would you like a password to be generated for you? y/n only");
                var response = Console.ReadLine().ToLower();
                if(response == "y")
                {
                    PasswordGen passwordCharacters = new PasswordGen();
                    
                    string passwordCharacterListAlpha = passwordCharacters.CharacterListAlpha;
                    string passwordCharactersUpper = passwordCharacters.CharacterListUpper;
                    string passwordCharactersInt = passwordCharacters.CharacterListInt;
                    string passwordCharactersSpecial = passwordCharacters.CharacterListSpecial;
                    
                    var random = new Random();
                    var Char = passwordCharactersUpper[1].ToString().Length;
                    int numOutcomes = 15; // change this value to create a new password length
                    
                    for(Char = 1; Char <= numOutcomes; Char++)
                    {
                            var lengthRange = random.Next(0, 10);
                            char passwordChar = passwordCharactersInt[lengthRange];
                            Console.Write(passwordChar);
                    }                }
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
    public string CharacterListAlpha = "abcdefghijklmnopqrstuvwxyz;";
    public string CharacterListUpper = "ABCDEFGHIJKMNOPQRSTUVWXYZ"; 
    public string CharacterListInt = "1234567890";
    public string CharacterListSpecial = "!@#$%^&*()-=_+[]{}|;':,./<>?";
}