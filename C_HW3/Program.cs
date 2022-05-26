using C_HW3;
using System.Text;

// Test your knowledge
// 1. Public, Private. Protected, Internal, Protected Internal, Private Protected
// 2. const are implicityly static and we can access them without instantialization but it cannot be easily changed because it is constant. Readonly can only be initialized or changed in the constructor.  
// 3. Constructor is a method whose name is the same as the name of its type. It does not include a return type.
// 4. The partial keyword indicates that other parts of the class, struct, or interface can be defined in the namespace. 
// 5、Tuple is a data structure that contains a sequence of elements of different data types.
// 6. Beginning with C# 9, you use the record keyword to define a reference type that provides built-in functionality for encapsulating data. Records are distinct from classes in that record types use value-based equality.
// 7. Overload means define more than one method with the same name in a class; Override means rewrite the method
// 8. A field is a variable of any type that is declared directly in a class. A property is a member that provides a flexible mechanism to read write or compute the value of a private field
// 9、You set a default value within the method
// 10. Interface is a type similar toa class but it purely represents a contract between an object and its user。It does not have field or solid method, only containing abstract method.
// 11.Public
// 12. True
// 13. True
// 14. False
// 15. False 
// 16. True
// 17. True
// 18. True
// 19. False
// 20. False
// 21. True
// 22. False
// 23. True


//Working with methods
//1.
int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
foreach (int i in ReverseNumbers.Reverse(array))
{
    Console.WriteLine(i);
}

Console.WriteLine("----");

//2.Fibonacci
int a = 1;
int b = 1;
// get the list up to 10th number
for(int i = 2; i < 10; i++)
{
    Console.Write(Fibonacci.GetFibonacci(i));
    Console.Write(",");
}


Console.WriteLine("----");

//7. Balls
Ball ballRed = new Ball(3, new Color(255, 0, 0));
Ball ballGreen = new Ball(6, new Color(0, 255, 0));
Ball ballBlue = new Ball(9, new Color(0, 0, 255));

ballRed.Throwing();
Console.WriteLine($"The red ball is thrown {ballRed.GetThrow()} times.");
;

ballGreen.Throwing();
ballGreen.Throwing();
Console.WriteLine($"The green ball is thrown {ballGreen.GetThrow()} times.");

ballBlue.Throwing();
Console.WriteLine($"The blue ball has been thown {ballBlue.GetThrow()} times.");
ballBlue.Pop();
ballBlue.Throwing();
Console.WriteLine($"The blue ball has been thown {ballBlue.GetThrow()} times.");

//2
/*Bird b = new Bird();
b.Weight = 3;
Console.WriteLine(b.Weight);*/


