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

    public readonly struct TypeKindN1<N,T> : ITypeKindN1<N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        public static TypeKindN1<N,T> None => default;

        [MethodImpl(Inline)]
        public TypeKindN1(TypeKind k)
        {
            this.Classifier = k;
        }
        
        public TypeKind Classifier {get;}
    }

    public readonly struct TypeKindN2<M,N,T> : ITypeKindN2<M,N,T>
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        public static TypeKindN2<M,N,T> None => default;

        [MethodImpl(Inline)]
        public TypeKindN2(TypeKind k)
        {
            this.Classifier = k;
        }

        public TypeKind Classifier {get;}
    }        
}