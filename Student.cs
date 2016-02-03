using System;
using System.Text;
using System.Collections.Generic; 
namespace Lab1Mogolivskogo
{
	class Student
	{
		private string _surname;
		private Dictionary<string, ushort> _grades = new Dictionary<string, ushort>();
		private float _averageGrade;
		private bool _wasChanged;

		public Student(String surname)
		{
			_surname = surname;
			_averageGrade = 0;
			_wasChanged = false;
		}

		public void addGrade(string subject, ushort grade)
		{
			_grades [subject] = grade;
			_wasChanged = true;
			Console.WriteLine(_grades[subject] + " added to grades of "+_surname); 
		}

		public float getAverageGrade()
		{
			if(_wasChanged) countAverage();
			return _averageGrade;
		}

		private void countAverage()
		{
			_averageGrade = 0;
			foreach (string key in _grades.Keys)
			{
				_averageGrade += _grades[key];
			}
			_averageGrade /= _grades.Keys.Count;
		}

		public override string ToString ()
		{
			StringBuilder result = new StringBuilder();
			result.AppendLine ("Grades of "+ _surname+ ": ");
			foreach (string key in _grades.Keys)
			{
				result.AppendLine (key + " \t\t "+_grades[key]);
			}
			result.AppendLine ("Average Grade \t " + Math.Round(getAverageGrade(),2));
			return result.ToString();
		}

	}
}

