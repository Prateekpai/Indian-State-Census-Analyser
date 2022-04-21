using System.Io;
namespace IndianStateAnalyser
{
    public abstract class CensusAdapter
    {
        protected string[] GetCensusData(string csvfilepath, string dataHeaderes)
        {
            string[] censusData;

            if (!File.Exists(csvfilepath))
            {
                throw new CensusAnalyserException("File Not Found", CensusAnalyserException.ExceptionType.FILE_NOT_FOUND);
            }
            if (Path.GetExtension(csvfilepath) != ".csv")
            {
                throw new CensusAnalyserException("Invalid File Type", CensusAnalyserException.ExceptionType.INVALID_FILE_TYPE);
            }
            censusData = File.ReadAllLines(csvfilepath);

            if (censusData[0] != dataHeaderes)
            {
                throw new CensusAnalyserException("Incorrect Header in Data", CensusAnalyserException.ExceptionType.INCORRECT_HEADER);
            }

            return censusData;
        }


    }
}

