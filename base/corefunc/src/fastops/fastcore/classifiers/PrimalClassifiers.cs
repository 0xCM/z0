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
        public readonly struct PrimalClass<T> : IPrimalClass<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public static implicit operator PrimalKind(PrimalClass<T> src)
                => src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator PrimalClass<T>(T src)
                => default;

            public PrimalKind Classifier 
            {
                [MethodImpl(Inline)] 
                get => PrimalType.kind<T>();
            }
        }        

        [MethodImpl(Inline)]
        public static PrimalClass<T> primal<T>(T t = default)
            where T : unmanaged
                => default;

        public readonly struct Primal8u : IPrimalClass { public const PrimalKind Kind = PrimalKind.U8; public PrimalKind Classifier => Kind;}
        
        public readonly struct Primal8i : IPrimalClass { public const PrimalKind Kind = PrimalKind.I8; public PrimalKind Classifier => Kind;}
        
        public readonly struct Primal16u : IPrimalClass { public const PrimalKind Kind = PrimalKind.U16; public PrimalKind Classifier => Kind;}

        public readonly struct Primal16i : IPrimalClass { public const PrimalKind Kind = PrimalKind.I16; public PrimalKind Classifier => Kind;}

        public readonly struct Primal32u : IPrimalClass { public const PrimalKind Kind = PrimalKind.U32; public PrimalKind Classifier => Kind;}

        public readonly struct Primal32i : IPrimalClass { public const PrimalKind Kind = PrimalKind.I32; public PrimalKind Classifier => Kind;}

        public readonly struct Primal64u : IPrimalClass { public const PrimalKind Kind = PrimalKind.U64; public PrimalKind Classifier => Kind;}

        public readonly struct Primal64i : IPrimalClass { public const PrimalKind Kind = PrimalKind.I64; public PrimalKind Classifier => Kind;}

        public readonly struct Primal32f : IPrimalClass { public const PrimalKind Kind = PrimalKind.F32; public PrimalKind Classifier => Kind;}

        public readonly struct Primal64f : IPrimalClass { public const PrimalKind Kind = PrimalKind.F64; public PrimalKind Classifier => Kind;}

        public static PrimalClass<byte> u8
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static PrimalClass<sbyte> i8
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static PrimalClass<ushort> u16
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static PrimalClass<short> i16
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static PrimalClass<uint> u32
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static PrimalClass<int> i32
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static PrimalClass<ulong> u64
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static PrimalClass<long> i64
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static PrimalClass<float> f32
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static PrimalClass<double> f64
        {
            [MethodImpl(Inline)]
            get => default;
        }
    }
}

