using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RochevYA.Sprint6.Task4.V10.Lib
{
    public class DataService : ISprint6Task4V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] results = new double[length];

            for (int x = startValue, i = 0; x <= stopValue; x++, i++)
            {
                double res = (Math.Sin(x)+3);

                if (res == 0)
                {
                    results[i] = 0;
                }
                else
                {
                    double value = ((5 * x + 2.5) / res) + 2*x + Math.Cos(x);
                    results[i] = Math.Round(value, 2);
                }
            }
            return results;
        }
    }
}
