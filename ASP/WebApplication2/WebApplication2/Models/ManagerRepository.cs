namespace WebApplication2.Models
{
    public class ManagerRepository: Imanager
    {
        public List<Manager> DataSource ()
        {
            return new List<Manager>()
            { new Manager(){Name = "Anshu", Gender = "male", managerID = 1, Address = "Patna"},


            new Manager(){Name = "Anshuman", Gender = "male", managerID = 2, Address = "Patna"}
            };
        }

        public Manager GetManagerById(int managerID)
        {
            return DataSource().FirstOrDefault(e => e.managerID == managerID);
        }

    }
}
