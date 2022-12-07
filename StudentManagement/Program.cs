using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace StudentManagement
{
    internal class Program
    {

        static int ID = 0; //Used to iterate student ids automatically when new student is initialized
        static List<Course> courses = new List<Course>(); //Preset courses
        static List<Student> students = new List<Student>(); //Keep track of total number of students


        static void Main(string[] args)
        {
            //Initializing course list
            courses.Add(new Course("Math 101"));
            courses.Add(new Course("English 105"));
            courses.Add(new Course("Science 101"));
            courses.Add(new Course("Yoga 101"));

            //Used throughout app to keep user in menus until finished
            bool exitStatus = false;

            Console.WriteLine("<------------Student Management-------------->");
            while (!exitStatus)
            {
                Console.WriteLine("Please select a menu option!!!!");
                Console.WriteLine("\n1. Register Student" + "\n2. List Students" + "\n3. Find Student by id" + "\n4. Edit Student info" + "\n5. Course Student total" + "\n6. Exit");

                int input = int.Parse(Console.ReadLine());

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
        
        //Runs through creating a new Student object step by step, some validation on input where necessary
        public static void RegisterStudent()
        {

            bool exitStatus = false;
            string name, fName = "", mName, lName = "";
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

            //Formats name if no middle name is specified
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

            //Combines input for singular name attribute in Student object
            name = String.Concat(fName, " ", mName, lName);

            while (!exitStatus)
            {
                Console.WriteLine("Please enter Student's birth year: ");

                year = int.Parse(Console.ReadLine());

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

                month = int.Parse(Console.ReadLine());

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

                day = int.Parse(Console.ReadLine());

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

        //List all students in system, along with their courses and associated grades.
        public static void ListStudents()
        {
            if (students.Count != 0)
            {
                foreach (Student student in students)
                {
                    Console.WriteLine("Student ID: " + student.id);
                    Console.WriteLine("Student Name: " + student.name);
                    Console.WriteLine("Student Courses: ");

                    foreach (Course course in student.studentCourses)
                    {
                        Console.WriteLine("\t" + course.name + ", Grade: " + course.grade);
                    }

                }

                Console.WriteLine("Press any key to continue.....");
                Console.ReadKey();
            }

            else {
                Console.WriteLine("No students found in system.");
            }
        }

        //Finds specify student by id, lists all info along with courses/grades.
        public static void FindStudent()
        {

            Student chosenStudent = new Student();

            int id;
            bool found = false;

            Console.WriteLine("Please enter id of Student:");

            id = int.Parse(Console.ReadLine());

            foreach (var student in students)
            {

                if (id == student.id)
                {
                    found = true;
                    Console.WriteLine("Student ID: " + student.id);
                    Console.WriteLine("Student Name: " + student.name);
                    Console.WriteLine("Student Courses: ");

                    foreach (Course course in student.studentCourses)
                    {
                        Console.WriteLine("\t" + course.name + ", Grade: " + course.grade);
                    }

                    Console.WriteLine("Press any key to continue.....");
                    Console.ReadKey();
                    break;

                }

            }

            if (found == false)
            {
                Console.WriteLine("No matching student found. Returning to Main Menu......");
            }

        }

        //Based off RegisterStudent() and FindStudent(), Student is slected by Id value.
        //Before each attribute is collected User is asked if they would like to edit that attribute
        //If User chooses not to, previous value is assigned to new Student object.
        //Once editing is done the new Student object replaces the previous in the static Student list
        public static void EditStudent()
        {
            string confirm;
            int id, studentIndex = 0;
            bool found = false;

            Console.WriteLine("Please enter id of Student:");

            id = int.Parse(Console.ReadLine());

            foreach (var student in students)
            {

                if (id == student.id)
                {
                    found = true;
                    Console.WriteLine("Student ID: " + student.id);
                    Console.WriteLine("Student Name: " + student.name);
                    Console.WriteLine("Student Courses: ");

                    foreach (Course course in student.studentCourses)
                    {
                        Console.WriteLine("\t" + course.name + ", Grade: " + course.grade);
                    }

                    studentIndex = students.IndexOf(student);

                    Console.WriteLine("Press any key to continue.....");
                    Console.ReadKey();
                    break;

                }

            }

            if (found == true)
            {

                bool exitStatus = false;
                string name, fName = "", mName, lName = "", grade;
                DateTime dob;
                int year = 0, month = 0, day = 0;
                List<Course> courses = new List<Course>();


                Console.WriteLine("Edit Student's name? [Y/N]");
                confirm = Console.ReadLine();



                if (confirm.StartsWith("y") || confirm.StartsWith("Y"))
                {
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

                }

                else
                {
                    name = students[studentIndex].name;
                }

                Console.WriteLine("Edit Student's date of birth? [Y/N]");
                confirm = Console.ReadLine();



                if (confirm.StartsWith("y") || confirm.StartsWith("Y"))
                {
                    while (!exitStatus)
                    {
                        Console.WriteLine("Please enter Student's birth year: ");

                        year = int.Parse(Console.ReadLine());

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

                        month = int.Parse(Console.ReadLine());

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

                        day = int.Parse(Console.ReadLine());

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

                }
                else
                {
                    dob = students[studentIndex].dob;
                }

                Console.WriteLine("Edit Student's courses? [Y/N]");
                confirm = Console.ReadLine();



                if (confirm.StartsWith("y") || confirm.StartsWith("Y"))
                {
                    courses = addStudentToCourses();
                }
                else
                {
                    courses = students[studentIndex].studentCourses;
                }


                students[studentIndex] = new Student(name, dob, courses);


            }

            else if (found == false)
            {
                Console.WriteLine("No matching student found. Returning to Main Menu......");
            }


        }

        //Adds course to a List<Course>, when course is added to list a grade attribute is attached as well.
        //List gets returned to be added to Student object
        //Student count attribute is increased for everytime course is added to a list
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
                    Console.WriteLine((i + 1) + "." + " " + courseList[i].name);
                }

                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        while (!validInput)
                        {
                            Console.WriteLine("Please enter number grade for course.");

                            grade = int.Parse(Console.ReadLine());

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

                            grade = int.Parse(Console.ReadLine());

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

                            grade = int.Parse(Console.ReadLine());

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

                            grade = int.Parse(Console.ReadLine());

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

        //Returns student count for chosen course
        public static void CourseTotal()
        {

            bool exitStatus = false;

            while (!exitStatus)
            {

                Console.WriteLine("Please choose course: ");

                for (int i = 0; i < courses.Count; i++)
                {
                    Console.WriteLine((i + 1) + "." + " " + courses[i].name);
                }

                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.WriteLine("Students in {0}: {1}", courses[0].name, courses[0].studentTotal);
                        break;
                    case 2:
                        Console.WriteLine("Students in {0}: {1}", courses[1].name, courses[1].studentTotal);
                        break;
                    case 3:
                        Console.WriteLine("Students in {0}: {1}", courses[2].name, courses[2].studentTotal);
                        break;
                    case 4:
                        Console.WriteLine("Students in {0}: {1}", courses[3].name, courses[3].studentTotal);
                        break;
                }

                Console.WriteLine("Check another course? [Y/N]");

                string confirm = Console.ReadLine();

                if (confirm.StartsWith("N") || confirm.StartsWith("n"))
                {
                    exitStatus = true;
                }

            }
        }

        //Student class - Anytime a Student option is initialized the static ID int is incremented by 1
        internal class Student
        {

            public int id;
            public int Id
            {
                get { return id; }
                set { id = value; }
            }

            public string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public DateTime dob;
            public DateTime DoB
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

        //Course class
        internal class Course
        {
            public string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public int grade;
            public int Grade
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

