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

    /// <summary>
    /// Captures the content of a command-line
    /// </summary>
    public readonly struct CmdLine
    {
        public string Content {get;}

        [MethodImpl(Inline)]
        public CmdLine(string content)
            => Content = content;

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