using ReaderNamespace;
using StudentNamespace;

namespace StudentNamespace
{
    class Student
    {
        public string FullName { get; set; }
        public string GroupNumber { get; set; }
        private int age { get; set; }

        public Student(string fullName, string groupNumber, int age)
        {
            FullName = fullName;
            GroupNumber = groupNumber;
            this.age = age;
        }

        //метод выводящий информацию о студенте
        public void PrintStudentInfo()
        {
            Console.WriteLine($"Студент: {FullName}, группа {GroupNumber}, возраст {age}");
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
namespace ReaderNamespace
{
    class Reader
    {
        private string fullName;
        public string TicketNumber { get; set; }
        public string Faculty { get; set; }
        private DateTime birthDate;
        public string PhoneNumber { get; set; }

        public Reader(string fullName, string ticketNumber, string faculty, DateTime birthDate, string phoneNumber)
        {
            this.fullName = fullName;
            TicketNumber = ticketNumber;
            Faculty = faculty;
            this.birthDate = birthDate;
            PhoneNumber = phoneNumber;
        }

        // метод принимает кол-во взятых книг одним значением
        public void TakeBook(int count)
        {
            Console.WriteLine($"{fullName} взял {count} книги.");
            Console.WriteLine("-----------------------------------------------");
        }

        // метод принимает несколько названий книг
        public void TakeBook(params string[] bookTitles)
        {
            Console.WriteLine($"{fullName} взял книги: {string.Join(", ", bookTitles)}");
            Console.WriteLine("-----------------------------------------------");
        }

        // метод принимает кол-во вернутых книг одним значением
        public void ReturnBook(int count)
        {
            Console.WriteLine($"{fullName} вернул {count} книги.");
            Console.WriteLine("-----------------------------------------------");
        }

        // метод принимает несколько названий книг
        public void ReturnBook(params string[] bookTitles)
        {
            Console.WriteLine($"{fullName} вернул книги: {string.Join(", ", bookTitles)}");
            Console.WriteLine("-----------------------------------------------");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Массив объектов со студентами
        Student[] students = new Student[3]
        {
            new Student("Табаргин А.В.", "МШ25", 19),
            new Student("Казаков И.П.", "МШ26", 20),
            new Student("Букаткин А.С.", "МШ27", 20),
        };

        // Массив объектов с читателями
        Reader[] readers = new Reader[3]
        {
            new Reader("Табаргин А.В.", "101", "Информатика", new DateTime(2005, 04, 13), "89037564528"),
            new Reader("Казаков И.П.", "102", "Математика", new DateTime(2004, 01, 12), "89675243716"),
            new Reader("Букаткин А.С.", "103", "Физика", new DateTime(2004, 03, 24), "89076358976"),
        };

        // Вывод информации о студентах, с помощью foreach проходимся по массиву students и для каждого студента вызываем данный метод PrintStudentInfo()
        foreach (var student in students)
        {
            student.PrintStudentInfo();
        }

        // Вывод информации о взятии и возвращении книг, если ввести в скобку число, то используется метод для одного значения, а если ввести несколько названий книг, то метод для нескольких названий
        readers[0].TakeBook(3);
        readers[0].TakeBook("Аделаида", "4 Рыцаря Апокалипсиса", "Монолог Фармацевта");
        readers[1].TakeBook(3);
        readers[0].ReturnBook("Аделаида", "4 Рыцаря Апокалипсиса");
        readers[2].ReturnBook(3);
    }
}