// See https://aka.ms/new-console-template for more information

//1.
using static Color;

class program
{
    //static void Main(string[] args)
    //{
    //    int[] numbers = GenerateNumbers(10);
    //    Reverse(numbers);
    //    PrintNumbers(numbers);
    //}

    //static int[] GenerateNumbers(int length)
    //{
    //    int[] number = new int[length];
    //    for (int i = 0; i < length; i++) {
    //        number[i] = i;
    //    }
    //    return number;
    //}

    //static void Reverse(int[] arr) {
    //    int left = 0;
    //    int right = arr.Length - 1;
    //    while (left < right)
    //    {
    //        int temp = arr[left];
    //        arr[left] = arr[right];
    //        arr[right] = temp;
    //        left++;
    //        right--;
    //    }
    //}

    //static void PrintNumbers(int[] numbers)
    //{
    //    Console.WriteLine("Reversed Number");
    //    foreach (int num in numbers) { 
    //    Console.Write(num + " ");
    //    }
    //    Console.WriteLine();
    //}

    //2.
    //static void Main(string[] args)
    //{

    //    Console.WriteLine("input the number of the Fibonacci sequence, you want to get");
    //    string input = Console.ReadLine();
    //    int i = Convert.ToInt32(input);
    //    Console.WriteLine($"Fibonacci({i}) = {Fibonacci(i)}");
    //}

    // Method to calculate the nth Fibonacci number
    //static int Fibonacci(int n)
    //{
    //    if (n <= 0)
    //    {
    //        throw new ArgumentException("Invalid input. n must be a positive integer.");
    //    }
    //    else if (n == 1 || n == 2)
    //    {
    //        return 1;
    //    }
    //    else
    //    {
    //        int a = 1;
    //        int b = 1;
    //        int result = 0;
    //        for (int i = 3; i <= n; i++)
    //        {
    //            result = a + b;
    //            a = b;
    //            b = result;
    //        }
    //        return result;
    //    }
    //}

    //3.
    //// Abstraction: Abstract representation of a shape
    //public abstract class Shape
    //{
    //    public abstract void Draw();
    //}

    //// Encapsulation: Inherits from Shape and encapsulates properties and methods for circles
    //public class Circle : Shape
    //{
    //    private int radius;

    //    public Circle(int radius)
    //    {
    //        this.radius = radius;
    //    }

    //    // Polymorphism: Overrides Draw method to draw a circle
    //    public override void Draw()
    //    {
    //        Console.WriteLine("Drawing a circle with radius " + radius);
    //    }
    //}

    //// Encapsulation: Inherits from Shape and encapsulates properties and methods for rectangles
    //public class Rectangle : Shape
    //{
    //    private int width;
    //    private int height;

    //    public Rectangle(int width, int height)
    //    {
    //        this.width = width;
    //        this.height = height;
    //    }

    //    // Polymorphism: Overrides Draw method to draw a rectangle
    //    public override void Draw()
    //    {
    //        Console.WriteLine("Drawing a rectangle with width " + width + " and height " + height);
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Polymorphism: Create an array of shapes containing circles and rectangles
    //        Shape[] shapes = new Shape[]
    //        {
    //        new Circle(5),
    //        new Rectangle(4, 3),
    //        new Circle(7),
    //        new Rectangle(6, 2)
    //        };

    //        // Polymorphism: Loop through the shapes and draw each one
    //        foreach (Shape shape in shapes)
    //        {
    //            shape.Draw();
    //        }

    //    }
    //}
}

//4.
//public abstract class Student
//{
//    // Properties specific to students
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public int GradeLevel { get; set; }

//    // Abstract method to be implemented by derived classes
//    public abstract void Study();
//}

//// Abstract class representing an instructor
//public abstract class Instructor
//{
//    // Properties specific to instructors
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public string Subject { get; set; }

//    // Abstract method to be implemented by derived classes
//    public abstract void Teach();
//}

//5.
//public class Rectangle : Shape
//{
//    private int width;
//    private int height;

//    public Rectangle(int width, int height)
//    {
//        this.width = width;
//        this.height = height;
//    }

//6.
//public abstract class Person
//{
//    // Properties common to all persons
//    public string Name { get; set; }
//    public int Age { get; set; }

//    // Constructor
//    public Person(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }
//}

//// Derived class representing a student, inheriting from Person
//public class Student : Person
//{
//    // Additional property specific to students
//    public int GradeLevel { get; set; }

//    // Constructor
//    public Student(string name, int age, int gradeLevel) : base(name, age)
//    {
//        GradeLevel = gradeLevel;
//    }

//    // Method specific to students
//    public void Study()
//    {
//        Console.WriteLine($"{Name} is studying...");
//    }
//}

//// Derived class representing an instructor, inheriting from Person
//public class Instructor : Person
//{
//    // Additional property specific to instructors
//    public string Subject { get; set; }

//    // Constructor
//    public Instructor(string name, int age, string subject) : base(name, age)
//    {
//        Subject = subject;
//    }

//    // Method specific to instructors
//    public void Teach()
//    {
//        Console.WriteLine($"{Name} is teaching {Subject}...");
//    }
//}

//7.
//public abstract class Instructor
//{
//    // Properties specific to instructors
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public string Subject { get; set; }

//    // Abstract method to be implemented by derived classes
//    public virtual double calculatesalary() {
//        return 10000;
//    }
//}

//public class parttimeinstructor : Instructor {
//    public int Contracttime { get; set; }

//    public parttimeinstructor(string name, int age, string subject, int contracttime )
//        {
//        Contracttime = contracttime;

//        }
//    public override double calculatesalary()
//    {
//        return Contracttime * 30;
//    }

//}

//8. see reposittory fold

//9.
 public class Color {

    private int red;
    private int green;
    private int blue;
    private int alpha;

    // Constructor that takes red, green, blue, and alpha values
    public Color(int red, int green, int blue, int alpha)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
        this.alpha = alpha;
    }
    public Color(int red, int green, int blue) : this(red, green, blue, 255)
    {
    }

    // Method to get the red value
    public int GetRed()
    {
        return red;
    }

    // Method to set the red value
    public void SetRed(int red)
    {
        this.red = red;
    }

    // Method to get the green value
    public int GetGreen()
    {
        return green;
    }

    // Method to set the green value
    public void SetGreen(int green)
    {
        this.green = green;
    }

    // Method to get the blue value
    public int GetBlue()
    {
        return blue;
    }

    // Method to set the blue value
    public void SetBlue(int blue)
    {
        this.blue = blue;
    }

    // Method to get the alpha value
    public int GetAlpha()
    {
        return alpha;
    }

    // Method to set the alpha value
    public void SetAlpha(int alpha)
    {
        this.alpha = alpha;
    }

    // Method to calculate the grayscale value
    public int GetGrayscale()
    {
        // Calculate the average of red, green, and blue values
        int average = (red + green + blue) / 3;
        return average;
    }

    public class Ball {
        private int size;
        private Color color;
        private int throwtime;

        public Ball(int size, Color color, int throwtime)
        {
            this.size = size;
            this.color = color;
            this.throwtime = throwtime;
        }

        public void pop() {

            size = 0;
        }

        public void Throw (){
            if (size != 0) {
                throwtime++;
            }
}
        public int getthrotime() { 
        
            return throwtime;
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        // Create some Color objects
        Color red = new Color(255, 0, 0);
        Color blue = new Color(0, 0, 255);

        // Create some Ball objects
        Ball ball1 = new Ball(10, red, 0);
        Ball ball2 = new Ball(15, blue, 5);

        // Throw ball1 a few times
        for (int i = 0; i < 3; i++)
        {
            ball1.Throw();
        }

        // Throw ball2 a few times
        for (int i = 0; i < 2; i++)
        {
            ball2.Throw();
        }

        // Pop ball1
        ball1.pop();

        // Try to throw ball1 again (it shouldn't change throw count)
        ball1.Throw();

        // Print the throw count for each ball
        Console.WriteLine("Throw count for ball1: " + ball1.getthrotime()); // Expected: 0 (since ball1 is popped)
        Console.WriteLine("Throw count for ball2: " + ball2.getthrotime()); // Expected: 7 (initial throw count + 2)

        // Attempting to throw ball1 again won't change its throw count
        Console.WriteLine("Attempting to throw ball1 again...");
        ball1.Throw();
        Console.WriteLine("Throw count for ball1: " + ball1.getthrotime()); // Expected: 0
    }
}
