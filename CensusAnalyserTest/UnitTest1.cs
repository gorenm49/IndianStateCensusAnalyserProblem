using NUnit.Framework;
using IndianStateCensusAnalyserProblem.POCOCLass;
using System.Collections.Generic;

namespace CensusAnalyserTest
{
    public class Tests
    {
        public string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";
        public string indianStateCodeHeaders = "SrNo,StateName,TIN,StateCode";
        public string indianStatecensusFilePath = @"C:\Users\Nityanand Gore\source\repos\IndianStateCensusAnalyserProblem\CensusAnalyserTest\CSVFiles\IndianStateCensusData.csv";
        public string wrongHeaderIndianCensusFilePath = @"C:\Users\Nityanand Gore\source\repos\IndianStateCensusAnalyserProblem\CensusAnalyserTest\CSVFiles\WrongIndianStateCensusData.csv";
        public string delimiterIndianCensusFilePath = @"C:\Users\Nityanand Gore\source\repos\IndianStateCensusAnalyserProblem\CensusAnalyserTest\CSVFiles\DelimiterIndiaStateCensusData.csv";
        public string wrongIndianStateCensusFilePath = @"C:\Users\Nityanand Gore\source\repos\IndianStateCensusAnalyserProblem\CensusAnalyserTest\CSVFiles\IndiaData.csv";
        public string wrongIndianStateCensusFileType = @"C:\Users\Nityanand Gore\source\repos\IndianStateCensusAnalyserProblem\CensusAnalyserTest\CSVFiles\IndianStateCensusData.txt";
        public string indianStateCodeFilePath = @"C:\Users\Nityanand Gore\source\repos\IndianStateCensusAnalyserProblem\CensusAnalyserTest\CSVFiles\IndianStateCode.csv";
        public string wrongIndianStateCodeFileType = @"C:\Users\Nityanand Gore\source\repos\IndianStateCensusAnalyserProblem\CensusAnalyserTest\CSVFiles\IndianStateCode.txt";
        public string delimiterIndianStateCodeFilePath = @"C:\Users\Nityanand Gore\source\repos\IndianStateCensusAnalyserProblem\CensusAnalyserTest\CSVFiles\DelimiterIndiaStateCode.csv";
        public string wrongHeaderStateCodeFilePath = @"C:\Users\Nityanand Gore\source\repos\IndianStateCensusAnalyserProblem\CensusAnalyserTest\CSVFiles\WrongIndianStateCode.csv";

        IndianStateCensusAnalyserProblem.POCOCLass.CensusAnalyser censusAnalyser;
        Dictionary<string, CensusOperation> totalRecord;

        [SetUp]
        public void Setup()
        {
            censusAnalyser = new IndianStateCensusAnalyserProblem.POCOCLass.CensusAnalyser();
            totalRecord = new Dictionary<string, CensusOperation>();
        }

        [Test]
      
        public void GivenIndiaCencusDataFile_ShouldReturn_CensusDataCount()
        {
            totalRecord = censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, indianStatecensusFilePath, indianStateCensusHeaders);
            Assert.AreEqual(6, totalRecord.Count);
        }

        [Test]
        public void GivenWrongIndianCensusDataFile_ShoudReturn_CustomException()
        {
            var censusException = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, wrongIndianStateCensusFilePath, indianStateCensusHeaders));
            Assert.AreEqual(CensusAnalyserException.ExceptionType.FILE_NOT_FOUND, censusException.eType);
        }

        [Test]
        public void GivenIndianCensusDataFileWithWrongFileType_ShoudReturn_CustomException()
        {
            var censusException = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, wrongIndianStateCensusFileType, indianStateCensusHeaders));
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INVALID_FILE_TYPE, censusException.eType);
        }

        [Test]
        public void GivenFileIsCorrectButTheDelimiterIncorrect_ShoudReturn_CustomException()
        {
            var censusException = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, delimiterIndianCensusFilePath, indianStateCensusHeaders));
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INVALID_DELIMITER, censusException.eType);
        }

        [Test]
        public void GivenFileIsCorrectButTheHeaderIsIncorrect_ShoudReturn_CustomException()
        {
            var censusException = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, wrongHeaderIndianCensusFilePath, indianStateCensusHeaders));
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INCORRECT_HEADER_DATA, censusException.eType);
        }

       
    }
}



