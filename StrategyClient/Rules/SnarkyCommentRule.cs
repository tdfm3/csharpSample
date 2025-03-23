using System;
using System.Collections.Generic;
using System.Linq;

namespace StrategyClient.Rules
{
    public class SnarkyCommentRule : IRule
    {
        public bool Verify(string choice)
        {
            if (!choice.All(char.IsDigit)) return false;
            var answer = Convert.ToInt32(choice);
            return answer == 2;
        }

        public void Execute()
        {
            var index = new Random().Next(responses.Count);
            Console.WriteLine(responses[index]);
        }

        private List<string> responses => new List<string>()
        {
            "AAA",
            "BBB",
            "CCC",
            "DDD",
            "EEE",
            "FFF",
            "GGG",
            "HHH",
            "III",
            "JJJ"
        };
    }
}