//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class gbits
    {
        /// <summary>
        /// Returns 1 if an index-identified bit is enabled, false otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="pos">The bit index to check</param>
        [MethodImpl(Inline), TestBit, Closures(Integers)]
        public static Bit32 testbit32<T>(T src, byte pos)
            where T : unmanaged
                => testbit_u32(src,pos);

        [MethodImpl(Inline)]
        static Bit32 testbit_u32<T>(T src, byte pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return Bits.testbit32(uint8(src), pos);
            else if(typeof(T) == typeof(ushort))
                 return Bits.testbit32(uint16(src), pos);
            else if(typeof(T) == typeof(uint))
                 return Bits.testbit32(uint32(src), pos);
            else if(typeof(T) == typeof(ulong))
                 return Bits.testbit32(uint64(src), pos);
            else
                return testbit_i32(src,pos);
        }

        [MethodImpl(Inline)]
        static Bit32 testbit_i32<T>(T src, byte pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return Bits.testbit32(int8(src), pos);
            else if(typeof(T) == typeof(short))
                 return Bits.testbit32(int16(src), pos);
            else if(typeof(T) == typeof(int))
                 return Bits.testbit32(int32(src), pos);
            else if(typeof(T) == typeof(long))
                 return Bits.testbit32(int64(src), pos);
            else
                return testbit_f32(src,pos);
        }

        [MethodImpl(Inline)]
        static Bit32 testbit_f32<T>(T src, byte pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return Bits.testbit32(float32(src), pos);
            else if(typeof(T) == typeof(double))
                 return Bits.testbit32(float64(src), pos);
            else
                throw no<T>();
        }
    }
}