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

    public readonly struct TypeArrow<S,T>
    {

        public Type Source
            => typeof(S);

        public Type Target
            => typeof(T);

        [MethodImpl(Inline)]
        public static implicit operator FlowType<S,T>(TypeArrow<S,T> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator TypeArrow(TypeArrow<S,T> x)
            => (x.Source,x.Target);

        [MethodImpl(Inline)]
        public string Format()
            => string.Format(RP.ArrowAxB, Source.Name, Target.Name);
    }
}