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
            public static implicit operator NumericKind(PrimalClass<T> src)
                => src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator PrimalClass<T>(T src)
                => default;

            public NumericKind Classifier 
            {
                [MethodImpl(Inline)] 
                get => PrimalType.kind<T>();
            }
        }        

        [MethodImpl(Inline)]
        public static PrimalClass<T> primal<T>(T t = default)
            where T : unmanaged
                => default;

        public readonly struct Primal8u : IPrimalClass { public const NumericKind Kind = NumericKind.U8; public NumericKind Classifier => Kind;}
        
        public readonly struct Primal8i : IPrimalClass { public const NumericKind Kind = NumericKind.I8; public NumericKind Classifier => Kind;}
        
        public readonly struct Primal16u : IPrimalClass { public const NumericKind Kind = NumericKind.U16; public NumericKind Classifier => Kind;}

        public readonly struct Primal16i : IPrimalClass { public const NumericKind Kind = NumericKind.I16; public NumericKind Classifier => Kind;}

        public readonly struct Primal32u : IPrimalClass { public const NumericKind Kind = NumericKind.U32; public NumericKind Classifier => Kind;}

        public readonly struct Primal32i : IPrimalClass { public const NumericKind Kind = NumericKind.I32; public NumericKind Classifier => Kind;}

        public readonly struct Primal64u : IPrimalClass { public const NumericKind Kind = NumericKind.U64; public NumericKind Classifier => Kind;}

        public readonly struct Primal64i : IPrimalClass { public const NumericKind Kind = NumericKind.I64; public NumericKind Classifier => Kind;}

        public readonly struct Primal32f : IPrimalClass { public const NumericKind Kind = NumericKind.F32; public NumericKind Classifier => Kind;}

        public readonly struct Primal64f : IPrimalClass { public const NumericKind Kind = NumericKind.F64; public NumericKind Classifier => Kind;}

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

