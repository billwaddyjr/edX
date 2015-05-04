using System;
using System.Console;

public class Program{
	public string name;
	public string degrees;//array
	public string faculty;//array
	public string head;
}

public class Degree{
	public string name;
	public int credits;
	public string courseList;//array
	public string prereqs;//array
}

public class Student{
	public string firstName;
	public string lastName;
	public DateTime birthdate;
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
	public DateTime birthdate;
	public decimal salary;
	public string title;
	public string program;
}

public class Course{
	public string name;
	public string prereq;
	public int credits;
}

public class getInfo{
	public static Student forStudent(){
		Student student1 = new Student();
		WriteLine("Enter the student's first name: ");
		student1.firstName = ReadLine();
		WriteLine("Enter the student's last name: ");
		student1.lastName = ReadLine();
		WriteLine("Enter the student's birthdate: ");
		student1.birthdate = Convert.ToDateTime(ReadLine());
		WriteLine("Enter the student's address line 1: ");
		student1.add1 = ReadLine();
		WriteLine("Enter the student's address line 2: ");
		student1.add2 = ReadLine();
		WriteLine("Enter the student's city: ");
		student1.city = ReadLine();
		WriteLine("Enter the student's state: ");
		student1.state = ReadLine();
		WriteLine("Enter the student's zip code: ");
		student1.zip = Convert.ToInt32(ReadLine());
		WriteLine("Enter the student's country: ");
		student1.country = ReadLine();
		WriteLine("Enter the students' degree of study: ");
		student1.degree = ReadLine();
		
		return student1;
	}

	public static Professor forProf(){
		Professor prof1 = new Professor();
		WriteLine ("Enter the profesor's first name: ");
		prof1.firstName = ReadLine();
		WriteLine ("Enter the professor's last name: ");
		prof1.lastName = ReadLine ();
		WriteLine ("Enter the professor's birthday: ");
		prof1.birthdate = Convert.ToDateTime(ReadLine ());
		WriteLine ("Enter the professor's salary: ");
		prof1.salary = Convert.ToDecimal(ReadLine ());
		WriteLine ("Enter the professor's title: ");
		prof1.title = ReadLine ();
		WriteLine ("Enter the program the professor teaches in: ");
		prof1.program = ReadLine ();

		return prof1;
	}

	public static Program forProgram(){
		Program prog1 = new Program ();
		WriteLine ("Enter the name of the new program: ");
		prog1.name = ReadLine ();
		WriteLine ("Enter the degrees in this program: ");
		prog1.degrees = ReadLine ();
		WriteLine ("Enter the faculty in this program: ");
		prog1.faculty = ReadLine ();
		WriteLine ("Enter the head of this program: ");
		prog1.head = ReadLine ();

		return prog1;
	}

	public static Degree forDegree(){
		Degree deg1 = new Degree ();
		WriteLine ("Enter the name of the new degree: ");
		deg1.name = ReadLine ();
		WriteLine ("Enter the number of credits required: ");
		deg1.credits = Convert.ToInt32(ReadLine ());
		WriteLine ("Enter the courses required for the degree: ");
		deg1.courseList = ReadLine ();
		WriteLine ("Enter the pre-requisites for this degree: ");
		deg1.prereqs = ReadLine ();

		return deg1;
	}

	public static Course forCourse(){
		Course course1 = new Course ();
		WriteLine ("Enter the name of the new course: ");
		course1.name = ReadLine ();
		WriteLine ("Enter the pre-requisities for the course: ");
		course1.prereq = ReadLine ();
		WriteLine ("Enter the credits for the course: ");
		course1.credits = Convert.ToInt32(ReadLine ());

		return course1;	
	}
}		﻿

public class output{
	public static void programInfo(Program prog){
		WriteLine ("The {0} program head is {1}, has the degrees: {2}, which are taught by: {3}", prog.name, prog.head, prog.degrees, prog.faculty);
	}

	public static void degreeInfo(Degree deg){
		WriteLine ("The {0} degree requires {1} credits, including the courses: {2}", deg.name, deg.credits, deg.courseList);
	}

	public static void courseInfo(Course course){
		WriteLine ("Completion of the {0} course gets you {1} credits, but requires {2} as pre-requisities", course.name, course.credits, course.prereq);
	}

	public static void studentInfo(Student student){
		WriteLine ("{0} {1} is enrolled in the {2} degree", student.firstName, student.lastName, student.degree);
	}

	public static void profInfo(Professor prof){
		WriteLine ("{0} {1} {2} teaches in the {3} program", prof.title, prof.firstName, prof.lastName, prof.program);
	}
}

public class homework3{
	public static void Main(){

		Program newProg = new Program ();
		newProg = getInfo.forProgram ();
		WriteLine (" ");
		output.programInfo (newProg);
		WriteLine (" ");

		Degree newDeg = new Degree ();
		newDeg = getInfo.forDegree ();
		WriteLine (" ");
		output.degreeInfo (newDeg);
		WriteLine (" ");

		Course newCourse = new Course ();
		newCourse = getInfo.forCourse(); 
		WriteLine (" ");
		output.courseInfo (newCourse);
		WriteLine (" ");

		Student student1 = new Student();
		student1 = getInfo.forStudent();
		WriteLine (" ");
		output.studentInfo (student1);
		WriteLine (" ");

		Professor newProf = new Professor ();
		newProf = getInfo.forProf ();
		WriteLine (" ");
		output.profInfo (newProf);
	}
}
