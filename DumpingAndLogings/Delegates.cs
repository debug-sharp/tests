using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desharp.Tests.DumpingAndLogings {
	public class CustomEventArgs: EventArgs {
		public string Msg;
	}
	public delegate void CustomHandler (object o, CustomEventArgs e);
	class Delegates {
		public event EventHandler Easy;
		public event CustomHandler Custom;
		public Delegates () {
			this.Easy += delegate {
				Console.WriteLine("Easy first");
			};
			this.Easy += delegate {
				Console.WriteLine("Easy second");
			};
			this.Custom += this.CustomHandlerFirst;
			this.Custom += this.CustomHandlerSecond;
		}
		public void CustomHandlerSecond(object o, CustomEventArgs e) {
			Console.WriteLine("Custom second");
		}
		public void CustomHandlerFirst(object o, CustomEventArgs e) {
			Console.WriteLine("Custom first");
		}
		public void DumpAndLogLocals(Desharp.Level logLevel) {
			Delegates.TestBaseDelegate(delegate (object o, EventArgs e) {
				Console.Write("Handler first");
			}, logLevel);
			Delegates.TestTypedDelegate(delegate (object o, CustomEventArgs e) {
			}, logLevel);
		}
		public static void TestBaseDelegate(EventHandler handler, Desharp.Level logLevel) {
			Desharp.Debug.Dump(handler);
			Desharp.Debug.Log(handler, logLevel);
		}
		public static void TestTypedDelegate(CustomHandler handler, Desharp.Level logLevel) {
			Desharp.Debug.Dump(handler);
			Desharp.Debug.Log(handler, logLevel);
		}
	}
}
