﻿using Moq;
using OpenSchoolLibrary.Entities.Interfaces;
using OpenSchoolLibrary.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSchoolLibrary.Tests.Data
{
    internal static class FakeData
    {
        public static IEnumerable<Book> GetBookList()
        {
            return new List<Book>()
            {
                { new Book{ Author="James Dewey", BookId=1, Dewey=new Dewey{ }, DeweyID=1, Genre=new Genre{ }, GenreID=1, ISBN=1, SubTitle="", Title="" } },
                { new Book{ Author="", BookId=2, Dewey=new Dewey{ }, DeweyID=2, Genre=new Genre{ }, GenreID=2, ISBN=2, SubTitle="", Title="" } },
                { new Book{ Author="", BookId=3, Dewey=new Dewey{ }, DeweyID=3, Genre=new Genre{ }, GenreID=3, ISBN=3, SubTitle="", Title="" } }
            };
        }

        public static IEnumerable<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student {Email = "", Fines = 0, FirstName = "John", Grade = 3, IssuedID = 0003,
                LastName = "Smith", StudentID = 0258, Teacher = new Teacher { }, TeacherID = 458 },

                new Student {Email = "", Fines = 1.00m, FirstName = "Jane", Grade = 4, IssuedID = 0803,
                LastName = "Smith", StudentID = 0758, Teacher = new Teacher { }, TeacherID = 895 },

                new Student {Email = "", Fines = 0, FirstName = "Mark", Grade = 3, IssuedID = 0753,
                LastName = "Straw", StudentID = 5486, Teacher = new Teacher { }, TeacherID = 342 }
            };
        }

        public static IBookRepository GetBookRepository()
        {
            var mock = new Mock<IBookRepository>();
            mock.Setup(b => b.GetBooks()).Returns(() => GetBookList());

            return mock.Object;
        }


    }
}