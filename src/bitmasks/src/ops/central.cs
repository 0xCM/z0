//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static NumericCast;
    using static BitMasks;
    using static Typed;

    partial class BitMask
    {                
        /// <summary>
        /// Defines a central bitmask over 8-bit segments with a parametric bit density
        /// D:[N2 | N4 | N6]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="D">The bit density type</typeparam>
        /// <typeparam name="T">The primal mask type</typeparam>
        [MethodImpl(Inline)]
        public static T central<D,T>(N8 f, D d = default, T t = default)
            where T : unmanaged
            where D : unmanaged, ITypeNat
        {
            if(typeof(D) == typeof(N2))
                return central<T>(f,n2);        
            else if(typeof(D) == typeof(N4))
                return central<T>(f,n4);
            else if(typeof(D) == typeof(N6))
                return central<T>(f,n6);
            else
                throw Unsupported.define<D>();        
        }

        /// <summary>
        /// [00011000]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T central<T>(N8 f, N2 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Central8x8x2);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Central16x8x2);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Central32x8x2);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Central64x8x2);
            else 
                throw Unsupported.define<T>();
        }

        /// <summary>
        /// [00111100]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T central<T>(N8 f, N4 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Central8x8x4);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Central16x8x4);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Central32x8x4);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Central64x8x4);
            else 
                throw Unsupported.define<T>();
        }

        /// <summary>
        /// [01111110]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T central<T>(N8 f, N6 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Central8x8x6);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Central16x8x6);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Central32x8x6);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Central64x8x6);
            else 
                throw Unsupported.define<T>();
        }

        /// <summary>
        /// [00011000]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T mask<D,T>(CentralMask<N8,D,T> spec)
            where T : unmanaged
            where D : unmanaged, ITypeNat
                => central(spec.f, spec.d, spec.t);
    }
}