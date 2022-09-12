# w37 Ex II Inheritance Part 5-Ole

I have solved Part 5, which includes Parts 1-4.

<h2>Exercise-II Part-1: Person </h2>
Create a class Person. The class must work as follows: 

<pre>Person ada = new Person("Ada Lovelace", "24 Maddox St. London W1S 2QN"); 
Person esko = new Person("Esko Ukkonen", "Mannerheimintie 15 00100 Helsinki"); 
Console.WriteLine(ada); 
Console.WriteLine(esko); </pre>

Sample output 
<pre>Ada Lovelace 
  24 Maddox St. London W1S 2QN 
Esko Ukkonen 
  Mannerheimintie 15 00100 Helsinki </pre>

<h2>Part-2: Student </h2>
Create a class Student, which inherits the class Person. 
At creation, a student has 0 study credits. Every time a student studies, the amount of study credits goes up. 
The class must act as follows: 

<pre>Student ollie = new Student("Ollie", "6381 Hollywood Blvd. Los Angeles 90028"); 
Console.WriteLine(ollie); 
Console.WriteLine("Study credits " + ollie.credits()); 
ollie.study(); 
Console.WriteLine("Study credits "+ ollie.credits()); </pre>

Sample output 
<pre>Ollie 
  6381 Hollywood Blvd. Los Angeles 90028 
Study credits 0 
Study credits 1</pre>

<h2>Part-3: Student's toString (or show, or print method) </h2>
In the previous task, Studentinherits the show method (before we toString method) from the class Person. 
However, you can also overwrite an inherited method, replacing it with your own version. 
Write a version of show (toString) method specifically for the Student class.
The method must act as follows: 

<pre>Student ollie = new Student("Ollie", "6381 Hollywood Blvd. Los Angeles 90028"); 
Console.WriteLine(ollie); 
ollie.study(); 
Console.WriteLine(ollie); </pre>

Sample output 
<pre>Ollie 
  6381 Hollywood Blvd. Los Angeles 90028 
  Study credits 0 
Ollie 
  6381 Hollywood Blvd. Los Angeles 90028 
  Study credits 1</pre>

<h2>Part-4: Teacher </h2>
Create a class Teacher, which inherits the class Person. 
The class must act as follows: 

<pre>Teacher ada = new Teacher("Ada Lovelace", "24 Maddox St. London W1S 2QN", 1200); 
Teacher esko = new Teacher("Esko Ukkonen", "Mannerheimintie 15 00100 Helsinki", 5400); 
Console.WriteLine(ada); 
Console.WriteLine(esko); 
Student ollie = new Student("Ollie", "6381 Hollywood Blvd. Los Angeles 90028"); 
int i = 0; 
while (i < 25) 
{ 
  ollie.study(); 
  i = i + 1; 
} 
Console.WriteLine(ollie); </pre>

Sample output 
<pre>Ada Lovelace 
  24 Maddox St. London W1S 2QN 
  salary 1200 euro/month 
Esko Ukkonen 
  Mannerheimintie 15 00100 Helsinki 
  salary 5400 euro/month 
Ollie 
  6381 Hollywood Blvd. Los Angeles 90028 
  Study credits 25</pre>

<h2>Part-5: List all Persons </h2>
Write a method public static void printPersons(List<Person> persons) in the Main method. 
The method prints all the persons on the list given as the parameter. 
Method must act as follows when invoked from the main method: 

<pre>static void Main(String[] args) 
{ 
  List<Person> persons = new List<Person>(); 
  persons.add(new Teacher("Ada Lovelace", "24 Maddox St. London W1S 2QN", 1200)); 
  persons.add(new Student("Ollie", "6381 Hollywood Blvd. Los Angeles 90028")); 
  printPersons(persons); 
} </pre>

Sample output 
<pre>Ada Lovelace 
  24 Maddox St. London W1S 2QN 
  salary 1200 euro/month 
Ollie 
  6381 Hollywood Blvd. Los Angeles 90028 
  Study credits 0</pre>
