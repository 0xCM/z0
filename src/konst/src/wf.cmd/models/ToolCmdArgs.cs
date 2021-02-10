//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ToolCmdArgs : IIndex<ToolCmdArg>
    {
        readonly Index<ToolCmdArg> Data;

        [MethodImpl(Inline)]
        public ToolCmdArgs(ToolCmdArg[] src)
        {
            Data = src;
        }

        public string Format(string sep)
            => string.Join(sep, Data.Storage);
        public string Format()
            => Format(" ");

        public override string ToString()
            => Format();
        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ReadOnlySpan<ToolCmdArg> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<ToolCmdArg> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ToolCmdArg[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        [MethodImpl(Inline)]
        public static implicit operator ToolCmdArgs(string[] src)
            => new ToolCmdArgs(src.Select(x => new ToolCmdArg(x)));

        [MethodImpl(Inline)]
        public static implicit operator ToolCmdArgs(ToolCmdArg[] src)
            => new ToolCmdArgs(src);

        [MethodImpl(Inline)]
        public static implicit operator ToolCmdArg[](ToolCmdArgs src)
            => src.Data;
    }
}
