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
        /// Enables a contiguous sequence of source bits starting at a specified index
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="index">The index at which to begin</param>
        /// <param name="count">The number of bits to fill</param>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static T enable<T>(T src, byte index, byte count)
            where T : unmanaged
                => enable_u(src,index,count);

        [MethodImpl(Inline)]
        static T enable_u<T>(T src, byte index, byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.enable(uint8(src), index, count));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.enable(uint16(src), index, count));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.enable(uint32(src), index, count));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.enable(uint64(src), index, count));
            else
                return enable_i(src,index,count);
        }

        [MethodImpl(Inline)]
        static T enable_i<T>(T src, byte index, byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.enable(int8(src), index, count));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.enable(int16(src), index, count));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.enable(int32(src), index, count));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.enable(int64(src), index, count));
            else
                throw no<T>();
        }
        /// <summary>
        /// Enables an index-identified source bit
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The 0-based index of the bit to change</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Enable, Closures(AllNumeric)]
        public static T enable<T>(T src, byte pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte)
            || typeof(T) == typeof(ushort)
            || typeof(T) == typeof(uint)
            || typeof(T) == typeof(ulong))
                return enable_u(src,pos);
            else if(typeof(T) == typeof(sbyte)
            || typeof(T) == typeof(short)
            || typeof(T) == typeof(int)
            || typeof(T) == typeof(long))
                return enable_i(src,pos);
            else
                return enable_f(src,pos);
        }

        [MethodImpl(Inline)]
        static T enable_i<T>(T src, byte pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(Bits.enable(int8(src), pos));
            else if(typeof(T) == typeof(short))
                 return generic<T>(Bits.enable(int16(src), pos));
            else if(typeof(T) == typeof(int))
                 return generic<T>(Bits.enable(int32(src), pos));
            else
                 return generic<T>(Bits.enable(int64(src), pos));
        }

        [MethodImpl(Inline)]
        static T enable_u<T>(T src, byte pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return generic<T>(Bits.enable(uint8(src), pos));
            else if(typeof(T) == typeof(ushort))
                 return generic<T>(Bits.enable(uint16(src), pos));
            else if(typeof(T) == typeof(uint))
                 return generic<T>(Bits.enable(uint32(src), pos));
            else
                 return generic<T>(Bits.enable(uint64(src), pos));
        }

        [MethodImpl(Inline)]
        static T enable_f<T>(T src, byte pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return generic<T>(Bits.enable(float32(src), pos));
            else if(typeof(T) == typeof(double))
                 return generic<T>(Bits.enable(float64(src), pos));
            else
                throw no<T>();
        }
    }
}