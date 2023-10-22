using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatterninCSharp.ExercisesPractice;

namespace PatterninCSharp
{
    public class RunGenericProgram
    {
        ForLoop loopObj = new ForLoop();
        public void AllForLoopProgram()
        {
            loopObj.WordPattern();
            Console.WriteLine("------------------------");
            loopObj.TriangleNumIncreased();
            Console.WriteLine("------------------------");
            loopObj.PatternTriNum();
            Console.WriteLine("------------------------");
            loopObj.OddNaturalNumbSum();
            Console.WriteLine("------------------------");
            loopObj.MultiplicationOfTable();
            Console.WriteLine("------------------------");
            loopObj.DisplayNaturalNumber();
            Console.WriteLine("------------------------");
            loopObj.SumOfNaturalNum();
            Console.WriteLine("------------------------");
            loopObj.CubeNum();
        }
    }
}
