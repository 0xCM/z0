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
        public readonly struct TestZ<W,T> : IBitFunctionKind<TestZ,W,T> where W : unmanaged, ITypeWidth where T : unmanaged {}

        public readonly struct TestC<W,T> : IBitFunctionKind<TestC,W,T> where W : unmanaged, ITypeWidth where T : unmanaged {}
    }
}