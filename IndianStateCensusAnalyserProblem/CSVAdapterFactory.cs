using System;
using System.Collections.Generic;
using System.Text;
using IndianStateCensusAnalyserProblem.POCOCLass;

namespace IndianStateCensusAnalyserProblem
{
    public class CSVAdapterFactory
    {
        public Dictionary<string, CensusOperation> LoadCsvData(CensusAnalyser.Country country, string csvFilePath, string dataHeaders)
        {
            switch (country)
            {
                case (CensusAnalyser.Country.INDIA):
                    return new IndianCensusAdapter().LoadCensusData(csvFilePath, dataHeaders);
                //case (CensusAnalyser.Country.US):
                //    return new USCensusAdapter().LoadUSCensusData(csvFilePath, dataHeaders);
                default:
                    throw new CensusAnalyserException("No such country", CensusAnalyserException.ExceptionType.NO_SUCH_COUNTRY);
            }
        }
    }
}
