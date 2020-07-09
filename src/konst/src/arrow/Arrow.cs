//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Arrow<T> : IArrow<T>
    {
        public readonly T Src;

        public readonly T Dst;

        [MethodImpl(Inline)]
        public static implicit operator Arrow<T>((T src, T dst) x)
            => new Arrow<T>(x.src,x.dst);

        [MethodImpl(Inline)]
        public static implicit operator (T src, T dst)(Arrow<T> a)
            => (a.Src, a.Dst);

        [MethodImpl(Inline)]
        public Arrow(T src, T dst)
        {
            Src = src;
            Dst = dst;
        }

        public void Deconstruct(out T src, out T dst)
        {
            src = Src;
            dst = Dst;
        }

        public string Identifier
        {
            get => text.concat(text.format(Src), " -> ", text.format(Dst));
        }

        public string Format()
            => Identifier;

        public override string ToString()
            => Format();

        T IArrow<T>.Src
            => Src;

        T IArrow<T>.Dst
            => Dst;
    }
}