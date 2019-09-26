using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace Desharp.Tests.DumpingAndLogings {
	class Collections {
		dynamic SampleObject = new ExpandoObject(); 
		BitArray BitArr = new BitArray( 5, false );
		public Collections () {
			this.SampleObject.sampleInt = 5; 
			this.SampleObject.sampleStr = "abc";
			this.SampleObject.sampleEvent = null; 
			this.SampleObject.sampleEvent += new EventHandler(SampleHandler); 
			this.SampleObject.sampleEvent(this.SampleObject, new EventArgs());  
		}
		static void SampleHandler(object sender, EventArgs e) {
		}
	}
}
