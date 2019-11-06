
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using d7p4n4.Final.Class;
using GuidLibrary;

namespace d7p4n4.PreProcessed.Class
{
	            [GUID("854f54b3-1763-4edf-82f5-f7dee660c487")]
	public class Ac4yIdentificationPreProcessed : Ac4yIdentificationBase

	{
    		public Ac4yIdentificationBase template { get; set; }
    		public Int32 id { get; set; }
    		public String GUID { get; set; }
    		public String HumanId { get; set; }
    		public String PublicHumanId { get; set; }
    		public DateTime CreatedAt { get; set; }
    		public String UpdatedAt { get; set; }
		
		public Ac4yIdentificationPreProcessed()
		{
			GUID = "854f54b3-1763-4edf-82f5-f7dee660c487";
		}
	}
}