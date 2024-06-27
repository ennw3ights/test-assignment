using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using TestAssignment.Models;

namespace TestAssignment.Services
{
    public class DbClient
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();

        ObservableCollection<DataModel> models = new ObservableCollection<DataModel>();

        public DbClient()
        {
            dbContext.Database.EnsureCreated();

            dbContext.DataTable.Load();
        }

        public ObservableCollection<DataModel> LoadContext()
        {
            return dbContext.DataTable.Local.ToObservableCollection();
        }

        public void AddDataModel(DataModel model) 
        { 
            dbContext.DataTable.Add(model);
            dbContext.SaveChanges();
        }
    }
}
