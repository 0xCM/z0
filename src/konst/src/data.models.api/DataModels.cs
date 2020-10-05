//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct DataModels
    {

    }

    public readonly struct Mapped<S> : ITextual
    {
        public readonly S Source;

        public readonly string Target;

        [MethodImpl(Inline)]
        public Mapped(S src, string dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Target;
    }

    public readonly struct TextMapper<S> : IProjector<S,string>
    {
        readonly Func<S,string> Fx;

        [MethodImpl(Inline)]
        public TextMapper(Func<S,string> fx)
        {
            Fx = fx;
        }

        [MethodImpl(Inline)]
        public string Invoke(S a)
            => Fx(a);
    }
}