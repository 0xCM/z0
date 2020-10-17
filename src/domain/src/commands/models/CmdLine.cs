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

    public readonly struct CmdLine
    {
        public string Content {get;}

        [MethodImpl(Inline)]
        public CmdLine(string content)
        {
            Content = content;
        }

        public string ToolName
            => Content?.LeftOfFirst(Space) ?? EmptyString;

        [MethodImpl(Inline)]
        public static implicit operator CmdLine(string src)
            => new CmdLine(src);

        [MethodImpl(Inline)]
        public string Format()
            => Content;

        public override string ToString()
            => Format();
    }
}