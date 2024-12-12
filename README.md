# University Management System
It is a simple project created to include most of what i have learned about ```Object Oriented Programming ```  using ```C#``` as the programming language.

# UML Diagram    
<img src="_oop_.drawio .png">

# OOP Concepts Included 

|Concept               |  Application                                                      |
|:---------------------|:-----------------------------------------------------------------:|
|**Class and Object**  |The `User` class represents a user with attributes like `user_name`, `email` and methods like `get_email()`|
|**Constructor**       |The `Student` Class includes a special overloaded method for creating and initializing objects. `Student` class with constructors like `Student()` and `Student(grade,...)`|
|**Static**            |`Professor` class has static consts shared by all objects like `experience_bonus` , `User` class has an independent shared method : `is_valid_email(email)`|
|**Modifiers**         |`Student` class is an `internal` class with `Private` attributes and `Public` methods , and `User` class has `Protected` constructors| 
|**Encapsulation**|`User` class has private field `email` can only be accessed by a public method `set_email()` with a condition before assignment |
|**Abstraction**       |The `User` abstract class defines common attributes and functions (abstract and not abstract) for other classes `Professor`,`Student`, `Manager`,forcing subclasses to implement abstract methods `login(user_name,password)`|
|**Inheritance**       |The `Professor` classes inherit from the `User` class, reusing common functionality like `get_email()` while adding specialized attributes like `salary` and behaviors like `get_experience_years()` |
|**Polymorphism**      |A variable of a supertype can refer to a subtype object. we create `Professor` object and assign its reference to a `User` variable (check the main method )|
|**Association**       |General relationship: `student take course` is represented by `addcourse(course)` function in `Student` and `addstudent(student)` in `Course` class |
|**Composition**       |Whole-part strong ownership relationship: `Faculty consists of at most 5 Departments` is represented by `add_department(department)` function in `Faculty` class| 
|**this**              |The this reference refers to class’s `hidden data fields` in the `constructors` and refers to the object itself so we can use parent `methods` in the child class| 
|**Dynamic Binding**   |A method implemented in several classes along the inheritance chain C# decides which method is invoked at runtime: `login(user_name,password)` in `User` and all his children classes `Professor` , `Manager` , `Student` |
|**Generic Function**  |`GenericFunction(user)` method in `User` class defines a variable with a supertype, which can accept an object of any subtype , we make `explicit casting` for the object by the help of `is` operator |
|**Interface**         |`IDisplayable` interface represents a common behavior (Displaying) for related or unrelated classes , `Faculty` class implements it |
|**ICloneable**        |Every class implements the IClonable interface implements `Clone` method , for `shallow and deep copy` |

```
There were examples from the whole project.
```
# Recommendation 
I highly recommend the reference  
**INTRODUCTION TO JAVA PROGRAMMING** ,
chapters: **9,10,11,12,13** for learning **OOP**. They are very helpful.


# Installation and Run

1- clone the repo :  
```
git clone https://github.com/alyaaa7med/university-management-system.git
```

2- change your directory to the repo : 
```
cd university-management-system
```
3- run the project :
```
dotnet run
```

# Contribution 
Any contributions will be greatly appreciated.

1. Fork the Project
2. Create and Switch to your Feature Branch: 
   ```git checkout -b NewFeature```
3. Stage your Changes ```git add -A ```
4. Commit your Changes: ```git commit -m "add some new features"```
5. Push to the Branch: ``` git push origin NewFeature```
6. Open a Pull Request


