using System;
using Microsoft.EntityFrameworkCore;
using stepikEFPractice.Data;
using stepikEFPractice.Models;

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
}
