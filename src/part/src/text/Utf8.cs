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

    [ApiHost]
    public readonly unsafe partial struct Utf8
    {
        [MethodImpl(Inline), Op]
        public static TextEncoding encoding()
            => new TextEncoding(Encoding.UTF8);

        [MethodImpl(Inline), Op]
        public static bool nonempty(utf8p src)
            => memory.address(src.pData) != 0 && (*src.pData != 0);

        [MethodImpl(Inline), Op]
        public static ByteSize size(utf8p src)
        {
            var pData = src.pData;
            var size = 0ul;
            while(true)
            {
                if(*pData != 0)
                {
                    size++;
                    pData++;
                }
                else
                    break;
            }
            return size;
        }

        [MethodImpl(Inline), Op]
        public static int length(ReadOnlySpan<byte> src)
            => encoding().GetCharCount(src);

        [MethodImpl(Inline), Op]
        public static ref string decode(ReadOnlySpan<byte> src, out string dst)
        {
            dst = encoding().GetString(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static byte[] bytes(string src)
            => encoding().GetBytes(src);

        [MethodImpl(Inline), Op]
        public static byte[] bytes(char[] src)
            => encoding().GetBytes(src);
    }
}