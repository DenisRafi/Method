/* 
 What Is a "Method"?

A method is a basic part of a program. It can solve a certain problem,
eventually take parameters and return a result.
A method represents all data conversion a program does, to resolve a
particular task.

Methods are declared in a class or struct by specifying:

An optional access level, such as public or private. The default is private.
Optional modifiers such as abstract or sealed.
The return value, or void if the method has none.
The method name.
Any method parameters. 
Method parameters are enclosed in parentheses and are separated by commas. 
Empty parentheses indicate that the method requires no parameters.

Inherited and overridden methods.
The following example defines a Person class,
instantiates two Person objects, and calls the Person.
Equals method to determine whether the two objects are equal. 
The Equals method, however, is not defined in the Person class; 
it is inherited from Object.

-By Denis Rafi
*/
using System;

public class Person
{
    public String FirstName;

    public override bool Equals(object obj)
    {
        var p2 = obj as Person;
        if (p2 == null)
            return false;
        else
            return FirstName.Equals(p2.FirstName);
    }

    public override int GetHashCode()
    {
        return FirstName.GetHashCode();
    }
}
public class Example
{
    public static void Main()
    {
        var p1 = new Person();
        p1.FirstName = "Denis";
        var p2 = new Person();
        p2.FirstName = "Denis";
        Console.WriteLine("p1 = p2: {0}", p1.Equals(p2));
    }
}
