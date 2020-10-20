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

    public readonly struct CmdPattern
    {
        public string Id {get;}

        public string Content {get;}

        [MethodImpl(Inline)]
        public CmdPattern(string content)
        {
            Id = Cmd.Anonymous;
            Content = content;
        }

        [MethodImpl(Inline)]
        public CmdPattern(string id, string content)
        {
            Id = id;
            Content = content;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.blank(Content);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !text.blank(Content);
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

        public static CmdPattern Empty => new CmdPattern(EmptyString, EmptyString);
    }
}