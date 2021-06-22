//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct CmdArgs : IIndex<CmdArg>
    {
        readonly Index<ushort,CmdArg> Data;

        [MethodImpl(Inline)]
        public CmdArgs(CmdArg[] src)
        {
            Data = src;
        }

        public ushort Count
        {
            [MethodImpl(Inline)]
            get => (ushort)Data.Count;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public Span<CmdArg> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public CmdArg[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public ReadOnlySpan<CmdArg> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdArgs(CmdArg[] src)
            => new CmdArgs(src);

        public static CmdArgs Empty
        {
            [MethodImpl(Inline)]
            get => new CmdArgs(core.array<CmdArg>());
        }
    }
}