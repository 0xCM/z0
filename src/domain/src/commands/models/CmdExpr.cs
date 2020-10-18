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

    using api = Cmd;

    public readonly struct CmdExpr
    {
        readonly string Content;

        [MethodImpl(Inline)]
        public CmdExpr(string src)
            => Content = src;

        [MethodImpl(Inline)]
        public static implicit operator CmdExpr(string src)
            => new CmdExpr(src);

        [MethodImpl(Inline)]
        public static implicit operator string(CmdExpr src)
            => src.Text;

        public string Text
        {
            [MethodImpl(Inline)]
            get => Content;
        }
    }
}
