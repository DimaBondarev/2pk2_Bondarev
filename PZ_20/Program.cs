namespace PZ_20
{
    internal class Student : ICloneable, IComparable<Student>
    {


        // Поля класса
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string Specialty { get; set; }
        public double AverageGrade { get; set; }
        public object DateOfreceipt { get; private set; }

        // Конструкторы класса
        public Student(string name, DateTime dateOfBirth, DateTime enrollmentDate, string specialty)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            EnrollmentDate = enrollmentDate;
            Specialty = specialty;
            AverageGrade = 0; // начальное значение для среднего балла
        }

        // Виртуальный метод отчисления для студента
        public virtual void DismissStudent()
        {
            Console.WriteLine($"{Name} был отчислен.");
        }

        // Перегрузка операторов сравнения по дате поступления
        public static bool operator >(Student student1, Student student2)
        {
            return student1.EnrollmentDate > student2.EnrollmentDate;
        }
        public static bool operator <(Student student1, Student student2)
        {
            return student1.EnrollmentDate > student2.EnrollmentDate;
        }
        public object Clone()
        {
            Student newStudent = new Student(this.Name, this.DateOfBirth, this.EnrollmentDate, this.Specialty);
            newStudent.AverageGrade = this.AverageGrade;

            // Для ссылочных типов производим глубокое копирование, если необходимо
            // newStudent.SomeReferenceField = new SomeReferenceType(this.SomeReferenceField);

            return newStudent;
        }
        public int CompareTo(Student other)
        {
            if (other == null) return 1;

            // Сравниваем объекты по среднему баллу
            return this.AverageGrade.CompareTo(other.AverageGrade);
        }

        public override string ToString()
        {
            return ($"ФИО: {Name}, Дата рождения: {DateOfBirth}, Дата поступления: {DateOfreceipt}");
        }
    }  
}   