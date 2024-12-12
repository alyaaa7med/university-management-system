using System;
using System.Collections.Generic;

class Manager : User  , ICloneable {
    string department ;
    List<Course> courses;
    List<Professor> professors;
    List<Student> students;


    public Manager() {
        // User() will be called implictly 
        department="system admin";
        courses = new List<Course>();
        professors = new List<Professor>();
        students = new List<Student>();

    }

    //pic only one :--

    // public Manager(string department,string user_name,string email,string password){
    //     // default parent constructor will be called implictly with default values,so we will reassign them
    //     set_user_name(user_name);
    //     set_email(email);
    //     set_password(password);
    //     this.department = department;
    //     courses = new List<Course>();
    //     professors = new List<Professor>();
    //     students = new List<Student>();

    // }
    
    public Manager(string department,string user_name,string email,string password): base(user_name,email,password)
    {    
        //i |must| explicitly call a parametrized constructor  
        this.department = department;
        courses = new List<Course>();
        professors = new List<Professor>();
        students = new List<Student>();
    }
    public void set_department(string department){
        this.department = department;
    }
    public void add_course(Course course){
        courses.Add(course);
      
    }
    public void add_professor(Professor professor){
        professors.Add(professor);
    }
    public void add_student(Student student){
        students.Add(student);

    }
    public string get_department(){
        return department;
    }
    public List<Course> get_courses(){
        return courses;
         
    }
    public List<Professor> get_professors(){
        return professors; 
    }
    public List<Student> get_students(){
        return students;
    }
    public override string login(string user_name , string password){
        if (this.get_user_name() == user_name && this.get_password()==password){
            return $"welcome manager ,{this.get_user_name()}";
        }
        else {
        return "Invalid username or password."; 
        }
    }

    //overloading in parent + child
    public string promotion(DateTime date){
        DateTime? pastdate = this.get_date_of_joining();
        int years = date.Year - (pastdate != null? pastdate.Value.Year : 0);
        if (years >= 2){
            return promotion()+"  ,your salary will be doubled";
        }
        else { 
            return promotion()+"  ,you are still in your place"; 
        }

    }
    public  void appreciation(){
        Console.WriteLine("welcome manager");
    }


    //note : override keyword is not a must here not like java 
    public object Clone(){
        try {
            //perform a shallow copy 
            Manager clonedmanager= (Manager)this.MemberwiseClone();
            //perform a deep copy: will be infinite loop each course refereces to an other reference and we can not stop ...
            
            // List<Course> temp = new List<Course>();
            // foreach (var course in clonedmanager.courses)
            // {
            //     temp.Add((Course)course.Clone()); 
            // } 
            // clonedmanager.courses=temp ;
            
            // clonedmanager.professors=
            // clonedmanager.students=
            return clonedmanager;
        }
        catch (Exception ex){
            return "error during cloning:" + ex ;
        }
    }
}