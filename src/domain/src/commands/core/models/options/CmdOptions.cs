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

    public readonly struct CmdOptions : ITextual
    {
        readonly TableSpan<CmdOption> Data;

        [MethodImpl(Inline)]
        public CmdOptions(CmdOption[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator CmdOptions(CmdOption[] src)
            => new CmdOptions(src);

        public ReadOnlySpan<CmdOption> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<CmdOption> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public byte Count
        {
            [MethodImpl(Inline)]
            get => (byte)Data.Length;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}