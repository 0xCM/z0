//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Root;

    partial class text
    {
        [MethodImpl(Inline), Op]
        public static BinaryCode asci(string src)
            => Encoding.ASCII.GetBytes(src);

        [MethodImpl(Inline), Op]
        public static string asci(ReadOnlySpan<byte> src)
            => Encoding.ASCII.GetString(src);

        [MethodImpl(Inline), Op]
        public static void asci(ReadOnlySpan<byte> src, Span<char> dst)
            => Encoding.ASCII.GetChars(src,dst);

        [MethodImpl(Inline), Op]
        public static unsafe string asci(byte* pSrc, ByteSize size)
            => Encoding.ASCII.GetString(pSrc,size);
    }
}