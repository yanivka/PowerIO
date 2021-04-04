using System;
using System.Collections.Generic;
using System.Text;

namespace PowerIO.Converter
{
    /// <summary>
    /// Interface for parsing base types from binary in Big-Endian (BE) OR Small-Endian (LE)
    /// </summary>
    public interface IBineryConverter
    {
        /// <summary>
        /// Parsing to UInt16 from the given byte array in Big-Endian
        /// </summary>
        /// <param name="buffer">Byte array to parse from</param>
        /// <param name="offset">Index inside the given buffer to parse from</param>
        /// <returns>UInt16 representation in Big-Endian</returns>
        UInt16 ToUInt16BE(byte[] buffer, int offset);
        /// <summary>
        /// Parsing to Int16 from the given byte array in Big-Endian
        /// </summary>
        /// <param name="buffer">Byte array to parse from</param>
        /// <param name="offset">Index inside the given buffer to parse from</param>
        /// <returns>Int16 representation in Big-Endian</returns>
        Int16 ToInt16BE(byte[] buffer, int offset);
        /// <summary>
        /// Parsing to UInt32 from the given byte array in Big-Endian
        /// </summary>
        /// <param name="buffer">Byte array to parse from</param>
        /// <param name="offset">Index inside the given buffer to parse from</param>
        /// <returns>UInt32 representation in Big-Endian</returns>
        UInt32 ToUInt32BE(byte[] buffer, int offset);
        /// <summary>
        /// Parsing to Int32 from the given byte array in Big-Endian
        /// </summary>
        /// <param name="buffer">Byte array to parse from</param>
        /// <param name="offset">Index inside the given buffer to parse from</param>
        /// <returns>Int32 representation in Big-Endian</returns>
        Int32 ToInt32BE(byte[] buffer, int offset);
        /// <summary>
        /// Parsing to UInt64 from the given byte array in Big-Endian
        /// </summary>
        /// <param name="buffer">Byte array to parse from</param>
        /// <param name="offset">Index inside the given buffer to parse from</param>
        /// <returns>UInt64 representation in Big-Endian</returns>
        UInt64 ToUInt64BE(byte[] buffer, int offset);
        /// <summary>
        /// Parsing to Int64 from the given byte array in Big-Endian
        /// </summary>
        /// <param name="buffer">Byte array to parse from</param>
        /// <param name="offset">Index inside the given buffer to parse from</param>
        /// <returns>Int64 representation in Big-Endian</returns>
        Int64 ToInt64BE(byte[] buffer, int offset);
        /// <summary>
        /// Parsing to Float from the given byte array in Big-Endian
        /// </summary>
        /// <param name="buffer">Byte array to parse from</param>
        /// <param name="offset">Index inside the given buffer to parse from</param>
        /// <returns>Float representation in Big-Endian</returns>
        float ToFloatBE(byte[] buffer, int offset);
        /// <summary>
        /// Parsing to Double from the given byte array in Big-Endian
        /// </summary>
        /// <param name="buffer">Byte array to parse from</param>
        /// <param name="offset">Index inside the given buffer to parse from</param>
        /// <returns>Double representation in Big-Endian</returns>
        double ToDoubleBE(byte[] buffer, int offset);
        /// <summary>
        /// Parsing to UInt16 from the given byte array in Little-Endian
        /// </summary>
        /// <param name="buffer">Byte array to parse from</param>
        /// <param name="offset">Index inside the given buffer to parse from</param>
        /// <returns>UInt16 representation in Little-Endian</returns>
        UInt16 ToUInt16LE(byte[] buffer, int offset);
        /// <summary>
        /// Parsing to Int16 from the given byte array in Little-Endian
        /// </summary>
        /// <param name="buffer">Byte array to parse from</param>
        /// <param name="offset">Index inside the given buffer to parse from</param>
        /// <returns>Int16 representation in Little-Endian</returns>
        Int16 ToInt16LE(byte[] buffer, int offset);
        /// <summary>
        /// Parsing to UInt32 from the given byte array in Little-Endian
        /// </summary>
        /// <param name="buffer">Byte array to parse from</param>
        /// <param name="offset">Index inside the given buffer to parse from</param>
        /// <returns>UInt32 representation in Little-Endian</returns>
        UInt32 ToUInt32LE(byte[] buffer, int offset);
        /// <summary>
        /// Parsing to Int32 from the given byte array in Little-Endian
        /// </summary>
        /// <param name="buffer">Byte array to parse from</param>
        /// <param name="offset">Index inside the given buffer to parse from</param>
        /// <returns>Int32 representation in Little-Endian</returns>
        Int32 ToInt32LE(byte[] buffer, int offset);
        /// <summary>
        /// Parsing to UInt64 from the given byte array in Little-Endian
        /// </summary>
        /// <param name="buffer">Byte array to parse from</param>
        /// <param name="offset">Index inside the given buffer to parse from</param>
        /// <returns>UInt64 representation in Little-Endian</returns>
        UInt64 ToUInt64LE(byte[] buffer, int offset);
        /// <summary>
        /// Parsing to Int64 from the given byte array in Little-Endian
        /// </summary>
        /// <param name="buffer">Byte array to parse from</param>
        /// <param name="offset">Index inside the given buffer to parse from</param>
        /// <returns>Int64 representation in Little-Endian</returns>
        Int64 ToInt64LE(byte[] buffer, int offset);
        /// <summary>Float from the given byte array in Little-Endian
        /// </summary>
        /// <param name="buffer">Byte array to parse from</param>
        /// <param name="offset">Index inside the given buffer to parse from</param>
        /// <returns>Float representation in Little-Endian</returns>
        float ToFloatLE(byte[] buffer, int offset);
        /// <summary>
        /// Parsing to Double from the given byte array in Little-Endian
        /// </summary>
        /// <param name="buffer">Byte array to parse from</param>
        /// <param name="offset">Index inside the given buffer to parse from</param>
        /// <returns>Double representation in Little-Endian</returns>
        double ToDoubleLE(byte[] buffer, int offset);
    }
}
