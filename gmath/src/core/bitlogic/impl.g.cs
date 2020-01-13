//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    using static AsIn;

    partial class gmath
    {
        [MethodImpl(Inline)]
        public static T left<T>(T a, T b)
            where T : unmanaged
                => a;

        [MethodImpl(Inline)]
        public static T right<T>(T a, T b)
            where T : unmanaged
                => b;

        [MethodImpl(Inline)]
        public static T lnot<T>(T a, T b)
            where T : unmanaged
                => not(a);

        [MethodImpl(Inline)]
        public static T rnot<T>(T a, T b)
            where T : unmanaged
                => not(b);

        [MethodImpl(Inline)]
        public static T @false<T>()
            where T:unmanaged
                => zero<T>();

        [MethodImpl(Inline)]
        public static T @false<T>(T a)
            where T:unmanaged
                => @false<T>();

        [MethodImpl(Inline)]
        public static T @false<T>(T a, T b, T c)
            where T:unmanaged
                => @false<T>();

        [MethodImpl(Inline)]
        public static T @true<T>()
            where T:unmanaged
                => ones<T>();

        [MethodImpl(Inline)]
        public static T @true<T>(T a)
            where T:unmanaged
                => @true<T>();

        [MethodImpl(Inline)]
        public static T @true<T>(T a, T b)
            where T:unmanaged
                => @true<T>();

        [MethodImpl(Inline)]
        public static T @false<T>(T a, T b)
            where T:unmanaged
                => @false<T>();

        [MethodImpl(Inline)]
        public static T @true<T>(T a, T b, T c)
            where T:unmanaged
                => @true<T>();

        [MethodImpl(Inline)]
        public static T identity<T>(T a)
            where T : unmanaged
                => a;

        /// <summary>
        /// Computes the material implication c := a | ~b for integral values a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), ZFunc(PrimalKind.Integers)]
        public static T impl<T>(T a, T b)
            where T : unmanaged
                => impl_u(a,b);

        [MethodImpl(Inline)]
        static T impl_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<T>(math.impl(convert<T,uint>(a), convert<T,uint>(b)));
            else if(typeof(T) == typeof(ushort))
                return convert<T>(math.impl(convert<T,uint>(a), convert<T,uint>(b)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.impl(uint32(a), uint32(b)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.impl(uint64(a), uint64(b)));
            else
                return impl_i(a,b);
        }

        [MethodImpl(Inline)]
        static T impl_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return convert<T>(math.impl(convert<T,int>(a), convert<T,int>(b)));
            else if(typeof(T) == typeof(short))
                return convert<T>(math.impl(convert<T,int>(a), convert<T,int>(b)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.impl(int32(a), int32(b)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.impl(int64(a), int64(b)));
            else
                throw unsupported<T>();
        }
    }
}