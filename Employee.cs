using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeSupplies
{
    class Employee
    {

		private String firstName;

		public String FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

		private String lastName;

		public String LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		private String address;

		public String Address
		{
			get { return address; }
			set { address = value; }
		}

		private String department;

		public String Department
		{
			get { return department; }
			set { department = value; }
		}

		private String user;

		public String User
		{
			get { return user; }
			set {
				//if (user.Length >= 2 && user.Length <= 10)
					user = value;
				//else
					//MessageBox.Show("Username out of range");
			}
		}

		private int password;

		public int Password
		{
			get { return password; }
			set {
			//if (password.ToString().Length > 1 && password.ToString().Length < 9)
				password = value;
				//else
					//MessageBox.Show("Password out of range");

			}
		}


		private int employeeID;

		public int EmployeeID

		{
			get { return employeeID; }
			set { employeeID = value; }
		}


		public bool LogIn()
		{
			if(password == 1234 && user == "user")
			{
				return true;
			}
			return false;
		}

		public bool LogOut()
		{
			return true;
		}

	}
}
