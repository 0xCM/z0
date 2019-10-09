//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Bmi1;
    using static System.Runtime.Intrinsics.X86.Bmi1.X64;
 
    using static zfunc;
    
    partial class Bits
    {               
        /// <summary>
        /// Extracts the upper 4 bits from the source
        /// </summary>
        /// <param name="src">The soruce value</param>
        [MethodImpl(Inline)]        
        public static sbyte hi(sbyte src)
            => (sbyte)(src >> 4);

        /// <summary>
        /// Extracts the upper 4 bits from the source
        /// </summary>
        /// <param name="src">The soruce value</param>
        [MethodImpl(Inline)]
        public static byte hi(byte src)
            => (byte)(src >> 4);

        /// <summary>
        /// Extracts the upper 8 bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static sbyte hi(short src)
            => (sbyte)(src >> 8);            

        /// <summary>
        /// Extracts the upper 8 bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte hi(ushort src)
            => (byte)(src >> 8);

        /// <summary>
        /// Extracts the upper 16 bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static short hi(int src)
            => (short)(src >> 16);

        /// <summary>
        /// Extracts the upper 16 bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ushort hi(uint src)
            => (ushort)(src >> 16); 

        /// <summary>
        /// Extracts the upper 16 bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int hi(long src)
            => (int)(src >> 32);

        /// <summary>
        /// Extracts the upper 16 bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static uint hi(ulong src)
            => (uint)(src >> 32);

        [MethodImpl(Inline)]
        public static ref ushort puthi(byte src, ref ushort dst)
        {
            dst = (ushort)(bzhi(ref dst,8) | ((ushort)src << 8));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref uint puthi(ushort src, ref uint dst)
        {
            dst = bzhi(ref dst,16) | ((uint)src << 16);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ulong puthi(uint src, ref ulong dst)
        {
            dst = bzhi(ref dst,32) | ((ulong)src << 32);
            return ref dst;
        }

    }

}