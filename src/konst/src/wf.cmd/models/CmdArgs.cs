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

    public readonly struct CmdArgs
    {
        readonly TableSpan<CmdArg> Data;

        [MethodImpl(Inline)]
        public CmdArgs(CmdArg[] src)
            => Data = src;

        public ReadOnlySpan<CmdArg> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<CmdArg> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public byte Count
        {
            [MethodImpl(Inline)]
            get => (byte)Data.Length;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdArgs(CmdArg[] src)
            => new CmdArgs(src);
    }
}