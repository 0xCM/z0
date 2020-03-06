//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    
    using static Root;
    using static Nats;
    
    public class t_bg_dim : t_bg<t_bg_dim>
    {        

        public void nbg_describe_dim()
        {
            var g1 = BitGrid.dimension<N128,N4,N32,uint>();
            Claim.eq(g1.BitCount,128);
            Claim.eq(g1.BlockLength,4);
            Claim.eq(g1.BlockWidth,128);
            Claim.eq(g1.ByteCount,16);
            Claim.eq(g1.CellCount,4);
            Claim.eq(g1.CellWidth,32);
            Claim.eq(g1.ColCount, 32);
            Claim.eq(g1.RowCount, 4);
            Claim.eq(g1.BlockCount,1);

            var g2 = BitGrid.dimension<N256,N16,N16,byte>();
            Claim.eq(g2.BitCount,256);
            Claim.eq(g2.BlockLength,32);
            Claim.eq(g2.BlockWidth,256);
            Claim.eq(g2.ByteCount,32);
            Claim.eq(g2.CellCount,32);
            Claim.eq(g2.CellWidth,8);
            Claim.eq(g2.ColCount, 16);
            Claim.eq(g2.RowCount, 16);
            Claim.eq(g2.BlockCount,1);

        }

        public void nbg_dimensions()
        {

            var d256a = BitGrid.p2dimensions(Pow2.T08).OrderBy(x =>x.I).ThenBy(x => x.J).ToArray();
            var d256b = BitGrid.dimensions(n256).OrderBy(x =>x.I).ThenBy(x => x.J).ToArray();
            for(var i=0; i< zfunc.length(d256a,d256b); i++)
            {
                Claim.eq(d256a[i].I, d256b[i].I);
                Claim.eq(d256a[i].J, d256b[i].J);
            }
            
            var d128a = BitGrid.p2dimensions(Pow2.T07).OrderBy(x =>x.I).ThenBy(x => x.J).ToArray();
            var d128b = BitGrid.dimensions(n128).OrderBy(x =>x.I).ThenBy(x => x.J).ToArray();
            for(var i=0; i< zfunc.length(d128a,d128b); i++)
            {
                Claim.eq(d128a[i].I, d128b[i].I);
                Claim.eq(d128a[i].J, d128b[i].J);
            }
            
        }

    }

}