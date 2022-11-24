Students sanjit = new(1, "Sanjit", "Poudel", "11-07-2002");
Students amanda = new(2, "Amanda", "E.V Gudmand", "01-04-1998");
Students dennis = new(3, "Dennis", "D. B Paaske", "01-01-1980");
Students ozan = new(4, "Ozan", "Korkmaz", "02-11-2000");
Students camilla = new(5, "Camilla", "Kløjgaard", "02-11-2003");
Students rune = new Students(6, "Rune", "Hansen", "01-11-1999");
Students alexander = new Students(7, "Sanjit", "Pouden", "11-05-1998");
Students rasmus = new Students(8, "Rasmus", "Wiell", "20-04-1997");
Students temp = new Students(9, "Temp", "Name", "01-01-2001");


Teachers niels = new("Teacher", "Niels", "Olesen", "23-02-1971");
Teachers peter = new("Teacher", "Peter", "Lindenskov", "01-01-1970");

Course clientSide = new(CourseEnum.Clientsideprogrammering.ToString(), peter);
Course studieteknik = new(CourseEnum.Studieteknik.ToString(), niels);   
Course grundPro = new(CourseEnum.Grundlæggendeprogrammering.ToString(), niels);
Course oop = new(CourseEnum.OOP.ToString(), niels);
Course databaseprog = new Course(CourseEnum.Databaseprogrammering.ToString(), niels);
Course computertek = new Course(CourseEnum.Computerteknologi.ToString(), niels);
Course netværk = new Course(CourseEnum.Netværk.ToString(), niels);

Enrollment _enrollmentList = new();

_enrollmentList.EnrollList = new List<Enrollment>()
{
    new(alexander, clientSide),
    new(alexander, studieteknik),
    new(alexander, oop),
    new(alexander, grundPro),
    new(alexander, databaseprog),
    new(alexander, computertek),
    new(alexander, netværk),

    new(sanjit, studieteknik),
    new(sanjit, grundPro),
    new(sanjit, oop),
    new(sanjit, databaseprog),
    new(sanjit, computertek),
    new(sanjit, netværk),

    new(amanda, studieteknik),
    new(amanda, grundPro),
    new(amanda, oop),
    new(amanda, databaseprog),
    new(amanda, computertek),
    new(amanda, netværk),

    new(dennis, studieteknik),
    new(dennis, oop),
    new(dennis, grundPro),
    new(dennis, databaseprog),
    new(dennis, computertek),
    new(dennis, netværk),

    new(ozan, grundPro),
    new(ozan, oop),
    new(ozan, databaseprog),
    new(ozan, computertek),
    new(ozan, netværk),

    new(camilla, grundPro),
    new(camilla, oop),
    new(camilla, databaseprog),
    new(camilla, computertek),
    new(camilla, netværk),

    new(rune, oop),
    new(rasmus, oop),
    new(temp, oop)
};

//foreach (var item in _enrollmentList.EnrollList)
//{
//    Console.WriteLine($"{item.StudentInfo.FirstName} {item.StudentInfo.LastName}  Course: {item.CoursesInfo.CourseName}  Teacher: {item.CoursesInfo.Teachers.FirstName} {item.CoursesInfo.Teachers.LastName} ");
//}

//Console.WriteLine(sanjit.ReturnFullName());
//Console.WriteLine(sanjit.PersonAge());
//Console.WriteLine(sanjit.GetAllCourses(_enrollmentList)

//Console.WriteLine(niels.ReturnFullName());
//Console.WriteLine(niels.PersonAge());
//Console.WriteLine(niels.GetAllCourses(_enrollmentList));

//string? result = niels.GetAllCourses(_enrollmentList);
//List<string> result2 = niels.GetAllCourses(_enrollmentList.EnrollList);

//foreach (var item in result2)
//{
//    Console.WriteLine(item);
//}

//_enrollmentList.EnrollList.Sort();

//foreach(var item in _enrollmentList.EnrollList)
//{
//    Console.WriteLine($"{item.StudentInfo.FirstName} {item.StudentInfo.LastName}  Course: {item.CoursesInfo.CourseName}  Teacher: {item.CoursesInfo.Teachers.FirstName} {item.CoursesInfo.Teachers.LastName} ");
//}

try
{
    oop.CourseStudentAmount(oop.StudentList(_enrollmentList));
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}