using System;
using stepikEFPractice.Data;
using stepikEFPractice.Models;

namespace stepikEFPractice.Services;

public class UserService
{
    /// <summary>
    /// Получение пользователя из таблицы users
    /// </summary>
    /// <param name="fullName">Полное имя пользователя</param>
    /// <returns>User</returns>
    public User? Get(string fullName)
    {
        using ApplicationDbContext context = new();

        return context.Users.FirstOrDefault(user =>user.Full_Name == fullName && user.Is_Active);
    }
    /// <summary>
    /// Получение общего количества пользователей
    /// </summary>
    public int GetTotalCount()
    {
        using ApplicationDbContext context = new();

        return context.Users.Count();
    }
    /// <summary>
    /// Добавление нового пользователя в таблицу users
    /// </summary>
    /// <param name="user">Новый пользователь</param>
    /// <returns>Удалось ли добавить пользователя</returns>
    public bool Add(User user)
    {
        try
        {
            using ApplicationDbContext dbContext = new();

        }
        catch
        {

        }
    }
}
