using System.Collections.Generic;
using System.IO;


namespace TradingJpurnal
{
    class DataManger
    {
        public static List<Trade> trades = new List<Trade>();

        public static void SaveData()
        {
            using (TextWriter tw = new StreamWriter("data.txt"))
            {
                foreach (Trade item in trades)
                {
                    tw.WriteLine(item.ToString());

                }
            }

        }

        public static void ReadData()
        {
            using (StreamReader file = new StreamReader("data.txt"))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    string[] arr = ln.Split(',');

                    trades.Add(new Trade(arr[0], arr[1],arr[2], int.Parse(arr[3]), double.Parse(arr[4]), double.Parse(arr[5]), arr[6], arr[7], arr[8], arr[9], double.Parse(arr[10]), double.Parse(arr[11]), double.Parse(arr[12]), double.Parse(arr[13]), double.Parse(arr[14])));
                    counter++;
                }
                file.Close();
                
            }
        }


    }
}
