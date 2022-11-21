Students sanjit = new(1, "Sanjit", "Poudel", "11-07-2002");
Students amanda = new(2, "Amanda", "E.V Gudmand", "01-04-1998");
Students dennis = new(3, "Dennis", "D. B Paaske", "01-01-1980");
Students ozan = new(4, "Ozan", "Korkmaz", "02-11-2000");
Students camilla = new(5, "Camilla", "Kløjgaard", "02-11-2003");


Teachers niels = new("Teacher", "Niels", "Olesen", "23-02-1971");

Course studieteknik = new("Studieteknik", niels);
Course grundPro = new("Grundl.prog", niels);
Course oop = new("OOP", niels);

List<Enrollment> enList = new()
{
    new(sanjit, studieteknik),
    new(sanjit, grundPro),
    new(sanjit, oop),
    new(amanda, studieteknik),
    new(amanda, grundPro),
    new(amanda, oop),
    new(dennis, studieteknik),
    new(dennis, oop),
    new(dennis, grundPro),
    new(ozan, grundPro),
    new(ozan, oop),
    new(camilla, grundPro),
    new(camilla, oop),
};

foreach (var item in enList)
{
    Console.WriteLine($"{item.StudentInfo.FirstName} {item.StudentInfo.LastName}  Course: {item.CoursesInfo.CourseName}  Teacher: {item.CoursesInfo.Teachers.FirstName} {item.CoursesInfo.Teachers.LastName} ");
}
