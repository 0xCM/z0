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
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static sbyte disable(sbyte src, int pos)        
            => (sbyte)(src & (byte)~((sbyte)(1 << pos)));

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static byte disable(byte src, int pos)        
            => (byte)(src & (byte)~((byte)(1 << pos)));

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static short disable(short src, int pos)        
            => (short)(src & (short)~((short)(1 << pos)));

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static ushort disable(ushort src, int pos)        
            => (ushort)(src & (ushort)~((ushort)(1 << pos)));

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static int disable(int src, int pos)        
            => src & ~((1 << pos));

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static uint disable(uint src, int pos)        
            => src & ~((1u << pos));

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static long disable(long src, int pos)        
            => src & ~((1L << pos));

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static ulong disable(ulong src, int pos)        
            => src & ~((1ul << pos));

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static float disable(float src, int pos)
        {
            ref var bits = ref Unsafe.As<float,int>(ref src);
            var m = 1 << pos;
            bits &= ~m;
            return src;
        } 

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static double disable(double src, int pos)
        {
            ref var bits = ref Unsafe.As<double,long>(ref src);
            var m = 1L << pos;
            bits &= ~m;
            return src;
        } 
    }
}