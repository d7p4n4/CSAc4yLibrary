using d7p4n4.Final.Class;
using d7p4n4.PreProcessed.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace d7p4n4.Algebra.Class
{
	public class Ac4yObjectAlgebra : Ac4yObjectPreProcessed
	{

		public Ac4yIdentification getAc4yIdentification() {
        		return Ac4yIdentification;
        }

		public Int32 getId() {
        		return id;
        }


    		public void setAc4yIdentification(Ac4yIdentification newValue) {
        		Ac4yIdentification = newValue;
        }

    		public void setId(Int32 newValue) {
        		id = newValue;
        }
	
		public Boolean hasAc4yIdentification(){
			if(this.getAc4yIdentification() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasId(){
			if(this.getId() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

    


	}
}
