
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using d7p4n4.Final.Class;
using GuidLibrary;

namespace d7p4n4.PreProcessed.Class
{
	            [GUID("727f9743-c8ba-4112-8af9-ffa8e5607235")]
	public class Ac4yPreProcessed : Ac4yObject

	{
    		public Ac4yIdentification Ac4yIdentification { get; set; }
    		public Int32 id { get; set; }
    		public string GUID { get; set; }
		
		public Ac4yPreProcessed()
		{
			GUID = "727f9743-c8ba-4112-8af9-ffa8e5607235";
		}
	}
}