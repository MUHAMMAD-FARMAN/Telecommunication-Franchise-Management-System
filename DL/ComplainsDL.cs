using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Telecommunication_Franchise_Management_System.BL;

namespace Telecommunication_Franchise_Management_System.DL
{
    public class ComplainsDL
    {
        private static List<ComplainClass> complainsList = new List<ComplainClass>();

        public static List<ComplainClass> ComplainsList { get => complainsList; set => complainsList = value; }

        public static void addComplainIntoList(ComplainClass Complain)
        {
            ComplainsList.Add(Complain);
        }
        public static void DeleteComplainFromList(ComplainClass Complain)
        {
            int index = 0;
            foreach(ComplainClass complain in ComplainsList)
            {
                if(complain.Complain == Complain.Complain)
                {
                    ComplainsList.RemoveAt(index);
                }
                index++;
            }
        }
        public static void addComplainIntoFile(ComplainClass Complain ,string Path)
        {
            StreamWriter file = new StreamWriter(Path,true);
            file.WriteLine(Complain.Complain);
            file.Close();
            
        }
        public static void AddComplainsDataIntoFile( string Path)
        {
            StreamWriter file = new StreamWriter(Path,true);
            foreach(ComplainClass complain in complainsList)
            {
                file.WriteLine(complain.Complain  + "," + complain.Action);

            }
            file.Close();
        }
        public static void AddComplainsIntoList(string Path)
        {
            StreamReader file = new StreamReader(Path);
            string line;
            while((line = file.ReadLine()) != null)
            {
                string[] splitLine = line.Split(',');
                string complain = splitLine[0];
                string Action = splitLine[1];
                ComplainClass complainClass = new ComplainClass(complain,Action);
                complainsList.Add(complainClass);
            }
            file.Close();
        }

       
    }
}
