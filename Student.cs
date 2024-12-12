class Student : User , ICloneable{
    int grade ;
    List<Course> courses ;

    public Student(){
        //defualt User() will be called 
        grade = 0 ;
        courses = new List<Course>();

    }
    // public Student(int grade,string user_name,string email,string password){
    //     this.grade = grade;
    //     set_user_name(user_name);
    //     set_email(email);
    //     set_password(password);
    //     courses = new Course[1];

    // }

    public Student(int grade,string user_name,string email,string password):base(user_name,email,password){
        // explicitly call a parametrized constructor 
        this.grade = grade;
        courses = new List<Course>();


    }

    public void set_grade(int grade){
        this.grade = grade;
    }
    public void add_course(Course course){
        courses.Add(course);
    }

    public int get_grade(){
        return grade;
    }
    public List<Course> get_courses(){
        return courses ; 
    }
    public override string login(string user_name, string password)
     {
        if (this.get_user_name() == user_name && this.get_password()==password){
            return $"welcome student ,{this.get_user_name()}";
        }
        else {
            return "Invalid username or password."; 
        }
    }
    public  void appreciation(){
        Console.WriteLine("welcome student");
    }

    public object Clone(){
        try {
            //perform a shallow copy for fields from student + user not methods 
            Student student = (Student)this.MemberwiseClone();
            //perform a deep copy , can not be done ....
            return student ;
        }
        catch (Exception ex){
            return "error during cloning:" + ex ;
        }
    }

}