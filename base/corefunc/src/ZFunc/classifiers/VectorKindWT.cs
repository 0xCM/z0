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

    public readonly struct VectorKind<W,T> : IVectorKind<W,T>
        where W : unmanaged, ITypeNat
        where T : unmanaged
            
    {
        public static VectorKind<W,T> TheOnly => default;

        [MethodImpl(Inline)]
        public static implicit operator VectorKind(VectorKind<W,T> v)
            => v.Classifier;

        public VectorKind Classifier 
        {
            [MethodImpl(Inline)]
            get => VectorType.kind<W,T>();
        }
    }
}