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

    public readonly struct CmdPattern
    {
        public string Id {get;}

        public bool Anonymous {get;}

        public string Content {get;}

        [MethodImpl(Inline)]
        public CmdPattern(string src)
        {
            Id = Cmd.Anonymous;
            Content = src;
            Anonymous = true;
        }

        [MethodImpl(Inline)]
        public CmdPattern(string name, string src)
        {
            Id = name;
            Content = src;
            Anonymous = false;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdPattern(string src)
            => new CmdPattern(src);

        [MethodImpl(Inline)]
        public static implicit operator string(CmdPattern src)
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator CmdPattern(Pair<string> src)
            => new CmdPattern(src.Left, src.Right);

        public override string ToString()
            => Content;
    }
}