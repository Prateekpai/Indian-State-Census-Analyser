using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateAnalyser
{
    public class Census
    {
        public int serialNumber;
        public string stateName;
        public string state;
        public int tin;
        public string stateCode;
        public long population;
        public long area;
        public long density;
        public double housingUnits;
        public double totalArea;
        public double waterArea;
        public double landArea;
        public double populationDensity;
        public double housingDensity;

        public Census(StateCode stateCode)
        {
            this.serialNumber = stateCode.serialNumber;
            this.stateName = stateCode.stateName;
            this.tin = stateCode.tin;
            this.stateCode = stateCode.statecode;
        }

        public Census(CenusData cenusData)
        {
            this.state = cenusData.state;
            this.population = cenusData.population;
            this.area = cenusData.area;
            this.density = cenusData.density;

        }
    }
}
