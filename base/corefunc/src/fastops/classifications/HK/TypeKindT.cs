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
        public readonly struct TypeKind<T> : IHKType<TypeKind<T>,T>
            where T : unmanaged
        {
            public static TypeKind<T> None => default;

            [MethodImpl(Inline)]
            public TypeKind(HKTypeKind k)
            {
                this.Classifier = k;
            }

            public HKTypeKind Classifier {get;}
        }
    }
}