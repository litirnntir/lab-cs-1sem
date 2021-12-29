using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_8
{
    class MathProblem
    {
        private
            static double ComputerResult, Answer, Alpha, Beta;


        public static double MathManager(string PlayerResult, string AStr, string BStr)
        {
            Answer = double.Parse(PlayerResult);
            Alpha = double.Parse(AStr);
            Beta = double.Parse(BStr);

            ComputerResult = Math.Sin((Math.Pow(Alpha, 3) + Math.Pow(Beta, 5)) / (Math.PI * 2)) + Math.Pow(Math.Abs(Math.Cos(Alpha + Beta)), 1.0 / 3.0);

            return ComputerResult;
        }

        public static bool MatchChecker(double ComputerResult, string PlayerResult)
        {

            double HelperComputerResult = Math.Round(ComputerResult, 2);
            Answer = Math.Round(Answer, 2);

            return HelperComputerResult == Answer;
        }
    }
}
