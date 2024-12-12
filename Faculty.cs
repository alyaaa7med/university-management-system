sealed class Faculty : IDisplayable { // can not be inherited 
    string name ;
    DateTime date_of_building;
    string location ;
    List<Department> departments;

    public Faculty(){
        name = "Engineering";
        date_of_building= new DateTime(1995, 1, 1);
        location="Egypt";
        departments = new List<Department>();
    }
    public Faculty(string name , DateTime date_of_building , string location ){
        this.name = name;
        this.date_of_building= date_of_building;
        this.location=location;
        departments = new List<Department>();
        
    }
    public void set_name(string name){
        this.name = name;
    }
    public void set_date_of_building(DateTime date_of_building){
        this.date_of_building=  date_of_building;

    }
    public void set_location(string location){
        this.location = location ; 
    }
    public void add_department(Department department){
        if(departments.Count<5){
            departments.Add(department);
        }
        else {
            Console.WriteLine("only allowed 5 departments at most...");
        }

    }
    public string get_name(){
        return name;
    }
    public string get_location(){
        return location;
    }
    public DateTime get_date_of_building(){
        return date_of_building ; // value type : not reference, Datetime  is a struct 
    }
    
    public List<Department> get_departments(){
        return departments;

    }

    public void display (){
        Console.WriteLine ($"Faculty name :{name}\nDate of building :{date_of_building.ToShortDateString()}");
        foreach (Department d in departments){
            d.display();            
    
        }
    }

}