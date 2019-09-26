using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Desharp.Tests.DumpingAndLogings.CustomClasses {
	class Person {
		public int? Id { get; set; }
		public string FirstName { get; set; }
		public string SecondName { get; set; }
		public string Description { get; set; }

		public static int Count {
			get { return Person.count; }
			set { Person.count = value; }
		}
		protected static int count = 0;

		[Desharp.Hidden]
		[CompilerGenerated]
		protected Dictionary<string, object> store = new Dictionary<string, object>();

		public object this[string key] {
			get {
				PropertyInfo prop = this.GetType().GetProperty(key, BindingFlags.Public | BindingFlags.Instance);
				if (prop is PropertyInfo) {
					return prop.GetValue(this, new object[] { });
				} else if (this.store.ContainsKey(key)) {
					return this.store[key];
				}
				return null;
			}
			set {
				PropertyInfo prop = this.GetType().GetProperty(key, BindingFlags.Public | BindingFlags.Instance);
				if (prop is PropertyInfo) {
					prop.SetValue(this, value, new object[] { });
				} else {
					if (this.store.ContainsKey(key)) {
						this.store[key] = value;
					} else {
						this.store.Add(key, value);
					}
				}
			}
		}

		public Person () {
			Person.count += 1;
		}
	}
}
