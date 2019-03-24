using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StormLightArchive.Models;

namespace StormLightArchive.DAL
{
    public interface IBookDAL
    {
        List<BookModel> GetAllBooks();

        BookModel GetBook(string name);
    }
}
