



// Const-Inheritance-Hometask



//3) Employee adinda class yaradin, Class -in id, name, surname, address, email, age fieldleri olacaq. Proqram.cs - de ashagidaki methodlari      yazin. 
//    1)  Yashi methoda parametr kimi gelen yashdan boyuk olan 
//employee -lerin  siyahisini qaytaran method.
//    2)  Yashi 20 - ve 30 arasinda olan telebelerin sayini qaytaran method.
//    3)  Butun Emloyeelerin yashlarinin cemini qaytaran method.
//    4)  Emaili methoda parametr kimi gelen stringle bashlayan employee-lerin siyahisini qaytaran method.





using Csharp_Constr_Inheri_Hometask;
using System;
using System.Collections.Immutable;
using System.Net;
using System.Xml.Linq;

Employee[] GetAllPerson()
{
    Employee employer1 = new()
    {
        id = 1,
        name = "Person1",
        surName = "Personn1",
        address = "Baku",
        email = "akslalsahlj2kl@lk",
        age = 21
    };


    Employee employer2 = new()
    {
        id = 2,
        name = "Person2",
        surName = "Personn2",
        address = "Baku",
        email = "sahlj2kl@lk",
        age = 22
    };

    Employee employer3 = new()
    {
        id = 3,
        name = "Person3",
        surName = "Personn3",
        address = "Baku",
        email = "aks@lk",
        age = 32
    };

    Employee employer4 = new()
    {
        id = 4,
        name = "Person4",
        surName = "Personn4",
        address = "Baku",
        email = "aks@lkohohfo",
        age = 35
    };

    Employee[] employees = { employer1, employer2, employer3, employer4 };
    return employees;
}





//3.1)  Yashi methoda parametr kimi gelen yashdan boyuk olan employee -lerin  siyahisini qaytaran method.



void GetByAge(Employee[] employees, int age)
{
    foreach (var item in employees)
    {
        if ( item.age > age)
        {
            string response = $"Id: {item.id}; name: {item.name}; Surname:{item.surName}; " +
                $"Address: {item.address}; Email: {item.email} Age: {item.age}";
            Console.WriteLine(response);
        }
    }
}
//GetByAge(GetAllPerson(), 30);






//3.2)  Yashi 20 - ve 30 arasinda olan telebelerin sayini qaytaran method.



void CountOfEmployees(Employee[] employees)
{
    int count = 0;

    foreach ( var item in employees)
    {
        if ( item.age > 20 && item.age< 30)
        {
            count++;
        }
    }
    Console.WriteLine(count);
}

//CountOfEmployees(GetAllPerson());



// 3.3)  Butun Emloyeelerin yashlarinin cemini qaytaran method.


void SumOfAge(Employee[] employees)
{
    int sum = 0;

    foreach ( var item in employees)
    {
        sum += item.age;
    }

    Console.WriteLine(sum);
}



//SumOfAge(GetAllPerson());






// 3.4)  Emaili methoda parametr kimi gelen stringle bashlayan employee-lerin siyahisini qaytaran method.



void GetByEmail(Employee[] employees, string text)
{
    

    foreach (var item in employees)
    {
        if (item.email.ToLower().Trim() == text.ToLower().Trim())
        {
            string response = $"Id: {item.id}; name: {item.name}; Surname:{item.surName}; Address: {item.address}; Email: {item.email} Age: {item.age}";
            Console.WriteLine(response);

        }

             //else
             //{
             //    Console.WriteLine("Buna uygun email yoxdur");
             //    break;
             //}
    }
}

//GetByEmail(GetAllPerson(), "sahlj2kl@lk");






////////////////////////////////////////////////////////////////////////////






////2) CustomMath adinda class yaradin, hemin clasin icinde ashagidaki methodlar olacaq. Hemin methodlari proqram classda cagirib ishledin. 
//1)Method array qebul edir, arrayin icerisindeki tek ededlerin cemini tapin.
//     2)Methoda gelen ededin tek ve ya cut olub olmamasini gosterin.
//     3) Methoda gelen arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.
//     4) Methoda n ededi gelir, 1-den n ededine qeder olan ededlerin hasilini tapin.



//2.1/ Method array qebul edir, arrayin icerisindeki tek ededlerin cemini tapin.

CustomMath task1 = new();

int[] nums = { 1, 2, 3, 4, 5 };


int result = task1.SumOfOddInArray(nums);

//Console.WriteLine(result);




//2.2)Methoda gelen ededin tek ve ya cut olub olmamasini gosterin.

CustomMath task2 = new();

int m = 8;

string result2 = task2.OddOrEvenNum(m);

//Console.WriteLine(result2);





// 2.3) Methoda gelen arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.


CustomMath task3 = new();

int[] arr = { 1, 2, 3, 4, 5 };

int result3 = task3.SumOfEvenNums(arr);

//Console.WriteLine(result3);






// 4) Methoda n ededi gelir, 1-den n ededine qeder olan ededlerin hasilini tapin.

CustomMath task4 = new();

int n = 4;

int result4 = task4.MultiOfNums(n);

//Console.WriteLine(result4);







