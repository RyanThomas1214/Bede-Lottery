﻿namespace Bede.Lottery.Core.Models
{
	public class Employee
	{
		public int Id { get; set; }
		public string Name { get; set; }

	    public override string ToString()
	    {
	        return $"{Name}";
	    }
	}
}
