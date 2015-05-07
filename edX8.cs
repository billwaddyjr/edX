using System;
using System.Console;
using System.Collections;
using System.Collections.Generic;

public class UProgram{
	public string name {get; set;}
	public Degree degree {get; set;}
	public Professor head {get; set;}
}

public class Degree{
	public string name {get; set;}
	public int credits {get; set;}
	public Course course {get; set;}
	public string prereqs {get; set;}
}

public class Person{
	public string firstName {get; set;}
	public string lastName {get; set;}
	public DateTime birthdate {get; set;}
	public string add1 {get; set;}
	public string add2 {get; set;}
	public string city {get; set;}
	public string state {get; set;}
	public int zip {get; set;}
	public string country {get; set;}
}

public class Student : Person{
	public decimal GPA {get; set;}
	public Stack<int> grades = new Stack<int>();
	public int year {get; set;}
	public void TakeTest(){
		var ex = new NotImplementedException();
		throw ex;
	}
}

public class Professor : Person{
	public decimal salary {get; set;}
	public string title {get; set;}
	public void GiveTest(){
		var ex = new NotImplementedException();
		throw ex;
	}
}

public class Course{
	public string name {get; set;}
	public string prereq {get; set;}
	public int credits {get; set;}
	public List<Student> students = new List<Student>();
	public ArrayList professors;
	public void ListStudents(){
		WriteLine ("The students in the {0} course are: ", this.name);
		foreach (Student student in this.students) {
			WriteLine ("{0} {1}", student.firstName, student.lastName);
		}
	}
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

public class homework8{
	public static void Main(){

		var students = new List<Student>();
		for (int i = 0; i < 3; i++) {
			WriteLine ("Enter info for student {0}", i+1);
			students.Add(getInfo.forStudent ());
			WriteLine (" ");
		}
			
		Course course1 = new Course ();
		course1.name = "Programming with C#";
		course1.students = students;

		foreach (Student student in course1.students) {
			for (int i = 1; i <= 5; i++) {
				WriteLine ("Enter grade {0} for {1}", i, student.firstName);
				int grade = Convert.ToInt32(ReadLine ());
				student.grades.Push (grade);
			}
		}

		course1.ListStudents ();

	}
}
