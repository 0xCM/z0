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

        //~ Parametric
        //~ -------------------------------------------------------------------
        public readonly struct Reverse<T> : ICanonicalKind<Reverse,T> {}

        public readonly struct Identity<T> : ICanonicalKind<Identity,T> {}

        public readonly struct Concat<T> : ICanonicalKind<Concat,T> {}

        public readonly struct Parse<T> : ICanonicalKind<Parse,T> {}

        public readonly struct Slice<T> : ICanonicalKind<Slice,T> {}

        public readonly struct Zero<T> : ICanonicalKind<Zero,T> {}

        public readonly struct One<T> : ICanonicalKind<One,T> {}

        public readonly struct Test<T> : ICanonicalKind<Test,T> {}

        public readonly struct Zip<T> : ICanonicalKind<Zip,T> {}
    }
}