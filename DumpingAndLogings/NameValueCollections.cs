using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Desharp.Tests.DumpingAndLogings {
	class NameValueCollections {
		NameValueCollection nameValColl = new NameValueCollection() {
			{ "name",	"Paul" },
			{ "surname","McCartney" },
			{ "age",	Int64.MaxValue.ToString()},
			{ "more",	null}
		};
		HybridDictionary hybridDct = new HybridDictionary(2, false) {
			{ "apple", 1 },
			{ "Banana", 2 },
			{ "melon", null },
		};
		StringCollection strColl = new StringCollection() {
			"one", "two", "three", "go", null
		};
	}
}
