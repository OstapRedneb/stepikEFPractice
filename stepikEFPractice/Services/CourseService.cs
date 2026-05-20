using System;
using Microsoft.EntityFrameworkCore;
using stepikEFPractice.Data;

namespace stepikEFPractice.Services;

public class CourseService
{
    /// <summary>
    /// Получение общего количества курсов
    /// </summary>
    public int GetTotalCount()
    {
        using ApplicationDbContext dbContext = new();
        
        return dbContext.Courses.AsNoTracking().Count();
    }
    /// <summary>
    /// Получение списка курсов пользователя
    /// </summary>
    /// <param name="fullName">Полное имя пользователя</param>
    /// <returns>Список курсов</returns>
    public List<Course> Get(string fullName)
    {
        using ApplicationDbContext dbContext = new();
    
        return dbContext.Users
            .Include(user => user.UserCourses)
            .ThenInclude(userCourse => userCourse.Course)
            .AsNoTracking()
            .FirstOrDefault(user => user.FullName == fullName)
            ?.UserCourses
            ?.Select(userCourse => userCourse.Course)
            ?.ToList() ?? new List<Course>();
    }
}
