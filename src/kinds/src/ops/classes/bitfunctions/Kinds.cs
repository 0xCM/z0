//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    using Id = BitFunctionKind;

    partial class Kinds
    {

        public readonly struct TestZ : IBitFunctionKind { public Id Kind { [MethodImpl(Inline)] get => Id.TestZ;}}

        public readonly struct TestC : IBitFunctionKind { public Id Kind { [MethodImpl(Inline)] get => Id.TestC;}}

        public readonly struct TestZ<T> : IBitFunctionKind<TestZ,T> where T : unmanaged {}

        public readonly struct TestC<T> : IBitFunctionKind<TestC,T> where T : unmanaged {}

    }
}