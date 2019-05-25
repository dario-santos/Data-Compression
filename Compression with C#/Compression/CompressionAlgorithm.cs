using System.IO;

namespace Compression
{
    abstract class CompressionAlgorithm
    {
        public int MinCompressionLevel { get; }

        public int MaxCompressionLevel { get; }

        public string Extension { get; }

        public CompressionAlgorithm(string extension, int minCompressionLevel = 1, int maxCompressionLevel = 9)
        {
            Extension = extension;
            MinCompressionLevel = minCompressionLevel;
            MaxCompressionLevel = maxCompressionLevel;
        }

        public abstract void Compress(FileInfo fInput, DataUnits dataUnit);

        public abstract void Decompress(string fInput);
    }
}
