//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using System.Runtime.CompilerServices;
    using static zfunc;
    using static nfunc;
 
    public sealed class t_perm : UnitTest<t_perm>
    {
        public void perm_inc()
        {
            var p = Perm.identity(16);
            for(var i=0; i<16; i++)
                p.Inc();
            Claim.eq(p, Perm.identity(16));
        }

        public void perm_dec()
        {
            var p = Perm.identity(16);
            for(var i=0; i<16; i++)
                p.Dec();

            Claim.eq(p, Perm.identity(16));
        }

        public void perm_invert()
        {
            perm_invert_check(n12);
            perm_invert_check(n17);
            perm_invert_check(n64);
            perm_invert_check(n31);
            perm_invert_check(n128);
            perm_invert_check(n257);
        }

        public void perm_identity()
        {
            perm_identity_check(n32);         
            perm_identity_check(n20);
            perm_identity_check(n17);
            perm_identity_check(n64);
            perm_identity_check(n128);
            perm_identity_check(n21);
            perm_identity_check(n257);
        }    

        public void perm_comp()
        {
            perm_comp_check(n32);         
            perm_comp_check(n20);
            perm_comp_check(n17);
            perm_comp_check(n64);
            perm_comp_check(n128);
            perm_comp_check(n21);
            perm_comp_check(n257);
        }


        public void perm_format()
        {
            const Perm4  p = Perm4.DCBA;            
            const string pbs_expect = "00011011";
            const string pformat_epect = "[00 01 10 11]: ABCD -> DCBA";

            var pbs_actual = BitString.FromScalar((byte)p);            
            Claim.eq(pbs_expect, pbs_actual);
            
            var p_assembled = PermSpec.assemble(Perm4.D, Perm4.C, Perm4.B, Perm4.A);            
            Claim.eq(p, p_assembled);            
            
            var pformat_actual = p.FormatMap();
            Claim.eq(pformat_epect, pformat_actual);

        }        

        void perm_comp_check<N>(N n = default)
            where N : unmanaged, ITypeNat
        {
            var p1 = Random.Perm<N>();
            var p2 = p1 * Perm<N>.Identity;
            Claim.yea(p1 == p2);
        }

       void perm_identity_check<N>(N rep = default)
            where N : unmanaged, ITypeNat
        {
            var permA = Perm<N>.Identity;
            var n = nati<N>();
            Claim.eq(n, permA.Length);
            Claim.eq(n, permA.Terms.Length);

            var terms = range(0, n-1).ToArray();
            Claim.eq(n, terms.Length);

            var permB = Perm.Define(new N(), terms);
            Claim.yea(permA == permB);
        }

        void perm_invert_check<N>(N n = default, int cycles = DefaltCycleCount)
            where N: unmanaged, ITypeNat
        {
            for(var i=0; i<(int)n.value; i++)
            {
                var p1 = Random.Perm(n);
                var p2 = ~ p1;
                var p3 = p1 * p2;                    
                Claim.yea(p3 == Perm<N>.Identity);
            }
        }
    }
}