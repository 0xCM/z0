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

        public readonly struct Numeric : IHKType<Numeric>
        {
            public const HKTypeKind Kind = HKTypeKind.NumericType; 

            [MethodImpl(Inline)]
            public static implicit operator HKTypeKind(Numeric src)
                =>  src.Classifier;
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct Numeric<T> : IHKType<Numeric<T>,T> 
            where T : unmanaged
        {
            public const HKTypeKind Kind = HKTypeKind.NumericType; 

            public static FixedWidth Width => (FixedWidth)bitsize<T>();

            [MethodImpl(Inline)]
            public static implicit operator HKTypeKind(Numeric<T> src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(Numeric<T> src)
                =>  new TypeKind<T>(src.Classifier);

            [MethodImpl(Inline)]
            public static implicit operator Numeric(Numeric<T> src)
                =>  default;
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }
    }
}