using System.Collections.Generic;
using System.Linq;
using KafedraApp.Models;

namespace KafedraApp.Data
{
    public sealed class DbReader
    {
        public bool ValidateUser(string login, string password)
        {
            using (var context = new KafedraDBEntities3())
            {
                return context.AppUsers.Any(u =>
                    u.LoginName == login &&
                    u.PasswordPlain == password &&
                    u.RoleName == "HeadOfDepartment");
            }
        }

        public List<TeacherInfo> GetTeachers()
        {
            using (var context = new KafedraDBEntities3())
            {
                return context.vTeacherLists
                    .OrderBy(t => t.LastName)
                    .ThenBy(t => t.FirstName)
                    .ThenBy(t => t.MiddleName)
                    .Select(t => new TeacherInfo
                    {
                        LastName = t.LastName,
                        FirstName = t.FirstName,
                        MiddleName = t.MiddleName,
                        CategoryName = t.CategoryName,
                        Salary = t.Salary,
                        AddressLine = t.AddressLine
                    })
                    .ToList();
            }
        }

        public List<TeacherLoadInfo> GetTeacherLoad()
        {
            using (var context = new KafedraDBEntities3())
            {
                return context.vTeacherLoads
                    .OrderBy(l => l.FIO)
                    .ThenBy(l => l.SubjectName)
                    .Select(l => new TeacherLoadInfo
                    {
                        Fio = l.FIO,
                        SubjectName = l.SubjectName,
                        CycleCode = l.CycleCode,
                        Hours = l.Hours
                    })
                    .ToList();
            }
        }
    }
}
