﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace NestedObjects
{
	/// <summary>
	/// Represents an individual college student
	/// </summary>
	public class Student
	{
		/// <summary>
		/// The legal first name
		/// </summary>
		public string? FirstName {  get; set; }
	
		/// <summary>
		/// The legal last name
		/// </summary>
		public string? LastName { get; set; }

		/// <summary>
		/// The assigned email address
		/// </summary>
		public string SchoolEmail { get; set; }


		public string PhoneNumber { get; set; }


		public Advisor AssignedAdvisor { get; set; }
	}
}