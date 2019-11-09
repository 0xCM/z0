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
        /// Inverts a bit at a specified position in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The bit position</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref T toggle<T>(ref T src, byte pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                toggleu(ref src,pos);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                togglei(ref src,pos);
            else 
                togglef(ref src,pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T togglei<T>(ref T src, byte pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 BitMask.toggle(ref int8(ref src), pos);
            else if(typeof(T) == typeof(short))
                 BitMask.toggle(ref int16(ref src), pos);
            else if(typeof(T) == typeof(int))
                 BitMask.toggle(ref int32(ref src), pos);
            else 
                 BitMask.toggle(ref int64(ref src), pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T toggleu<T>(ref T src, byte pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 BitMask.toggle(ref uint8(ref src), pos);
            else if(typeof(T) == typeof(ushort))
                 BitMask.toggle(ref uint16(ref src), pos);
            else if(typeof(T) == typeof(uint))
                 BitMask.toggle(ref uint32(ref src), pos);
            else 
                 BitMask.toggle(ref uint64(ref src), pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T togglef<T>(ref T src, byte pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 BitMask.toggle(ref float32(ref src), pos);
            else if(typeof(T) == typeof(double))
                 BitMask.toggle(ref float64(ref src), pos);
            else
                throw unsupported<T>();
            return ref src;
        }
    }
}