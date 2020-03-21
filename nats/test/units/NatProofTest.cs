//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Nats;

    public class NatProofTest : UnitTest<NatProofTest>
    {    
        public static void equality()
        {
            NatClaim.eq<N16>(16);
            NatClaim.eq<N512>(512);
            NatClaim.eq<NatSeq<N8, N2, N1>>(821);
        }
        public static void smaller()
        {
            NatClaim.lt(n11, n12);
            NatClaim.lt(n512, n1024);
        }

        public static void larger()
        {
            NatClaim.gt(n12, n11);
            NatClaim.gt(n1024, n512);
        }

        public static void nonzero()
        {
            NatClaim.nonzero(n12);
            NatClaim.nonzero(n4);
            NatClaim.nonzero(n1);

        }

        public static void sum()
        {
            NatClaim.add(n5, n5, n10.NatValue);
            NatClaim.add(n13, n0, n13.NatValue);
            NatClaim.add(n512, n10, 522);
        }

        public static void product()
        {
            NatClaim.mul(n5, n5, 25);
            NatClaim.mul(n13, n10, 130);
            NatClaim.mul(n512, n10, 5120);
        }

        public static void next()
        {
            NatClaim.next(n0, n1);            
            NatClaim.next(n5, n6);            
            NatClaim.next(n15, n16);
            
            var n11 = Nat.next(n10);
            var n12 = Nat.next(n11);
            var n13 = Nat.next(n12);
            NatClaim.next(n10, n11);
            NatClaim.next(n11, n12);
            NatClaim.next(n12, n13);

        }

        public static void iterate()
        {
           var n11 = Nat.next(n10);
           var n12 = Nat.next(n11);
           var n13 = Nat.next(n12);
           var n14 = Nat.next(n13);
           var n15 = Nat.next(n14);
           var n16 = Nat.next(n15);
           var n17 = Nat.next(n16);
           var n18 = Nat.next(n17);
           var n19 = Nat.next(n18);
           Claim.eq(n19.NatValue,19);
        }
    }
}