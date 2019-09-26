using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desharp.Tests.DumpingAndLogings.CustomClasses.Persons {
	class Employe: Person {
		public int? IdDepartment { get; set; }
		public double? Salary { get; set; }
	}
}
