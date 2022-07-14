using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Telecommunication_Franchise_Management_System.BL;

namespace Telecommunication_Franchise_Management_System.DL
{
    internal class MUserDL
    {
        private static  List<MUser> Users = new List<MUser>();

        internal static List<MUser> UsersList { get => Users; set => Users = value; }

        public static void addUserIntoList(MUser user)
        {
            Users.Add(user);
        }

        public static MUser SignIn(MUser user)
        {
            foreach (MUser storedUser in Users)
            {
                if (storedUser.Name == user.Name && storedUser.Password == user.Password)
                {
                    return storedUser;
                }
            }
            return null;
        }

        public static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        public static bool readDataFromFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string Name = parseData(record, 1);
                    string Password = parseData(record, 2);
                    string Role = parseData(record, 3);
                    MUser user = new MUser(Name, Password, Role);
                    addUserIntoList(user);
                }
                fileVariable.Close();
                return true;
            }
            else
                return false;
        }
        public static void readCustomerDataFromFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;
                while((line = file.ReadLine()) != null)
                {
                    string[] splitLine = line.Split(',');
                    string name = splitLine[0];
                    string password = splitLine[1];
                    string phoneNum = splitLine[2];
                    string cnic = splitLine[3];

                    Customer cust = new Customer(name, password, phoneNum , cnic);
                    addUserIntoList(cust);
                }
                file.Close();

            }

        }

        public static void storeUserIntoFile(MUser user, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.Name + "," + user.Password + "," + user.Role);
            file.Flush();
            file.Close();

        }
        public static void storeCustomerIntoFile(Customer cust, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(cust.Name + "," + cust.Password + "," + cust.PhoneNum + "," + cust.Cnic );
            file.Flush();
            file.Close();

        }

        public static void deleteUserFromList(MUser user)
        {
            for (int index = 0; index < Users.Count; index++)
            {
                if (Users[index].Name == user.Name && Users[index].Password == user.Password)
                {
                    Users.RemoveAt(index);
                }
            }

        }
        public static void deleteCustomerFromList(MUser user)
        {
            for (int index = 0; index < Users.Count; index++)
            {
                if (Users[index].Name == user.Name && Users[index].Password == user.Password)
                {
                    Users.RemoveAt(index);
                }
            }

        }

        public static void EditUserFromList(MUser previous, MUser updated)
        {
            foreach (MUser user in Users)
            {
                if (user.Name == previous.Name && user.Password == previous.Password)
                {
                    user.Name = updated.Name;
                    user.Password = updated.Password;
                    user.Role = updated.Role;
                }
            }

        }
        public static void EditCustomerFromList(Customer previous, Customer updated)
        {
            foreach (Customer cust in Users)
            {
                if (cust.Name == previous.Name && cust.Password == previous.Password)
                {
                    cust.Name = updated.Name;
                    cust.Password = updated.Password;
                    cust.PhoneNum = updated.PhoneNum;
                    cust.Cnic = updated.Cnic;
                    cust.Role = updated.Role;
                }
            }

        }
        public static void storeAllDataIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (MUser storedUser in Users)
            {

                file.WriteLine(storedUser.Name + "," + storedUser.Password + "," + storedUser.Role);
            }
            file.Flush();
            file.Close();

        }



    }
}
