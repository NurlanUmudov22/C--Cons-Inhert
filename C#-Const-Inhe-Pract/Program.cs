

// Hometask-Practise-Constructors-Inheritance-


using Csharp_Methods_Constrs_Inherit;

//Person person = new()
//{
//    id = 1,
//    fullName = "Fatime Qarayeva",
//    age = 22,
//    position = "student"
//};



////////////////


//Person person = new(1, "Hacixan Hacixanov", 19, "student");

//Console.WriteLine(person.fullName);



////////////////



//Person person = new Person("Azerbaycan","Turkiye");





//////////////////////
///





//Person person1 = new ()
//{
//    id = 1,
//    fullName = "Ilqar Shiriyev",
//    age = 26
//};

//Person person2 = new()
//{
//    id = 2,
//    fullName = "Reshad Aghayev",
//    age = 21
//};

//Person person3 = new()
//{
//    id = 3,
//    fullName = "Nurlan Umudov",
//    age = 22
//};

//Person person4 = new()
//{
//    id = 4,
//    fullName = "Elmir Qafarzade",
//    age = 21
//};



//Person[] people = { person1, person2, person3, person4 };

//Person FindPersonById(Person[] people, int id)
//{
//    Person person = people.FirstOrDefault(m => m.id == id);

//    return person;
//}



//Person result = FindPersonById(people, 3);
//string response = $"id: {result.id}, fullName: {result.fullName}, age: {result.age}";
//Console.WriteLine(response);





///////////////



//Person[] people = { person1, person2, person3, person4 }; 

//Person FindPersonById(Person[] people, int id)
//{
//    return people.FirstOrDefault(m => m.id == id);

//}

//Person result = FindPersonById(people, 1);


//if (result != null)
//{
//    string response = $"id: {result.id}, fullName: {result.fullName}, age: {result.age}";

//    Console.WriteLine(response);
//}
//else
//{
//    Console.WriteLine("Data notfound");
//}




///////////
///



//var result1 = result != null ? $"id: {result.id}, fullName: {result.fullName}, age: {result.age}" : "not found";
//Console.WriteLine(result1);



///////////////////////



//Person[] people = { person1, person2, person3, person4 };

//Person FindPersonById(Person[] people, int id)
//{
//    return people.FirstOrDefault(m => m.id == id);

//}

//Person result = FindPersonById(people, 1);




//Person[] GetAllPerson(Person[] datas)
//{
//    return datas;
//}



//var allPeople = GetAllPerson(people);





//void ShowPersonId(Person person)
//{
//    if (person != null)
//    {
//        string response = $"Id: {person.id}; Fullname: {person.fullName}; Age:{person.age}";
//        Console.WriteLine(response);
//    }
//    else
//    {
//        Console.WriteLine("Data not found");
//    } 

//}






///////////////////////////////////////////////////////////////////
///



Person[] GetAllPerson()
{


    Person person1 = new()
    {
        id = 1,
        fullName = "Ilqar Shiriyev",
        age = 26
    };

    Person person2 = new()
    {
        id = 2,
        fullName = "Reshad Aghayev",
        age = 21
    };

    Person person3 = new()
    {
        id = 3,
        fullName = "Nurlan Umudov",
        age = 22
    };

    Person person4 = new()
    {
        id = 4,
        fullName = "Elmir Qafarzade",
        age = 21
    };

    Person[] people = { person1, person2, person3, person4 };
    return people;
}

void ShowAllPeople(Person[] datas)
{
    foreach (var item in datas)
    {
        string response = $"Id: {item.id}; Fullname: {item.fullName}; Age: {item.age}";
        Console.WriteLine(response);
    }
}

//    ShowAllPeople(GetAllPerson());






Person FindPersonById(Person[] people, int id)
{
    return people.FirstOrDefault(m => m.id == id);

}

void ShowPerson(Person person)
{
    if (person != null)
    {
        string response = $"Id: {person.id}; Fullname: {person.fullName}; Age:{person.age}";
        Console.WriteLine(response);
    }
    else
    {
        Console.WriteLine("Data not found");
    }
}


//    ShowPerson(FindPersonById(GetAllPerson(), 2));




/////////////////////////////////////






// Inheritance 



//Animal animal = new();

//animal.id = 5;
//animal.name = "test";
////Console.WriteLine(animal.name);
////Console.WriteLine(animal.id);




//Bird bird = new()
//{
//    id = 1,
//    name = "Qaranqush"
//};

//Console.WriteLine( bird.name);



//bird.Sound();


//bird.Sound();






//Fish fish = new();




