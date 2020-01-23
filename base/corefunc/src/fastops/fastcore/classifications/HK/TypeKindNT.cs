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
    
    public readonly struct TypeKind<N,T> : IHKType<TypeKind<N,T>,N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        public static TypeKind<N,T> None => default;

        [MethodImpl(Inline)]
        public TypeKind(HKTypeKind k)
        {
            this.Classifier = k;
        }

        public HKTypeKind Classifier {get;}
    }
}