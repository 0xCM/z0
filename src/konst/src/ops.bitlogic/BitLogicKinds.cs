//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using U = UnaryBitLogicKind;
    using B = BinaryBitLogicKind;
    using T = TernaryBitLogicKind;
    using TK = TernaryBitLogicApiKey;

    using K = BinaryBitLogicApiKey;
    using I = IBitLogicKind;

    using static Konst;

    public readonly struct BitLogicKinds
    {
        const NumericKind Closure = UnsignedInts;

        [KindFactory]
        public static And and(N2 n)
            => default;

        [KindFactory]
        public static Or or(N2 n)
            => default;

        [KindFactory]
        public static Xor xor(N2 n)
            => default;

        [KindFactory]
        public static Nand nand(N2 n)
            => default;

        [KindFactory]
        public static Nor nor(N2 n)
            => default;

        [KindFactory]
        public static Xnor xnor(N2 n)
            => default;

        [KindFactory]
        public static Not not(N1 n)
            => default;

        [KindFactory]
        public static Impl impl(N2 n)
            => default;

        [KindFactory]
        public static NonImpl nonimpl(N2 n)
            => default;

        [KindFactory]
        public static CImpl cimpl(N2 n)
            => default;

        [KindFactory]
        public static CNonImpl cnonimpl(N2 n)
            => default;

        [KindFactory]
        public static LNot lnot(N2 n)
            => default;

        [KindFactory]
        public static RNot rnot(N2 n)
            => default;

        [KindFactory]
        public static Select select(N3 n)
            => default;

        [KindFactory, Closures(Closure)]
        public static And<T> and<T>(N2 n, T t = default)
            => default;

        [KindFactory, Closures(Closure)]
        public static Nand<T> nand<T>(N2 n, T t = default)
            => default;

        [KindFactory, Closures(Closure)]
        public static Or<T> or<T>(N2 n, T t = default)
            => default;

        [KindFactory, Closures(Closure)]
        public static Nor<T> nor<T>(N2 n, T t = default)
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

        public readonly struct And<T> : IBitLogicKindHost<And,T> {}

        public readonly struct Nand<T> : IBitLogicKindHost<Nand,T> {}

        public readonly struct Or<T> : IBitLogicKindHost<Or,T> {}

        public readonly struct Nor<T> : IBitLogicKindHost<Nor,T> {}

        public readonly struct Xor<T> : IBitLogicKindHost<Xor,T> {}

        public readonly struct Xnor<T> : IBitLogicKindHost<Xnor,T> {}

        public readonly struct Impl<T> : IBitLogicKindHost<Impl,T> {}

        public readonly struct NonImpl<T> : IBitLogicKindHost<NonImpl,T> {}

        public readonly struct CImpl<T> : IBitLogicKindHost<CImpl,T> {}

        public readonly struct CNonImpl<T> : IBitLogicKindHost<CNonImpl,T> {}

        public readonly struct Not<T> : IBitLogicKindHost<Not,T> {}

        public readonly struct Select<T> : IBitLogicKindHost<Select,T> {}
    }
}