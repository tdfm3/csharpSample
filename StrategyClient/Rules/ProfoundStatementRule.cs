using System;
using System.Collections.Generic;
using System.Linq;

namespace StrategyClient.Rules
{
    public class ProfoundStatementRule : IRule
    {
        public bool Verify(string choice)
        {
            if (!choice.All(char.IsDigit)) return false;
            var answer = Convert.ToInt32(choice);
            return answer == 3;
        }

        public void Execute()
        {
            var index = new Random().Next(responses.Count);
            Console.WriteLine(responses[index]);
        }

        private List<string> responses => new List<string>()
        {
            "aaa",
            "bbb",
            "ccc",
            "ddd",
            "eee",
            "fff",
            "ggg",
            "hhh",
            "iii",
            "jjj"
        };
    }
}