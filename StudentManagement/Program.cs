using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StudentManagement
{
    internal class Program
    {

        static int ID = 0;
        static List<Course> courses = new List<Course>();
        static List<Student> students = new List<Student>();


        static void Main(string[] args)
        {
            //Initializing course list
            courses.Add(new Course("Math 101"));
            courses.Add(new Course("English 101"));
            courses.Add(new Course("Science 101"));
            courses.Add(new Course("Yoga 101"));

            bool exitStatus = false;

            /*
             -1. List students
             -2. Register student
             -3. Find student by id
             -4. Edit student
             -5. Course student total
             */

            Console.WriteLine("<------------Student Management-------------->");
            while (!exitStatus)
            {
                Console.WriteLine("Please select a menu option!!!!");
                Console.WriteLine("\n1. Register Student" + "\n2. List Students" + "\n3. Find Student by id" + "\n4. Edit Student info" + "\n5. Course Student total" + "\n6. Exit");

                int input = Console.Read();

                switch (input)
                {
                    case 1:
                        RegisterStudent();
                        break;
                    case 2:
                        ListStudents();
                        break;
                    case 3:
                        FindStudent();
                        break;
                    case 4:
                        EditStudent();
                        break;
                    case 5:
                        CourseTotal();
                        break;
                    case 6:
                        exitStatus = true;
                        break;
                }
            }
        }

        public static void RegisterStudent()
        {

            bool exitStatus = false;
            string name, fName = "", mName, lName = "", grade;
            DateTime dob;
            int year = 0, month = 0, day = 0;
            List<Course> courses = new List<Course>();

            while (!exitStatus)
            {
                Console.WriteLine("Please enter Student's first name: ");

                fName = Console.ReadLine();

                if (fName.Equals(""))
                {
                    Console.WriteLine("First name can not be blank.");
                }
                else
                {
                    exitStatus = true;
                }
            }

            exitStatus = false;

            Console.WriteLine("Please enter Student middle name (press enter if no middle name): ");

            mName = Console.ReadLine();

            if (!mName.Equals(""))
            {
                mName = mName + " ";
            }

            while (!exitStatus)
            {
                Console.WriteLine("Please enter Student's last name: ");

                lName = Console.ReadLine();

                if (lName.Equals(""))
                {
                    Console.WriteLine("Last name can not be blank.");
                }
                else
                {
                    exitStatus = true;
                }
            }

            exitStatus = false;

            name = String.Concat(fName, " ", mName, lName);

            while (!exitStatus)
            {
                Console.WriteLine("Please enter Student's birth year: ");

                year = Console.Read();

                if (year > 2004 || year < 1932)
                {
                    Console.WriteLine("Student must between 18 and 90.");
                }
                else
                {
                    exitStatus = true;
                }
            }

            exitStatus = false;

            while (!exitStatus)
            {
                Console.WriteLine("Please enter Student's birth month: ");

                month = Console.Read();

                if (month > 12 || month < 1)
                {
                    Console.WriteLine("Invalid month");
                }
                else
                {
                    exitStatus = true;
                }
            }

            exitStatus = false;

            while (!exitStatus)
            {
                Console.WriteLine("Please enter Student's birth day: ");

                day = Console.Read();

                if (day > 31 || year < 1)
                {
                    Console.WriteLine("Invalid day.");
                }
                else
                {
                    exitStatus = true;
                }
            }

            exitStatus = false;

            dob = new DateTime(year, month, day);

            courses = addStudentToCourses();

            Student student = new Student(name, dob, courses);
            students.Add(student);

        }

        public static void ListStudents()
        {

            foreach (Student student in students)
            {
                Console.WriteLine("Student ID: " + student.id);
                Console.WriteLine("Student Name: " + student.name);
                Console.WriteLine("Student Courses: ");

                foreach (Course course in student.studentCourses) {
                    Console.WriteLine("\t" + course.name + ", Grade: " + course.grade);
                }

            }

            Console.WriteLine("Press any key to continue.....");
            Console.ReadKey();
        }

        public static void FindStudent() { }

        public static void EditStudent() { }

        public static List<Course> addStudentToCourses()
        {

            bool exitStatus = false;
            List<Course> courseList = courses;
            List<Course> courseOutput = new List<Course>();

            int grade;

            while (!exitStatus)
            {
                bool validInput = false;

                Console.WriteLine("Please add Student to courses: ");

                for (int i = 0; i < courseList.Count; i++)
                {
                    Console.WriteLine(i + "." + " " + courseList[i]);
                }

                int input = Console.Read();

                switch (input)
                {
                    case 1:
                        while (!validInput)
                        {
                            Console.WriteLine("Please enter number grade for course.");

                            grade = Console.Read();

                            if (grade > 100 || grade < 0)
                            {
                                Console.WriteLine("Invalid grade.");
                            }
                            else
                            {
                                courseList[0].grade = grade;
                                validInput = true;
                            }
                        }
                        courses[0].studentTotal++;
                        courseOutput.Add(courseList[0]);
                        break;
                    case 2:
                        while (!validInput)
                        {
                            Console.WriteLine("Please enter number grade for course.");

                            grade = Console.Read();

                            if (grade > 100 || grade < 0)
                            {
                                Console.WriteLine("Invalid grade.");
                            }
                            else
                            {
                                courseList[1].grade = grade;
                                validInput = true;
                            }
                        }

                        courses[1].studentTotal++;
                        courseOutput.Add(courseList[1]);
                        break;
                    case 3:
                        while (!validInput)
                        {
                            Console.WriteLine("Please enter number grade for course.");

                            grade = Console.Read();

                            if (grade > 100 || grade < 0)
                            {
                                Console.WriteLine("Invalid grade.");
                            }
                            else
                            {
                                courseList[2].grade = grade;
                                validInput = true;
                            }
                        }

                        courses[2].studentTotal++;
                        courseOutput.Add(courseList[2]);
                        break;
                    case 4:
                        while (!validInput)
                        {
                            Console.WriteLine("Please enter number grade for course.");

                            grade = Console.Read();

                            if (grade > 100 || grade < 0)
                            {
                                Console.WriteLine("Invalid grade.");
                            }
                            else
                            {
                                courseList[3].grade = grade;
                                validInput = true;
                            }
                        }

                        courses[3].studentTotal++;
                        courseOutput.Add(courseList[3]);
                        break;
                }

                Console.WriteLine("Add another course? [Y/N]");

                string confirm = Console.ReadLine();

                if (confirm.StartsWith("N") || confirm.StartsWith("n"))
                {
                    exitStatus = true;
                }


            }

            return courseOutput;



        }

        public static void CourseTotal() { }

        internal class Student
        {
            public int id
            {
                get { return id; }
                set { id = value; }
            }

            public string name
            {
                get { return name; }
                set { name = value; }
            }

            public DateTime dob
            {
                get { return dob; }
                set { dob = value; }
            }



            public List<Course> studentCourses;

            public Student()
            {
                this.id = ID++;
                this.dob = new DateTime();
                this.name = "";
                this.studentCourses = new List<Course>();

            }

            public Student(string name, DateTime dob, List<Course> courses)
            {

                this.id = ID++;
                this.dob = dob;
                this.name = name;
                this.studentCourses = courses;
            }

            public void addCourse(Course course)
            {
                studentCourses.Add(course);
            }
        }

        internal class Course
        {

            public string name
            {
                get { return name; }
                set { name = value; }
            }

            public int grade
            {
                get { return grade; }
                set { grade = value; }
            }

            public int studentTotal;

            public Course(string name)
            {
                this.name = name;
                this.studentTotal = 0;
            }




        }
    }
}

