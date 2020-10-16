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

    public readonly struct CmdLinePattern
    {
        readonly string Content;

        [MethodImpl(Inline)]
        public CmdLinePattern(string src)
        {
            Content = src;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdLinePattern(string src)
            => new CmdLinePattern(src);

        [MethodImpl(Inline)]
        public static implicit operator string(CmdLinePattern src)
            => src.Text;

        public string Text
        {
            [MethodImpl(Inline)]
            get => Content;
        }
    }
}
