using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KACAT_data_processing
{
    internal class ArduinoSim
    {
        // GPS data
        private double lat, lon, altitude, hGeoid;
        private char latDir, lonDir, altitudeUnit, hGeoidUnit;
        private string gpsIdentifier = "$GPGGA";
        private char checksumEnd = '*';

        public ArduinoSim()
        {

        }
    }
}
