﻿using StuMS.Data;
using StuMS.Models;
using StuMS.Repo.IRepo;

namespace StuMS.Repo
{
    public class CourseRepo : Repo<Course>, ICourseRepo
    {
        private ApplicationDbContext _db;
        public CourseRepo(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

    }
}
