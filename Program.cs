namespace NumberRules;


class Program
{
    static void Main(string[] args)
    {
        Rules rules = new();

        //Default Rules
        rules.AddRule(3, "foo");
        rules.AddRule(5, "bar");
        rules.AddRule(7, "jazz");

        string? userChoice = "";

        while (userChoice != "3"){
            Console.WriteLine("Enter the option:");
            Console.WriteLine("1. Input a number to print");
            Console.WriteLine("2. Input a new rule");
            Console.WriteLine("3. Exit");

            userChoice = Console.ReadLine();
            
            switch (userChoice){
                case "1": {
                    Console.WriteLine("Enter a number to print");
                    string? number = Console.ReadLine();
                    if (!string.IsNullOrEmpty(number)  && int.TryParse(number, out int n)){
                        string output = "";
                        for (int i = 1 ; i <= n; i++){
                            if (output == ""){
                                output = rules.getOutPut(i);
                            } else {
                                output += ", " + rules.getOutPut(i);
                            }
                        }
                        Console.WriteLine(output);
                    } else {
                        Console.WriteLine("Invalid Input. Please enter a number");
                    }
                    break;
                }
                case "2": {
                    Console.WriteLine("Please enter the number and the word separated with ,");
                    string? input = Console.ReadLine();
                    string [] inputs = (input ?? "").Split(',');
                    if (inputs.Length == 2 && int.TryParse(inputs[0], out int key) &&
                        !string.IsNullOrEmpty(inputs[1])){
                        
                        rules.AddRule(key, inputs[1]);
                        Console.WriteLine("New rules added with number: "+key+", word: "+inputs[1]);
                    }
                    break;
                }
                case "3": {
                    Console.WriteLine("Exiting program . . .");
                    break;
                }
                default: {
                    Console.WriteLine("Invalid input, Please enter 1, 2, or 3");
                    break;
                }
            }
        }
    }
}
