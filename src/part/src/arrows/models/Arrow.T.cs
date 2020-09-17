//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = Arrows;

    public readonly struct Arrow<T> : IArrow<T>
    {
        public readonly T Source;

        public readonly T Target;

        [MethodImpl(Inline)]
        public static implicit operator Arrow<T>((T src, T dst) x)
            => new Arrow<T>(x.src,x.dst);

        [MethodImpl(Inline)]
        public static implicit operator (T src, T dst)(Arrow<T> a)
            => (a.Source, a.Target);

        [MethodImpl(Inline)]
        public Arrow(T src, T dst)
        {
            Source = src;
            Target = dst;
        }

        public void Deconstruct(out T src, out T dst)
        {
            src = Source;
            dst = Target;
        }

        public string Identifier
        {
            [MethodImpl(Inline)]
            get => api.identify(Source, Target);
        }

        [MethodImpl(Inline)]
        public string Format()
            => Identifier;

        public override string ToString()
            => Format();

        T IArrow<T,T>.Source
            => Source;

        T IArrow<T,T>.Target
            => Target;
    }
}