using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Study_Application_3._0
{  
    class App
    {
        public string Username;
        public string Password;
        public int Score;

        public App()
        {
            GetUsername();
            GetPassword();
            Login();
            Questions();
            score();
            Score = 0;
        }
        

        private void Questions()
        {
            WriteLine("\n These are your Terms and Deffinitions:\n ");

            using(StreamReader sr = new StreamReader("Question.txt"))
            {
                string s = string.Empty;
                while((s = sr.ReadLine()) != null)
                {
                    WriteLine(s);
                }
            }

            WriteLine("\n Once your ready to test your knowledge hit any key...");
            ReadKey();
            Clear();

            Random rand = new Random();

            string[] definitions =
            {
                "Variables defined by a class","Compilation of classes", "Symbols which transform and combine expressions", "Thing which gives something a value",
                "An instruction describing how to run a program", "A class that cannot be instantiated", "A data type that stores a string of characters",
                "The repeated execution of a statement or statements", "A data type that stores a whole number", "A single binary number",
                "A number that allows a decimal point for greater precision", "A template of a type of object", "A language developed by Microsoft to work with the .Net platform",
                "A data type with a binary value such as true or false", "A language that structures document elements"
            };

            List<Question> Terms = new List<Question>();
            Terms.Add(new Question("Field", "Variables defined by a class"));
            Terms.Add(new Question("Assembly", "Compilation of classes"));
            Terms.Add(new Question("Operator", "Symbols which transform and combine expressions"));
            Terms.Add(new Question("Expression", "Thing which gives something a value"));
            Terms.Add(new Question("Statement", "An instruction describing how to run a program"));
            Terms.Add(new Question("Abstract Class", "a class that cannot be instantiated"));
            Terms.Add(new Question("String", "A data type that stores a string of characters"));
            Terms.Add(new Question("Loop", "The repeated execution of a statement or statements"));
            Terms.Add(new Question("Integer", "A data type that stores a whole number"));
            Terms.Add(new Question("Bit", "A single binary number"));
            Terms.Add(new Question("Double", "A number that allows a decimal point for greater precision"));
            Terms.Add(new Question("Class", "A template of a type of object"));
            Terms.Add(new Question("C#", "A language developed by Microsoft to work with the .Net platform"));
            Terms.Add(new Question("Boolean", "A data type with a binary value such as true or false"));
            Terms.Add(new Question("HTML", "A language that structures document elements"));


            var question = Terms.OrderBy(c => rand.Next()).Select(c => c.Term).ToList();


            WriteLine("\n Definition: " + definitions[0] + "\n What Term matches this?");

            for (int i = 0; i < 3; i++)
            {
                int optionNumber = i + 1;
                WriteLine("\n " + optionNumber + ")" + question[i]);
            }
            WriteLine("\n 4)Field");
            WriteLine("\n Is the answer 1, 2, 3, or 4?");
            if (ReadLine() == "4")
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("\n That was the correct answer!");
                ResetColor();
                WriteLine("\n Press Enter for the next question");
                Score++;
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\n That was not the correct answer :(");
                ResetColor();
                WriteLine("\n The correct answer was Field");
                WriteLine("\n Press Enter for the next question");

            }
            ReadKey();

            WriteLine("\n Definition: " + definitions[1] + "\n What Term matches this?");

            for (int i = 0; i < 2; i++)
            {
                int optionNumber = i + 1;
                WriteLine("\n " + optionNumber + ")" + question[i]);
            }
            WriteLine("\n 3)Assembly");

            WriteLine("\n 4)Byte");

            WriteLine("\n Is the answer 1, 2, 3, or 4?");
            if (ReadLine() == "3")
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("\n That was the correct answer!");
                ResetColor();
                WriteLine("\n Press Enter for the next question");
                Score++;
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\n That was not the correct answer :(");
                ResetColor();
                WriteLine("\n The correct answer was Assembly");
                WriteLine("\n Press Enter for the next question");

            }
            ReadKey();

            WriteLine("\n Definition: " + definitions[2] + "\n What Term matches this?");

            WriteLine("\n 1)Operator");

            for (int i = 1; i < 4; i++)
            {
                int optionNumber = i + 1;
                WriteLine("\n " + optionNumber + ")" + question[i]);
            }
            WriteLine("\n Is the answer 1, 2, 3, or 4?");
            if (ReadLine() == "1")
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("\n That was the correct answer!");
                ResetColor();
                WriteLine("\n Press Enter for the next question");
                Score++;
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\n That was not the correct answer :(");
                ResetColor();
                WriteLine("\n The correct answer was Operator");
                WriteLine("\n Press Enter for the next question");

            }
            ReadKey();

            WriteLine("\n Definition: " + definitions[3] + "\n What Term matches this?");

            WriteLine("\n 1)OOP");

            WriteLine("\n 2)Expression");

            for (int i = 2; i < 4; i++)
            {
                int optionNumber = i + 1;
                WriteLine("\n " + optionNumber + ")" + question[i]);
            }
            WriteLine("\n Is the answer 1, 2, 3, or 4?");
            if (ReadLine() == "2")
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("\n That was the correct answer!");
                ResetColor();
                WriteLine("\n Press Enter for the next question");
                Score++;
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\n That was not the correct answer :(");
                ResetColor();
                WriteLine("\n The correct answer was Expression");
                WriteLine("\n Press Enter for the next question");

            }
            ReadKey();

            WriteLine("\n Definition: " + definitions[4] + "\n What Term matches this?");

            WriteLine("\n 1)Statement");
            for (int i = 1; i < 4; i++)
            {
                int optionNumber = i + 1;
                WriteLine("\n " + optionNumber + ")" + question[i]);
            }
            WriteLine("\n Is the answer 1, 2, 3, or 4?");
            if (ReadLine() == "1")
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("\n That was the correct answer!");
                ResetColor();
                WriteLine("\n Press Enter for the next question");
                Score++;
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\n That was not the correct answer :(");
                ResetColor();
                WriteLine("\n The correct answer was Statement");
                WriteLine("\n Press Enter for the next question");

            }
            ReadKey();

            WriteLine("\n Definition: " + definitions[5] + "\n What Term matches this?");

            for (int i = 0; i < 3; i++)
            {
                int optionNumber = i + 1;
                WriteLine("\n " + optionNumber + ")" + question[i]);
            }
            WriteLine("\n 4)Abstract Class");
            WriteLine("\n Is the answer 1, 2, 3, or 4?");
            if (ReadLine() == "4")
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("\n That was the correct answer!");
                ResetColor();
                WriteLine("\n Press Enter for the next question");
                Score++;
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\n That was not the correct answer :(");
                ResetColor();
                WriteLine("\n The correct answer was Abstract Class");
                WriteLine("\n Press Enter for the next question");

            }
            ReadKey();

            WriteLine("\n Definition: " + definitions[6] + "\n What Term matches this?");

            for (int i = 0; i < 3; i++)
            {
                int optionNumber = i + 1;
                WriteLine("\n " + optionNumber + ")" + question[i]);
            }
            WriteLine("\n 4)String");
            WriteLine("\n Is the answer 1, 2, 3, or 4?");
            if (ReadLine() == "4")
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("\n That was the correct answer!");
                ResetColor();
                WriteLine("\n Press Enter for the next question");
                Score++;
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\n That was not the correct answer :(");
                ResetColor();
                WriteLine("\n The correct answer was String");
                WriteLine("\n Press Enter for the next question");

            }
            ReadKey();

            WriteLine("\n Definition: " + definitions[7] + "\n What Term matches this?");

            WriteLine("\n 1)Loop");
            for (int i = 1; i < 4; i++)
            {
                int optionNumber = i + 1;
                WriteLine("\n " + optionNumber + ")" + question[i]);
            }
            WriteLine("\n Is the answer 1, 2, 3, or 4?");
            if (ReadLine() == "1")
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("\n That was the correct answer!");
                ResetColor();
                WriteLine("\n Press Enter for the next question");
                Score++;
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\n That was not the correct answer :(");
                ResetColor();
                WriteLine("\n The correct answer was Loop");
                WriteLine("\n Press Enter for the next question");

            }
            ReadKey();

            WriteLine("\n Definition: " + definitions[8] + "\n What Term matches this?");

            for (int i = 0; i < 2; i++)
            {
                int optionNumber = i + 1;
                WriteLine("\n " + optionNumber + ")" + question[i]);
            }
            WriteLine("\n 3)Integer");

            WriteLine("\n 4)Java");

            WriteLine("\n Is the answer 1, 2, 3, or 4?");
            if (ReadLine() == "3")
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("\n That was the correct answer!");
                ResetColor();
                WriteLine("\n Press Enter for the next question");
                Score++;
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\n That was not the correct answer :(");
                ResetColor();
                WriteLine("\n The correct answer was Integer");
                WriteLine("\n Press Enter for the next question");

            }
            ReadKey();

            WriteLine("\n Definition: " + definitions[9] + "\n What Term matches this?");

            WriteLine("\n 1)Recursion");

            WriteLine("\n 2)Bit");

            for (int i = 2; i < 4; i++)
            {
                int optionNumber = i + 1;
                WriteLine("\n " + optionNumber + ")" + question[i]);
            }
            WriteLine("\n Is the answer 1, 2, 3, or 4?");
            if (ReadLine() == "2")
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("\n That was the correct answer!");
                ResetColor();
                WriteLine("\n Press Enter for the next question");
                Score++;
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\n That was not the correct answer :(");
                ResetColor();
                WriteLine("\n The correct answer was Bit");
                WriteLine("\n Press Enter for the next question");

            }
            ReadKey();

            WriteLine("\n Definition: " + definitions[10] + "\n What Term matches this?");

            for (int i = 0; i < 2; i++)
            {
                int optionNumber = i + 1;
                WriteLine("\n " + optionNumber + ")" + question[i]);
            }
            WriteLine("\n 3)Double");

            WriteLine("\n 4)Variable");

            WriteLine("\n Is the answer 1, 2, 3, or 4?");
            if (ReadLine() == "3")
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("\n That was the correct answer!");
                ResetColor();
                WriteLine("\n Press Enter for the next question");
                Score++;
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\n That was not the correct answer :(");
                ResetColor();
                WriteLine("\n The correct answer was Double");
                WriteLine("\n Press Enter for the next question");

            }
            ReadKey();

            WriteLine("\n Definition: " + definitions[11] + "\n What Term matches this?");

            for (int i = 0; i < 2; i++)
            {
                int optionNumber = i + 1;
                WriteLine("\n " + optionNumber + ")" + question[i]);
            }
            WriteLine("\n 3)Class");

            WriteLine("\n 4).exe");

            WriteLine("\n Is the answer 1, 2, 3, or 4?");
            if (ReadLine() == "3")
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("\n That was the correct answer!");
                ResetColor();
                WriteLine("\n Press Enter for the next question");
                Score++;
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\n That was not the correct answer :(");
                ResetColor();
                WriteLine("\n The correct answer was Class");
                WriteLine("\n Press Enter for the next question");

            }
            ReadKey();

            WriteLine("\n Definition: " + definitions[12] + "\n What Term matches this?");

            for (int i = 0; i < 3; i++)
            {
                int optionNumber = i + 1;
                WriteLine("\n " + optionNumber + ")" + question[i]);
            }
            WriteLine("\n 4)C#");
            WriteLine("\n Is the answer 1, 2, 3, or 4?");
            if (ReadLine() == "4")
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("\n That was the correct answer!");
                ResetColor();
                WriteLine("\n Press Enter for the next question");
                Score++;
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\n That was not the correct answer :(");
                ResetColor();
                WriteLine("\n The correct answer was C#");
                WriteLine("\n Press Enter for the next question");

            }
            ReadKey();

            WriteLine("\n Definition: " + definitions[13] + "\n What Term matches this?");

            WriteLine("\n 1)Boolean");

            for (int i = 1; i < 4; i++)
            {
                int optionNumber = i + 1;
                WriteLine("\n " + optionNumber + ")" + question[i]);
            }

            WriteLine("\n Is the answer 1, 2, 3, or 4?");
            if (ReadLine() == "1")
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("\n That was the correct answer!");
                ResetColor();
                WriteLine("\n Press Enter for the next question");
                Score++;
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\n That was not the correct answer :(");
                ResetColor();
                WriteLine("\n The correct answer was Boolean");
                WriteLine("\n Press Enter for the next question");

            }
            ReadKey();

            WriteLine("\n Definition: " + definitions[14] + "\n What Term matches this?");

            for (int i = 0; i < 3; i++)
            {
                int optionNumber = i + 1;
                WriteLine("\n " + optionNumber + ")" + question[i]);
            }
            WriteLine("\n 4)HTML");
            WriteLine("\n Is the answer 1, 2, 3, or 4?");
            if (ReadLine() == "4")
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("\n That was the correct answer!");
                ResetColor();
                WriteLine("\n Press Enter to see your score");
                Score++;
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\n That was not the correct answer :(");
                ResetColor();
                WriteLine("\n The correct answer was HTML");
                WriteLine("\n Press Enter to see your score");

            }
            ReadKey();
            score();
        }


        public void GetUsername()
        {
            Username = "";

            Write("\n What would you like your Username to be: ");
            Username = ReadLine();
            string input = "";
            Write("\n Your Username is: " + Username + "\n Is that Correct? Yes or No? ");
            input = ReadLine();

            if (input.ToLower() == "yes")
            {
                GetPassword();
            }
            else
            {
                WriteLine(" Input new Username");
                GetUsername();
            }

        }

        public void GetPassword()
        {

            Password = "";

            Write("\n What would you like your Password to be: ");
            Password = ReadLine();
            string input = "";
            Write("\n Your Password is: " + Password + "\n Is that Correct? Yes or No? ");
            input = ReadLine();

            if (input.ToLower() == "yes")
            {
                Login();
            }
            else
            {
                WriteLine("\n Input new Password");
                GetPassword();
            }
        }

        public void Login()
        {
            Write("\n Username: ");
            if (Username == ReadLine())
            {
                Write("\n Password: ");
                if (Password == ReadLine())
                {
                    Clear();
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("\n You sucessfully logged in!");
                    ResetColor();
                    Questions();

                }
                else
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("\n You inputed the wrong Password try again");
                    ResetColor();
                    Login();
                }
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\n You inputed the wrong Username try again");
                ResetColor();
                Login();
            }
        }


        private void score()
        {
            WriteLine("\n Your Score: " + Score + "/15 \n Press any key to stop studying");
            ReadKey();
            Environment.Exit(0);
        }

    }
}
   
        
    
