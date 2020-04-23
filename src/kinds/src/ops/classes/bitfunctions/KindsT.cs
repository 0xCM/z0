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
        public readonly struct TestZ<T> : IBitFunctionKind<TestZ,T> {}

        public readonly struct TestC<T> : IBitFunctionKind<TestC,T> {}

        public readonly struct Ntz<T> : IBitFunctionKind<Ntz,T> {}

        public readonly struct Nlz<T> : IBitFunctionKind<Nlz,T> {}

        public readonly struct Pop<T> : IBitFunctionKind<Pop,T> {}

        public readonly struct Mux<T> : IBitFunctionKind<Mux,T> {}

        public readonly struct Scatter<T> : IBitFunctionKind<Scatter,T> {}

        public readonly struct Gather<T> : IBitFunctionKind<Gather,T> {}

        public readonly struct Mix<T> : IBitFunctionKind<Mix,T> {}

        public readonly struct Rank<T> : IBitFunctionKind<Rank,T> {}
    }
}