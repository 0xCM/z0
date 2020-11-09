//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Arrow<T> : IArrow<T>
    {
        public T Source {get;}

        public T Target {get;}

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
            get => string.Format("{0} -> {1}", Source, Target);
        }

        [MethodImpl(Inline)]
        public string Format()
            => Identifier;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Arrow<T>((T src, T dst) x)
            => new Arrow<T>(x.src,x.dst);

        [MethodImpl(Inline)]
        public static implicit operator Arrow<T>(Pair<T> x)
            => new Arrow<T>(x.Left,x.Right);

        [MethodImpl(Inline)]
        public static implicit operator (T src, T dst)(Arrow<T> a)
            => (a.Source, a.Target);
    }
}