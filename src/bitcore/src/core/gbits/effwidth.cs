//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    partial class gbits
    {
        /// <summary>
        /// Defines a mask that disables a sequence of bits
        /// </summary>
        /// <param name="start">The index at which to begin</param>
        /// <param name="count">The number of bits to disable</param>
        /// <typeparam name="T">The primal type over which the mask is defined</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T eraser<T>(byte start, byte count)
            where T : unmanaged
                => gmath.xor(Literals.maxval<T>(), gmath.sll(BitMask.lo<T>(count - 1), start));        
                
        /// <summary>
        /// Computes the minimal number of bits required to represent the source value, the effective width
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static int effwidth<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Bits.effwidth(uint8(src));
            else if(typeof(T) == typeof(ushort))
                return Bits.effwidth(uint16(src));
            else if(typeof(T) == typeof(uint))
                return Bits.effwidth(uint32(src));
            else if(typeof(T) == typeof(ulong))
                return Bits.effwidth(uint64(src));
            else            
                throw Unsupported.define<T>();
        }           
    }
}