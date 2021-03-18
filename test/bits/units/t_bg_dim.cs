//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MLeftT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Linq;

    public class t_bg_dim : t_bits<t_bg_dim>
    {
        public void nbg_dimensions()
        {
            var d256a = BitGrid.p2dimensions(Pow2.T08).OrderBy(x =>x.Left).ThenBy(x => x.Right).ToArray();
            var d256b = BitGrid.dims(n256).OrderBy(x =>x.Left).ThenBy(x => x.Right).ToArray();
            for(var i=0; i< Claim.length(d256a,d256b); i++)
            {
                Claim.eq(d256a[i], d256b[i]);
                Claim.eq(d256a[i], d256b[i]);
            }

            var d128a = BitGrid.p2dimensions(Pow2.T07).OrderBy(x =>x.Left).ThenBy(x => x.Right).ToArray();
            var d128b = BitGrid.dims(n128).OrderBy(x =>x.Left).ThenBy(x => x.Right).ToArray();
            for(var i=0; i< Claim.length(d128a,d128b); i++)
            {
                Claim.eq(d128a[i].Left, d128b[i].Left);
                Claim.eq(d128a[i].Right, d128b[i].Right);
            }
        }
    }
}