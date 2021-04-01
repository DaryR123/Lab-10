using System;

class Employee {

  private string firstname;
  private string lastname;
  private string id;
  private string address;
  private string phonenumber;
  private string title;
  private string employmentstatus;
  private int age;
  private double yearlysalary;

  public string FirstName {get; set;}
  public string LastName {get; set;}

  public string Id{
    get{return id;}
    set{
        if (value.Length == 0)
        {
          id = value;
        }
      else{
          Console.WriteLine("Rejected id");
        }
    }
  public string EmploymentStatus{
    get{return employmentstatus;}
    set{
        if (value.Length == 0){
 employmentstatus = value;
        }
         
      
      else{
          Console.WriteLine("Rejected employmentstatus");
        }
    }
  

public int Age{
    get{return age;}
    set{
        if (value >18){
          age = value;
      }
      else{
        Console.WriteLine("Rejected age.");
      }
    }
  }

public double Yearlysalary{
    get{return yearlysalary;}
    set{
        if (value>1000) {
          yearlysalary = value;
      }
       else{
        Console.WriteLine("Rejected yearlysalary.");
      }
    }
  }


  public Employee()
  {    
    FirstName="Unknown";
    LastName="Unknown";
    Age= 0;

  }

  public Employee(string idNbr, string fname, string lname, int age, double yearlysalary)
  {
    
    Id = idNbr;
    FirstName = fname;
    LastName = lname;
    Age = 25;
    Yearlysalary = 0.0;
  }

    public void Intro()
    {
      Console.WriteLine("My name is " + FirstName + LastName) ;
      Console.WriteLine("My id is " + Id);
      Console.WriteLine("My age is " + Age);

    }

public Employee(string firstname, string lastname , string id, int age)
{
  firstname = "John";
  lastname = "Smith";
  id = "S0089";
  age = 38;
  employmentstatus = "active";
  
}

public void Display(){

  Console.WriteLine("First = " + firstname);
  Console.WriteLine("Last  = " + lastname);
  Console.WriteLine("Id = " + id);
  Console.WriteLine("Age = " + age);
  }

  } 