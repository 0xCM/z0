//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    public readonly partial struct IntelSdm
    {
        [MethodImpl(Inline)]
        public static TableNumber table(ReadOnlySpan<char> src)
        {
            var dst = CharBlock8.Null;
            var count = min(src.Length, dst.Length);
            var buffer = dst.Data;
            for(var i=0; i<count; i++)
                seek(buffer,i) = skip(src,i);
            return new TableNumber(dst);
        }

        public static void render(SectionNumber src, ITextBuffer dst)
        {
            var count = src.Count;
            if(count >= 1)
                dst.Append(src.A.ToString());
            if(count >= 2)
                dst.Append(string.Format(".{0}",src.B));
            if(count >= 3)
                dst.Append(string.Format(".{0}",src.C));
            if(count >= 4)
                dst.Append(string.Format(".{0}",src.D));
        }
    }
}