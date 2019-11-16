//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Collections.Generic;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;

    partial class gbits
    {
        public static bool subset<T,S>(T test, S set)
            where S : unmanaged
            where T : unmanaged
        {

            var subset = BitString.from(test).BitSeq.ToHashSet();
            var superset = BitString.from(set).BitSeq.ToHashSet();
            superset.IntersectWith(subset);
            return superset.IsNonEmpty();            
        }


    }

}