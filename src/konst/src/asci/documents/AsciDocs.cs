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

    [ApiHost]
    public readonly struct AsciDocs
    {
        [MethodImpl(Inline), Op]
        public static AsciCell cell(uint row, uint col, AsciSymbols content)
            => new AsciCell(row, col, content);

        [MethodImpl(Inline), Op]
        public static Span<char> chars(in AsciCell src)
        {
            var dst = span<char>(src.Width);
            encode(src,ref first(dst));
            return dst;
        }
            
        [MethodImpl(Inline), Op]
        public static void encode(in AsciCell src, ref char dst)
        {
            var input = src.View;
            for(var i=0u; i<src.Width; i++)
                seek(dst,i) =  (char)skip(input,i);
        }
    }
}