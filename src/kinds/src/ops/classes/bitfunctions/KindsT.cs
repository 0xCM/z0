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
        public readonly struct TestZ<T> : IBitFunctionKind<TestZ,T> where T : unmanaged {}

        public readonly struct TestC<T> : IBitFunctionKind<TestC,T> where T : unmanaged {}
    }
}