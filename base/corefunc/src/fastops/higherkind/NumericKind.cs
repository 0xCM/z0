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

    partial class HK
    {
        [MethodImpl(Inline)]
        public static Numeric nk()
            => default;

        [MethodImpl(Inline)]
        public static Numeric<T> nk<T>(T t = default)
            where T : unmanaged
                => default;

        public readonly struct Numeric : ITypeKind<Numeric>
        {
            public const TypeKind Kind = TypeKind.NumericType; 

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Numeric src)
                =>  src.Classifier;
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct Numeric<T> : ITypeKind<Numeric<T>,T> 
            where T : unmanaged
        {
            public const TypeKind Kind = TypeKind.NumericType; 

            public static FixedWidth Width => (FixedWidth)bitsize<T>();

            public static NumericKind NumericKind { [MethodImpl(Inline)] get=> NumericType.kind<T>();}

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Numeric<T> src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator NumericKind(Numeric<T> src)
                => NumericKind;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(Numeric<T> src)
                =>  new TypeKind<T>(src.Classifier);

            [MethodImpl(Inline)]
            public static implicit operator Numeric(Numeric<T> src)
                =>  default;
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }

        public static Numeric<byte> u8
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Numeric<sbyte> i8
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Numeric<ushort> u16
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Numeric<short> i16
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Numeric<uint> u32
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Numeric<int> i32
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Numeric<ulong> u64
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Numeric<long> i64
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Numeric<float> f32
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Numeric<double> f64
        {
            [MethodImpl(Inline)]
            get => default;
        }
    }
}