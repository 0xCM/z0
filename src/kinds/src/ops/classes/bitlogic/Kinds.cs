//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    using K = BitLogicKind;
    using I = IBitLogicKind;

    partial class Kinds
    {
        public readonly struct And : I { K I.Kind => K.And; }

        public readonly struct Or : I { K I.Kind => K.Or; }

        public readonly struct Xor : I { K I.Kind => K.Xor; }

        public readonly struct Nand : I { K I.Kind => K.Nand; }

        public readonly struct Nor : I { K I.Kind => K.Nor; }

        public readonly struct Xnor : I { K I.Kind => K.Xnor; }

        public readonly struct Impl : I { K I.Kind => K.Impl; }

        public readonly struct NonImpl : I { K I.Kind => K.NonImpl; }

        public readonly struct CImpl : I { K I.Kind => K.CImpl; }

        public readonly struct CNonImpl : I { K I.Kind => K.CNonImpl; }

        public readonly struct Not : I { K I.Kind => K.Not; }

        public readonly struct Select : I { K I.Kind => K.Select; }
    }
}