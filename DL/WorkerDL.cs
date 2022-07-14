using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Telecommunication_Franchise_Management_System.BL;

namespace Telecommunication_Franchise_Management_System.DL
{
    internal class WorkerDL
    {
        private static List<Worker> workersList = new List<Worker>();

        internal static List<Worker> WorkersList { get => workersList; set => workersList = value; }
        public static void addWorkerIntoList(Worker worker)
        {
            workersList.Add(worker);
        }
        public static bool UpdateWorkerData(Worker PreviousData, Worker UpdatedData)
        {
            foreach (Worker worker in workersList)
            {
                if (worker.Name == PreviousData.Name && worker.Password == PreviousData.Password && worker.Cnic == PreviousData.Cnic)
                {
                    worker.Name = UpdatedData.Name;
                    worker.Password = UpdatedData.Password;
                    worker.Role = UpdatedData.Role;
                    worker.PhoneNum = UpdatedData.PhoneNum;
                    worker.Cnic = UpdatedData.Cnic;
                    return true;
                }

            }
            return false;
        }

        public static void deletWorkerFromList(Worker Delworker)
        {

            foreach (Worker worker in workersList)
            {
            int index = 0;
                if (worker.Name == Delworker.Name && worker.Password == Delworker.Password && worker.Cnic == Delworker.Cnic)
                {
                    workersList.RemoveAt(index);
                    break;

                }
                index++;
            }
        }
        public static void LoadWorkersFromFile(string path)
        {
            StreamReader file = new StreamReader(path);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] splitLine = line.Split(',');
                string name = splitLine[0];
                string password = splitLine[1];
                string phoneNum = splitLine[2];
                string cnic = splitLine[3];
                int Balance = int.Parse(splitLine[4]);
                int Emoney = int.Parse(splitLine[5]);

                Worker worker = new Worker(name, password, phoneNum, cnic, Balance, Emoney);
                workersList.Add(worker);


            }
            file.Close();

        }

        public static void EditWorkerFromList(Worker previous, Worker updated)
        {
            foreach (Worker worker in WorkersList)
            {
                if (worker.Name == previous.Name && worker.Password == previous.Password)
                {
                    worker.Name = updated.Name;
                    worker.Password = updated.Password;
                    worker.PhoneNum = updated.PhoneNum;
                    worker.Cnic = updated.Cnic;
                }
            }

        }
        public static void storeAllDataIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (Worker storedWorker in WorkersList)
            {

                file.WriteLine(storedWorker.Name + "," + storedWorker.Password + "," + storedWorker.PhoneNum + "," +  storedWorker.Cnic + "," + storedWorker.Balance + "," + storedWorker.Emoney);
            }
            file.Flush();
            file.Close();

        }

    }
}
