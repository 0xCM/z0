//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    using static Konst;
    using static Memories;
 
    public sealed class t_perm_ops : t_permute<t_perm_ops>
    {
        public void perm_inc()
        {
            var p = Perm.Identity(16);
            for(var i=0; i<16; i++)
                p.Inc();
            Claim.eq(p.Terms, Perm.Identity(16).Terms);
        }

        public void perm_dec()
        {
            var p = Perm.Identity(16);
            for(var i=0; i<16; i++)
                p.Dec();

            Claim.eq(p.Terms, Perm.Identity(16).Terms);
        }

        public void perm_invert()
        {
            perm_invert_check(n12);
            perm_invert_check(n17);
            perm_invert_check(n64);
            perm_invert_check(n31);
            perm_invert_check(n128);
            perm_invert_check(n256);
        }

        public void perm_identity()
        {
            perm_identity_check(n32);         
            perm_identity_check(n20);
            perm_identity_check(n17);
            perm_identity_check(n64);
            perm_identity_check(n128);
            perm_identity_check(n21);
            perm_identity_check(n256);
        }    

        public void perm_comp()
        {
            perm_comp_check(n32);         
            perm_comp_check(n20);
            perm_comp_check(n17);
            perm_comp_check(n64);
            perm_comp_check(n128);
            perm_comp_check(n21);
            perm_comp_check(n256);
        }

        public void perm_format()
        {
            const Perm4L  p = Perm4L.DCBA;            
            const string pbs_expect = "00011011";
            const string pformat_epect = "[00 01 10 11]: ABCD -> DCBA";

            var pbs_actual = BitString.scalar((byte)p);            
            Claim.eq(pbs_expect, pbs_actual);
            
            var p_assembled = Symbolic.assemble(Perm4L.D, Perm4L.C, Perm4L.B, Perm4L.A);            
            Claim.Eq(p, p_assembled);            
            
            var pformat_actual = p.FormatMap();
            Claim.eq(pformat_epect, pformat_actual);

        }        

        void perm_comp_check<N>(N n = default)
            where N : unmanaged, ITypeNat
        {
            var p1 = Random.Perm<N>();
            var p2 = p1 * NatPerm<N>.Identity;
            Claim.Require(p1 == p2);
        }

       void perm_identity_check<N>(N n = default)
            where N : unmanaged, ITypeNat
        {
            var permA = NatPerm<N>.Identity;
            var length = nati<N>();
            Claim.eq(length, permA.Length);
            Claim.eq(length, permA.Terms.Length);

            var terms = gmath.range(0, length-1).ToArray();
            Claim.eq(length, terms.Length);

            var permB = Permute.natural(n, terms);
            Claim.Require(permA == permB);
        }

        void perm_invert_check<N>(N n = default)
            where N: unmanaged, ITypeNat
        {
            for(var i=0; i<(int)n.NatValue; i++)
            {
                var p1 = Random.Perm(n);
                var p2 = ~ p1;
                var p3 = p1 * p2;                    
                Claim.Require(p3 == NatPerm<N>.Identity);
            }
        }
    }
}