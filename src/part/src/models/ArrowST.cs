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
        public readonly S Src;

        public readonly T Dst;

        [MethodImpl(Inline)]
        public Arrow(S src, T dst)
        {
            Src = src;
            Dst = dst;
        }

        public void Deconstruct(out S src, out T dst)
        {
            src = Src;
            dst = Dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator Arrow<S,T>((S src, T dst) x)
            => new Arrow<S,T>(x.src, x.dst);

        [MethodImpl(Inline)]
        public static implicit operator (S src, T dst)(Arrow<S,T> a)
            => (a.Src, a.Dst);

        public string Identifier
        {
            [MethodImpl(Inline)]
            get => string.Concat(Src, Connector, Dst);
        }

        S IArrow<S,T>.Src 
            => Src;

        T IArrow<S,T>.Dst 
            => Dst;

        public string Format()
            => Identifier;

        public override string ToString()
            => Format();
    }
}