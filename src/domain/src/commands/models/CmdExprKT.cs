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

    public readonly struct CmdExpr<K,T> : ITextual, IIdentified<K>, IContented<T>
        where K : unmanaged
    {
        public K Id {get;}

        public T Content {get;}

        [MethodImpl(Inline)]
        public CmdExpr(T src)
        {
            Id = default;
            Content = src;
        }

        [MethodImpl(Inline)]
        public CmdExpr(K id, T src)
        {
            Id = id;
            Content = src;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdExpr<K,T>(T src)
            => new CmdExpr<K,T>(src);

        [MethodImpl(Inline)]
        public static implicit operator string(CmdExpr<K,T> src)
            => src.Format();

        [MethodImpl(Inline)]
        public string Format()
            => Content?.ToString() ?? EmptyString;

        public override string ToString()
            => Format();
    }
}