using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tut2_Quetsion2
{
    
    internal class DataManager
    {
        private Data[] data;
        public Data[] ReadFromFile()
        {
            List<Data> dataList = new List<Data>();
            string filePath = @"C:\Users\RANDY\Desktop\Studies\BIT 2024\Semester One\DSW013A\Graded Tutorials & Labs\222026588_Ngubo.Tut2\FilesToStudents\MOCK_DATA.csv";


            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] columns = line.Split(',');
                    Data data = new Data();
                    data.Number = int.Parse(columns[0]);
                    data.Name = columns[1];
                    data.Surname = columns[2];
                    data.Email = columns[3];
                    data.Gender = columns[4];
                    data.Ip = columns[5];
                    dataList.Add(data);                   
                       

                }
                

            }
            data = dataList.ToArray();
            return data;

        }


        public Data[] determineDomain(string domain)
        {
            List<Data> domainList = new List<Data>();

            foreach(Data item in data)
            {
                if (item.Email.EndsWith(domain))
                {
                    domainList.Add(item);

                }
            }

            return domainList.ToArray();
        }
        public int getCounter(string domain)
        {
            int count = 0;

            foreach (Data item in data)
            {
                if (item.Email.EndsWith(domain))
                {
                    count++;
                }
            }
           return count;
        }

        public Data getRecord(int index)
        {
            if(index >= 0 && index < data.Length)
            {
                return data[index];
            }
            else
            {
                return null;
            }
            

        }
    }
}
