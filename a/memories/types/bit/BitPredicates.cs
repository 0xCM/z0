//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;

     partial class XTend
     {
        [MethodImpl(Inline)]
        public static UnaryPredicate<T> ToUnaryPredicate<T>(this System.Func<T,bit> f)
            => new UnaryPredicate<T>(f);

        [MethodImpl(Inline)]
        public static Z0.BinaryPredicate<T> ToBinaryPredicate<T>(this System.Func<T,T,bit> f)
            => new Z0.BinaryPredicate<T>(f);

        [MethodImpl(Inline)]
        public static System.Func<T,bit> ToFunc<T>(this UnaryPredicate<T> f)
            => new System.Func<T,bit>(f);

        [MethodImpl(Inline)]
        public static System.Func<T,T,bit> ToFunc<T>(this BinaryPredicate<T> f)
            => new System.Func<T,T,bit>(f);
     }
}