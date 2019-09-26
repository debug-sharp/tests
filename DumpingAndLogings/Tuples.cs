using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desharp.Tests.DumpingAndLogings {
	class Tuples {
		//public Tuple1 = (42, "The meaning of life");
		//public Tuple2 = (one: 1, two: 2, three: "3");
		public System.Tuple<int, string> Tuple1 = new System.Tuple<int, string>(42, "The meaning of life");
		public System.Tuple<int, int, int?> Tuple2 = new System.Tuple<int, int, int?>(1, 2, null);
	}
}
