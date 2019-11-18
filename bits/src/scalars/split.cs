//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static Constants;
    
    partial class Bits
    {                        
        /// <summary>
        /// Partitions an 8-bit source upper and lower parts, each with an effective width of 4 bits
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="x0">Taken from bits 0-3 of the source value</param>
        /// <param name="x1">Taken from bits 4-7 of the source value</param>
        [MethodImpl(Inline)]
        public static void split(byte src, out byte x0, out byte x1)
        {
            x0 = (byte)(src &0xF);
            x1 = (byte)(src >> 4);
        }        


        /// <summary>
        /// Partitions a 16-bit source value into upper and lower 8-bit parts
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="x0">Receives source bits [0..7]</param>
        /// <param name="x1">Receives source bits [8..15]</param>
        [MethodImpl(Inline)]
        public static void split(ushort src, out byte x0, out byte x1)
        {
            x0 = (byte)src;
            x1 = (byte)(src >>8);
        }

        /// <summary>
        /// Partitions a 32-bit source value into upper and lower 16-bit parts
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="x0">Receives source bits [0..15]</param>
        /// <param name="x1">Receives source bits [16..31]</param>
        [MethodImpl(Inline)]
        public static void split(uint src, out ushort x0, out ushort x1)
        {
            x0 = (ushort)(src); 
            x1 = (ushort)(src >> 16);
        }

        /// <summary>
        /// Partitions a 64-bit source value into upper and lower 32-bit parts
        /// <param name="src">The source value</param>
        /// <param name="x0">Receives source bits [0..31]</param>
        /// <param name="x1">Receives source bits [32..63]</param>
        [MethodImpl(Inline)]
        public static void split(ulong src, out uint x0, out uint x1)
        { 
            x0 = (uint)src;
            x1 = (uint)(src >> 32);
        }

        /// <summary>
        /// Partitions a 64-bit source value into 4 16-bit parts
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="x0">Receives source bits [0..15]</param>
        /// <param name="x1">Receives source bits [16..31]</param>
        /// <param name="x2">Receives source bits [32..47]</param>
        /// <param name="x3">Receives source bits [48..63]</param>
        [MethodImpl(Inline)]
        public static void split(ulong src, out ushort x0, out ushort x1, out ushort x2, out ushort x3)
        { 
            x0 = (ushort)src;
            x1 = (ushort)(src >> 16);
            x2 = (ushort)(src >> 32);
            x3 = (ushort)(src >> 48);
        }

        /// <summary>
        /// Partitions a 32-bit source value into 4 8-bit parts
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="x0">Receives source bits [0..7]</param>
        /// <param name="x1">Receives source bits [8..15]</param>
        /// <param name="x2">Receives source bits [16..23]</param>
        /// <param name="x3">Receives source bits [24..31]</param>
        [MethodImpl(Inline)]
        public static void split(uint src, out byte x0, out byte x1, out byte x2, out byte x3)
        {
            x0 = (byte)(src >> 0*8);
            x1 = (byte)(src >> 1*8);
            x2 = (byte)(src >> 2*8);
            x3 = (byte)(src >> 3*8);
        }

        /// <summary>
        /// Partitions a 32-bit source value into 8 8-bit parts
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="x0">Receives source bits [0..7]</param>
        /// <param name="x1">Receives source bits [8..15]</param>
        /// <param name="x2">Receives source bits [16..23]</param>
        /// <param name="x3">Receives source bits [24..31]</param>
        /// <param name="x4">Receives source bits [32..39]</param>
        /// <param name="x5">Receives source bits [40..47]</param>
        /// <param name="x6">Receives source bits [48..55]</param>
        /// <param name="x7">Receives source bits [56..63]</param>
        [MethodImpl(Inline)]
        public static void split(ulong src, out byte x0, out byte x1, out byte x2, out byte x3, out byte x4, out byte x5, out byte x6, out byte x7)
        {
            x0 = (byte)(src >> 0*8);
            x1 = (byte)(src >> 1*8);
            x2 = (byte)(src >> 2*8);
            x3 = (byte)(src >> 3*8);
            x4 = (byte)(src >> 4*8);
            x5 = (byte)(src >> 5*8);
            x6 = (byte)(src >> 6*8);
            x7 = (byte)(src >> 7*8);
        }
    }
}