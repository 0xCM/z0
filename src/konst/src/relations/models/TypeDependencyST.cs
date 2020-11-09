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

    public readonly struct TypeDependency<S,T>
    {
        public Type Source
            => typeof(S);

        public Type Target
            => typeof(T);

        [MethodImpl(Inline)]
        public string Format()
            => string.Format(RP.ArrowAxB, Source.Name, Target.Name);

        [MethodImpl(Inline)]
        public static implicit operator FlowType<S,T>(TypeDependency<S,T> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator TypeDependency(TypeDependency<S,T> x)
            => (x.Source,x.Target);
    }
}