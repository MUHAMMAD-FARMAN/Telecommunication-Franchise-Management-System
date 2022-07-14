using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telecommunication_Franchise_Management_System.BL;
using System.IO;

namespace Telecommunication_Franchise_Management_System.DL
{
    internal class SimsDL
    {
        private int simIdx;
        private static List<sim> simsList = new List<sim>();

        public static List<sim> SimsList { get => simsList; set => simsList = value; }
        public int SimIdx { get => simIdx; set => simIdx = value; }

        public static void addSimIntoList(sim Sim)
        {
            simsList.Add(Sim);
        }
        public static bool UpdateSimData(sim PreviousData, sim UpdatedData)
        {
            foreach (sim Sim in simsList)
            {
                if (Sim.Number == PreviousData.Number && Sim.Type == PreviousData.Type)
                {
                    Sim.Number = UpdatedData.Number;
                    Sim.Type = UpdatedData.Type;
                    Sim.Price = UpdatedData.Price;
                    
                    return true;
                }

            }
            return false;
        }
        public static void deletSimFromList(sim DelSim)
        {

            foreach (sim Sim in simsList)
            {
                int index = 0;
                if (Sim.Number == DelSim.Number && Sim.Type == DelSim.Type)
                {
                    simsList.RemoveAt(index);
                    break;

                }
                index++;
            }
        }
        public static void LoadSimsFromFile(string path)
        {
            StreamReader file = new StreamReader(path);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] splitLine = line.Split(',');
                string Number = splitLine[0];
                string Type = splitLine[1];
                string Price = splitLine[2];
               

                sim Sim = new sim(Number ,Type , int.Parse(Price));
                simsList.Add(Sim);


            }
            file.Close();

        }
        public static void EditSimFromList(sim PreviousData, sim updated)
        {
            foreach (sim Sim in simsList)
            {
                if (Sim.Number == PreviousData.Number && Sim.Type == PreviousData.Type)
                {
                   Sim.Number = updated.Number;
                    Sim.Type = updated.Type;
                    Sim.Price = updated.Price;
                }
            }

        }
        public static void storeAllDataIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (sim storedsims in simsList)
            {

                file.WriteLine(storedsims.Number + "," + storedsims.Type + "," + storedsims.Price);
            }
            file.Flush();
            file.Close();

        }
       
    }
}

