//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class Classifiers
    {
        public readonly struct Primal8u : IPrimalKind { public const PrimalKind Kind = PrimalKind.U8; public PrimalKind Classifier => Kind;}
        
        public readonly struct Primal8i : IPrimalKind { public const PrimalKind Kind = PrimalKind.I8; public PrimalKind Classifier => Kind;}
        
        public readonly struct Primal16u : IPrimalKind { public const PrimalKind Kind = PrimalKind.U16; public PrimalKind Classifier => Kind;}

        public readonly struct Primal16i : IPrimalKind { public const PrimalKind Kind = PrimalKind.I16; public PrimalKind Classifier => Kind;}

        public readonly struct Primal32u : IPrimalKind { public const PrimalKind Kind = PrimalKind.U32; public PrimalKind Classifier => Kind;}

        public readonly struct Primal32i : IPrimalKind { public const PrimalKind Kind = PrimalKind.I32; public PrimalKind Classifier => Kind;}

        public readonly struct Primal64u : IPrimalKind { public const PrimalKind Kind = PrimalKind.U64; public PrimalKind Classifier => Kind;}

        public readonly struct Primal64i : IPrimalKind { public const PrimalKind Kind = PrimalKind.I64; public PrimalKind Classifier => Kind;}

        public readonly struct Primal32f : IPrimalKind { public const PrimalKind Kind = PrimalKind.F32; public PrimalKind Classifier => Kind;}

        public readonly struct Primal64f : IPrimalKind { public const PrimalKind Kind = PrimalKind.F64; public PrimalKind Classifier => Kind;}

        public readonly struct PrimalKind<T> : IPrimalKind<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public static implicit operator PrimalKind(PrimalKind<T> src)
                => src.Classifier;

            public PrimalKind Classifier {[MethodImpl(Inline)] get  => PrimalType.kind<T>();}
        }

        public static Primal8u u8
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Primal8i i8
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Primal16u u16
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Primal16i i16
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Primal32u u32
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Primal32i i32
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Primal64u u64
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Primal64i i64
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Primal32f f32
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Primal64f f64
        {
            [MethodImpl(Inline)]
            get => default;
        }

        [MethodImpl(Inline)]
        public static PrimalKind<T> pkind<T>(T t = default)
            where T : unmanaged
                => default;
    }
}

