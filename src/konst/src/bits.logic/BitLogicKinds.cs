//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using K = ApiBitLogicClass;
    using I = IBitLogicKind;

    using static Part;

    [ApiHost]
    public readonly struct BitLogicKinds
    {
        const NumericKind Closure = UnsignedInts;

        [KindFactory]
        public static And and()
            => default;

        [KindFactory]
        public static Or or()
            => default;

        [KindFactory]
        public static Xor xor()
            => default;

        [KindFactory]
        public static Nand nand()
            => default;

        [KindFactory]
        public static Nor nor()
            => default;

        [KindFactory]
        public static Xnor xnor()
            => default;

        [KindFactory]
        public static Not not()
            => default;

        [KindFactory]
        public static Impl impl()
            => default;

        [KindFactory]
        public static NonImpl nonimpl()
            => default;

        [KindFactory]
        public static CImpl cimpl()
            => default;

        [KindFactory]
        public static CNonImpl cnonimpl()
            => default;

        [KindFactory]
        public static LNot lnot()
            => default;

        [KindFactory]
        public static RNot rnot()
            => default;

        [KindFactory]
        public static Select select()
            => default;

        [KindFactory, Closures(Closure)]
        public static And<T> and<T>()
            => default;

        [KindFactory, Closures(Closure)]
        public static Nand<T> nand<T>()
            => default;

        [KindFactory, Closures(Closure)]
        public static Or<T> or<T>()
            => default;

        [KindFactory, Closures(Closure)]
        public static Nor<T> nor<T>()
            => default;

        [KindFactory, Closures(Closure)]
        public static Impl<T> impl<T>()
            => default;

        [KindFactory, Closures(Closure)]
        public static NonImpl<T> nonimpl<T>()
            => default;

        [KindFactory, Closures(Closure)]
        public static CImpl<T> cimpl<T>()
            => default;

        [KindFactory, Closures(Closure)]
        public static CNonImpl<T> cnonimpl<T>()
            => default;

        [KindFactory, Closures(Closure)]
        public static Not<T> not<T>()
            => default;

        [KindFactory, Closures(Closure)]
        public static Select<T> select<T>()
            => default;

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

        public readonly struct True : I { K I.Kind => K.True; }

        public readonly struct False : I { K I.Kind => K.False; }

        public readonly struct LProject : I { K I.Kind => K.LProject; }

        public readonly struct RProject : I { K I.Kind => K.RProject; }

        public readonly struct LNot : I { K I.Kind => K.LNot; }

        public readonly struct RNot : I { K I.Kind => K.RNot; }

        public readonly struct And<T> : IBitLogicKind<And,T> {}

        public readonly struct Nand<T> : IBitLogicKind<Nand,T> {}

        public readonly struct Or<T> : IBitLogicKind<Or,T> {}

        public readonly struct Nor<T> : IBitLogicKind<Nor,T> {}

        public readonly struct Xor<T> : IBitLogicKind<Xor,T> {}

        public readonly struct Xnor<T> : IBitLogicKind<Xnor,T> {}

        public readonly struct Impl<T> : IBitLogicKind<Impl,T> {}

        public readonly struct NonImpl<T> : IBitLogicKind<NonImpl,T> {}

        public readonly struct CImpl<T> : IBitLogicKind<CImpl,T> {}

        public readonly struct CNonImpl<T> : IBitLogicKind<CNonImpl,T> {}

        public readonly struct Not<T> : IBitLogicKind<Not,T> {}

        public readonly struct Select<T> : IBitLogicKind<Select,T> {}
    }
}