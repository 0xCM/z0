//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Kinds;

    using K = BitFunctionApiKey;
    using I = IBitFunctionApiKey;

    partial struct BitFunctions
    {
        public readonly struct TestZ : I {  K I.Kind => K.TestZ; }

        public readonly struct TestC : I {  K I.Kind => K.TestC; }

        public readonly struct Ntz : I {  K I.Kind => K.Ntz; }

        public readonly struct Nlz : I {  K I.Kind => K.Nlz; }

        public readonly struct Pop : I {  K I.Kind => K.Pop; }

        public readonly struct Mux : I {  K I.Kind => K.Mux; }

        public readonly struct Scatter : I {  K I.Kind => K.Scatter; }

        public readonly struct Gather : I {  K I.Kind => K.Gather; }

        public readonly struct Mix : I {  K I.Kind => K.Mix; }

        public readonly struct Rank : I {  K I.Kind => K.Rank; }

        public readonly struct BitSeg : I {  K I.Kind => K.Extract; }

        public readonly struct TestBit : I {  K I.Kind => K.TestBit; }

        public readonly struct SetBit : I {  K I.Kind => K.SetBit; }

        public readonly struct TestBits : I {  K I.Kind => K.TestBits; }

        public readonly struct Stitch : I {  K I.Kind => K.Stitch; }

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

        public readonly struct BitSeg<T> : IBitFunctionKind<BitSeg,T> {}

        public readonly struct TestBit<T> : IBitFunctionKind<TestBit,T> {}

        public readonly struct TestBits<T> : IBitFunctionKind<TestBits,T> {}
    }
}