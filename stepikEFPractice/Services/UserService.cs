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

        return context.Users.FirstOrDefault(user =>user.FullName == fullName && user.IsActive);
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
            using ApplicationDbContext context = new();
            context.Users.Add(user);
            return context.SaveChanges() == 1;
        }
        catch
        {
            return false;
        }
    }
    /// <summary>
    /// Форматирование показателей пользователя
    /// </summary>
    /// <param name="number">Число для форматирования</param>
    /// <returns>Отформатированное число</returns>
    public string? FormatUserMetrics(int number)
    {
        if (number < 1000)
        {
            return number.ToString();
        }
        else
        {
            double formattedNumber = number / 1000.0;
            string formattedString = formattedNumber
                .ToString("0.0K", System.Globalization.CultureInfo.InvariantCulture)
                .Replace(".0K", "K");
            return formattedString;
        }
    }
}
