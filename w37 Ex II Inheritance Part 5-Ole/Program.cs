// Exercise-II Part-5: Person - Create a class Person.
// Create a class Student, which inherits the class Person.
// At creation, a student has 0 study credits.
// Every time a student studies, the amount of study credits goes up.

// In the previous task, Studentinherits the show method
// (before we toString method) from the class Person.
// However, you can also overwrite an inherited method,
// replacing it with your own version. Write a version of
// show (toString) method specifically for the Student class.
//
// Create a class Teacher, which inherits the class Person.
//
// Write a method public static void printPersons(List<Person> persons)
// in the Main method. The method prints all the persons on the list
// given as the parameter.
// Method must act as follows when invoked from the main method:

List<Person> persons = new List<Person>(); 
persons.Add(new Teacher("Ada Lovelace", "24 Maddox St. London W1S 2QN", 1200)); 
persons.Add(new Student("Ollie", "6381 Hollywood Blvd. Los Angeles 90028")); 
printPersons(persons);

static void printPersons(List<Person> persons)
{
    foreach(Person person in persons)
    {
        Console.WriteLine(person);
    }
}

class Person
{
    public Person(string name, string address)
    {
        Name = name;
        Address = address;
    }

    public string Name { get; set; }
    public string Address { get; set; }
    public override string ToString()
    {
        return $"{Name}\n\n\t{Address}\n";
    }
}

class Teacher : Person
{
    public Teacher(string name, string address, int salary) : base(name, address)
    {
        Salary = salary;
    }

    public int Salary { get; init; }
    public override string ToString()
    {
        return $"{Name}\n\n\t{Address}\n\n\tSalary {Salary} euro/month\n";
    }
}

class Student : Person
{
    public Student(string name, string address) : base(name, address)
    {
    }

    public int credits() { return cr; }
    public void study() { cr++; }

    private int cr = 0;
    public override string ToString()
    {
        return $"{Name}\n\n\t{Address}\n\n\tStudy credits {cr}\n";
    }
}

// By Ole Victor