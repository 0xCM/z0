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
        public readonly S Data;

        [MethodImpl(Inline)]
        public Name(S src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator Name<S>(S src)
            => new Name<S>(src);

        [MethodImpl(Inline)]
        public static implicit operator S(Name<S> src)
            => src.Data;

        public static implicit operator Name(Name<S> src)
            => new Name(src.Format());

        [MethodImpl(Inline)]
        public string Format()
            => string.Format("{0}", Data);

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => (uint)Data.GetHashCode();
        }

        [MethodImpl(Inline)]
        public bool Equals(Name<S> src)
            => object.Equals(Data, src.Data);

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Data.GetHashCode();

        public override bool Equals(object src)
            => src is Name n && Equals(n);

        S IContented<S>.Content
            => Data;
    }
}