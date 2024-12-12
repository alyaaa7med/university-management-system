class Course : ICloneable{
   string course_name ;
   List<Student> students;
   List<Professor> professors;
   List<Department> departments;

   public Course(){
    course_name="Math1";
    students = new List<Student>();
    professors =new List<Professor>();
    departments = new List<Department>();

   }
   public Course(string course_name){
    this.course_name=course_name;
    students = new List<Student>();
    professors =new List<Professor>();
    departments = new List<Department>();

   }
   public void set_name(string course_name){
    this.course_name = course_name;
   }
   public void add_student(Student student){
    students.Add(student);

   }
   public void add_professor(Professor professor){
    professors.Add(professor); 
   }
   public void add_department(Department department){
    departments.Add(department);

   }
   public List<Student> get_students(){
      return students;
   }
   public List<Professor> get_professors(){
      return professors;
   }
    public List<Department> get_departments(){
       return departments;

   }
   public string get_course_name(){
     return course_name;
   }
    public object Clone(){
        try {
            //perform a shallow copy for fields from manager + user not methods 
            Course course = (Course)this.MemberwiseClone();
            //perform a deep copy  
            //can not be done .......... 
            return course ;
        }
        catch (Exception ex){
            return "error during cloning:" + ex ;
        }
    } 

}