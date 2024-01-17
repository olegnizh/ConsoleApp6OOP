using System;

namespace ConsoleApp662
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}

	class User
	{
		private int age;
		private string login;
		private string email;

		public string Email
		{
			get
			{
				return email;
			}
			set
			{
				if (!value.Contains('@'))
				{
					Console.WriteLine("Неверный формат электронной почты");
				}
				else
				{
					login = value;
				}

			}
		}
		public string Login
		{
			get
			{
				return login;
			}
			set
			{
				if (value.Length <= 3)
				{
					Console.WriteLine("Свойство должно быть более 3 символов");
				}
				else
				{
					login = value;
				}

			}
		}
		public int Age
		{
			get
			{
				return age;
			}

			set
			{
				if (value < 18)
				{
					Console.WriteLine("Возраст должен быть не меньше 18");
				}
				else
				{
					age = value;
				}
			}
		}

	}


}

