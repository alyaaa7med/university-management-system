using System ;
class Professor :User , ICloneable {
    const int experience_bonus = 500; //const = static
    const int course_rate = 200;
    double experience_years;
    int teaching_load;
    double salary ; 
    string department ;
    List<Course> courses ;
    public Professor(){
        // default User() will be called 
        experience_years = 0.0;
        teaching_load = 0;
        department = "Prep Year";
        salary = 0.0;
        courses= new List<Course>();
    }
    
    // public Professor(double experience_years,int teaching_load,string department,string user_name,string email,string password){
        
    //     //parent default constructor will be called 
    //     this.experience_years = experience_years;
    //     this.teaching_load = teaching_load;
    //     this.department = department;
    //     salary = get_salary();
    //     //re-assign 
    //     set_user_name(user_name);
    //     set_email(email);
    //     set_password(password);
    //     courses = new Course[1];

    // }
    
    public Professor(double experience_years,int teaching_load,string department,string user_name,string email,string password): base(user_name,email,password)
    {
        // explicitly call a parametrized constructor 
        this.experience_years= experience_years;
        this.teaching_load=teaching_load;
        this.department=department;
        salary = get_salary();
        courses = new List<Course>();

    }

    public void set_experience_years(double experience_years){
        this.experience_years = experience_years;

    }
    public void set_teaching_load(int teaching_load){
        this.teaching_load = teaching_load;

    }
    public void set_department(string department){
        this.department = department;

    }
    public void add_course(Course course){
        courses.Add(course);
        
    }
    public double get_experience_years(){
        return experience_years ;
    }
    public int get_teaching_load(){
        return teaching_load;
    }

    public string get_department(){
        return department;
    }

    public List<Course> get_courses(){
        return  courses ;
    }

    public double get_salary(){

        salary= teaching_load * course_rate + experience_years*experience_bonus;
        return salary ; 

    }

    public override string login(string user_name, string password)
    {
        if (this.get_user_name() == user_name && this.get_password()==password){
            return $"welcome professor ,{this.get_user_name()}";
        }
        else {
            return "Invalid username or password."; 
        }
    }    

    //overloading in the child class ^_^
    public string promotion(DateTime date){
        
        DateTime? pastdate = this.get_date_of_joining();
        int years =date.Year - (pastdate != null? pastdate.Value.Year : 0);        
        if (years >= 2){
            salary*=2;
            return promotion()+"  ,your salary will be doubled";
        }
        else { 
            return promotion()+"  ,you are still in your place"; 
        }

    }
    public  void appreciation(){
        Console.WriteLine("welcome professor");
    }

    public object Clone(){
        try {
            //perform a shallow copy for fields from professor + user not methods 
            Professor professor = (Professor)this.MemberwiseClone();
             
            return professor ;
        }
        catch (Exception ex){
            return "error during cloning:" + ex ;
        }
    }
}
