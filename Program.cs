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
                    PasswordGen passwordChars = new PasswordGen();

                    string passwordCharAlpha = passwordChars.CharAlpha;
                    string passwordCharUpper = passwordChars.CharUpper;
                    string passwordCharInt = passwordChars.CharInt;
                    string passwordCharSpecial = passwordChars.CharSpecial;

                    var random = new Random();
                    var Char = passwordCharUpper[1].ToString().Length;
                    var numOutcomes = 15; // change this value to create a new password length

                    for(Char = 1; Char <= numOutcomes; Char++)
                    {
                        var rangeInt = random.Next(0, 10);
                        var rangeAlpha = random.Next(0, 26);
                        var rangeSpecial = random.Next(0, 28);
                        
                        char charInt = passwordCharInt[rangeInt];
                        char charAlpha = passwordCharAlpha[rangeAlpha];
                        char charUpper = passwordCharUpper[rangeAlpha];
                        char charSpecial = passwordCharSpecial[rangeSpecial];
                        
                        var characterRoll = random.Next(0, 101); // Creates a range of 0 to 100 allowing for significantly elevated control of outputs
                        switch(characterRoll)
                        {
                            case int characterRollInt when characterRoll is >= 0 and <= 20: // 20% chance
                                Console.Write(charInt);
                                break;
                            case int characterRollAlpha when characterRoll is >= 21 and <= 50: // 30% chance
                                Console.Write(charAlpha);
                                break;
                            case int characterRollUpper when characterRoll is >= 51 and <= 80: // 30% chance
                                Console.Write(charUpper);
                                break;
                            case int characterRollSpecial when characterRoll is >= 81 and <= 100: // 20% chance
                                Console.Write(charSpecial);
                                break;
                            default:
                                Console.Write("An exception has occured, Please try again");
                                break;
                        }
                    }
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
    public string CharAlpha = "abcdefghijklmnopqrstuvwxyz;";
    public string CharUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; 
    public string CharInt = "1234567890";
    public string CharSpecial = "!@#$%^&*()-=_+[]{}|;':,./<>?";
    //Decided to split the strings up to make it a little more readble, planning on combining them after sufficient testing is done
}