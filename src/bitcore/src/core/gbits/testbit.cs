//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    partial class gbits
    {        
        /// <summary>
        /// Returns 1 if an index-identified bit is enabled, false otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="pos">The bit index to chech</param>
        [MethodImpl(Inline), TestBit, Closures(Integers)]
        public static bit testbit<T>(T src, byte pos)
            where T : unmanaged
                => testbit_u(src,pos);

        [MethodImpl(Inline)]
        static bit testbit_u<T>(T src, byte pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return Bits.testbit(uint8(src), pos);
            else if(typeof(T) == typeof(ushort))
                 return Bits.testbit(uint16(src), pos);
            else if(typeof(T) == typeof(uint))
                 return Bits.testbit(uint32(src), pos);
            else if(typeof(T) == typeof(ulong))
                 return Bits.testbit(uint64(src), pos);
            else
                return testbit_i(src,pos);
        }

        [MethodImpl(Inline)]
        static bit testbit_i<T>(T src, byte pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return Bits.testbit(int8(src), pos);
            else if(typeof(T) == typeof(short))
                 return Bits.testbit(int16(src), pos);
            else if(typeof(T) == typeof(int))
                 return Bits.testbit(int32(src), pos);
            else if(typeof(T) == typeof(long))
                 return Bits.testbit(int64(src), pos);
            else
                return testbit_f(src,pos);
        }

        [MethodImpl(Inline)]
        static bit testbit_f<T>(T src, byte pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return Bits.testbit(float32(src), pos);
            else if(typeof(T) == typeof(double))
                 return Bits.testbit(float64(src), pos);
            else
                throw Unsupported.define<T>();
        }           
    }
}