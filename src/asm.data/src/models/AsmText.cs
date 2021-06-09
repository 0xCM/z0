//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    using api = AsmTextBuilder;

    [StructLayout(LayoutKind.Sequential, Size=16, Pack =1)]
    public readonly struct AsmText : IAsmText<AsmText>
    {
        public StringAddress Source {get;}

        public AsmTextKind Kind {get;}

        [MethodImpl(Inline)]
        public AsmText(StringAddress src, AsmTextKind kind = default)
        {
            Source = src;
            Kind = kind;
        }

        [MethodImpl(Inline)]
        public AsmText WithKind(AsmTextKind kind)
            => new AsmText(Source, kind);

        [MethodImpl(Inline)]
        public uint Render(ref uint i, Span<char> dst)
            => Source.Render(ref i, dst);

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator AsmText(ReadOnlySpan<char> src)
            => new AsmText(TextTools.address(src));

        [MethodImpl(Inline)]
        public static implicit operator AsmText(ReadOnlySpan<byte> src)
            => new AsmText(TextTools.address(src));
    }
}