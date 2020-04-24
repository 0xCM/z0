//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using K = CanonicalKind;
    using I = ICanonicalKind;

    partial class Kinds
    {
        public readonly struct Reverse : I { K I.Kind => K.Reverse; }

        public readonly struct Identity : I { K I.Kind => K.Identity; }

        public readonly struct Concat : I { K I.Kind => K.Concat; }

        public readonly struct Parse : I { K I.Kind => K.Parse; }

        public readonly struct Slice : I { K I.Kind => K.Slice; }
    }
}