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
        /// Counts the number enabled source bits
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Pop,  Closures(Integers)]
        public static uint pop<T>(T src)
            where T : unmanaged
                => pop_u(src);

        [MethodImpl(Inline), Pop,  Closures(Integers)]
        public static uint pop<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            var cells = src.Length;
            var result = 0u;
            for(var i=0; i<cells; i++)
                result += pop(skip(src,i));
            return result;
        }

        /// <summary>
        /// Counts the number of enabled primal operand bits
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Pop, Closures(Integers)]
        public static uint pop<T>(T x0, T x1, T x2)
            where T : unmanaged
                => Bits.pop(force<T,ulong>(x0), force<T,ulong>(x1), force<T,ulong>(x2));

        /// <summary>
        /// Counts the number of enabled primal operand bits
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Pop, Closures(Integers)]
        public static uint pop<T>(T x0, T x1, T x2, T x3)
            where T : unmanaged
                => Bits.pop(force<T,ulong>(x0), force<T,ulong>(x1), force<T,ulong>(x2), force<T,ulong>(x3));

        /// <summary>
        /// Counts the number of enabled primal operand bits
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Pop, Closures(Integers)]
        public static uint pop<T>(T x0, T x1, T x2, T x3,T x4, T x5, T x6, T x7)
            where T : unmanaged
                => Bits.pop(
                    force<T,ulong>(x0),force<T,ulong>(x1), force<T,ulong>(x2), force<T,ulong>(x3),
                    force<T,ulong>(x4),force<T,ulong>(x5), force<T,ulong>(x6), force<T,ulong>(x7)
                    );

        [MethodImpl(Inline)]
        static uint pop_u<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return Bits.pop(uint8(src));
            else if(typeof(T) == typeof(ushort))
                 return Bits.pop(uint16(src));
            else if(typeof(T) == typeof(uint))
                 return Bits.pop(uint32(src));
            else if(typeof(T) == typeof(ulong))
                 return Bits.pop(uint64(src));
            else
                return  pop_i(src);
        }

        [MethodImpl(Inline)]
        static uint pop_i<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return Bits.pop(int8(src));
            else if(typeof(T) == typeof(short))
                 return Bits.pop(int16(src));
            else if(typeof(T) == typeof(int))
                 return Bits.pop(int32(src));
            else if(typeof(T) == typeof(long))
                 return Bits.pop(int64(src));
             else
                throw no<T>();
       }
    }
}