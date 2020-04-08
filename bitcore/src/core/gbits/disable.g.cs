//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    partial class gbits
    {                
        /// <summary>
        /// Disables an identified source bit
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The 0-based index of the bit to change</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(NumericKind.All)]
        public static T disable<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return disable_u(src,pos);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return disable_i(src,pos);
            else 
                return disable_f(src,pos);            
        }

        [MethodImpl(Inline)]
        static T disable_i<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(Bits.disable(int8(src), pos));
            else if(typeof(T) == typeof(short))
                 return generic<T>(Bits.disable(int16(src), pos));
            else if(typeof(T) == typeof(int))
                 return generic<T>(Bits.disable(int32(src), pos));
            else 
                 return generic<T>(Bits.disable(int64(src), pos));
        }

        [MethodImpl(Inline)]
        static T disable_u<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return generic<T>(Bits.disable(uint8(src), pos));
            else if(typeof(T) == typeof(ushort))
                 return generic<T>(Bits.disable(uint16(src), pos));
            else if(typeof(T) == typeof(uint))
                 return generic<T>(Bits.disable(uint32(src), pos));
            else 
                 return generic<T>(Bits.disable(uint64(src), pos));
        }

        [MethodImpl(Inline)]
        static T disable_f<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return generic<T>(Bits.disable(float32(src), pos));
            else if(typeof(T) == typeof(double))
                 return generic<T>(Bits.disable(float64(src), pos));
            else
                throw Unsupported.define<T>();
        }         
    }
}