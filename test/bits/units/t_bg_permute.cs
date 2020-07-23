//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public class t_bg_permute : t_bitgrids<t_bg_permute>
    {                
        public void bg_permute_32x5()
        {
            var p = Permute.natural(n32);
            Claim.eq(p.Length,32);
            
            var g = SubGrid.init(p);
        }
        
        public void bg_permute_16x4()
        {
            var identity = Permutary.identity(n16);
            var iterms = identity.Literals();
            var g1 = identity.ToBitGrid();
            var iperm = identity.ToNatural();            
            var g2 = iperm.ToBitGrid();
            Claim.Require(g1 == g2);
        
        }

        public void bg_permute_8x3()
        {
            var id = Permutary.identity(n8);
            var idterms = id.Literals();
            var g1 = id.ToSubGrid();
            var iperm = id.ToNatural();
            var g2 = iperm.ToSubGrid();
            //Claim.yea(g1 == g2);        
        }

        public void perm_8x32_digits()
        {
            var symbols = NatSpan.parts(n8, Perm8L.B, Perm8L.A, Perm8L.D, Perm8L.C, Perm8L.F, Perm8L.E, Perm8L.H, Perm8L.G);
            var spec = Permutary.assemble(symbols[0], symbols[1], symbols[2], symbols[3], symbols[4], symbols[5], symbols[6], symbols[7]);
            
            //[o1, o0, o3, o2, o5, o4, o7, o6]
            var digits = spec.ToDigits();
            for(var i =0; i<8; i++)
                Claim.Eq((uint)symbols[i], (uint)digits[i]);
                        
        }

        public void bg_perm_8x32_bits()
        {
            var p1 = Permutary.identity(n8);
            var v1 = BitVector24.FromEnum(p1);
            var p1F = p1.ToBitString(24).Format(3);            
            var v1F = v1.Format(3);
            ClaimPrimalSeq.eq(p1F, v1F);
            
            var p2 = Permutary.reversed(n8);
            var p2F = p2.ToBitString(24).Format(3);
            var v2 = BitVector24.FromEnum(p2);
            var v2F = v2.Format(3);
            ClaimPrimalSeq.eq(p2F, v2F);

            Claim.Require(v2.ToSubGrid(n8,n3) == p2.ToSubGrid());
        }       
    }
}