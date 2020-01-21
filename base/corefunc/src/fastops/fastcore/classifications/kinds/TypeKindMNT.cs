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