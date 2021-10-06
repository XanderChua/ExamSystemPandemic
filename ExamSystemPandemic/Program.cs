using System;
using System.Collections.Generic;
using System.Linq;
//let's design an exam system to solve the modern days pandemic problem. THe organization uses a multiple objective answering system to evaluate the students.
//but first you need to signup as a student then appear for the exam . After completion of the exam it shows the result and the correct answer of the respective questions.
//But there is two conditions first "one cane appear the exam only once ' and the second one is the admin allows the students to take the exam or not .

namespace ExamSystemPandemic
{  
    class Program
    {
        static void Main(string[] args)
        {
            StudentManagement stuMgmt = new StudentManagement();
            Console.WriteLine("--Pandemic Exam System--");
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("1. Take exam");
                Console.WriteLine("2. Add students");
                Console.WriteLine("3. List all students");
                Console.WriteLine("4. List all students results");
                Console.WriteLine("5. Exit");
                int input = Int32.Parse(Console.ReadLine());
                if (input == 1)
                {
                    Console.WriteLine("Enter your name:");
                    string yourName = Console.ReadLine();
                    Student studentObj = null;
                    int score = 0;
                    foreach (var s in stuMgmt.StudentDictObj)//loop thru student list to find matching name and store in student object
                    {
                        if (string.Equals(yourName, s.Key))
                        {
                            studentObj = s.Value;
                        }
                    }
                    if (studentObj != null)//check if student object name exist in list 
                    {
                        if (stuMgmt.StudentDictObj[yourName].DoExamAlrAnot == false)//check if the person do exam alrd from dict key and value bool
                        {
                            Console.WriteLine("Q1. What is 1 + 1?");
                            Console.WriteLine("1) 1");
                            Console.WriteLine("2) 10");
                            Console.WriteLine("3) 2");
                            int answer1 = Int32.Parse(Console.ReadLine());
                            switch (answer1)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Wrong answer! Correct answer is 3) 2");
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("Wrong answer! Correct answer is 3) 2");
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("Correct answer!");
                                        score++;
                                        break;
                                    }
                            }
                            Console.WriteLine("Q2. What is 10 x 10?");
                            Console.WriteLine("1) 10");
                            Console.WriteLine("2) 100");
                            Console.WriteLine("3) 999");
                            int answer2 = Int32.Parse(Console.ReadLine());
                            switch (answer2)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Wrong answer! Correct answer is 2) 100");
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("Correct answer!");
                                        score++;
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("Wrong answer! Correct answer is 2) 100");
                                        break;
                                    }
                            }
                            Console.WriteLine("Q3. What is 3 - 3?");
                            Console.WriteLine("1) 0");
                            Console.WriteLine("2) 6");
                            Console.WriteLine("3) 1");
                            int answer3 = Int32.Parse(Console.ReadLine());
                            switch (answer3)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Correct answer!");
                                        score++;
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("Wrong answer! Correct answer is 1) 0");
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("Wrong answer! Correct answer is 1) 0");
                                        break;
                                    }
                            }
                            Console.WriteLine("Your final score: " + score + "/3");
                            stuMgmt.StudentDictObj[yourName].DoExamAlrAnot = true;//updateupdateeeeeeeeeee to true if the person do exam alrd
                            stuMgmt.StudentDictObj[yourName].Result = score; //UPDATE THE SCORE VERY IMPT!!! cus default score is 0 lmao
                        }
                        else
                        {
                            Console.WriteLine(yourName + " has already taken the exam.");
                        }
                    }
                    else
                    {
                        Console.WriteLine(yourName + " does not exist.");
                    }
                }
                else if (input == 2)//add student
                {
                    Console.WriteLine("Enter student name:");
                    string studentName = Console.ReadLine();                   
                    int score = 0;
                    int studentID = 1;
                    bool DoExamAlrd = false;
                    foreach (var student in stuMgmt.StudentDictObj)
                    {
                        studentID++;                       
                    }
                    //studentName is key, id,name,score are values initialised frm Student class
                    stuMgmt.StudentDictObj.Add(studentName, new Student(studentID, studentName, score, DoExamAlrd));
                }
                else if (input == 3)//list students
                {
                    foreach (var student in stuMgmt.StudentDictObj)
                    {
                        Console.WriteLine("ID: " + student.Value.studentID + " Name: " + student.Key);//ur unique key is same as student.value.studentname                                           
                    }                   
                }
                else if (input == 4)//list student results
                {
                    foreach (var results in stuMgmt.StudentDictObj)
                    {
                        if (results.Value.DoExamAlrAnot == true)
                        {
                            Console.WriteLine(results.Key + "'s score: " + results.Value.Result);
                        }
                    }
                }
            }
        }
    }
}
//for future ref if wanna use 2 or more list to compare wif input
//if(listStudent.CollectionObj.Where((x) => x.Equals(yourName)).Count() > 0) 
//{

//}
