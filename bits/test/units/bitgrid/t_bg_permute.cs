//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    public class t_bg_permute : t_bg<t_bg_permute>
    {                
        public void bg_permute_32x5()
        {
            var p = Perm.natural(n32);
            Claim.eq(p.Length,32);
            
            var g = BitGrid.from(p);


        }
        public void bg_permute_16x4()
        {
            var identity = Perm.identity(n16);
            var iterms = identity.Literals();
            var g1 = identity.ToBitGrid();
            var iperm = identity.ToNatural();            
            var g2 = iperm.ToBitGrid();
            Claim.yea(g1 == g2);
        
        }

        public void bg_permute_8x3()
        {
            var id = Perm.identity(n8);
            var idterms = id.Literals();
            var g1 = id.ToSubGrid();
            var iperm = id.ToNatural();
            var g2 = iperm.ToSubGrid();
            //Claim.yea(g1 == g2);        
        }

        public void perm_8x32_digits()
        {
            var symbols = DataBlocks.natparts(n8, Perm8.B, Perm8.A, Perm8.D, Perm8.C, Perm8.F, Perm8.E, Perm8.H, Perm8.G);
            var spec = Perm.assemble(symbols[0], symbols[1], symbols[2], symbols[3], symbols[4], symbols[5], symbols[6], symbols[7]);
            
            //[o1, o0, o3, o2, o5, o4, o7, o6]
            var digits = spec.ToDigits();
            for(var i =0; i<8; i++)
                Claim.eq((uint)symbols[i], (uint)digits[i]);
                        
        }

        public void bg_perm_8x32_bits()
        {
            var p1 = Perm.identity(n8);
            var v1 = p1.ToBitVector(n24);
            var p1F = p1.ToBitString(24).Format(3);            
            var v1F = v1.Format(3);
            Claim.eq(p1F, v1F);
            
            var p2 = Perm.reversed(n8);
            var p2F = p2.ToBitString(24).Format(3);
            var v2 = p2.ToBitVector(n24);
            var v2F = v2.Format(3);
            Claim.eq(p2F, v2F);

            Claim.yea(v2.ToSubGrid(n8,n3) == p2.ToSubGrid());

        }

        
    }
}