using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
*   C# Drill
    demonstrate the difference between
*   overloading methods and overriding methods
*   
*   the constructor method is overloaded
*       Course()
*       Course(string, int)
*       Course(string, string)
*
*   ToString() is overridden
*/

class Course
{
    protected string name;
    public string Name
    {
        get { return name;  }
        set { name = value; }
    }

    protected int durationInHours;
    public int DurationInHours
    {
        get { return durationInHours; }
        set { durationInHours = value; }
    }

    static int courseCount = 0;
    public static int getCourseCount()
    {
        return courseCount;
    }

    public override string ToString()
    {
        return String.Format("Course: {0}   Hours to complete: {1}", name, durationInHours);
    }
    public Course()
    {
        Console.WriteLine("constructor 1 - no params");

        this.name = "No Name";
        this.durationInHours = 0;
        courseCount++;
    }

    public Course(string name, int  hours)
    {
        Console.WriteLine("constructor 2 - string, int");
        this.name = name;
        this.durationInHours = hours;
        courseCount++;
    }

    public Course(string name, string hours)
    {
        Console.WriteLine("constructor 3 - string, string");
        this.name = name;

        int i;
        if (int.TryParse(hours, out i))
            this.durationInHours = i;
        else
            this.durationInHours = 0;

        courseCount++;
    }

}

namespace OverloadingOverridingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create 3 Course objects - each one using a differrent constructor");
            Course c = new Course();
            Console.WriteLine("Course # 1:   {0}", c.ToString());
            c.Name = "Computer Basics";
            c.DurationInHours = 40;
            Console.WriteLine("Course # 1 with data:   {0}", c.ToString());

            Console.ReadKey();

            Course c1 = new Course("HTML", 25);
            Console.WriteLine("Course # 2:   {0}", c1.ToString());
            Console.ReadKey();


            Course c2 = new Course("Javascript Basic", "250");
            Console.WriteLine("Course # 3:   {0}", c.ToString());
            Console.ReadKey();

//           Console.ReadKey();

        }
    }
}
