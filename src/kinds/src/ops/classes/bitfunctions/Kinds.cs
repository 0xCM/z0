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

    }
}