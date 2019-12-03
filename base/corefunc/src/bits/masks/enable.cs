//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;

    partial class BitMask
    {        
        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public static sbyte enable(sbyte src, int pos)
            =>  src |= (sbyte)(1 << pos);
            
        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public static byte enable(byte src, int pos)
            =>  src |= (byte)(1 << pos);

        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public static short enable(short src, int pos)
            =>  src |= (short)(1 << pos);
            
        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public static ushort enable(ushort src, int pos)
            =>  src |= (ushort)(1 << pos);

        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public static int enable(int src, int pos)
            =>  src |= (1 << pos);

        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public static uint enable(uint src, int pos)
            =>  src |= (1u << pos);

        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public static long enable(long src, int pos)
            =>  src |= (1L << pos);

        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public static ulong enable(ulong src, int pos)
            =>  src |= (1ul << pos);
 
        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public static float enable(float src, int pos)
        {
            var srcBits = BitConverter.SingleToInt32Bits(src);
            srcBits |= 1 << pos;
            src = BitConverter.Int32BitsToSingle(srcBits);            
            return src;
        }

        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public static double enable(double src, int pos)
        {               
            var srcBits = BitConverter.DoubleToInt64Bits(src);
            srcBits |= 1L << pos;
            src = BitConverter.Int64BitsToDouble(srcBits);                           
            return src;
        }
    }
}