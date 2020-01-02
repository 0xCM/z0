//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class gmathops
    {

        public static uint gcd_32u(uint a, uint b)
            => gmath.gcd(a,b);

        public static int gcd_32i(int a, int b)
            => gmath.gcd(a,b);

    }

}