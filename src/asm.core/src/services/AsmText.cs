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
    using static core;

    [StructLayout(LayoutKind.Sequential, Size=16, Pack =1), ApiHost]
    public readonly struct AsmText : IAsmText<AsmText>
    {
        public static string format<T>(T src)
            where T : unmanaged, IAsmText
        {
            Span<char> dst = stackalloc char[(int)src.Source.Length];
            var i=0u;
            var count = src.Render(ref i, dst);
            return text.format(slice(dst,0,count));
        }

        [MethodImpl(Inline), Op, Closures(UInt8x16k)]
        public static AsmText<T> asmtext<T>(ReadOnlySpan<T> src, AsmTextKind kind = default)
            where T : unmanaged
                =>  new AsmText<T>(text.address(src), kind);

        [MethodImpl(Inline), Op]
        public static AsmText<byte> asmtext(StringAddress src, AsmTextKind kind = default)
            => new AsmText<byte>(src, kind);

        [MethodImpl(Inline), Op]
        public static AsmText<byte> asmtext(string src, AsmTextKind kind = default)
            => asmtext(text.address(src), kind);

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
            => format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator AsmText(ReadOnlySpan<char> src)
            => new AsmText(text.address(src));

        [MethodImpl(Inline)]
        public static implicit operator AsmText(ReadOnlySpan<byte> src)
            => new AsmText(text.address(src));
    }
}