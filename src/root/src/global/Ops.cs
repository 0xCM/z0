//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct Root
    {
        [MethodImpl(Inline)]
        internal static ref T @as<S,T>(in S src)
            => ref Unsafe.As<S,T>(ref Unsafe.AsRef(src));


        [MethodImpl(Inline), Op]
        public static uint hash(PartId src)
            => (uint)src;

        [MethodImpl(Inline), Op]
        internal static T[] array<T>(params T[] src)
            => src;

        /// <summary>
        /// Applies a function to a value
        /// </summary>
        /// <param name="x">The source value</param>
        /// <param name="f">The function to apply</param>
        /// <typeparam name="X">The source value type</typeparam>
        /// <typeparam name="Y">The output value type</typeparam>
         [MethodImpl(Inline)]
         public static Y apply<X,Y>(X x, Func<X,Y> f)
            => f(x);


        [MethodImpl(Inline), Op]
        public static string format(ExternId id)
            => id.ToString().ToLower();
    }
}