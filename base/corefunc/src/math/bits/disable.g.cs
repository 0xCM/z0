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
        public static ref T disable<T>(ref T src, byte pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                disableu(ref src,pos);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                disablei(ref src,pos);
            else 
                disablef(ref src,pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T disablei<T>(ref T src, byte pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 BitMask.disable(ref int8(ref src), pos);
            else if(typeof(T) == typeof(short))
                 BitMask.disable(ref int16(ref src), pos);
            else if(typeof(T) == typeof(int))
                 BitMask.disable(ref int32(ref src), pos);
            else 
                 BitMask.disable(ref int64(ref src), pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T disableu<T>(ref T src, byte pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 BitMask.disable(ref uint8(ref src), pos);
            else if(typeof(T) == typeof(ushort))
                 BitMask.disable(ref uint16(ref src), pos);
            else if(typeof(T) == typeof(uint))
                 BitMask.disable(ref uint32(ref src), pos);
            else 
                 BitMask.disable(ref uint64(ref src), pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T disablef<T>(ref T src, byte pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 BitMask.disable(ref float32(ref src), pos);
            else if(typeof(T) == typeof(double))
                 BitMask.disable(ref float64(ref src), pos);
            else
                throw unsupported<T>();
            return ref src;
        }
    }
}