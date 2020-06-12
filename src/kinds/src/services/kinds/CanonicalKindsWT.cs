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
        public readonly struct Zero<W,T> : ICanonicalKind<Zero,W,T> where W : unmanaged, ITypeWidth {}

        public readonly struct One<W,T> : ICanonicalKind<One,W,T> where W : unmanaged, ITypeWidth {}

        public readonly struct Test<W,T> : ICanonicalKind<Test,W,T> where W : unmanaged, ITypeWidth {}

    }
}