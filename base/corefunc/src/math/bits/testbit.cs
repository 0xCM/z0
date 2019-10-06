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

    /// <summary>
    /// Defines generic bitmask functions that parameterize those defined in <see cref='BitMask'/>
    /// </summary>
    partial class BitMaskG
    {

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool testbit<T>(in T src, int pos)
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
        static bool testi<T>(in T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return BitMask.test(in int8(in src), pos);
            else if(typeof(T) == typeof(short))
                 return BitMask.test(in int16(in src), pos);
            else if(typeof(T) == typeof(int))
                 return BitMask.test(in int32(in src), pos);
            else 
                 return BitMask.test(in int64(in src), pos);
        }

        [MethodImpl(Inline)]
        static bool testu<T>(in T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return BitMask.test(in uint8(in src), pos);
            else if(typeof(T) == typeof(ushort))
                 return BitMask.test(in uint16(in src), pos);
            else if(typeof(T) == typeof(uint))
                 return BitMask.test(in uint32(in src), pos);
            else 
                 return BitMask.test(in uint64(in src), pos);
        }

        [MethodImpl(Inline)]
        static bool testf<T>(in T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return BitMask.test(in float32(in src), pos);
            else if(typeof(T) == typeof(double))
                 return BitMask.test(in float64(in src), pos);
            else
                throw unsupported<T>();
        }




    }

}