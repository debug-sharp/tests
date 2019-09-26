using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desharp.Tests.DumpingAndLogings {
	[Flags] public enum EnergySources: byte {
		//					// Binary  // Dec
		None	= 0,		// 000000  0
		Solar	= 1 << 0,	// 000001  1
		Wind	= 1 << 1,	// 000010  2
		Coal    = 1 << 2,	// 000100  4
		Nuclear = 1 << 3,	// 001000  8
		Flood	= 1 << 4,	// 010000  16
	}
	class Enums {
		public enum Colors {
			None = 0,
			Red = 1,
			Green = 2,
			Blue = 4
		}
		public enum Letters {
			None = 0,
			A = 1,
			B = 2,
			C = 4,
			D = 8,
			E = 16,
			F = 24
		}
		public Colors Color;
		public Letters Letter = Letters.B;
		public Letters Licences = Letters.B | Letters.D;
		public EnergySources Energy = EnergySources.Flood | EnergySources.Solar | EnergySources.Wind;
	}
}
