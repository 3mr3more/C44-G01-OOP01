// 1. Class
// 2. Struct
// 3. Interface
// 4. Enum
using Demo;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    static void main()
    {
        // Struct: Value Types: STACK

        // Employee
        // Id, Name, Salary

        // Point

        Point P01;
        // Declare For Object From Type 'Point'
        // P01: Object
        // Allocate UnInitialized 8 Bytes at STACK

        //P01.X = 12;

        //P01.Y = 12;

        //Console.WriteLine(P01.Χ);

        //Console.WriteLine(P01.Υ);

        P01 = new Point(1, 2);

        // new: Used For Select The Constructor

        Console.WriteLine(P01.X);
        Console.WriteLine(P01.Υ);

 //Console.WriteLine(P01); // C_00P01G07.Point
//P01.PrintPoint();

//Console.WriteLine(P01.ToString()); // C_O0P01G07.Point
Console.WriteLine(P01); // C_O0P01G07.Point

        //OOP: Object Oriented Programming
        // Programming Paradigm
        // OOP: The Paradigm Use For Build Any Business

        // Class : Blueprint Of The Object
        // Object: Specific Instance From Class

        // 4 Pillars

        //============================

        // 1. Encapsulation
        // 2. Inheritance
        // 3. Ploymorphism
        // 4. Abstraction

        //1. Encapsulation:
        // Class Or Struct
        // Seperate The Data(Attributes) Definition From Its Use
        // [Setter Getter Method Properties]


        // Employee
        // Id Name salary


        // 1. End User Access data itself
        // 2. No Data Validation
        // 3. No Read Only Filed

        // Apply Encapsulation:
        // 1. Make All Data(Attributes) Private
        // 2. Access Data Through:
        // 2.1. Setter Getter Method
        // 2.2. Properties

        Employee E01 = new Employee(id: 1, name: "Ahmed", salary: -12000);
        Console.WriteLine(E01);
        // Id: Read Only Attributes

        E01.GetId();


        E01.id = 1;
        E01.name = "Ahmed";
        E01.salary = -12000;



       Console.WriteLine(E01.id);
        Console.WriteLine(E01.name);
        Console.WriteLine(E01.salary);

        E01.SetId(1);
        E01.SetName("Ahmed");
        //E01.SetSalary(-12000);

        Console.WriteLine(E01.GetId());
        Console.WriteLine(E01.GetName());
        Console.WriteLine(E01.GetSalary());

        //Console.WriteLine(E01);

        Employee E01 = new Employee();

        E01.Id = 12;
        E01.Name = "Ahmed amin";
        E01.Salary = 12000;
        E01.Address = "Cairo";

        Console.WriteLine(E01.Id);
        Console.WriteLine(E01.Name);
        Console.WriteLine(E01.Salary);
        Console.WriteLine(E01.Address);

        // Indexer: Special Property

        // Phonebook :
        PhoneBook phoneBook = new PhoneBook(size: 3);

        phoneBook.AddPerson(name: "Ahmed", number: 111, Index: 0);
        phoneBook.AddPerson(name: "Ali", number: 222, Index: 1);
        phoneBook.AddPerson(name: "Omar", number: 333, Index: 2);
        Console.WriteLine(phoneBook.GetNumber(name: "Ahmed"));

        Console.WriteLine(phoneBook[name: "Ahmed"]); // long

       phoneBook[name: "Ahmed"] = 999; // long
        Console.WriteLine(phoneBook[name: "Ahmed"]); // long
         Console.WriteLine(phoneBook number: 1111]);

        // Class: Reference Types: HEAP

        // Car: Id Model Speed

        Car C01;

        // Decalre For Refernce (Pointer) From Type 'Car'

        // CB1: Can Refer To Object From Type 'Car' Or Any Class Inhe

        //C01: Refer To Null

        //Console.WriteLine(C81);
        //8 Bytes Will Be Allocated At STACK For The Reference 'C01'

        // Bytes Will Be Allocated At HEAP

        C01 new Car();

        // new
        // 1. Allocate The Number Of Required Bytes At HEAP For The Object
        // 2. Initailized The Allocated Bytes With The Default Value Of The Data of the Datatypes
        //3. Call User Defined Constructor if Exists
        // 4. Assign The Object To The Reference
        //Console.WriteLine(C81.Id);
        //Console.WriteLine(Cel.Model);
        //Console.WriteLine(C01.Speed);
        Console.WriteLine(C01);
        //8 Bytes Will Be Allocated At STACK For The Reference 'C81'
// 0 Bytes Will Be Allocated At HEAP


//C01= new Car(1);
//C01 = new Car(1, 200);

C01 = new Car(id: 1, speed: 200, model: "XYZ");

// new
// 1. Allocate The Number Of Required Bytes At HEAP For The Ot
// 2. Initailized The Allocated Bytes With The Default Value O
// 3. Call User-Defined Constructor if Exists
// 4. Assign The Object To The Reference

//Console.WriteLine(C81.Id);
//Console.WriteLine(C01.Model);
//Console.WriteLine(C01.Speed);


    }
}
