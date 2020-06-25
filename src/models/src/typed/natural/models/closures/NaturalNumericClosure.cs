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
    using static Typed;

    public readonly struct NaturalNumericClosure
    {
        [MethodImpl(Inline)]
        public NaturalNumericClosure(MethodInfo def, ulong? m, ulong n, NumericKind t) 
        {
            this.Definition = def;
            this.M = m;
            this.N = n;
            this.T = t;
        }

        public readonly ulong? M;

        public readonly ulong N;
        
        public readonly NumericKind T;

        public readonly MethodInfo Definition;
    }
}