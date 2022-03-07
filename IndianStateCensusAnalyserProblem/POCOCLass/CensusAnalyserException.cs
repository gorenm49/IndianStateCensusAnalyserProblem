using System;
using System.Collections.Generic;
using System.Text;
using IndianStateCensusAnalyserProblem;

namespace IndianStateCensusAnalyserProblem.POCOCLass
{
    public class CensusAnalyserException : Exception
    {
        public enum ExceptionType
        { 
            FILE_NOT_FOUND, INVALID_DELIMITER, INVALID_FILE_TYPE, INCORRECT_HEADER_DATA, NO_SUCH_COUNTRY
        }

        public ExceptionType eType;

        public CensusAnalyserException(string message, ExceptionType exceptionType) : base(message)
        {
            this.eType = exceptionType;
        }
    }
}
