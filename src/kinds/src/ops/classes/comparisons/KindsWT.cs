//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    

    partial class Kinds
    {
        public readonly struct Lt<W,T> : IComparisonKind<Lt,W,T> where W : unmanaged, ITypeWidth {}

        public readonly struct LtEq<W,T> : IComparisonKind<LtEq,W,T> where W : unmanaged, ITypeWidth {}

        public readonly struct Gt<W,T> : IComparisonKind<Gt,W,T> where W : unmanaged, ITypeWidth {}

        public readonly struct GtEq<W,T> : IComparisonKind<GtEq,W,T> where W : unmanaged, ITypeWidth {}

        public readonly struct Eq<W,T> : IComparisonKind<Eq,W,T> where W : unmanaged, ITypeWidth {}

        public readonly struct Neq<W,T> : IComparisonKind<Neq,W,T> where W : unmanaged, ITypeWidth {}
    }
}