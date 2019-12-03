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
    using static AsIn;

    partial class BitMaskG
    {
        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit testbit<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return testu(src,pos);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return testi(src,pos);
            else 
                return testf(src,pos);
        }

        [MethodImpl(Inline)]
        static bit testi<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return BitMask.test(int8(src), pos);
            else if(typeof(T) == typeof(short))
                 return BitMask.test(int16(src), pos);
            else if(typeof(T) == typeof(int))
                 return BitMask.test(int32(src), pos);
            else 
                 return BitMask.test(int64(src), pos);
        }

        [MethodImpl(Inline)]
        static bit testu<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return BitMask.test(uint8(src), pos);
            else if(typeof(T) == typeof(ushort))
                 return BitMask.test(uint16(src), pos);
            else if(typeof(T) == typeof(uint))
                 return BitMask.test(uint32(src), pos);
            else 
                 return BitMask.test(uint64(src), pos);
        }

        [MethodImpl(Inline)]
        static bit testf<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return BitMask.test(float32(src), pos);
            else if(typeof(T) == typeof(double))
                 return BitMask.test(float64(src), pos);
            else
                throw unsupported<T>();
        }
    }
}