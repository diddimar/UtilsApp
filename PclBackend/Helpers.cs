using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PclBackend
{
    public enum TemperatureTypeResult { Celsius, Farenheit }

    public enum WeightTypeResult { Kg, Lbs }

    public static class Helpers
    {

        const float calcConst = 2.2046226F;

        public static string CalculateHeat(string temp, TemperatureTypeResult tempTypeResult)
        {
            float tempNumber;
            float tempResult;

            string result = string.Empty;

            bool isNumber = float.TryParse(temp, out tempNumber);

            if (isNumber)
            {
                result = string.Empty;

                if (tempTypeResult == TemperatureTypeResult.Celsius)
                {
                    tempResult = ((tempNumber - 32) / 9) * 5;
                    result = String.Format("{0:0.00}° C", tempResult);
                }
                else if (tempTypeResult == TemperatureTypeResult.Farenheit)
                {
                    tempResult = ((tempNumber / 5) * 9) + 32;
                    result = String.Format("{0:0.00}° F", tempResult);
                }
            }
            else
            {
                throw new Exception("Óleyfileg tala");
            }

            return result;
        }

        public static string CalculateWeight(string weight, WeightTypeResult weightTypeResult)
        {
            float weightResult;
            float nWeight = float.MinValue;

            string result = string.Empty;

            bool isNumeric = float.TryParse(weight, out nWeight);

            if (isNumeric)
            {
                if (weightTypeResult == WeightTypeResult.Lbs)
                {
                    weightResult = (nWeight * calcConst);
                    result = String.Format("{0:0.00} Lbs", weightResult);
                }
                else if (weightTypeResult == WeightTypeResult.Kg)
                {
                    weightResult = (nWeight / calcConst);
                    result = String.Format("{0:0.00} Kg", weightResult);
                }
            }
            else
            {
                throw new Exception("Óleyfileg tala");
            }

            return result;
        }
    }

}

