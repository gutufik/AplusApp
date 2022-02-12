using System.Collections.Generic;
using SQLite;

 
namespace MobileApp.DataBase
{
    public class LocalRepository
    {
        SQLiteConnection database;
        public LocalRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<User>();
            database.CreateTable<Project>();
        }
        public IEnumerable<User> GetUsers()
        {
            return database.Table<User>().ToList();
        }
        public User GetUser(int id)
        {
            return database.Get<User>(id);
        }
        public int DeleteUser(int id)
        {
            return database.Delete<User>(id);
        }
        public int AddUser(User item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
        public IEnumerable<Project> GetProjects()
        {
            return database.Table<Project>().ToList();
        }
        public int AddProject(Project project)
        {
            if (project.Id != 0)
            {
                database.Update(project);
                return project.Id;
            }
            else
            {
                return database.Insert(project);
            }
        }
        public int DeleteProject(int id)
        {
            return database.Delete<Project>(id);
        }
    }
}
