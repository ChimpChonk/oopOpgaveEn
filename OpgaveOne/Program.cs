Students sanjit = new(1, "Sanjit", "Poudel", "11-07-2002");
Students amanda = new(2, "Amanda", "E.V Gudmand", "01-04-1998");
Students dennis = new(3, "Dennis", "D. B Paaske", "01-01-1980");
Students ozan = new(4, "Ozan", "Korkmaz", "02-11-2000");
Students camilla = new(5, "Camilla", "Kløjgaard", "02-11-2003");


Teachers niels = new("Teacher", "Niels", "Olesen", "02-23-1971");

Course studieteknik = new("Studieteknik", niels);
Course grundPro = new("Grundl.prog", niels);
Course oop = new("OOP", niels);

Enrollment en1 = new(sanjit, studieteknik);
Enrollment en2 = new(sanjit, grundPro);
Enrollment en3 = new(sanjit, oop);

Enrollment en4 = new(amanda, studieteknik);
Enrollment en5 = new(amanda, grundPro);
Enrollment en6 = new(amanda, oop);

Enrollment en7 = new(dennis, studieteknik);
Enrollment en8 = new(dennis, oop);
Enrollment en9 = new(dennis, grundPro);

Enrollment en10 = new(ozan, grundPro);
Enrollment en11 = new(ozan, oop);

Enrollment en12 = new(camilla, grundPro);
Enrollment en13 = new(camilla, oop);
