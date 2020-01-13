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
        [MethodImpl(Inline)]
        public static PrimalKind<T> primal<T>(T t = default)
            where T : unmanaged
                => default;

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



        public static PrimalKind<byte> u8
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static PrimalKind<sbyte> i8
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static PrimalKind<ushort> u16
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static PrimalKind<short> i16
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static PrimalKind<uint> u32
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static PrimalKind<int> i32
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static PrimalKind<ulong> u64
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static PrimalKind<long> i64
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static PrimalKind<float> f32
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static PrimalKind<double> f64
        {
            [MethodImpl(Inline)]
            get => default;
        }

    }
}

