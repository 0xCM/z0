//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static V0;
    using static Typed;
    using static As;
    using static Konst;

    public class t_vwrite : t_vcheck<t_vwrite>
    {
        public static void asci_format_16()
        {
            term.print(AsciFormatter.format((asci2)"01"));
            term.print(AsciFormatter.format((asci4)"1234"));
            term.print(AsciFormatter.format((asci8)"abcdefg"));
            term.print(AsciFormatter.format((asci16)"abcdefghijklmnop"));
            term.print(AsciFormatter.format((asci32)"abcdefghijklmnopqrstuvwxyz"));
            term.print(AsciFormatter.format((asci64)"abcdefghijklmnopqrstuvwxyzABCdDEghijklmnopqrstuvwxyz"));
            term.print(AsciFormatter.format((asci64)"ABCdDEghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz"));
        }

        public static unsafe string format(ReadOnlySpan<char> src)
        {
            const string Buffer = "                                                                                                                                ";

            var pDst = As.pchar(Buffer);
            var pSrc = As.gptr(first(src));
            var count = Math.Min(src.Length, Buffer.Length);
            for(var i=0; i<count; i++)
                *pDst++ = *pSrc++;
                            
            return Buffer;
        }

        public void format_1()
        {
            var src = "abcdefghijklmnopqrstuvwxyz";
            var dst = format(src);
            term.print(dst.Length);
            term.print(dst);

        }
        public unsafe void format_3()
        {
            const string A = "abcdefghijklmnopqrstuvwxyz";

            var src = A;
            var r = Refs.from(src);
            Claim.eq(A.Length, r.CellCount);
            Claim.eq(A.Length*2, r.DataSize);
            
            for(var i=0; i<src.Length; i++)
                Claim.eq(r[i],src[i]);     

            var pSrc = (char*)r.Location; 
            var data = cover(pSrc, A.Length);
            
            ref readonly var rC = ref As.@ref(pSrc);

            
            for(var i=0u; i<data.Length; i++)
                term.write(skip(data,i));
            
            term.print();
        }

        public void format_2()
        {       
            var refs = Hex.store(n3, new StringRef[Hex3.Count]);

        }
        
        public void check_vwrite_u8()
        {
            var src = Random.Span<byte>(16);        
            var dst = vcover<uint>(w128, ref first(src));
            var a = Spans.alloc<uint>(4);
            vsave(dst, ref first(a));
            var b = uint32(src);

            Claim.eq(a,b);

        }
    }
}