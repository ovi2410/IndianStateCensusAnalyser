using CsvHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensus
{
    public enum StateCensusException
    {
        /// <summary>
        /// state census enuumerations for exception types
        /// </summary>
        wrongcsvfile, IncorrectDelimeter, InvalidHeader, fileNotFound
    }
}
