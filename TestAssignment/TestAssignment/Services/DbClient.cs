using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using TestAssignment.Models;

namespace TestAssignment.Services
{
    public class DbClient
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();

        public DbClient()
        {
            dbContext.Database.EnsureCreated();

            dbContext.DataTable.Load();
        }

        private ObservableCollection<DataModel> LoadContext()
        {
            return dbContext.DataTable.Local.ToObservableCollection();
        }

        private void CreateDataModel(DataModel model) 
        { 
            dbContext.DataTable.Add(model);
            dbContext.SaveChanges();
        }

        private void UpdateDataModel(DataModel model) 
        { 
            dbContext.DataTable.Update(model);
        }

        private void RemoveDataModel(DataModel model) 
        {
            dbContext.DataTable.Remove(model);
        }
    }
}
