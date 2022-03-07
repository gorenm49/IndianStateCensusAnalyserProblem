using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensusAnalyserProblem.POCOCLass
{
    public class CensusOperation
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



        public CensusOperation(StateCodeDAO stateCodeDao)
        {
            this.serialNumber = stateCodeDao.serialNumber;
            this.stateName = stateCodeDao.stateName;
            this.tin = stateCodeDao.tin;
            this.stateCode = stateCodeDao.stateCode;
        }

        public CensusOperation(CensusDataDAO censusDataDao)
        {
            this.state = censusDataDao.state;
            this.population = censusDataDao.population;
            this.area = censusDataDao.area;
            this.density = censusDataDao.density;
        }
    }
}
