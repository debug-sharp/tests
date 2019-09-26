using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Desharp.Tests.DumpingAndLogings {
	class Dictionaries {
		public Dictionary<string, string> Person = new Dictionary<string, string>() {
			{"name",	"Tom"},
			{"surname", "Flidr"},
			{"email",	"tomflidr@gmail.com"},
			{"gender",	"male"},
			{"crime",	null},
		};
		public Dictionary<string, object> Cars = new Dictionary<string, object>() {
			{"Skoda 120 L", new Dictionary<string, int>() {
				{"gauge", 180},
				{"doors", 4},
                {"speeds", 4}
            }},
			{"Skoda 135 GLS", new Dictionary<string, int?>() {
				{"gauge", 205},
				{"doors", 4},
                {"speeds", null}
			}}
		};
		private Dictionary<string, int> Months = new Dictionary<string, int>() {
            { "Jan", 31 },
            { "Feb", 28 },
            { "Mar", 31 },
            { "Apr", 30 },
			{ "May", 31 },
			{ "Jun", 30 },
			{ "Jul", 31 },
			{ "Aug", 31 },
			{ "Sep", 30 },
			{ "Oct", 31 },
			{ "Nov", 30 },
			{ "Dec", 31 }
        };
		Hashtable OpenWith = new Hashtable() {
			{ "txt", "notepad.exe" },
			{ "bmp", "paint.exe" },
			{ "dib", "paint.exe" },
			{ "rtf", "wordpad.exe" },
		};
	}
}
