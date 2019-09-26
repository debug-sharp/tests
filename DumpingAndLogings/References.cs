using System;
using System.Text;

namespace Desharp.Tests.DumpingAndLogings {
	class References {
		public System.DateTimeOffset A = DateTimeOffset.Now;
		public System.DateTime B = DateTime.Now;
		public System.TimeSpan C = TimeSpan.FromTicks(DateTime.Now.Ticks);
		public System.DBNull D = System.DBNull.Value;
		public System.Guid E = typeof(References).GUID;
		public System.Text.StringBuilder F = new System.Text.StringBuilder("String builder test value");

		public void DumpAndLogLocals (Desharp.Level logLevel) {
			System.DateTimeOffset a = DateTimeOffset.Now;
			System.DateTime b = DateTime.Now;
			System.TimeSpan c = TimeSpan.FromTicks(DateTime.Now.Ticks);
			System.DBNull d = System.DBNull.Value;
			System.Guid e = this.GetType().GUID;
			System.Text.StringBuilder f = new System.Text.StringBuilder("String builder test value");

			Desharp.Debug.Dump(a, b, c, d, e, f);
			Desharp.Debug.Log(a, logLevel);
			Desharp.Debug.Log(b, logLevel);
			Desharp.Debug.Log(c, logLevel);
			Desharp.Debug.Log(d, logLevel);
			Desharp.Debug.Log(e, logLevel);
			Desharp.Debug.Log(f, logLevel);
		}
	}
}