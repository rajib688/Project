
using AttendanceSystem;


TrainingDbContext trainingDbContext = new TrainingDbContext();

Console.WriteLine("\n");
Console.WriteLine("         ==================== ATTENDANCE SYSTEM ====================");
while (true)
{
    string Username, Password;
    Console.Write("         Username : ");
    Username = Console.ReadLine().Trim();
    Console.Write("         Password : ");
    Password = Console.ReadLine().Trim();

    while (true)
    {
        if (Username == "rajib12" && Password == "1234")
        {
            Console.WriteLine("         ***********************************************************");
            Console.WriteLine("                      1. Admin        ");
            Console.WriteLine("                      2. Teacher      ");
            Console.WriteLine("                      3. Student      ");
            Console.WriteLine();
            Console.WriteLine("         ***********************************************************");
            Console.WriteLine();
            Console.Write("         Enter your Option : ");
            int user = int.Parse(Console.ReadLine().Trim());
            if (user == 1)
            {
                string Adminuser, Adminpassword;
                Console.WriteLine();
                Console.Write("         Admin Username : ");
                Adminuser = Console.ReadLine().Trim();
                Console.Write("         Admin Password : ");
                Adminpassword = Console.ReadLine().Trim();
                if (Adminuser == "admin" && Adminpassword == "123")
                {
                    Console.WriteLine("         ***********************************************************");
                    Console.WriteLine("         ====================Admin can login and Create=============");
                    while (true)
                    {
                        Console.WriteLine();
                        Console.WriteLine("         ***********************************************************");
                        Console.WriteLine("                      1. Teacher");
                        Console.WriteLine("                      2. Course");
                        Console.WriteLine("                      3. Student");
                        Console.WriteLine("                      4. Assign to Teacher Course");
                        Console.WriteLine("                      5. Assign to Student Course");
                        Console.WriteLine("                      6. Back to Main Menu");
                        Console.WriteLine("         ***********************************************************");
                        Console.WriteLine();
                        Console.Write("         Enter your Interesting number : ");
                        int adminuser = int.Parse(Console.ReadLine().Trim());
                        if (adminuser == 1)
                        {
                            Console.WriteLine("         ***********************************************************");
                            Teacher teacher = new Teacher();
                            Console.Write("         Teacher Name : ");
                            teacher.Name = Console.ReadLine().Trim();
                            Console.Write("         Teacher Username : ");
                            teacher.Username = Console.ReadLine().Trim();
                            Console.Write("         Teacher Password : ");
                            teacher.Password = Console.ReadLine().Trim();
                            trainingDbContext.Teachers.Add(teacher);
                            trainingDbContext.SaveChanges();
                            Console.WriteLine("                             Added Successfully.");
                            Console.WriteLine("         ***********************************************************");
                            Console.WriteLine("                             Do you want to contiune (1/0) ");
                            Console.Write("         Enter your Interesting number : ");
                            int chk = int.Parse(Console.ReadLine());
                            if (chk==1)
                            {
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else if (adminuser == 2)
                        {
                            Console.WriteLine("         ***********************************************************");
                            Course course = new Course();
                            Console.Write("         Course Name : ");
                            course.CourseName = Console.ReadLine().Trim();
                            Console.Write("         Course Fee : ");
                            course.fees = double.Parse(Console.ReadLine().Trim());
                            Console.Write("         Starting Date : ");
                            course.StartingTime = DateTime.Parse(Console.ReadLine().Trim());
                            Console.Write("         Ending Date : ");
                            course.EndingTime = DateTime.Parse(Console.ReadLine().Trim());
                            trainingDbContext.courses.Add(course);
                            trainingDbContext.SaveChanges();
                            Console.WriteLine("                             Added Successfully.");
                            Console.WriteLine("         ***********************************************************");
                            Console.WriteLine("                             Do you want to contiune (1/0) ");
                            Console.Write("         Enter your Interesting number : ");
                            int chk = int.Parse(Console.ReadLine());
                            if (chk == 1)
                            {
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else if (adminuser == 3)
                        {
                            Console.WriteLine("         ***********************************************************");
                            Student student = new Student();
                            Console.Write("         Student Name : ");
                            student.Name = Console.ReadLine().Trim();
                            Console.Write("         Student Username : ");
                            student.Username = Console.ReadLine().Trim();
                            Console.Write("         Student Password : ");
                            student.Password = Console.ReadLine().Trim();
                            trainingDbContext.Students.Add(student);
                            trainingDbContext.SaveChanges();
                            Console.WriteLine("                             Added Successfully.");
                            Console.WriteLine("         ***********************************************************");
                            Console.WriteLine("                             Do you want to contiune (1/0) ");
                            Console.Write("         Enter your Interesting number : ");
                            int chk = int.Parse(Console.ReadLine());
                            if (chk == 1)
                            {
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else if (adminuser == 4)
                        {
                            Course course = new Course();
                            Console.WriteLine("         ***********************************************************");
                            var CourseList = trainingDbContext.courses.ToList();
                            var TeacherList = trainingDbContext.Teachers.ToList();
                            foreach (var item in CourseList)
                            {
                                Console.WriteLine($"ID : {item.ID}, CourseName : {item.CourseName}, Fee : {item.fees}, StartingDate: {item.StartingTime.ToString("dd-MMM-yyyy")}, EndingDate : {item.EndingTime.ToString("dd-MMM-yyyy")}");                               
                            }
                            Console.WriteLine("         ***********************************************************");
                            Console.WriteLine();
                            Console.Write("         Enter your course assign number : ");
                            int CourId = int.Parse(Console.ReadLine().Trim());
                            foreach (var Iitem in CourseList)
                            {
                                if (CourId == Iitem.ID)
                                {
                                    Console.WriteLine("         ***********************************************************");                                  
                                    foreach (var Titem in TeacherList)
                                    {
                                        Console.WriteLine("{0} {1}", Titem.ID, Titem.Name);
                                    }
                                }
                            }
                            Console.WriteLine();
                            Console.Write("         Enter your Teacher assign number : ");
                            int TeaId = int.Parse(Console.ReadLine().Trim());
                            foreach (var teaitem in TeacherList)
                            {
                                if (TeaId == teaitem.ID)
                                {
                                    Console.Write("         Teacher Assign to create successfully !");
                                }
                            }
                        }

                        else if (adminuser ==6)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("         Incorrect Username or Password. Please try again!!!!");
                    break;
                }
            }
            else if (user == 2)
            {
                string Teacheruser, Teacherpassword;
                Console.WriteLine();
                Console.Write("         Teacher Username : ");
                Teacheruser = Console.ReadLine().Trim();
                Console.Write("         Teacher Password : ");
                Teacherpassword = Console.ReadLine().Trim();
                if (Teacheruser == "teacher" && Teacherpassword == "123")
                {
                    Console.WriteLine("         ***********************************************************");                  
                }

                else
                {
                    break;
                }
            }
            else if (user == 3)
            {
                Console.WriteLine("         ***********************************************************");
                string studentuser, studentpassword;
                Console.Write("         Student Username : ");
                studentuser = Console.ReadLine().Trim();
                Console.Write("         Student Password : ");
                studentpassword = Console.ReadLine().Trim();
                if (studentuser == "student" && studentpassword == "123")
                {
                    Console.WriteLine("         ***********************************************************");
                    Console.WriteLine("         Sucessfully Login : ");
                    Console.WriteLine("         Here student part : ");
                    Console.WriteLine("         ***********************************************************");
                    while (true)
                    {
                        Console.WriteLine("                      1. My Course        ");
                        Console.WriteLine("                      2. Give Attendance        ");
                        Console.WriteLine("                      3. Back to Main Menu       ");
                        Console.WriteLine("         ***********************************************************");
                        Console.Write("         Enter your Interesting number : ");
                        int stdentuser = int.Parse(Console.ReadLine().Trim());
                        if (stdentuser == 1)
                        {
                            var courseList = trainingDbContext.courses.ToList();
                            foreach (var item in courseList)
                            {
                                Console.WriteLine("{0} {1}",item.ID, item.CourseName);
                            }
                        }
                        else if (stdentuser == 2)
                        {
                            Student student = new Student();
                            student.AttendanceSheets = new List<AttendanceSheet>();
                            Console.Write("         Enter your Date : ");
                            student.AttendanceSheets.Add(new AttendanceSheet() { EntryDate = DateTime.Parse(Console.ReadLine().Trim())});
                            trainingDbContext.SaveChanges();
                        }
                        else if (stdentuser == 3)
                        {
                            break;
                        }
                    }                   
                }
            }
            else
            {
                break;
            }
        }     
        else
        {
            Console.WriteLine();
            Console.WriteLine("         Incorrect Username or Password. Please try again!!!!");
            Console.WriteLine();
            Console.WriteLine("         ***********************************************************");
            break;
        }
    }
}
