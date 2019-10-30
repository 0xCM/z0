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
        /// Partitions an 8-bit unsigned integer into a pair of unsigned 8-bit integers
        /// (x0, x1), wich with a maximum value of 0xF, that repectively represent the lo and hi bits of the source where
        /// x0 := src[0..3] and x1 = src[4..7] 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="x0">Taken from bits 0-15 of the source value</param>
        /// <param name="x1">Taken from bits 16-31 of the source value</param>
        [MethodImpl(Inline)]
        public static void split(byte src, out byte x0, out byte x1)
        {
            x0 = (byte)(src &0xF);
            x1 = (byte)(src >> 4);
        }        

        /// <summary>
        /// Partitions a 16-bit signed integer into a pair of signed 8-bit integers
        /// (x0, x1) that repectively represent the lo and hi bits of the source where
        /// x0 := src[0..7] and x1 = src[8..15] 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="x0">Taken from bits 0-15 of the source value</param>
        /// <param name="x1">Taken from bits 16-31 of the source value</param>
        [MethodImpl(Inline)]
        public static (sbyte x0, sbyte x1) split(short src, N2 parts = default)
            => (lo(src), hi(src));

        /// <summary>
        /// Partitions a 16-bit unsigned integer into a pair of unsigned 8-bit integers
        /// (x0, x1) that repectively represent the lo and hi bits of the source where
        /// x0 := src[0..7] and x1 = src[8..15] 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="x0">Taken from bits 0-15 of the source value</param>
        /// <param name="x1">Taken from bits 16-31 of the source value</param>
        [MethodImpl(Inline)]
        public static void split(ushort src, out byte x0, out byte x1)
        {
            x0 = (byte)src;
            x1 = (byte)(src >>8);
        }

        /// <summary>
        /// Partitions a 32-bit signed integer into a pair of signed 16-bit signed integers
        /// (x0, x1) that respectively represent the lo and hi bits of the source where
        /// x0 := src[0..15] and x1 = src[16..31] 
        /// <param name="src">The source value</param>
        /// <param name="x0">Taken from bits 0-31 of the source value</param>
        /// <param name="x1">Taken from bits 32-63 of the source value</param>
        [MethodImpl(Inline)]
        public static (short x0, short x1) split(int src, N2 parts = default)
          => (lo(src), hi(src));


        /// <summary>
        /// Partitions a 32-bit unsigned integer into a pair of unsigned 16-bit integers
        /// (x0, x1) that respectively represent the lo and hi bits of the source where
        /// x0 := src[0..15] and x1 = src[16..31] 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="x0">Taken from bits 0-15 of the source value</param>
        /// <param name="x1">Taken from bits 16-31 of the source value</param>
        [MethodImpl(Inline)]
        public static void split(uint src, out ushort x0, out ushort x1)
        {
            x0 = (ushort)(src); 
            x1 = (ushort)(src >> 16);
        }

        /// <summary>
        /// Partitions a 64-bit signed integer into a pair of signed 32-bit integers
        /// (x0, x1) that respectively represent the lo and hi bits of the source where
        /// x0 := src[0..31] and x1 = src[32..63] 
        /// <param name="src">The source value</param>
        /// <param name="x0">Taken from bits 0-31 of the source value</param>
        /// <param name="x1">Taken from bits 32-63 of the source value</param>
        [MethodImpl(Inline)]
        public static void split(long src, out int x0, out int x1)
        {
            x0 = lo(src);
            x1 = hi(src);
        }

        /// <summary>
        /// Partitions a 64-bit unsigned integer into a pair of unsigned 32-bit integers
        /// (x0, x1) respectively represent the lo and hi bits of the source where
        /// x0 := src[0..31] and x1 = src[32..63] 
        /// <param name="src">The source value</param>
        /// <param name="x0">Taken from bits 0-31 of the source value</param>
        /// <param name="x1">Taken from bits 32-63 of the source value</param>
        [MethodImpl(Inline)]
        public static void split(ulong src, out uint x0, out uint x1)
        { 
            x0 = (uint)src;
            x1 = (uint)(src >> 32);
        }

        /// <summary>
        /// Partitions a 32-bit unsigned integer int four unsigned 8-bit integers (x0,x1,x2,x3) where
        /// x0:=src[0..7], x1:=src[8..15], x2:=[16..23] and x3:=[24..31]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="x0">Taken from bits 0-7 of the source value</param>
        /// <param name="x1">Taken from bits 8-15 of the source value</param>
        /// <param name="x2">Taken from bits 16-23 of the source value</param>
        /// <param name="x3">Taken from bits 24-31 of the source value</param>
        [MethodImpl(Inline)]
        public static void split(uint src, out byte x0, out byte x1, out byte x2, out byte x3)
        {
            x0 = (byte)(src >> 0*8);
            x1 = (byte)(src >> 1*8);
            x2 = (byte)(src >> 2*8);
            x3 = (byte)(src >> 3*8);
        }

        /// <summary>
        /// Partitions a 64-bit unsigned integer int eight unsigned 8-bit integers
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="x0">Taken from bits 0-7 of the source value</param>
        /// <param name="x1">Taken from bits 8-15 of the source value</param>
        /// <param name="x2">Taken from bits 16-23 of the source value</param>
        /// <param name="x3">Taken from bits 24-31 of the source value</param>
        /// <param name="x4">Taken from bits 32-39 of the source value</param>
        /// <param name="x5">Taken from bits 40-47 of the source value</param>
        /// <param name="x6">Taken from bits 48-57 of the source value</param>
        /// <param name="x7">Take from bits 58-63 of the source value</param>
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