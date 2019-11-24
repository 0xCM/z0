//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;
    using static AsIn;

    partial class gbits
    {
        /// <summary>
        /// Pretends that the operands are bitvectors and computes their scalar product
        /// </summary>
        /// <param name="x">The left scalar</param>
        /// <param name="y">The right scalar</param>
        /// <typeparam name="T">The primal unsigned integral type</typeparam>
        [MethodImpl(Inline)]
        public static bit dot<T>(T x, T y)
            where T : unmanaged
                => odd(pop(gmath.and(x,y)));


        [MethodImpl(Inline)]
        public static uint pop<T>(T x0, T x1, T x2, T x3)
            where T : unmanaged
                => Bits.pop(convert<T,ulong>(x0),convert<T,ulong>(x1), convert<T,ulong>(x2), convert<T,ulong>(x3));

        [MethodImpl(Inline)]
        public static uint pop<T>(T x0, T x1, T x2, T x3,T x4, T x5, T x6, T x7)
            where T : unmanaged
                => Bits.pop(
                    convert<T,ulong>(x0),convert<T,ulong>(x1), convert<T,ulong>(x2), convert<T,ulong>(x3),
                    convert<T,ulong>(x4),convert<T,ulong>(x5), convert<T,ulong>(x6), convert<T,ulong>(x7)
                    );

        /// <summary>
        /// Counts the number enabled source bits
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static uint pop<T>(T src)
            where T : unmanaged
        {        
            if(typeof(T) == typeof(byte) 
                || typeof(T) == typeof(ushort) 
                || typeof(T) == typeof(uint) 
                || typeof(T) == typeof(ulong))
                    return pop_u(src);
            else if(typeof(T) == typeof(sbyte) 
                || typeof(T) == typeof(short)
                || typeof(T) == typeof(int) 
                || typeof(T) == typeof(long))
                    return pop_i(src);
            else
                throw unsupported<T>();
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
            else 
                 return Bits.pop(int64(src));
        }

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
            else 
                 return Bits.pop(uint64(src));
        }
 
    }
}