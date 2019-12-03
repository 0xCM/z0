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
        /// Enables an identified source bit
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The 0-based index of the bit to change</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static T enable<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return enableu(src,pos);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return enablei(src,pos);
            else 
                return enablef(src,pos);
        }

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
            src = enable(src,pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        static T enablei<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(BitMask.enable(int8(src), pos));
            else if(typeof(T) == typeof(short))
                 return generic<T>(BitMask.enable(int16(src), pos));
            else if(typeof(T) == typeof(int))
                 return generic<T>(BitMask.enable(int32(src), pos));
            else 
                 return generic<T>(BitMask.enable(int64(src), pos));
        }

        [MethodImpl(Inline)]
        static T enableu<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return generic<T>(BitMask.enable(uint8(src), pos));
            else if(typeof(T) == typeof(ushort))
                 return generic<T>(BitMask.enable(uint16(src), pos));
            else if(typeof(T) == typeof(uint))
                 return generic<T>(BitMask.enable(uint32(src), pos));
            else 
                 return generic<T>(BitMask.enable(uint64(src), pos));
            
        }

        [MethodImpl(Inline)]
        static T enablef<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return generic<T>(BitMask.enable(float32(src), pos));
            else if(typeof(T) == typeof(double))
                 return generic<T>(BitMask.enable(float64(src), pos));
            else
                throw unsupported<T>();
        }
         
    }
}