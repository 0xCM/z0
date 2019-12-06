//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class gmoc
    {
        public static ulong select_1(ulong a, ulong b, ulong c)
            => gmath.select(a,b,c);

        public static ulong select_2(ulong a, ulong b, ulong c)
            => gmath.blend(a,b,c);

    }

}