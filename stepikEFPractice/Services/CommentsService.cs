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
        try
        {
            using ApplicationDbContext dbContext = new();

            var courseReviews = dbContext.CourseReviews.Where(cr => cr.CommentId == id);
            dbContext.CourseReviews.RemoveRange(courseReviews);

            var replies = dbContext.Comments.Where(c => c.ReplyCommentId == id);
            dbContext.Comments.RemoveRange(replies);

            var comment = dbContext.Comments.FirstOrDefault(c => c.Id == id);
            if (comment != null)
            {
                dbContext.Comments.Remove(comment);
            }

            dbContext.SaveChanges();

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
