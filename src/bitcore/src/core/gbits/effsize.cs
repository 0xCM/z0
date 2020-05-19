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
        /// Computes the minimum number of butes required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), EffWidth, Closures(Integers)]
        public static byte effsize<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Bits.effsize(uint8(src));
            else if(typeof(T) == typeof(ushort))
                return Bits.effsize(uint16(src));
            else if(typeof(T) == typeof(uint))
                return Bits.effsize(uint32(src));
            else if(typeof(T) == typeof(ulong))
                return Bits.effsize_baseline(uint64(src));
            else            
                return effsize_i(src);
        }           

        static byte effsize_i<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return Bits.effsize(int8(src));
            else if(typeof(T) == typeof(short))
                return Bits.effsize(int16(src));
            else if(typeof(T) == typeof(int))
                return Bits.effsize(int32(src));
            else if(typeof(T) == typeof(long))
                return Bits.effsize(int64(src));
            else            
                throw Unsupported.define<T>();
        }           
    }
}