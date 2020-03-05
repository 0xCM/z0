//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static As;
    using static AsIn;     

    using static Root;    

    public static class Scale
    {
        [MethodImpl(Inline)]
        public static T contract<T>(T src, T max)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(contract(uint8(src),uint8(max)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(contract(uint16(src),(uint16(max))));
            else if(typeof(T) == typeof(uint))
                return generic<T>(contract(uint32(src),(uint32(max))));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(contract(uint64(src),(uint64(max))));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        internal static ulong mulhi(ulong x, ulong y)
            => Bmi2.X64.MultiplyNoFlags(x,y);

        /// <summary>
        /// Evenly projects points from the interval [0,2^8 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline)]
        static byte contract(byte src, byte max)
            => (byte)(((ushort)src * (ushort)max) >> 8);

        /// <summary>
        /// Evenly projects points from the interval [0,2^15 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline)]
        static ushort contract(ushort src, ushort max)
            => (ushort)(((uint)src * (uint)max) >> 16);

        /// <summary>
        /// Evenly projects points from the interval [0,2^31 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline)]
        static uint contract(uint src, uint max)
            => (uint)(((ulong)src * (ulong)max) >> 32);

        /// <summary>
        /// Evenly projects points from the interval [0,2^63 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline)]
        static ulong contract(ulong src, ulong max)
            => Scale.mulhi(src,max);
   }

    public static class ScaleExtend
    {
        /// <summary>
        /// Evenly projects points from the interval [0,2^31 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline)]
        public static uint contract(this uint src, uint max)
            => (uint)(((ulong)src * (ulong)max) >> 32);

        /// <summary>
        /// Evenly projects points from the interval [0,2^63 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline)]
        public static ulong contract(this ulong src, ulong max)
            => Scale.mulhi(src,max); 
    }
}