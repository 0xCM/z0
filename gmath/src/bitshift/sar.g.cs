//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed; using static Memories;

    partial class gmath
    {
        /// <summary>
        /// Applies an arithmetic left-shift to an integer
        /// </summary>
        /// <param name="src">The value to shift</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <typeparam name="T">The primal integer type</typeparam>
        [MethodImpl(Inline), Sra, Closures(Integers)]
        public static T sar<T>(T src, byte offset)
            where T : unmanaged
                => sar_u(src,offset);

        [MethodImpl(Inline)]
        static T sar_u<T>(T src, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.sar(uint8(src), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.sar(uint16(src), offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.sar(uint32(src), offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.sar(uint64(src), offset));
            else
                return sar_i(src,offset);
        }

        [MethodImpl(Inline)]
        static T sar_i<T>(T src, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.sar(int8(src), offset));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.sar(int16(src), offset));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.sar(int32(src), offset));
            else if(typeof(T) == typeof(long))
                 return generic<T>(math.sar(int64(src), offset));
            else
                throw Unsupported.define<T>();
        }
    }
}