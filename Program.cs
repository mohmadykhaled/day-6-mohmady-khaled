 #region Problem 1
using System;

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point()
    {
        X = 0;
        Y = 0;
    }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point();
        Point p2 = new Point(5, 7);

        Console.WriteLine(p1);
        Console.WriteLine(p2);
    }
}
/*
    structs to inherit from other structs or classes would introduce complexity
and overhead that contradicts their purpose
structs cannot inherit from other structs or classes Because
Memory Layout: Structs have a fixed memory layout
and inheritance would complicate this layout making it less efficient*/

 #endregion

#region problem 2
using System;

public class TypeA
{
    private int F;
    internal int G;
    public int H;

    public TypeA(int f, int g, int h)
    {
        F = f;
        G = g;
        H = h;
    }

    public int GetF()
    {
        return F;
    }

    public void SetF(int value)
    {
        F = value;
    }
}

class Program
{
    static void Main(string[] args)
    {
        TypeA obj = new TypeA(1, 2, 3);

        Console.WriteLine("Public H: " + obj.H);

        Console.WriteLine("Internal G: " + obj.G);

        Console.WriteLine("Private F: " + obj.GetF());
        obj.SetF(10);
        Console.WriteLine("Updated Private F: " + obj.GetF());
    }
}
/* determine the scope and visibility of a class member
  * PrivateUse Case: Encapsulation to restrict direct access to sensitive data
   * InternalUse Case: Sharing implementation details within an assembly while hiding them from external assemblies
 */
#endregion

            #region problem 3
using System;

public struct Employee
{

    private int EmpId;
    private string Name;
    private decimal Salary;

    public Employee(int empId, string name, decimal salary)
    {
        EmpId = empId;
        Name = name;
        Salary = salary;
    }

    public string GetName()
    {
        return Name;
    }

    public void SetName(string name)
    {
        Name = name;
    }

    public int EmployeeId
    {
        get { return EmpId; }
    }

    public decimal EmployeeSalary
    {
        get { return Salary; }
        set { Salary = value; }
        class Program
    {
        static void Main(string[] args)
        {

            Employee emp = new Employee(101, "mohmady", 3000.00m);

            Console.WriteLine($"Employee ID: {emp.EmployeeId}");

            Console.WriteLine($"Employee Name: {emp.GetName()}");
            emp.SetName("mohmady khaled");
            Console.WriteLine($"Updated Employee Name: {emp.GetName()}");

            Console.WriteLine($"Employee Salary: {emp.EmployeeSalary}");
            emp.EmployeeSalary = 5000.00m;
            Console.WriteLine($"Updated Employee Salary: {emp.EmployeeSalary}");

        }
    }
    /*
     Encapsulation is essential in software design as it hides an object's internal state and provides a controlled interface for interaction
     This safeguards data integrity by preventing unauthorized access or modification
     */
}
}

            #endregion

#region problem 4
using System;

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x)
    {
        X = x;
        Y = 0;
    }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"Point(X: {X}, Y: {Y})";
    }
}
class Program
{
    static void Main(string[] args)
    {

        Point p1 = new Point(10);
        Console.WriteLine(p1); 

        Point p2 = new Point(15, 25);
        Console.WriteLine(p2); 
    }
}
/* 
  Ensure the struct is in a valid state upon creation.
 Characteristics is Cannot include a parameterless constructor and Must explicitly initialize all fields of the struct
 */
#endregion

#region problem 5
using System;

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x)
    {
        X = x;
        Y = 0;
    }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"Point [X={X}, Y={Y}]";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point(5,10);
        Point p2 = new Point(15, 20);
        Point p3 = new Point(25, 30);

        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(p3);
    }
}
/* returns the fully qualified type name, which is not informative
  During debugging or logging, seeing custom-formatted object data directly can save time and reduce confusion 
ensures uniform formatting for output, making the codebase consistent and predictable.
*/

#endregion

#region problem 6
using System;

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"Point [X={X}, Y={Y}]";
    }
}

public class Employee
{
    public int EmpId { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public Employee(int empId, string name, decimal salary)
    {
        EmpId = empId;
        Name = name;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"Employee [EmpId={EmpId}, Name={Name}, Salary={Salary}]";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point p = new Point(10, 20);
        Employee e = new Employee(10, "mohmady", 30000);

        Console.WriteLine("Before method call:");
        Console.WriteLine(p);
        Console.WriteLine(e);

        ModifyPoint(p);
        ModifyEmployee(e);

        Console.WriteLine("After method call:");
        Console.WriteLine(p);
        Console.WriteLine(e);
    }

    static void ModifyPoint(Point point)
    {
        point.X = 10;
        point.Y = 20;
    }

    static void ModifyEmployee(Employee employee)
    {
        employee.EmpId = 102;
        employee.Name = "Jane Doe";
        employee.Salary = 60000m;
    }
}
/*Memory allocation:
  Structs are value types and are generally allocated on the stack or inline within other structures
   This can lead to better memory usage and performance Classes
  being reference types, are allocated on the heap 
  */
#endregion