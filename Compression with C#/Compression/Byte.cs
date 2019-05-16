using System;

namespace Compression
{
    //TODO: Think about a better name to resolve the ambiguity between System.Byte and Compression.Byte
    /// <summary>
    /// The Byte methods
    /// </summary>
    static class Byte
    {
        /// <summary>
        /// Converts a value in Byte to the given data unit.
        /// </summary>
        /// <param name="value">The value to convert</param>
        /// <param name="dataUnit">The aimed unit.</param>
        /// <returns>The converted value or -1 in the case of an error.</returns>
        public static long ConvertTo(long value, DataUnits dataUnit)
        {
            switch(dataUnit)
            {
                case DataUnits.Byte:
                    return value;

                case DataUnits.KiloByte:
                    return value / 1024;

                case DataUnits.MegaByte:
                    return value / (1024 * 1024);

                case DataUnits.GigaByte:
                    return value / (1024 * 1024 * 1024);

                default:
                    Console.WriteLine("\n\nError in ConvertByteTo, invalid DataType\n\n");
                    return -1;
            }
        }
    }
}
