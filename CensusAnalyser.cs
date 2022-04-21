using System.IO;
using System;
using System.Collections.Generic;
namespace IndianStateAnalyser
{
    public class CensusAnalyser
    {
        public enum Country
        {
            INDIA, US, BRAZIL
        }
        Dictionary<string, Census> datamap;
        public Dictionary<string, Census> LoadCensusData(Country contry, string csvfilepath, string dataHeaders)
        {
            datamap = new Csvdapterfactory().LoadcsvData(country, csvfilepath, dataHeaders);
            return datamap;
        }


    }
}
