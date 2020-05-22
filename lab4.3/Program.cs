using System;

public class Test
{

	class Note
	{

		private string name = "none";
		private string surname = "none";
		private string adress = "none";
		private string phone = "none";
		private string email = "none";

		public Note()
		{
			name = "none";
			surname = "none";
			adress = "none";
			phone = "none";
			email = "none";
		}

		public Note(string n, string sn, string a, string p, string e)
		{
			name = n;
			surname = sn;
			adress = a;
			phone = p;
			email = e;
		}

		public void setName(string n)
		{
			name = n;
		}

		public string getName()
		{
			return name;
		}

		public void setSurname(string sn)
		{
			surname = sn;
		}

		public string getSurname()
		{
			return surname;
		}

		public void setAdress(string a)
		{
			adress = a;
		}

		public string getAdress()
		{
			return adress;
		}

		public void setPhone(string p)
		{
			phone = p;
		}

		public string getPhone()
		{
			return phone;
		}

		public void setEmail(string e)
		{
			email = e;
		}

		public string getEmail()
		{
			return email;
		}

		public void add()
		{
			Console.WriteLine("Insert Name:");
			name = Console.ReadLine();

			Console.WriteLine("Insert Surname:");
			surname = Console.ReadLine();

			Console.WriteLine("Insert Adress:");
			adress = Console.ReadLine();

			Console.WriteLine("Insert Phone:");
			phone = Console.ReadLine();

			Console.WriteLine("Insert Email:");
			email = Console.ReadLine();
		}

		public void edit()
		{
			Console.WriteLine("Insert Name:");
			name = Console.ReadLine();

			Console.WriteLine("Insert Surname:");
			surname = Console.ReadLine();

			Console.WriteLine("Insert Adress:");
			adress = Console.ReadLine();

			Console.WriteLine("Insert Phone:");
			phone = Console.ReadLine();

			Console.WriteLine("Insert Email:");
			email = Console.ReadLine();
		}

		public void del()
		{
			name = "delete";
			surname = "delete";
			adress = "delete";
			phone = "delete";
			email = "delete";
		}

		public void print()
		{
			Console.WriteLine("Name = " + name);
			Console.WriteLine("Surname = " + surname);
			Console.WriteLine("Adress = " + adress);
			Console.WriteLine("Phone = " + phone);
			Console.WriteLine("Email = " + email);
		}
	}

	class Date
	{

		public Note[] arr = new Note[10];

		public Date()
		{
			for (int i = 0; i < 10; i++)
			{
				arr[i] = new Note();
			}
		}

		public void sort()
		{
			Array.Sort(arr);
		}

		public void find()
		{

			string z = "";
			Console.WriteLine("Insert Email to find:");
			z = Console.ReadLine();
			bool x = true;

			for (int i = 0; i < 10; i++)
			{
				if (String.Equals(arr[i].getEmail(), z))
				{
					arr[i].print();
					x = false;
				}
			}

			if (x)
			{
				Console.WriteLine("Email: " + z + " not prezent!");
			}

		}

		public void add()
		{
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("Add element" + i);
				arr[i].add();
			}
		}

		public void edit()
		{
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("Edit element" + i);
				arr[i].edit();
			}
		}

		public void print()
		{
			for (int i = 0; i < 10; i++)
			{
				arr[i].print();
				Console.WriteLine("--------------------------");
			}
		}

	}


	public static void Main()
	{
		Date d1 = new Date();
		d1.print();

		string s = "";

		Console.WriteLine("Select menu optionals:");
		Console.WriteLine("1. Add new Note, press bottom: a");
		Console.WriteLine("2. Edit Note, press bottom: e");
		Console.WriteLine("3. Find Note, press bottom: f");
		Console.WriteLine("4. Exit, press bottom: x");
		s = Console.ReadLine();

		switch (s)
		{
			case "a":
				d1.add();
				break;
			case "e":
				d1.edit();
				break;
			case "f":
				d1.find();
				break;
			case "x":
				Console.WriteLine("Exit");
				break;
		}


	}
}