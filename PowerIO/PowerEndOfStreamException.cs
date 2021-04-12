using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PowerIO
{
    /// <summary>
    /// Same as EndOfStreamException with additional data that was successfully read from the stream
    /// </summary>
    public class PowerEndOfStreamException:EndOfStreamException
    {
        /// <summary>
        /// A byte array that was allocated to read from the stream with the data that was successfully read from the stream
        /// </summary>
        public readonly byte[] Buffer;
        /// <summary>
        /// The amount of data that was successfully read from the stream and stored in the Buffer field
        /// </summary>
        public readonly int BufferDataLength;
        public PowerEndOfStreamException(string message, byte[] buffer, int bufferDataLength) : base(message)
        {
            this.Buffer = buffer;
            this.BufferDataLength = bufferDataLength;
        }
    }
}
