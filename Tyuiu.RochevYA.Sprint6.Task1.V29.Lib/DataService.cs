using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.RochevYA.Sprint6.Task1.V29.Lib
{
    public class DataService : ISprint6Task1V29
    {
        public double[] GetMassFunction(int startValue, int stopValue) 
        {
            int length = stopValue - startValue + 1;
            double[] results = new double[length];

            for (int x = startValue, i = 0; x <= stopValue; x++, i++)
            {
                double res = (x + 1);

                if (res == 0)
                {
                    results[i] = 0;
                }
                else
                {
                    double value = ((Math.Cos(x)) / res) - Math.Cos(x) * 1.3 + 3*x;
                    results[i] = Math.Round(value, 2);
                }
            }

            return results;
        }
    }

}
