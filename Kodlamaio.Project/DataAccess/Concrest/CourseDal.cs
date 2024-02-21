﻿using Kodlamaio.Project.DataAccess.Abstract;
using Kodlamaio.Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.Project.DataAccess.Concrest
{
    public class CourseDal:ICourseDal
    {
        List<Course> courses;
        public CourseDal()
        {
            Course course1 = new Course();
            course1.Name = "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)";
            course1.Id = 1;
            course1.Description = ".net";
            course1.Price = 10;


            Course course2 = new Course();
            course2.Name = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)";
            course2.Id = 2;
            course2.Description = "C# + Angular";
            course2.Price = 23;

            Course course3 = new Course();
            course3.Name = "(2023) Yazılım Geliştirici Yetiştirme Kampı (Python & Selenium)";
            course3.Id = 3;
            course3.Description = "Python";
            course3.Price = 23;

            Course course4 = new Course();
            course4.Name = "2022) Yazılım Geliştirici Yetiştirme Kampı - JAVA";
            course4.Id = 4;
            course4.Description = "Java";
            course4.Price = 233;

            Course course5 = new Course();
            course5.Name = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)";
            course5.Id = 5;
            course5.Description = "Javascript";
            course5.Price = 233;

            Course course6 = new Course();
            course6.Name = "Yazılım Geliştirici Yetiştirme Kampı (JAVA & REACT)";
            course6.Id = 6;
            course6.Description = "JAVA & REACT";
            course6.Price = 53;

            courses = new List<Course>() { course1, course2, course3, course4, course5, course6 };

        }


        public List<Course>GetAll(){
            return courses;
           
}
        public void Add(Course course) {

            courses.Add(course);
           
        }


    }
}
