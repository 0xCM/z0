//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static As;
    using static AsIn;
    
    partial class gbits
    {

        /// <summary>
        /// Extracts a contiguous range of bits from a primal source inclusively between two index positions
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="rhs">The left bit position</param>
        /// <param name="dst">The right bit position</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T between<T>(T src, byte p0, byte p1)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
                || typeof(T) == typeof(ushort) 
                || typeof(T) == typeof(uint) 
                || typeof(T) == typeof(ulong))
                    return between_u(src,p0,p1);
            else if(typeof(T) == typeof(sbyte) 
                || typeof(T) == typeof(short)
                || typeof(T) == typeof(int) 
                || typeof(T) == typeof(long))
                    return between_i(src,p0,p1);
            else
                    return between_f(src,p0,p1);
        }

        [MethodImpl(Inline)]
        static T between_i<T>(T src, byte p0, byte p1)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(Bits.between(int8(src), p0, p1));
            else if(typeof(T) == typeof(short))
                 return generic<T>(Bits.between(int16(src), p0, p1));
            else if(typeof(T) == typeof(int))
                 return generic<T>(Bits.between(int32(src), p0, p1));
            else 
                 return generic<T>(Bits.between(int64(src), p0, p1));
        }

        [MethodImpl(Inline)]
        static T between_u<T>(T src, byte p0, byte p1)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return generic<T>(Bits.between(uint8(src), p0, p1));
            else if(typeof(T) == typeof(ushort))
                 return generic<T>(Bits.between(uint16(src), p0, p1));
            else if(typeof(T) == typeof(uint))
                 return generic<T>(Bits.between(uint32(src), p0, p1));
            else 
                 return generic<T>(Bits.between(uint64(src), p0, p1));
        }

        [MethodImpl(Inline)]
        static T between_f<T>(T src, byte p0, byte p1)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return generic<T>(Bits.between(float32(src), p0, p1));
            else if(typeof(T) == typeof(double))
                 return generic<T>(Bits.between(float64(src), p0, p1));
            else            
                throw unsupported<T>();
        }

    }

}