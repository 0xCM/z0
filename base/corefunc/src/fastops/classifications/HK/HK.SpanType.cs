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

        /// <summary>
        /// Reifies a non-parametric span kind
        /// </summary>
        [MethodImpl(Inline)]
        public static SpanType spk()
                => default;

        /// <summary>
        /// Reifies a primal-parametric span kind
        /// </summary>
        [MethodImpl(Inline)]
        public static SpanType<T> spk<T>(T t = default)
            where T : unmanaged
                => default;

        public readonly struct SpanType : IHKType<SpanType>
        {
            public const HKTypeKind Kind = HKTypeKind.SpanType; 

            [MethodImpl(Inline)]
            public static implicit operator HKTypeKind(SpanType src)
                =>  src.Classifier;
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct SpanType<T> : IHKType<SpanType<T>,T> 
            where T : unmanaged
        {
            public const HKTypeKind Kind = HKTypeKind.SpanType; 

            [MethodImpl(Inline)]
            public static implicit operator SpanType(SpanType<T> src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(SpanType<T> src)
                =>  new TypeKind<T>(src.Classifier);
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }
    }
}