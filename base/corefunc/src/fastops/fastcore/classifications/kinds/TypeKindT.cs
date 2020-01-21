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
}