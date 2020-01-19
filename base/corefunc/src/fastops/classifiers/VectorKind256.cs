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

    public readonly struct VectorKind256<T> : IVectorKind<N256,T>
        where T : unmanaged
            
    {
        public static VectorKind256<T> TheOnly => default;

        [MethodImpl(Inline)]
        public static implicit operator VectorKind(VectorKind256<T> v)
            => v.Classifier;

        public VectorKind Classifier 
        {
            [MethodImpl(Inline)]
            get => VectorType.kind<N256,T>();
        }
    }
}