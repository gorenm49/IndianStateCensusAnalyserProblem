using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IndianStateCensusAnalyserProblem.POCOCLass;

namespace IndianStateCensusAnalyserProblem
{
    public class IndianCensusAdapter : CensusAdapter
    {
        string[] censusData;
        Dictionary<string, CensusOperation> dataMap;
        public Dictionary<string, CensusOperation> LoadCensusData(string csvFilePath, string dataHeaders)
        {
            dataMap = new Dictionary<string, CensusOperation>();
            censusData = GetCensusData(csvFilePath, dataHeaders);

            foreach (string data in censusData.Skip(1))
            {
                if (!data.Contains(","))
                {
                    throw new CensusAnalyserException("File Contains wrong delimiter ", CensusAnalyserException.ExceptionType.INVALID_DELIMITER);
                }
                string[] column = data.Split(",");
                if (csvFilePath.Contains("IndiaStateCode.csv"))
                {
                    dataMap.Add(column[1], new CensusOperation(new StateCodeDAO(column[0], column[1], column[2], column[3])));
                }
                if (csvFilePath.Contains("IndianStateCensusData.csv"))
                {
                    dataMap.Add(column[0], new CensusOperation(new CensusDataDAO(column[0], column[1], column[2], column[3])));
                }
                if (csvFilePath.Contains("IndianStateCode.csv"))
                {
                    dataMap.Add(column[0], new CensusOperation(new StateCodeDAO(column[0], column[1], column[2], column[3])));
                }
            }
            return dataMap.ToDictionary(p => p.Key, p => p.Value);
        }
    }
}
