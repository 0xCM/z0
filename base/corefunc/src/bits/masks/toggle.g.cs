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
    /// Defines generic bitmask functions
    /// </summary>
    partial class BitMaskG
    {
        /// <summary>
        /// Inverts an index-identified source bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The bit position</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T toggle<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return toggleu(src,pos);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return togglei(src,pos);
            else 
                return togglef(src,pos);
            
        }

        /// <summary>
        /// Inverts a bit at a specified position in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The bit position</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref T toggle<T>(ref T src, int pos)
            where T : unmanaged
        {
            src = toggle(src,pos);
            return ref src;
        }


        [MethodImpl(Inline)]
        static T togglei<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(BitMask.toggle(int8(src), pos));
            else if(typeof(T) == typeof(short))
                 return generic<T>(BitMask.toggle(int16(src), pos));
            else if(typeof(T) == typeof(int))
                 return generic<T>(BitMask.toggle(int32(src), pos));
            else 
                 return generic<T>(BitMask.toggle(int64(src), pos));
        }

        [MethodImpl(Inline)]
        static T toggleu<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return generic<T>(BitMask.toggle(uint8(src), pos));
            else if(typeof(T) == typeof(ushort))
                 return generic<T>(BitMask.toggle(uint16(src), pos));
            else if(typeof(T) == typeof(uint))
                 return generic<T>(BitMask.toggle(uint32(src), pos));
            else 
                 return generic<T>(BitMask.toggle(uint64(src), pos));
        }

        [MethodImpl(Inline)]
        static T togglef<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return generic<T>(BitMask.toggle(float32(src), pos));
            else if(typeof(T) == typeof(double))
                 return generic<T>(BitMask.toggle(float64(src), pos));
            else
                throw unsupported<T>();
        }
         
    }
}