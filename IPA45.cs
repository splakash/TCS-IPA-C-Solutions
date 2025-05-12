using System;

class Employee{
    private String name;
    
    public String Name{
        get{
            return name;
        }
        set{
            name =value;
        }
    }
    private int age;
    
    public int Age{
        get{
            return age;
        }
        set{
            age =value;
        }
    }
    
    
    private double salary;
    
    public double Salary{
        get{
            return salary;
        }
        set{
            salary =value;
        }
    }
    
    public Employee(String name,int age, double salary){
        this.name = name;
        this.age = age;
        this.salary = salary;
    }
}


class Solution{
    public static void Main(String[] args){
        
        
        String a = Console.ReadLine();
        int b = Convert.ToInt32(Console.ReadLine());
        double c =  Convert.ToDouble(Console.ReadLine());
        Employee e1 = new Employee(a,b,c);
        
        double res1 = calculateYearlySalary(e1);
        Console.WriteLine(res1);
        
        double res2 = calculateTax(e1);
        Console.WriteLine(res2);
        
        
    }
    
    public static double calculateYearlySalary(Employee e1){
        return 12*e1.Salary;
    }
    
    public static double calculateTax(Employee e1){
        
        double annualSalary = 12 * e1.Salary;
        
        if(annualSalary<= Convert.ToDouble(50000)){
            return (10*annualSalary)/100;
        }
        else if(annualSalary>Convert.ToDouble(50000) && annualSalary<= Convert.ToDouble(100000)){
            double tax = (10*50000)/100 + (20*(annualSalary-Convert.ToDouble(50000)))/100;
            return tax;
        }
        else{
            return (10*50000)/100 + (20*50000)/100+ (30*(annualSalary-Convert.ToDouble(100000)))/100;
        }
    }
}






