using NUnit.Framework;
using System;
using System.Linq;

namespace ProjectManager.DataLayer.Tests
{
    public class ProjectManagerRepositoryTests
    {
        [Test]
        public void InsertTaskForValidDataTest()
        {
            var validData = new Task()
            {                       
                Parent_ID = 1,
                Project_ID = 1,
                TaskName = "Generate Scripts",
                Start_Date = DateTime.Now,
                End_Date = DateTime.Now.AddDays(1),
                Priority = 1,
                Status = true
            };
            var isSuccess = ProjectManagerRepository.InsertTask(validData);
            Assert.AreEqual(true, isSuccess);
        }

        [Test]
        public void InsertTaskForInValidDataTest()
        {
            var inValidData = new Task()
            {
                TaskName = null,
                Parent_ID = 1,
                Project_ID = 1,
                Start_Date = DateTime.Now,
                End_Date = DateTime.Now.AddDays(1),
                Priority = 1,
                Status = true
            };
            var isSuccess = ProjectManagerRepository.InsertTask(inValidData);
            Assert.AreEqual(false, isSuccess);
        }

        [Test]
        public void InsertTaskForNullTest()
        {
            var isSuccess = ProjectManagerRepository.InsertTask(null);
            Assert.AreEqual(false, isSuccess);
        }

        [Test]
        public void InsertUserForValidDataTest()
        {
            var validData = new User()
            {
                FirstName = "Reshma",
                LastName = "Rajendran",
                Employee_ID = 1,
                Project_ID = 1,
                Task_ID = 1
            };
            var isSuccess = ProjectManagerRepository.InsertUser(validData);
            Assert.AreEqual(true, isSuccess);
        }

        [Test]
        public void InsertUserForInValidDataTest()
        {
            var inValidData = new User()
            {
                FirstName = null,
                LastName = null,
                Employee_ID = 1,
                Project_ID = 1,
                Task_ID = 1
            };
            var isSuccess = ProjectManagerRepository.InsertUser(inValidData);
            Assert.AreEqual(false, isSuccess);
        }

        [Test]
        public void InsertUserForNullTest()
        {
            var isSuccess = ProjectManagerRepository.InsertUser(null);
            Assert.AreEqual(false, isSuccess);
        }

        [Test]
        public void InsertProjectForValidDataTest()
        {
            var validData = new Project()
            {
                ProjectName = "Microsoft",
                Start_Date = null,
                End_Date = null,
                Priority = 1
            };
            var isSuccess = ProjectManagerRepository.InsertProject(validData);
            Assert.AreEqual(true, isSuccess);
        }

        [Test]
        public void InsertProjectForInValidDataTest()
        {
            var inValidData = new Project()
            {
                ProjectName = null,
                Start_Date = null,
                End_Date = null,
                Priority = 1
            };
            var isSuccess = ProjectManagerRepository.InsertProject(inValidData);
            Assert.AreEqual(false, isSuccess);
        }

        [Test]
        public void InsertProjectForNullTest()
        {
            var isSuccess = ProjectManagerRepository.InsertProject(null);
            Assert.AreEqual(false, isSuccess);
        }

        [Test]
        public void InsertParentTaskForValidDataTest()
        {
            var validData = new ParentTask()
            {
                ParentTaskName = "Build Framework"
            };
            var isSuccess = ProjectManagerRepository.InsertParentTask(validData);
            Assert.AreEqual(true, isSuccess);
        }

        [Test]
        public void InsertParentTaskForInValidDataTest()
        {
            var inValidData = new ParentTask()
            {
                ParentTaskName = null
            };
            var isSuccess = ProjectManagerRepository.InsertParentTask(inValidData);
            Assert.AreEqual(false, isSuccess);
        }

        [Test]
        public void InsertParentTaskForNullTest()
        {
            var isSuccess = ProjectManagerRepository.InsertParentTask(null);
            Assert.AreEqual(false, isSuccess);
        }

        [Test]
        public void GetTasksTest()
        {
            var tasks = ProjectManagerRepository.GetTasks();
            Assert.NotZero(tasks.Count);
        }

        [Test]
        public void GetUsersTest()
        {
            var tasks = ProjectManagerRepository.GetUsers();
            Assert.NotZero(tasks.Count);
        }

        [Test]
        public void GetProjectsTest()
        {
            var tasks = ProjectManagerRepository.GetProjects();
            Assert.NotZero(tasks.Count);
        }

        [Test]
        public void GetTaskTestForValidDataTest()
        {
            var task = ProjectManagerRepository.GetTask(1);
            Assert.IsNotNull(task);
        }

        [Test]
        public void GetTaskTestForInValidDataTest()
        {
            var task = ProjectManagerRepository.GetTask(0);
            Assert.IsNull(task);
        }

        [Test]
        public void GetUserTestForValidDataTest()
        {
            var task = ProjectManagerRepository.GetUser(1);
            Assert.IsNotNull(task);
        }

        [Test]
        public void GetUserTestForInValidDataTest()
        {
            var task = ProjectManagerRepository.GetUser(0);
            Assert.IsNull(task);
        }

        [Test]
        public void GetProjectTestForValidDataTest()
        {
            var task = ProjectManagerRepository.GetProject(1);
            Assert.IsNotNull(task);
        }

        [Test]
        public void GetProjectForInValidDataTest()
        {
            var task = ProjectManagerRepository.GetProject(0);
            Assert.IsNull(task);
        }

        [Test]
        public void SearchUsersForValidDataTest()
        {
            var users = ProjectManagerRepository.SearchUsers("Reshma", "FirstName");
            Assert.NotZero(users.Count);
        }

        [Test]
        public void SearchUsersForInValidDataTest()
        {
            var users = ProjectManagerRepository.SearchUsers("Sydney", "FirstName");
            Assert.Zero(users.Count);
        }

        [Test]
        public void SearchUsersForNullTest()
        {
            var users = ProjectManagerRepository.SearchUsers(null, null);
            Assert.Zero(users.Count);
        }

        [Test]
        public void SearchProjectsForValidDataTest()
        {
            var projects = ProjectManagerRepository.SearchProjects("Microsoft", "StartDate");
            Assert.NotZero(projects.Count);
        }

        [Test]
        public void SearchProjectsForInValidDataTest()
        {
            var projects = ProjectManagerRepository.SearchProjects("awsyuwqwnksj", "StartDate");
            Assert.Zero(projects.Count);
        }

        [Test]
        public void SearchProjectsForNullTest()
        {
            var projects = ProjectManagerRepository.SearchProjects(null, null);
            Assert.Zero(projects.Count);
        }

        [Test]
        public void UpdateTaskForValidDataTest()
        {
            var validData = new Task()
            {
                Task_ID = 1,
                TaskName = "Generate Scripts",
                Parent_ID = 1,
                Project_ID = 1,
                Start_Date = DateTime.Now,
                End_Date = DateTime.Now.AddDays(1),
                Priority = 1,
                Status = true
            };
            var isSuccess = ProjectManagerRepository.UpdateTask(validData);
            Assert.AreEqual(true, isSuccess);
        }

        [Test]
        public void UpdateTaskForInValidDataTest()
        {
            var inValidData = new Task()
            {
                Task_ID = 1,
                TaskName = null,
                Parent_ID = 1,
                Project_ID = 1,
                Start_Date = DateTime.Now,
                End_Date = DateTime.Now.AddDays(1),
                Priority = 1,
                Status = true
            };
            var isSuccess = ProjectManagerRepository.UpdateTask(inValidData);
            Assert.AreEqual(false, isSuccess);
        }

        [Test]
        public void UpdateTaskForNullTest()
        {
            var isSuccess = ProjectManagerRepository.UpdateTask(null);
            Assert.AreEqual(false, isSuccess);
        }

        [Test]
        public void UpdateUserForValidDataTest()
        {
            var validData = new User()
            {
                User_ID = 1,
                FirstName = "Reshma",
                LastName = "Rajendran",
                Employee_ID = 1,
                Project_ID = 1,
                Task_ID = 1
            };
            var isSuccess = ProjectManagerRepository.UpdateUser(validData);
            Assert.AreEqual(true, isSuccess);
        }

        [Test]
        public void UpdateUserForInValidDataTest()
        {
            var inValidData = new User()
            {
                User_ID = 1,
                FirstName = null,
                LastName = null,
                Employee_ID = 1,
                Project_ID = 2,
                Task_ID = 12
            };
            var isSuccess = ProjectManagerRepository.UpdateUser(inValidData);
            Assert.AreEqual(false, isSuccess);
        }

        [Test]
        public void UpdateUserForNullTest()
        {
            var isSuccess = ProjectManagerRepository.UpdateUser(null);
            Assert.AreEqual(false, isSuccess);
        }

        [Test]
        public void UpdateProjectForValidDataTest()
        {
            var validData = new Project()
            {
                Project_ID = 1,
                ProjectName = "Microsoft",
                Start_Date = null,
                End_Date = null,
                Priority = 1
            };
            var isSuccess = ProjectManagerRepository.UpdateProject(validData);
            Assert.AreEqual(true, isSuccess);
        }

        [Test]
        public void UpdateProjectForInValidDataTest()
        {
            var inValidData = new Project()
            {
                Project_ID = 1,
                ProjectName = null,
                Start_Date = null,
                End_Date = null,
                Priority = 1
            };
            var isSuccess = ProjectManagerRepository.UpdateProject(inValidData);
            Assert.AreEqual(false, isSuccess);
        }

        [Test]
        public void UpdateProjectForNullTest()
        {
            var isSuccess = ProjectManagerRepository.UpdateProject(null);
            Assert.AreEqual(false, isSuccess);
        }

        [Test]
        public void UpdateParentTaskForValidDataTest()
        {
            var validData = new ParentTask()
            {
                Parent_ID = 1,
                ParentTaskName = "Build Framework"
            };
            var isSuccess = ProjectManagerRepository.UpdateParentTask(validData);
            Assert.AreEqual(true, isSuccess);
        }

        [Test]
        public void UpdateParentTaskForInValidDataTest()
        {
            var inValidData = new ParentTask()
            {
                Parent_ID = 1,
                ParentTaskName = null
            };
            var isSuccess = ProjectManagerRepository.UpdateParentTask(inValidData);
            Assert.AreEqual(false, isSuccess);
        }

        [Test]
        public void UpdateParentTaskForNullTest()
        {
            var isSuccess = ProjectManagerRepository.UpdateParentTask(null);
            Assert.AreEqual(false, isSuccess);
        }

        [Test]
        public void DeleteUserTest()
        {
            var isSuccess = ProjectManagerRepository.DeleteUser(1);
            Assert.AreEqual(true, isSuccess);
        }        

        [Test]
        public void DeleteProjectTest()
        {
            var isSuccess = ProjectManagerRepository.DeleteProject(1);
            Assert.AreEqual(true, isSuccess);
        }        
    }
}
