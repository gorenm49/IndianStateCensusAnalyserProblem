using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Newtonsoft.Json;
using IndianStateCensusAnalyserProblem.POCOCLass;
using CsvHelper;

namespace IndianStateCensusAnalyserProblem.POCOCLass
{
    public class CensusAnalyser
    {
        public enum Country
        { 
            INDIA, US , BRAZIL    
        }

        

        public Dictionary<string, CensusOperation> LoadCensusData(Country country, string csvFilePath, string dataHeaders)
        {
            Dictionary<string, CensusOperation> dataMap;
            dataMap = new CSVAdapterFactory().LoadCsvData(country, csvFilePath, dataHeaders);
            return dataMap;
        }

     
    }
}
