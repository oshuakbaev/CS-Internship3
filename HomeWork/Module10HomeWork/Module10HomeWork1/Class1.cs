using System;
using Module10HomeWork1;

class Program
{
    static void Main()
    {
        // Создание объектов студентов
        Student student1 = new Student("Alice", "Kanatova", 20, 1);
        Student student2 = new Student("Bob", "Marly", 21, 2);
        Student student3 = new Student("Charlie", "Chaplin", 22,3);

// Создание объекта учителя и добавление студентов
Teacher teacher = new Teacher("Dr. Gertz", "Doe", 45);
teacher.AddStudent(student1);
teacher.AddStudent(student2);
teacher.AddStudent(student3);

// Создание массива объектов Person
Person[] persons = new Person[] { student1, student2, student3, teacher };

// Вывод информации о всех персонах
foreach (var person in persons)
{
    person.Print();
    Console.WriteLine(); // Для лучшей читаемости вывода
}

// Определение типов и подсчет
int studentsCount = 0, teachersCount = 0;
foreach (var person in persons)
{
    if (person is Student)
    {
        studentsCount++;
        // Перевод студента на следующий курс
        ((Student)person).Year += 1;
    }
    else if (person is Teacher)
    {
        teachersCount++;
    }
}

Console.WriteLine($"Total Students: {studentsCount}, Total Teachers: {teachersCount}");

// Вывод информации после перевода студентов на следующий курс
Console.WriteLine("\nAfter advancing the year for each student:");
foreach (var person in persons)
{
    person.Print();
    Console.WriteLine(); // Для лучшей читаемости вывода
}
    }
}
