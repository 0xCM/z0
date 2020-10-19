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

    public readonly struct CmdExpr<T> : ITextual, IIdentified<asci32>, IContented<T>
    {
        public asci32 Id {get;}

        public bool Anonymous {get;}

        public T Content {get;}

        [MethodImpl(Inline)]
        public CmdExpr(T src)
        {
            Id = Cmd.Anonymous;
            Content = src;
            Anonymous = true;
        }

        [MethodImpl(Inline)]
        public CmdExpr(string name, T src)
        {
            Id = name;
            Content = src;
            Anonymous = false;
        }

        [MethodImpl(Inline)]
        internal CmdExpr(in asci32 name, T src)
        {
            Id = name;
            Content = src;
            Anonymous = false;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdExpr<T>(T src)
            => new CmdExpr<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator string(CmdExpr<T> src)
            => src.Format();

        [MethodImpl(Inline)]
        public string Format()
            => Content?.ToString() ?? EmptyString;

        public override string ToString()
            => Format();
    }
}