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

    public readonly struct CmdExpr : ITextual, IIdentified<asci32>, IContented<string>
    {
        public asci32 Id {get;}

        public bool Anonymous {get;}

        public string Content {get;}

        [MethodImpl(Inline)]
        public CmdExpr(string src)
        {
            Id = Cmd.Anonymous;
            Content = src;
            Anonymous = true;
        }

        [MethodImpl(Inline)]
        public CmdExpr(string name, string src)
        {
            Id = name;
            Content = src;
            Anonymous = false;
        }

        [MethodImpl(Inline)]
        internal CmdExpr(in asci32 name, string src)
        {
            Id = name;
            Content = src;
            Anonymous = false;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdExpr(string src)
            => new CmdExpr(src);

        [MethodImpl(Inline)]
        public static implicit operator string(CmdExpr src)
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator CmdExpr(Pair<string> src)
            => new CmdExpr(src.Left, src.Right);

        [MethodImpl(Inline)]
        public string Format()
            => Content ?? EmptyString;

        public override string ToString()
            => Format();
    }
}