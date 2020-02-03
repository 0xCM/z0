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

    /// <summary>
    /// Clasifies types
    /// </summary>
    [Flags]
    public enum TypeKind : uint
    {    
        None = 0,
        
        NumericType = Pow2.T00,

        SpanType = Pow2.T01,
        
        FixedType = Pow2.T08,

        FixedTypeSeg = Pow2.T09,

        BlockedType = Pow2.T10,

        VectorType = Pow2.T11,

        UserType = Pow2.T12,

        BitVectorType = Pow2.T15,

        BitMatrixType = Pow2.T16,

        BitGridType = Pow2.T17,
    }

    public readonly struct TypeKind<T> : ITypeKind<TypeKind<T>,T>
        where T : unmanaged
    {
        public static TypeKind<T> None => default;

        [MethodImpl(Inline)]
        public TypeKind(TypeKind k)
        {
            this.Classifier = k;
        }

        public TypeKind Classifier {get;}
    }

    public readonly struct TypeKind<N,T> : ITypeKind<TypeKind<N,T>,N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        public static TypeKind<N,T> None => default;

        [MethodImpl(Inline)]
        public TypeKind(TypeKind k)
        {
            this.Classifier = k;
        }
        
        public TypeKind Classifier {get;}
    }

    public readonly struct TypeKind<M,N,T> : ITypeKind<TypeKind<M,N,T>,M,N,T>
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        public static TypeKind<M,N,T> None => default;

        [MethodImpl(Inline)]
        public TypeKind(TypeKind k)
        {
            this.Classifier = k;
        }

        public TypeKind Classifier {get;}
    }        
}