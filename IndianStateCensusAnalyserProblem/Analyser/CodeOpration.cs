using IndianStateCensusAnalyserProblem.POCOCLass;
using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensusAnalyserProblem.Analyser
{
    public class CodeOpration
    {
        public int serialNumber;
        public string stateName;
        public string state;
        public int tin;
        public string stateCode;
        public long population;
        public long area;
        public long density;
        public long hoousingUnits;
        public double totalArea;
        public double waterArea;
        public double populationDensity;
        public double housingDesnsity;

        public CodeOpration(StateCodeDAO stateCodeDao)
        {
            this.serialNumber = stateCodeDao.serialNumber;
            this.stateName = stateCodeDao.stateName;
            this.tin = stateCodeDao.tin;
            this.stateCode = stateCodeDao.stateCode;
        }
    }
}
