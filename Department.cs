class Department : IDisplayable {
    string name; 
    DateTime date_of_stablished;
    List<Professor> professors;
    List<Course> courses;

    public Department(){
        name= "CSED";
        date_of_stablished = new DateTime(1995, 6, 1);
        professors=new List<Professor>();
        courses = new List<Course>();

    }
    public Department(string name , DateTime date_of_stablished){
        this.name= name;
        this.date_of_stablished = date_of_stablished;
        professors=new List<Professor>();
        courses = new List<Course>();
        
    }


    public void set_name(string name){
        this.name=name;
    }
    public void set_date_of_established(DateTime date_of_stablished){
       this.date_of_stablished = date_of_stablished ;
    }
    public void add_course(Course course){
        courses.Add(course);
    }
    public void add_professor(Professor professor){
        professors.Add(professor);
    }
    public string get_name(){
        return name;
    }
    public DateTime get_date_of_established(){
        return date_of_stablished;
    } 
    public List<Course> get_coures(){
        return courses; 
    }
    public List<Professor> get_professors(){
        return professors; 
    }
    public void display(){
        Console.WriteLine ($"\n   Departement name :{name}\n   Date of stablished :{date_of_stablished.Year}\n"+"\n   Courses:");
        foreach (Course c in courses){
            Console.WriteLine("      course name:"+c.get_course_name()+"\n      Students:  ");
            foreach (Student s in c.get_students()){
                Console.WriteLine("         "+s.get_user_name()+"\n" );
            }
    
        }
        Console.WriteLine("***********************");
    }

    public object Clone(){
        try {
            //perform a shallow copy for fields from manager + user not methods 
            Department department = (Department)this.MemberwiseClone();
            //perform a deep copy 
            ////////////infinity loop 
            return department ;
        }
        catch (Exception ex){
            return "error during cloning:" + ex ;
        }
    } 
   
}