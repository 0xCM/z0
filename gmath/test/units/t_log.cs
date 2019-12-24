//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_log : t_gmath<t_log>
    {

        public void ilog2()
        {
            Claim.eq(math.log2(Pow2.T20),20);
            Claim.eq(math.log2(Pow2.T24),24);
            Claim.eq(math.log2(Pow2.T30),30);
            Claim.eq(math.log2(Pow2.T40),40);
            Claim.eq(math.log2(Pow2.T50),50);
            Claim.eq(math.log2(Pow2.T60),60);
            Claim.eq(math.log2(Pow2.T63),63);
        }
    }
}

