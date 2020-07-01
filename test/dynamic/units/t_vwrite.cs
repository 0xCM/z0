//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static V0;
    using static Typed;
    using static As;

    public class t_vwrite : t_vcheck<t_vwrite>
    {
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