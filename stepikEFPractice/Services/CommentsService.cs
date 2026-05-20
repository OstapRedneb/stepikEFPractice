using System;
using Microsoft.EntityFrameworkCore;
using stepikEFPractice.Data;

namespace stepikEFPractice.Services;


public class CommentsService
{
    /// <summary>
    /// Получение всех комментариев к курсу
    /// </summary>
    /// <param name="id">id курса</param>
    /// <returns>Список комментариев</returns>  
    public List<Comment> Get(int id)
    {
        using ApplicationDbContext dbContext = new();

        return dbContext.Comments
            .AsNoTracking()
            .Where(comment => 
                comment.ReplyComment == null && 
                comment.Step.Lesson.UnitLessons.Any(unitLesson => unitLesson.Unit.CourseId == id))
            .OrderByDescending(c => c.Time)
            .ToList();
    }


    /// <summary>
    /// Удаление комментария пользователя
    /// </summary>
    /// <param name="id">id комментария</param>
    /// <returns>Удалось ли удалить комментарий</returns>
    public bool Delete(int id)
    {
        using ApplicationDbContext dbContext = new();

        return dbContext.RemoveRange()
    }
}
