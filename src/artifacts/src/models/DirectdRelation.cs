//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static ArtifactModel;

    public readonly struct DirectedRelation<S,T>
    {
        [MethodImpl(Inline)]
        public static implicit operator DirectedRelation<S,T>((TypeRef<S> src, TypeRef<T> dst) x)
            => default;

        public TypeRef<S> Source => default;

        public TypeRef<T> Target => default;
    }
}