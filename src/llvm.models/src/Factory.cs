//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.CompilerServices;

    using types;

    using static Root;

    [ApiHost]
    public readonly partial struct Factory
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static list<T> list<T>(T[] src)
            => new list<T>(src);

        [MethodImpl(Inline)]
        public static dag<L,R> dag<L,R>(L left, R right)
            where L : ITerm
            where R : ITerm
                => new dag<L,R>(left,right);
    }
}