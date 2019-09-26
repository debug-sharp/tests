using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desharp.Tests.DumpingAndLogings {
	class Funcs {
		Func<int, int, int?, string, bool> Fn1 = (a, b, c, d5) => {
			return false;
		};
		Func<int?> Fn2 = () => {
			return null;
		};
		public void DumpAndLogLocals(Desharp.Level logLevel) {
			Func<int, int, int, string, bool?> fn1 = (a, b, c, d) => {
				return false;
			};
			Func<int> fn2 = () => {
				return 1;
			};
			Desharp.Debug.Dump(fn1);
			Desharp.Debug.Dump(fn2);
			Desharp.Debug.Log(fn1, logLevel);
			Desharp.Debug.Log(fn2, logLevel);
		}
	}
}
