//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    partial class Kinds
    {
        public readonly struct Lt<T> : IComparisonKind<Lt,T> {}

        public readonly struct LtEq<T> : IComparisonKind<LtEq,T> {}

        public readonly struct Gt<T> : IComparisonKind<Gt,T> {}

        public readonly struct GtEq<T> : IComparisonKind<GtEq,T> {}

        public readonly struct Eq<T> : IComparisonKind<Eq,T> {}

        public readonly struct Neq<T> : IComparisonKind<Neq,T> {}

    }
}