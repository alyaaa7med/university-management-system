using System ;
using System.Text.RegularExpressions;

abstract class User {
    string user_name ;
    string email  ;
    string password;
    // primitive : basic types >> int , float , .....
    // value type : any type store data in the stack of the memory ....(may be primitive , nullable.....
    //DateTime : value type           //DateTime? :reference type
    DateTime? date_of_joining;  

    //overloading constructor
    protected User(){
        user_name = "Alyaa Ahmed";
        email = "alyaa@gmail.com";
        password = "**##**";
        date_of_joining = DateTime.Now;
    }
    protected User(string user_name,string email,string password){

        try {
        string validEmail = is_valid_email(email);
        this.user_name = user_name;
        this.email = validEmail;
        this.password = password;
        date_of_joining = DateTime.Now;
        }
        catch (ArgumentException ex){
            Console.WriteLine(ex.Message);
            this.user_name = "";
            this.email = "";
            this.password = "";
            date_of_joining = null;
        }
    } 
    
    // private 
    private static string is_valid_email(string email){

        string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,})+$";
;
        
        Regex regex = new Regex(emailPattern);
        if (regex.IsMatch(email) == true){
            return email;
        } 
        else {
            throw new ArgumentException("Invalid email address format.");  
        }
    }

    // add condition before assigning 
    public void set_user_name(string user_name){ 
        if (user_name.Length > 15) {
            Console.WriteLine("username must be of 14 word at most....");
        }
        else{
            this.user_name=user_name ;
        }
    }
    public void set_email(string email){
        try {
        string validEmail = is_valid_email(email);
        this.email = validEmail;
        }

        catch (ArgumentException ex){
            Console.WriteLine(ex.Message);
        }
    }

    public void set_password(string password){
        this.password = password;
    }

    public string get_user_name(){
        return user_name;
    }
    public string get_email(){
        return email;
    }
    public string get_password(){
        return password;
    }

    public DateTime? get_date_of_joining(){
        return date_of_joining ;
    }

    public abstract string login(string user_name , string password);
  
    //not static +overloading methods in child+ years in the method 
    public string promotion (){ 
        return $"hi {user_name} after this time ...";
    }

    //check instance of + explict casting   
    public static void GenericFunction(User user){
        if (user is Manager){
         ((Manager)user).appreciation();  //user does not have appreciation function so we must cast it 
         }
        else if (user is Professor){
         ((Professor)user).appreciation();
        }
        else if (user is Student){
         ((Student)user).appreciation();  
            }
        else {
        Console.WriteLine("Unknown type.");
        }
    }

}