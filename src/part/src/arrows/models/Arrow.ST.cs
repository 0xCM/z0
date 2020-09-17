//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Arrow<S,T> : IArrow<Arrow<S,T>,S,T>
    {
        public readonly S Source;

        public readonly T Target;

        [MethodImpl(Inline)]
        public Arrow(S src, T dst)
        {
            Source = src;
            Target = dst;
        }

        public void Deconstruct(out S src, out T dst)
        {
            src = Source;
            dst = Target;
        }

        [MethodImpl(Inline)]
        public static implicit operator Arrow<S,T>((S src, T dst) x)
            => new Arrow<S,T>(x.src, x.dst);

        [MethodImpl(Inline)]
        public static implicit operator (S src, T dst)(Arrow<S,T> a)
            => (a.Source, a.Target);

        public string Identifier
        {
            [MethodImpl(Inline)]
            get => string.Concat(Source, Connector, Target);
        }

        S IArrow<S,T>.Source
            => Source;

        T IArrow<S,T>.Target
            => Target;

        public string Format()
            => Identifier;

        public override string ToString()
            => Format();
    }
}