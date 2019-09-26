using System;
using System.Reflection;
using Desharp.Tests.DumpingAndLogings;

namespace Desharp.Tests {
	public class DumpingAndLoging {
		public void TestAll() {
			this.TestBasePrimitives();
			this.TestBaseReferences();
			this.TestArrays();
			this.TestNameValueCollections();
			this.TestDictionaries();
			this.TestDbResults();
			this.TestEnums();
			this.TestTypes();
			this.TestEnumerables();
			this.TestCollections();
			this.TestTuples();
			this.TestFuncs();
			this.TestDelegates();
			this.TestReflections();
			this.TestCustomClasses();
			this.TestAnonymous();
		}
		public void TestBasePrimitives() {
			var basePrimitives = new Primitives();
			basePrimitives.DumpAndLogLocals(Desharp.Level.DEBUG);
			Desharp.Debug.Dump(basePrimitives);
			Desharp.Debug.Log(basePrimitives, Desharp.Level.DEBUG);
		}
		public void TestBaseReferences() {
			var baseReferences = new References();
			baseReferences.DumpAndLogLocals(Desharp.Level.DEBUG);
			Desharp.Debug.Dump(baseReferences);
			Desharp.Debug.Log(baseReferences, Desharp.Level.DEBUG);
		}
		public void TestArrays() {
			var baseArrays = new Arrays();
			baseArrays.DumpAndLogLocals(Desharp.Level.DEBUG);
			Desharp.Debug.Dump(baseArrays);
			Desharp.Debug.Log(baseArrays, Desharp.Level.DEBUG);
		}
		public void TestNameValueCollections() {
			var nameValueCols = new NameValueCollections();
			Desharp.Debug.Dump(nameValueCols);
			Desharp.Debug.Log(nameValueCols, Desharp.Level.DEBUG);
		}
		public void TestDictionaries() {
			var dcts = new Dictionaries();
			Desharp.Debug.Dump(dcts);
			Desharp.Debug.Log(dcts, Desharp.Level.DEBUG);
		}
		public void TestDbResults() {
			// TODO
		}
		public void TestEnums() {
			var enms = new Enums();
			Desharp.Debug.Dump(enms);
			Desharp.Debug.Log(enms, Desharp.Level.DEBUG);
		}
		public void TestTypes() {
			Type currentType = this.GetType();
			Desharp.Debug.Dump(currentType);
			Desharp.Debug.Log(currentType, Desharp.Level.DEBUG);
		}
		public void TestEnumerables() {
			var enmrbls = new Enumerables();
			Desharp.Debug.Dump(enmrbls);
			Desharp.Debug.Log(enmrbls, Desharp.Level.DEBUG);
		}
		public void TestCollections() {
			var colls = new Collections();
			Desharp.Debug.Dump(colls);
			Desharp.Debug.Log(colls, Desharp.Level.DEBUG);
		}
		public void TestTuples() {
			var tpls = new Tuples();
			Desharp.Debug.Dump(tpls);
			Desharp.Debug.Log(tpls, Desharp.Level.DEBUG);
		}
		public void TestFuncs() {
			var fns = new Funcs();
			fns.DumpAndLogLocals(Desharp.Level.DEBUG);
			Desharp.Debug.Dump(fns);
			Desharp.Debug.Log(fns, Desharp.Level.DEBUG);
		}
		public void TestDelegates() {
			var dels = new Delegates();
			dels.DumpAndLogLocals(Desharp.Level.DEBUG);
			Desharp.Debug.Dump(dels);
			Desharp.Debug.Log(dels, Desharp.Level.DEBUG);
		}
		public void TestReflections() {
			MemberInfo[] members = this.GetType().GetMembers(
				BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public
			);
			Desharp.Debug.Dump(members);
			Desharp.Debug.Log(members, Desharp.Level.DEBUG);
		}
		public void TestCustomClasses() {
			var employe = new DumpingAndLogings.CustomClasses.Persons.Employe {
				Id = null,
				FirstName = "Tom",
				SecondName = "Flidr",
				Description = "dev ops",
				IdDepartment = 1,
				Salary = 0
			};
			Desharp.Debug.Dump(employe);
			Desharp.Debug.Log(employe, Desharp.Level.DEBUG);
		}
		public void TestAnonymous() {
			dynamic obj1 = new {
				name = "Tom",
				surname = "Flidr",
				age = 33
			};
			object obj2 = new { };
			var obj3 = new {
				name = "Tom",
				surname = "Flidr",
				age = 33
			};
			Desharp.Debug.Dump(obj1, obj2, obj3);
			Desharp.Debug.Log(new object[] { obj1, obj2, obj3 }, Desharp.Level.DEBUG);
		}
	}
}