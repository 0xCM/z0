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

    public readonly struct NaturalNumericClosure
    {
        public readonly ulong? M;

        public readonly ulong N;

        public readonly NumericKind T;

        public readonly MethodInfo Definition;

        [MethodImpl(Inline)]
        public NaturalNumericClosure(MethodInfo def, ulong? m, ulong n, NumericKind t)
        {
            Definition = def;
            M = m;
            N = n;
            T = t;
        }
    }
}