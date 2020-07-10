//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Delegates
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static UnaryOp<T> @operator<T>(System.Func<T,T> f)
            => new UnaryOp<T>(f);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BinaryOp<T> @operator<T>(System.Func<T,T,T> f)
            => new BinaryOp<T>(f);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static TernaryOp<T> @operator<T>(System.Func<T,T,T,T> f)
            => new TernaryOp<T>(f);
    }
}