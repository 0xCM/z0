//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.OpCodes
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    [OpCodeProvider]
    public static class msops
    {
        public static Span<uint> msand_32u(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
            => mathspan.and(lhs, rhs, dst);


    }

}