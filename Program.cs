using System;
using System.Text;
using System.Collections;
using System.Collections.Generic; 
using System.Linq;

namespace Lab1Mogolivskogo
{
	class MainClass
	{
		private static List<Student> students = new List<Student>();
		private delegate bool Comparator<T>(T st1, T st2);

		public static void Main (string[] args)
		{
			students.Add(new Student("Ivanov"));
			students[0].addGrade (".NET", 100);
			students[0].addGrade ("JavaSE", 81);
			students[0].addGrade ("JavaEE", 76);
			students.Add(new Student("Semenov"));
			students[1].addGrade (".NET", 78);
			students[1].addGrade ("JavaSE", 61);
			students[1].addGrade ("JavaEE", 72);
			students.Add(new Student("Green"));
			students[2].addGrade (".NET", 88);
			students[2].addGrade ("JavaSE", 60);
			students[2].addGrade ("JavaEE", 90);
			showStudents(ref students);
			Console.WriteLine("=========Ascending sorting========");
			sort<Student>(ref students, (t1, t2) => t1.getAverageGrade().CompareTo(t2.getAverageGrade()) > 0);
			showStudents(ref students);
			Console.WriteLine("========Descending sorting========");
			sort<Student>(ref students, (t1, t2) => t1.getAverageGrade().CompareTo(t2.getAverageGrade()) < 0);
			showStudents(ref students);
		}

		private static void sort<T>(ref List<T> list, Comparator<T> comparator)
		{
			T temp;
			for (int i = 0; i < list.Count; i++)
			{
				for (int j = 0; j < list.Count-1; j++)
				{
					if (comparator (list [j], list [j + 1]))
					{
						temp = list [j];
						list [j] = list [j + 1];
						list [j + 1] = temp;
					}
				}
			}
		}

		private static void showStudents(ref List<Student> students)
		{
			Console.WriteLine ("=============STUDENTS=============");
			foreach(Student s in students)
				Console.WriteLine(s);
			Console.WriteLine ("==================================");
		}
	}
	
}
