using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Telecommunication_Franchise_Management_System.BL;

namespace Telecommunication_Franchise_Management_System.DL
{
    public class CustomerDL
    {
        private static int customerIdx = 0;
        private static List<Customer> customerList = new List<Customer>();

        public static int CustomerIdx { get => customerIdx; set => customerIdx = value; }
        public static List<Customer> CustomerList { get => customerList; set => customerList = value; }

        public static void addCustomerIntoList(Customer cust)
                {
                    CustomerList.Add(cust);
                }
                public static bool UpdateCustomerData(Customer PreviousData,Customer UpdatedData)
                {
                    foreach (Customer cust in CustomerList)
                    {
                        if (cust.Name == PreviousData.Name && cust.Password == PreviousData.Password && cust.Cnic == PreviousData.Cnic)
                        {
                            cust.Name = UpdatedData.Name;
                            cust.Password = UpdatedData.Password;
                           
                            cust.PhoneNum = UpdatedData.PhoneNum;
                            cust.Cnic = UpdatedData.Cnic;

                            return true;
                        }

                    }
                    return false;
                }
                public static bool CustomerExist(Customer cust)
                {
                    foreach(Customer customer in CustomerList)
                    {
                        if(customer.Name == cust.Name && customer.Cnic == cust.Cnic)
                        {
                             return true;
                        }
                    }
                        return false;
                }
                public static void deleteCustomerFromList(Customer DelCust)
                {

                    foreach (Customer cust in CustomerList)
                    {
                    int index = 0;
                        if (cust.Name == DelCust.Name && cust.Password == DelCust.Password && DelCust.Cnic == cust.Cnic)
                        {
                            CustomerList.RemoveAt(index);
                            break;

                        }
                        index++;
                    }
                }
                public static void LoadCustomersFromFile(string path)
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
                        Customer cust = new Customer(name, password,phoneNum,cnic,Balance,Emoney);
                       /* string simsLine = splitLine[6];
                string[] splitSimsLine = simsLine.Split(';');
                for(int i = 0; i < splitSimsLine.Length; i++)
                {
                    string[] simdata = splitSimsLine[i].Split(':');
                    string number = simdata[0];
                    string type = simdata[1];
                    string Price = simdata[2];
                    sim s = new sim(number, type, int.Parse(Price));
                    cust.Sims.Add(s);
                }*/

                      
                        CustomerList.Add(cust);


                    }
                    file.Close();

                }
                public static void storeAllDataIntoFile(string path)
                {
                    StreamWriter file = new StreamWriter(path);
                    foreach (Customer storedCustomer in CustomerList)
                    {

                        file.Write(storedCustomer.Name + "," + storedCustomer.Password + "," + storedCustomer.PhoneNum + "," + storedCustomer.Cnic + "," + storedCustomer.Balance + "," + storedCustomer.Emoney + "," );
                        for(int i = 0; i < storedCustomer.Sims.Count; i++)
                {
                    file.Write(storedCustomer.Sims[i].Number + ":" + storedCustomer.Sims[i].Type + ":" + storedCustomer.Sims[i].Price );
                    file.Write(";");

                    
                }
                file.WriteLine();
                    }
                    file.Flush();
                    file.Close();

                }
                public static Customer SignIn(Customer cust)
                {
                        customerIdx = 0;
                    foreach (Customer storedCust in CustomerList)
                    {
                        if (storedCust.Name == cust.Name && storedCust.Password == cust.Password)
                        {
                            return storedCust;
                        }
                            customerIdx++;
                    }
                    return null;
                }
        /* 


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

                }*/
    }
}
