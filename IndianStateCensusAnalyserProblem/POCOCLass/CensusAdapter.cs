using System;
using System.Collections.Generic;
using System.Text;
using IndianStateCensusAnalyserProblem;
using System.IO;

namespace IndianStateCensusAnalyserProblem.POCOCLass
{
    public abstract class CensusAdapter
    {
        protected string[] GetCensusData(string csvFilePath, string dataHeaders)
        {
            string[] censusData;

            if (!File.Exists(csvFilePath))
            {
                throw new CensusAnalyserException("File not Found ", CensusAnalyserException.ExceptionType.FILE_NOT_FOUND);
            }
            if (Path.GetExtension(csvFilePath)!= ".csv")
            {
                throw new CensusAnalyserException("Invalid File Type ", CensusAnalyserException.ExceptionType.INVALID_FILE_TYPE);
            }
            censusData = File.ReadAllLines(csvFilePath);

            if (censusData[0] != dataHeaders)
            {
                    throw new CensusAnalyserException("Incorrect Header in data ", CensusAnalyserException.ExceptionType.INCORRECT_HEADER_DATA);
            }
            return censusData;
        }
    }
}
