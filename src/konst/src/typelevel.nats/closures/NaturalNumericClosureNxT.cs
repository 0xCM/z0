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
    using static z;

    public readonly struct NaturalNumericClosure<N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        public readonly MethodInfo Definition;

        [MethodImpl(Inline)]
        public NaturalNumericClosure(MethodInfo def)
            => Definition = def;

        public NaturalNumericClosure Untyped
            => new NaturalNumericClosure(Definition, null, nat64u<N>(), typeof(T).NumericKind());
    }
}