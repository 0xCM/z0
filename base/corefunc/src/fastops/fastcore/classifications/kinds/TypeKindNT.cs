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
}