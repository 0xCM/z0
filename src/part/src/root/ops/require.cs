//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;


    using static Root;

    partial struct root
    {
        [MethodImpl(Inline), Op]
        public static void require(bool invariant, in Func<string> f)
        {
            if(!invariant)
                sys.@throw(f);
        }

    }
}