//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    using K = BitFunctionKind;
    using I = IBitFunctionKind;

    partial class Kinds
    {
        public readonly struct TestZ : I { public K Kind { [MethodImpl(Inline)] get => K.TestZ;}}

        public readonly struct TestC : I { public K Kind { [MethodImpl(Inline)] get => K.TestC;}}

    }
}