//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;

    using static BitMasks;

    partial class BitMask
    {                
        [MethodImpl(Inline)]
        public static JsbMask<F,D,T> jsbspec<F,D,T>(F f = default, D d = default, T t = default) 
            where F : unmanaged, ITypeNat
            where D : unmanaged, ITypeNat
            where T : unmanaged
                => default;

        /// <summary>
        /// [10000001]
        /// </summary>
        /// <param name="f">The frequency selector</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>JSB := msb | lsb (8x1)</remarks>
        [MethodImpl(Inline)]
        public static T jsb<T>(N8 f, N1 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Jsb8x8x1);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Jsb16x8x1);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Jsb32x8x1);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Jsb64x8x1);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [10000001]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T jsb<T>(JsbMask<N8,N1,T> spec)
            where T : unmanaged
                => jsb(spec.f,spec.d,spec.t);


        /// <summary>
        /// [11000011]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>JSB := msb | lsb (8x2)</remarks>
        [MethodImpl(Inline)]
        public static T jsb<T>(N8 f, N2 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Jsb8x8x2);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Jsb16x8x2);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Jsb32x8x2);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Jsb64x8x2);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [11000011]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T jsb<T>(JsbMask<N8,N2,T> spec)
            where T : unmanaged
                => jsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [11100111]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>JSB := msb | lsb (8x3)</remarks>
        [MethodImpl(Inline)]
        public static T jsb<T>(N8 f, N3 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Jsb8x8x3);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Jsb16x8x3);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Jsb32x8x3);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Jsb64x8x3);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [11100111]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T jsb<T>(JsbMask<N8,N3,T> spec)
            where T : unmanaged
                => jsb(spec.f,spec.d,spec.t);
    }
}