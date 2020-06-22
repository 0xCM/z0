//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using K = CanonicalKind;
    using I = ICanonicalKind;

    partial class Kinds
    {
        public readonly struct Reverse : I { K I.Kind => K.Reverse; }

        public readonly struct Identity : I { K I.Kind => K.Identity; }

        public readonly struct Concat : I { K I.Kind => K.Concat; }

        public readonly struct Parse : I { K I.Kind => K.Parse; }

        public readonly struct Slice : I { K I.Kind => K.Slice; }

        public readonly struct Zero : I { K I.Kind => K.Zero; }

        public readonly struct One : I { K I.Kind => K.One; }

        public readonly struct Test : I { K I.Kind => K.Test; }

        public readonly struct Switch : I { K I.Kind => K.Switch; }

        public readonly struct Copy : I { K I.Kind => K.Copy; }

        public readonly struct Zip : I { K I.Kind => K.Zip; }

    }
}