//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.ComponentModel;

    using static nfunc;
    using static zfunc;

    public class NatProofTest : UnitTest<NatProofTest>
    {    
        public static void equality()
        {
            NatProve.eq<N16>(16);
            NatProve.eq<N512>(512);
            NatProve.eq<NatSeq<N8, N2, N1>>(821);
        }
        public static void smaller()
        {
            NatProve.lt(n11, n12);
            NatProve.lt(n512, n1024);
        }

        public static void larger()
        {
            NatProve.gt(n12, n11);
            NatProve.gt(n1024, n512);
        }

        public static void nonzero()
        {
            NatProve.nonzero(n12);
            NatProve.nonzero(n4);
            NatProve.nonzero(n1);

        }

        public static void sum()
        {
            NatProve.add(n5, n5, n10.NatValue);
            NatProve.add(n13, n0, n13.NatValue);
            NatProve.add(n512, n10, 522);
        }

        public static void product()
        {
            NatProve.mul(n5, n5, 25);
            NatProve.mul(n13, n10, 130);
            NatProve.mul(n512, n10, 5120);
        }

        public static void next()
        {
            NatProve.next(n0, n1);            
            NatProve.next(n5, n6);            
            NatProve.next(n15, n16);
            
            var n11 = Nat.next(n10);
            var n12 = Nat.next(n11);
            var n13 = Nat.next(n12);
            NatProve.next(n10, n11);
            NatProve.next(n11, n12);
            NatProve.next(n12, n13);

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