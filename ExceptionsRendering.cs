using System;
using System.Reflection;
using Desharp.Tests.DumpingAndLogings;

namespace Desharp.Tests {
	public class ExceptionsRendering {
		public void TestAll() {
			try {
				throw new Exception("Tests exception message text.");
			} catch (Exception ex) {
				Desharp.Debug.Dump(ex);
				Desharp.Debug.Log(ex);
			}
			Desharp.Debug.Stop();
			//throw new Exception("Will be this logged only in winforms.");
		}
	}
}