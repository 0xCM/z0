//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static root;

    public sealed class t_modn : UnitTest<t_modn>
    {

        public void mod16()
        {
            var ops = ModN.Ops(16);
            for(var i=0; i< RepCount; i++)
            {
                var a = Random.Next<uint>();
                var m0 = a % ops.N;
                var m1 = ops.mod(a);
                Claim.eq(m0,m1);
            }
        }

        public void mod18()
        {
            var ops = ModN.Ops(18);
            for(var i=0; i< RepCount; i++)
            {
                var a = Random.Next<uint>();
                var m0 = a % ops.N;
                var m1 = ops.mod(a);
                Claim.eq(m0,m1);
            }

        }

    }
}