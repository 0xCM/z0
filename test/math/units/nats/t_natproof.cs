//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    public class t_natproof : UnitTest<t_natproof>
    {
        public void equality()
        {
            NatClaims.eq<N16>(16);
            NatClaims.eq<N512>(512);
            NatClaims.eq<NatSeq<N8, N2, N1>>(821);
        }

        public void smaller()
        {
            NatClaims.lt(n11, n12);
            NatClaims.lt(n512, n1024);
        }

        public void larger()
        {
            NatClaims.gt(n12, n11);
            NatClaims.gt(n1024, n512);
        }

        public void nonzero()
        {
            NatClaims.nonzero(n12);
            NatClaims.nonzero(n4);
            NatClaims.nonzero(n1);
        }

        public void sum()
        {
            NatClaims.sum(n5, n5, n10.NatValue);
            NatClaims.sum(n13, n0, n13.NatValue);
            NatClaims.sum(n512, n10, 522);
        }

        public void product()
        {
            NatClaims.mul(n5, n5, 25);
            NatClaims.mul(n13, n10, 130);
            NatClaims.mul(n512, n10, 5120);
        }

        public void next()
        {
            NatClaims.next(n0, n1);
            NatClaims.next(n5, n6);
            NatClaims.next(n15, n16);

            var n11 = TypeNats.next(n10);
            var n12 = TypeNats.next(n11);
            var n13 = TypeNats.next(n12);
            NatClaims.next(n10, n11);
            NatClaims.next(n11, n12);
            NatClaims.next(n12, n13);

        }

        public void iterate()
        {
           var n11 = TypeNats.next(n10);
           var n12 = TypeNats.next(n11);
           var n13 = TypeNats.next(n12);
           var n14 = TypeNats.next(n13);
           var n15 = TypeNats.next(n14);
           var n16 = TypeNats.next(n15);
           var n17 = TypeNats.next(n16);
           var n18 = TypeNats.next(n17);
           var n19 = TypeNats.next(n18);
           Claim.eq(n19.NatValue,19ul);
        }
    }
}