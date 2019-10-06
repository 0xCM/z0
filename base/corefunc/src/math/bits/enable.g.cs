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
        /// Enables an identified source bit
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The 0-based index of the bit to change</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T enable<T>(ref T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                enableu(ref src,pos);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                enablei(ref src,pos);
            else 
                enablef(ref src,pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T enablei<T>(ref T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 BitMask.enable(ref int8(ref src), pos);
            else if(typeof(T) == typeof(short))
                 BitMask.enable(ref int16(ref src), pos);
            else if(typeof(T) == typeof(int))
                 BitMask.enable(ref int32(ref src), pos);
            else 
                 BitMask.enable(ref int64(ref src), pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T enableu<T>(ref T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 BitMask.enable(ref uint8(ref src), pos);
            else if(typeof(T) == typeof(ushort))
                 BitMask.enable(ref uint16(ref src), pos);
            else if(typeof(T) == typeof(uint))
                 BitMask.enable(ref uint32(ref src), pos);
            else 
                 BitMask.enable(ref uint64(ref src), pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T enablef<T>(ref T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 BitMask.enable(ref float32(ref src), pos);
            else if(typeof(T) == typeof(double))
                 BitMask.enable(ref float64(ref src), pos);
            else
                throw unsupported<T>();
            return ref src;
        }
    }
}