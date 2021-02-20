//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Captures the content of a command-line
    /// </summary>
    public readonly struct CmdLine
    {
        readonly Index<string> Data;

        [MethodImpl(Inline)]
        public CmdLine(params string[] content)
            => Data = content;

        public ReadOnlySpan<CmdLinePart> Parts
        {
            [MethodImpl(Inline)]
            get => memory.recover<string,CmdLinePart>(Data.Edit);
        }

        [MethodImpl(Inline)]
        public string Format()
            => Seq.delimit(Chars.Space, Data).Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CmdLine(string src)
            => new CmdLine(src);

        [MethodImpl(Inline)]
        public static implicit operator CmdLine(string[] src)
            => new CmdLine(src);

        [MethodImpl(Inline)]
        public static implicit operator string(CmdLine src)
            => src.Format();

        public static CmdLine Empty
        {
            [MethodImpl(Inline)]
            get => new CmdLine(sys.empty<string>());
        }
    }
}