//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static V0;
    using static Typed;
    using static As;

    public class t_vwrite : t_vcheck<t_vwrite>
    {
        string format(ReadOnlySpan<char> src)
        {
            return sys.@string(src);
        }

        public void format_hex()
        {       
            var refs = xHex.store(n3, new StringRef[Hex3.Count]);
            for(var i=0; i<refs.Length; i++)
            {
                var current = refs[i];
                if(i != 0)
                    Trace(current.Diagnostic(refs[i - 1]));
                else
                    Trace(current.Diagnostic());
            }

            // var s00 = format(xHex.chars(src, Hex4Kind.x00));
            // var s01 = format(xHex.chars(src, Hex4Kind.x01));
            // var s02 = format(xHex.chars(src, Hex4Kind.x02));
            // var s03 = format(xHex.chars(src, Hex4Kind.x03));
            // var s04 = format(xHex.chars(src, Hex4Kind.x04));
            // var s05 = format(xHex.chars(src, Hex4Kind.x05));

            // Trace(s00);
            // Trace(s01);
            // Trace(s02);
            // Trace(s03);
            // Trace(s04);
            // Trace(s05);

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