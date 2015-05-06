using System;
using System.Console;

public class UProgram{
	public string name;
	public Degree degree;
	public Professor head;
}

public class Degree{
	public string name;
	public int credits;
	public Course course;
	public string prereqs;
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
}

public class Course{
	public string name;
	public string prereq;
	public int credits;
	public Student[] students;
	public Professor[] professors;
}

public static class getInfo{
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

		return prof1;
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

public class homework5{
	public static void Main(){

		Student[] students = new Student[3];
		for (int i = 0; i < 3; i++) {
			WriteLine ("Enter info for student {0}", i);
			students [i] = getInfo.forStudent ();
			WriteLine (" ");
		}

		Professor[] professors = new Professor[3];
		for (int i = 0; i < 3; i++) {
			WriteLine ("Enter info for Professor {0}", i);
			professors [i] = getInfo.forProf ();
			WriteLine (" ");
		}

		Course course1 = new Course ();
		course1.name = "Programming with C#";
		course1.students = students;
		course1.professors = professors;

		Degree newDeg = new Degree ();
		newDeg.name = "Bachelor of Science";
		newDeg.course = course1;

		UProgram newProg = new UProgram ();
		newProg.name = "Information Technology";
		newProg.degree = newDeg;

		WriteLine ("The {0} program has the {1} degree", newProg.name, newProg.degree.name);
		WriteLine ("The {0} degree contains the {1} course", newDeg.name, newDeg.course.name);
		WriteLine ("The {0} course has {1} students enrolled", course1.name, course1.students.Length);


	}
}
