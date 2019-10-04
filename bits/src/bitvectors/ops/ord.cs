//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    
    using static nfunc;
    using static As;

    partial class bitvector
    {
        /// <summary>
        /// Computes the smallest integer n > 1 such that v^n = identity
        /// </summary>
        public static int ord(BitVector8 x)
        {
            var dst = x.Replicate();
            for(var i=2; i < Gf256.MemberCount; i++)
            {
                dst *= x;
                if(dst == BitVector8.One)
                    return i;
            }
            return 0;
        }


    }
}