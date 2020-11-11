//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    public class t_vwrite : t_vcheck<t_vwrite>
    {
        static void asci_format_16()
        {
            term.print(AsciFormatter.format((asci2)"01"));
            term.print(AsciFormatter.format((asci4)"1234"));
            term.print(AsciFormatter.format((asci8)"abcdefg"));
            term.print(AsciFormatter.format((asci16)"abcdefghijklmnop"));
            term.print(AsciFormatter.format((asci32)"abcdefghijklmnopqrstuvwxyz"));
            term.print(AsciFormatter.format((asci64)"abcdefghijklmnopqrstuvwxyzABCdDEghijklmnopqrstuvwxyz"));
            term.print(AsciFormatter.format((asci64)"ABCdDEghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz"));
        }

        static unsafe string format(ReadOnlySpan<char> src)
        {
            const string Buffer = "                                                                                                                                ";

            var pDst = z.pchar(Buffer);
            var pSrc = z.gptr(first(src));
            var count = Math.Min(src.Length, Buffer.Length);
            for(var i=0; i<count; i++)
                *pDst++ = *pSrc++;

            return Buffer;
        }

        public unsafe void check_ref_data()
        {
            const string A = "abcdefghijklmnopqrstuvwxyz";

            var src = A;
            var r = z.view(src);
            Claim.eq(A.Length, r.Length);

            for(var i=0; i<src.Length; i++)
                Claim.eq(r[i], src[i]);
        }

        public void check_vwrite_u8()
        {
            var src = Random.Span<byte>(16);
            var dst = z.vcover<uint>(w128, ref first(src));
            var a = Spans.alloc<uint>(4);
            z.vsave(dst, ref first(a));
            var b = SeqMap.u32(src);

            Claim.eq(a,b);
        }
    }
}