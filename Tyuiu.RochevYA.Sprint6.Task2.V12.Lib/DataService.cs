using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RochevYA.Sprint6.Task2.V12.Lib
{
    public class DataService : ISprint6Task2V12
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] results = new double[length];

            for (int x = startValue, i = 0; x <= stopValue; x++, i++)
            {
                double res = Math.Cos(x)+x;

                if (res == 0)
                {
                    results[i] = 0;
                }
                else
                {
                    double value = ((2*x+6) / res) - 3;
                    results[i] = Math.Round(value, 2);
                }
            }

            return results;
        }
    }

}
