
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using d7p4n4.Final.Class;
using GuidLibrary;

namespace d7p4n4.PreProcessed.Class
{
	            [GUID("84ba506f-bdc4-4574-9595-91af0ca7f1ac")]
	public class Ac4yPersistentPreProcessed : Ac4y

	{
    		public Ac4yIdentification Ac4yIdentification { get; set; }
    		public Int32 id { get; set; }
    		public string GUID { get; set; }
		
		public Ac4yPersistentPreProcessed()
		{
			GUID = "84ba506f-bdc4-4574-9595-91af0ca7f1ac";
		}
	}
}