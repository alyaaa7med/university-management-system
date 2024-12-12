namespace FacultyManagmentSystem ;
class Program {
    static void Main(string [] args){

        //faculty
        DateTime buildingDate = new DateTime(2000, 5, 15); // May 15, 2000
        Faculty faculty = new Faculty("Engineering",buildingDate ,"Egypt");

        //departments
        DateTime departmentDate1 = new DateTime(2000, 6, 15); 
        DateTime departmentDate2 = new DateTime(2000, 8, 15); 
        DateTime departmentDate3 = new DateTime(2000, 9, 15); 
        Department department1 = new Department("BME",departmentDate1);
        Department department2 = new Department("MTE",departmentDate2);
        Department department3 = new Department("CSED",departmentDate3);

        //courses
        Course course1 = new Course("Data Sturctures");
        Course course2 = new Course("Object Oriented Programming");
        Course course3 = new Course("Discrete Mathematics");
        Course course4 = new Course("DataBase");
        Course course5 = new Course("Operating Systems");
        Course course6 = new Course("Machine Learning");

        //students
        Student student1 = new Student(100,"asmaa","asmaa@gmail.com","yy123");
        Student student2 = new Student(0, "zahra1ll","zahraa@gmail.com","uuu788");
        Student student3 = new Student(300,"nada**","nadahosam@gmail.com","784++");

        //professors
        Professor professor1 = new Professor(3,3,"BME","eman196","eman@gmail.com","22--++");
        Professor professor4 = new Professor(3,3,"BME","hoda196","hoda@gmail.com","2255-++");
        Professor professor7 = new Professor(3,3,"BME","malak","malak@gmail.com","2oo++");

        Professor professor2 = new Professor(2,3,"CSED","ahmed321","ahmed@gmail.com","123++**");
        Professor professor5 = new Professor(2,3,"CSED","rokaia321","rokaia@gmail.com","1pp++**");
        Professor professor8 = new Professor(2,3,"CSED","basma","basma@gmail.com","1uuu**");

        Professor professor3 = new Professor(1,3,"MTE","nayra33","nayra@gmail.com","99--/i");
        Professor professor6 = new Professor(1,3,"MTE","haneen","haneen@gmail.com","98--/i");
        Professor professor9 = new Professor(1,3,"MTE","asmaa","asmaa@gmail.com","9oo/i");

        //managers
        Manager manager1 = new Manager("BME","al22","alya@.8gmail.com","2566"); //wrong email
        Manager manager2 = new Manager(); //default constructor 
        Manager manager3 = new Manager("MTE","alya127","alyaa@gmail.com","12344"); //right all 
        
        //faculty
        faculty.add_department(department1);
        faculty.add_department(department2);
        faculty.add_department(department3);

        //departments
        department1.add_course(course1);
        department1.add_course(course2);
        department1.add_course(course5);
        department1.add_professor(professor1);
        department1.add_professor(professor4);
        department1.add_professor(professor7);

        department2.add_course(course2);
        department2.add_course(course4);
        department2.add_course(course6);
        department2.add_professor(professor2);
        department2.add_professor(professor5);
        department2.add_professor(professor8);

        department3.add_course(course3);
        department3.add_course(course4);
        department3.add_course(course5);
        department3.add_professor(professor3);
        department3.add_professor(professor6);
        department3.add_professor(professor9);

        //courses 
        course1.add_department(department1);
        course1.add_student(student1);
        course1.add_professor(professor1);
        course1.add_professor(professor2);

        course2.add_department(department2);
        course2.add_department(department1);
        course2.add_student(student1);
        course2.add_professor(professor3);
        course2.add_professor(professor4);

        course3.add_department(department3);
        course3.add_student(student2);
        course3.add_professor(professor5);

        course4.add_department(department2);
        course4.add_student(student2);
        course4.add_department(department3);
        course4.add_professor(professor6);

        course5.add_department(department1);
        course5.add_department(department3);
        course5.add_student(student3);
        course5.add_professor(professor7);
        course5.add_professor(professor8);

        course6.add_department(department2);
        course6.add_student(student3);
        course6.add_professor(professor9);
         
        //students
        student1.add_course(course1);
        student1.add_course(course2);

        student2.add_course(course3);
        student2.add_course(course4);
        
        student3.add_course(course5);
        student3.add_course(course6);
        
        //professors
        professor1.add_course(course1);

        professor2.add_course(course1);

        professor3.add_course(course2);

        professor4.add_course(course2);

        professor5.add_course(course3);

        professor6.add_course(course4);

        professor7.add_course(course5);

        professor8.add_course(course5);

        professor9.add_course(course6);

        //managers
        manager3.add_course(course1);   
        manager3.add_course(course2);   
        manager3.add_course(course3);
        manager3.add_professor(professor1);
        manager3.add_professor(professor2);
        manager3.add_student(student1);
        manager3.add_student(student2);
        
        
        // shallow cloning ..... 
        department1.Clone();
        department2.Clone();
        department3.Clone();
        course1.Clone();
        course2.Clone();
        course3.Clone();
        course4.Clone();
        course5.Clone();
        course6.Clone();
        student1.Clone();
        student2.Clone();
        student3.Clone();
        professor1.Clone();
        professor2.Clone();
        professor3.Clone();
        professor4.Clone();
        professor5.Clone();
        professor6.Clone();
        professor7.Clone();
        professor8.Clone();
        professor9.Clone();
        manager1.Clone();
        manager2.Clone();
        manager3.Clone();


        //  (instanceof : is)
        User user1 = new Professor();
        User user2 = new Manager();
        User.GenericFunction(user1);
        User.GenericFunction(user2);
        


        //passing object to method 
        Console.WriteLine(course1.get_course_name());
        Course course = new Course();
        course.set_name(course1.get_course_name()); //new string using a reference of course1 
        Console.WriteLine(Object.ReferenceEquals(course.get_course_name() , course1.get_course_name()));
        course.set_name("Computer Architecture");  //new string
        Console.WriteLine(Object.ReferenceEquals(course.get_course_name() , course1.get_course_name()));

        //print the faculty 
        faculty.display();
        
        //get all professors 
        foreach (Professor prof  in department1.get_professors()){
            Console.WriteLine(prof.get_user_name());
        }

        //polymorphism + dynamic binding 
        Console.WriteLine(manager3.login("zyx","zieow")); //invalid login 
        Console.WriteLine(manager3.login("alya127","12344")); //valid login 
        Console.WriteLine(professor1.login("eman196","22--++"));
        Console.WriteLine(student2.login("zahra1l","uuu788"));

        //access public getter 
        Console.WriteLine("professor salary : "+professor1.get_salary()); 

        //promotion 
        DateTime pro_date1 = new DateTime(2015, 6, 15); 
        DateTime pro_date2 = new DateTime(2050, 6, 15); 
        Console.WriteLine(manager2.promotion(pro_date1));
        Console.WriteLine(manager3.promotion(pro_date2));

    }
}
