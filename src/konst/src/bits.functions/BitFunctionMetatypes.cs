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

    using K = BitFunctionApiClass;
    using I = IBitFunctionApiKey;

    public readonly struct BitFunctionMetatypes
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

        public readonly struct TestZ<T> : IBitFunctionApiKey<TestZ,T> {}

        public readonly struct TestC<T> : IBitFunctionApiKey<TestC,T> {}

        public readonly struct Ntz<T> : IBitFunctionApiKey<Ntz,T> {}

        public readonly struct Nlz<T> : IBitFunctionApiKey<Nlz,T> {}

        public readonly struct Pop<T> : IBitFunctionApiKey<Pop,T> {}

        public readonly struct Mux<T> : IBitFunctionApiKey<Mux,T> {}

        public readonly struct Scatter<T> : IBitFunctionApiKey<Scatter,T> {}

        public readonly struct Gather<T> : IBitFunctionApiKey<Gather,T> {}

        public readonly struct Mix<T> : IBitFunctionApiKey<Mix,T> {}

        public readonly struct Rank<T> : IBitFunctionApiKey<Rank,T> {}

        public readonly struct BitSeg<T> : IBitFunctionApiKey<BitSeg,T> {}

        public readonly struct TestBit<T> : IBitFunctionApiKey<TestBit,T> {}

        public readonly struct TestBits<T> : IBitFunctionApiKey<TestBits,T> {}
    }
}