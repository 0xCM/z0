//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Name<S> : IName<S>
    {
        public readonly S Content;

        [MethodImpl(Inline)]
        public Name(S src)
            => Content = src;

        [MethodImpl(Inline)]
        public static implicit operator Name<S>(S src)
            => new Name<S>(src);

        [MethodImpl(Inline)]
        public static implicit operator S(Name<S> src)
            => src.Content;

        public static implicit operator Name(Name<S> src)
            => new Name(src.Format());

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(Content);

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => (uint)Content.GetHashCode();
        }


        [MethodImpl(Inline)]
        public bool Equals(Name<S> src)
            => object.Equals(Content, src.Content);

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Content.GetHashCode();

        public override bool Equals(object src)
            => src is Name n && Equals(n);

        S IContented<S>.Content
            => Content;
    }
}