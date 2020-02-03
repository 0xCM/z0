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

    public static partial class HK
    {
        [MethodImpl(Inline)]
        public static FixedType<F> ftk<F>(F f = default)
            where F : unmanaged, IFixed
                => default;

        [MethodImpl(Inline)]
        public static FixedType<F,T> ftk<F,T>(F f = default, T t = default)
            where F : unmanaged, IFixed
            where T : unmanaged
                => default;

        public readonly struct FixedType<F> : IFixedKind<F>
            where F : unmanaged, IFixed
        {
            public static int BitCount => (int)Width;

            public const TypeKind Kind = TypeKind.FixedType;      

            public static FixedWidth Width => default(F).Width;

            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}

        }

        public readonly struct FixedType<F,T> : IFixedKind<F,T>
            where F : unmanaged, IFixed
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public static implicit operator FixedType<F>(FixedType<F,T> src)
                =>  default;

            public const TypeKind Kind = TypeKind.FixedTypeSeg;      

            public static FixedWidth Width => default(F).Width;

            public static int BitCount => (int)Width;

            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}

            public FixedKind Class1 { [MethodImpl(Inline)] get => (FixedKind)Width;}

            public NumericKind Class2 { [MethodImpl(Inline)] get => NumericType.kind<T>();}
        }
    }
}