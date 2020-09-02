//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = AB;

    public readonly struct WfType<S,T>
    {
        public readonly Type Source;

        public readonly Type Target;

        [MethodImpl(Inline)]
        public static implicit operator WfType(WfType<S,T> src)
            => new WfType(src.Source, src.Target);

        [MethodImpl(Inline)]
        internal WfType(Type src, Type dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public bool Equals(WfType src)
            => api.eq(this, src);

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);
    }
}