using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
	public class Pet
	{
		public Guid Id;

		public string Name;

		public Person Owner;

		public Guid OwnerId { get { return Owner.Id; } }

		public int From;

		public int Till;
	}
}