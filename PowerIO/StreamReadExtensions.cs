using System;
using System.IO;


namespace PowerIO
{
    public static class StreamReadExtensions
    {
        /// <summary>
        /// Read the given amount of bytes from the stream and return it as a byte array, Blocking until the amount was readed from the stream
        /// </summary>
        /// <param name="stream">Stream to read from</param>
        /// <param name="amount">The amount of bytes to read</param>
        /// <returns>Byte array with the given length (amount)</returns>
        public static byte[] ReadByteArray(this Stream stream, int amount)
        {
            int currentReadAmount, totalReadAmount = 0;
            byte[] buffer = new byte[amount];
            while(amount - totalReadAmount > 0)
            {
                currentReadAmount = stream.Read(buffer, totalReadAmount, amount - totalReadAmount);
                if (currentReadAmount == 0) throw new PowerEndOfStreamException($"Unable to read {{{amount}}} bytes from the stream, only {{{totalReadAmount}}} was readed, successfully", buffer, totalReadAmount);
                totalReadAmount += currentReadAmount;
            }
            return buffer;
        }
        /// <summary>
        /// Read a UInt8 from the given stream
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static byte ReadUInt8(this Stream stream) => stream.ReadByteArray(0)[0];
        public static SByte ReadInt8(this Stream stream) => (SByte)stream.ReadByteArray(0)[0];
    }
}
