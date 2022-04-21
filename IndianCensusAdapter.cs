using System;
using System.Collections.Generics;
using System.Linq;

namespace IndianStateAnalyser
{
    public class IndianCensusAdapter : CensusAdapter
    {
        string[] censusData;
        Dictionary <string, Census> datamap;
        public Dictionary<string, Census> LoadCensusData(string csvfilepath, string dataHeaderes)
        {
            datamap = new Dictionary<string, Census>();
            censusData = GetCensusData(csvfilepath, dataHeaderes);
            foreach (string data in censusData.Skip(1))
            {
                if (!data.Contains (","))
                {
                    throw new CensusAnalyserException("File Contains Wrong Delimeter", CensusAnalyserException);
                }
                string[] column = data.Split(",");
                if (csvfilepath.Contains("IndiaStateCode.csv"))
                    datamap.Add(column[1], new Census(new StateCode(column[0], column[1], column[2], column[3])));
                if (csvfilepath.Contains("IndiaStateCensusCode.csv"))
                    datamap.Add(column[1], new Census(new StateCode(column[0], column[1], column[2], column[3])));
            }
            return datamap.ToDictionary(p => p.Key, p =.p.Value);
        }

    }
}
