//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    partial class gbits
    {
        /// <summary>
        /// Defines a sequence of N enabled bits, starting from index 0 and extending to index n - 1
        /// </summary>
        /// <typeparam name="N">The enabled bit count type</typeparam>
        [MethodImpl(Inline)]
        public static T lomask<N,T>(N n = default, T t = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => convert<ulong,T>(Bits.lomask(n));

        /// <summary>
        /// Reurns a sequence of N enabled bits, starting from index 0 and extending to index n - 1
        /// </summary>
        [MethodImpl(Inline)]
        public static T lomask<T>(int n)
            where T : unmanaged
                => convert<ulong,T>(Bits.lomask(n));

        /// <summary>
        /// Returns a sequence of enabled hi bits from a specified index through the last bit
        /// </summary>
        /// <param name="n">The position at which to start</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T himask<T>(int n)
            where T : unmanaged
                => convert<ulong,T>(Bits.lomask(bitsize<T>() - n - 1) << bitsize<T>() - n);

        /// <summary>
        /// Defines a mask that disables a sequence of bits
        /// </summary>
        /// <param name="start">The index at which to begin</param>
        /// <param name="count">The number of bits to disable</param>
        /// <typeparam name="T">The primal type over which the mask is defined</typeparam>
        [MethodImpl(Inline)]
        public static T eraser<T>(int start, int count)
            where T : unmanaged
                => gmath.xor(gmath.maxval<T>(), gmath.sll(gbits.lomask<T>(count - 1), start));

        /// <summary>
        /// Logically equivalent to the composite operation (src-1) ^ src that enables the 
        /// lower bits of the source up to and including the least set bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static T blsmsk<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.blsmsk(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.blsmsk(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.blsmsk(uint32(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.blsmsk(uint64(src)));
            else            
                throw unsupported<T>();
        }           

    }

}