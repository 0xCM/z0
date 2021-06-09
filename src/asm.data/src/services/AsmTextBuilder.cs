//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly struct AsmTextBuilder
    {
        [MethodImpl(Inline), Op, Closures(UInt8x16k)]
        public static AsmText<T> asmtext<T>(ReadOnlySpan<T> src, AsmTextKind kind = default)
            where T : unmanaged
                =>  new AsmText<T>(TextTools.address(src), kind);

        [MethodImpl(Inline), Op]
        public static AsmText<byte> asmtext(StringAddress src, AsmTextKind kind = default)
            => new AsmText<byte>(src, kind);

        [MethodImpl(Inline), Op]
        public static AsmText<byte> asmtext(string src, AsmTextKind kind = default)
            => asmtext(TextTools.address(src), kind);

        public static string format<T>(T src)
            where T : unmanaged, IAsmText
        {
            Span<char> dst = stackalloc char[(int)src.Source.Length];
            var i=0u;
            var count = src.Render(ref i, dst);
            return new string(core.slice(dst,0,count));
        }
    }
}