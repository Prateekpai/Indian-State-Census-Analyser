using System.IO;
using System;
using System.Collections.Generic;
namespace IndianStateAnalyser
{
    public class CensusAnalyserException : Exception
    {
        public enum ExceptionType
        {
            FILE_NOT_FOUND, INVALID_FILE_TYPE, INCORRECT_DELIMITER, INCORRECT_HEADER, NO_SUCH_COUNTRY
        }
        public ExceptionType eType;
        public CensusAnalyserException(string message, ExceptionType exceptiontype) : base(message)
        {
            this.eType = exceptiontype;
        }

    }
}
