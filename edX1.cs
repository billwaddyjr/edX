

public class Program{
	public string degrees;//array
	public string faculty;//array
	public string head;
}

public class Degree{
	public int credits;
	public string courseList;//array
	public string prereqs;//array
}

public class Student{
	public string firstName;
	public string lastName;
	public string birthdate;
	public string add1;
	public string add2;
	public string city;
	public string state;
	public int zip;
	public string country;
	public string degree;
}

public class Professor{
	public string firstName;
	public string lastName;
	public string title;
	public string program;
}

public class Course{
	public string prereq;
	public int credits;
}

public class homework1{
	public static void Main(){
		Program Engineering = new Program();
		Engineering.degrees = "Civil";
		Engineering.faculty = "Dr. Doe";
		Engineering.head = "Dr. John Doe";

		Degree civilEng = new Degree();
		civilEng.credits = 140;
		civilEng.courseList = "Structural Class";
		civilEng.prereqs = "Basics";

		Student student1 = new Student();
		student1.firstName = "John";
		student1.lastName = "Doe";
		student1.birthdate = "8/25/1990";
		student1.add1 = "123 Street";
		student1.city = "major city";
		student1.state = "WI";
		student1.zip = 12340;
		student1.country = "USA";
		student1.degree = "civil";

		Professor econProf = new Professor ();
		econProf.firstName = "Jane";
		econProf.lastName = "Doe";
		econProf.title = "Associate Prof";
		econProf.program = "business";

		Course structuralEng = new Course();
		structuralEng.prereq = "physics";
		structuralEng.credits = 3;

		System.Console.WriteLine("The Engineering program has the " + Engineering.degrees + " degree, and " + Engineering.head + " is the department head.");
		System.Console.WriteLine(student1.firstName + " " + student1.lastName + " is a " + student1.degree + " student.");

	}
}
