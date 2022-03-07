using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensusAnalyserProblem.POCOCLass
{
    public class CensusDataDAO
    {
        public string state;
        public long population;
        public long area;
        public long density;
        public int srNo;
        public string StateName;
        public string tin;
        public string StateCode;

        public CensusDataDAO(string state, string population, string area, string density)
        {
            this.state = state;
            this.population = Convert.ToUInt32(population);
            this.area = Convert.ToUInt32(area);
            this.density = Convert.ToUInt32(density);
        }

        public CensusDataDAO(int srno, string state, string tin, string stateCode)
        {
            this.srNo = Convert.ToInt32(srno);
            this.StateName = state;
            this.tin = tin;
            this.StateCode = stateCode;
        }
    }
}
