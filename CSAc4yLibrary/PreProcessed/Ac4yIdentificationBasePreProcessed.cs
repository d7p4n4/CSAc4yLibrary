
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GuidLibrary;

namespace d7p4n4.PreProcessed.Class
{
	            [GUID("22bd598f-3830-4c5c-93e8-163b7196637c")]
	public class Ac4yIdentificationBasePreProcessed 

	{
    		public Int32 id { get; set; }
    		public String GUID { get; set; }
    		public String HumanId { get; set; }
    		public String PublicHumanId { get; set; }
    		public DateTime CreatedAt { get; set; }
    		public String UpdatedAt { get; set; }
		
		public Ac4yIdentificationBasePreProcessed()
		{
			GUID = "22bd598f-3830-4c5c-93e8-163b7196637c";
		}
	}
}