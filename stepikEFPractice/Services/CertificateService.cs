using System;
using stepikEFPractice.Data;
using stepikEFPractice.Models;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace stepikEFPractice.Services;

public class CertificateService
{
    /// <summary>
    /// Получение сертификатов пользователя
    /// </summary>
    /// <param name="fullName">Полное имя пользователя</param>
    /// <returns>DataSet</returns>
    public DataSet Get(string fullName)
    {
        using ApplicationDbContext dbContext = new();

        DataSet dataSet = new DataSet();
        
        DataTable table = new DataTable();
        table.Columns
            .AddRange([
            new DataColumn("title", typeof(string)),
            new DataColumn("issue_date", typeof(DateTime)),
            new DataColumn("grade", typeof(int))
            ]);
        
        var userCertificates = dbContext
            .Users
            .Include(user => user.Certificates)
                .ThenInclude(certificate => certificate.Course)
            .AsNoTracking()
            .Where(user => user.FullName == fullName)
            .FirstOrDefault()
            ?.Certificates
            ?.Select(certificate => new 
                {
                    certificate.Course.Title, 
                    certificate.IssueDate, 
                    certificate.Grade
                })
            ?.ToList();

        if (userCertificates != null)
            userCertificates.ForEach(userCertificate => table.Rows.Add(
                    userCertificate.Title, 
                    userCertificate.IssueDate, 
                    userCertificate.Grade));
        
        dataSet.Tables.Add(table);
    }
}
