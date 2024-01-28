namespace NumberRules;

using System.Collections.Generic;

class Rules {
    private Dictionary<int, string> rules;

    public Rules () {
        rules = new Dictionary<int, string>();
    }

    public void AddRule(int input, string output){
        rules.Add(input, output);
    }

    public string getOutPut(int number){

        string output = "";

        foreach (var rule in rules){
            if (number % rule.Key == 0){
                output += rule.Value;
            }
        }

        if (output == ""){
            output = number.ToString();
        }

        return output;
    }
    
}