using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern[] patterns = {
                new Pattern(1,"Specification", new Specificat1ionSample())
            };
            foreach (Pattern pattern in patterns)
                Console.WriteLine($"{pattern.Code} - {pattern.Name}");
            
            while (true)
            {
                Console.WriteLine("Choose an option (e for exit): ");
                string input = Console.ReadLine();

                if (input == "e")
                    break;

                Pattern pattern = patterns.Where(p => p.Code.ToString() == input).FirstOrDefault();
                if (pattern != null)
                    pattern.Sample.Execute();
            }
        }

        public class Pattern
        {
            public Pattern()
            { 
            }
            public Pattern(int code, string name, IPatternSample sample)
            {
                this.Code = code;
                this.Name = name;
                this.Sample = sample;
            }
            public String Name { get; set; }
            public int Code { get; set; }
            public IPatternSample Sample { get; set; }
        }
    }
}
