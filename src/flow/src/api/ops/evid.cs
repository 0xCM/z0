//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct OldFlow    
    {
        [MethodImpl(Inline), Op]
        public static WfEventId evid(string name, CorrelationToken ct)
            => new WfEventId(name, ct, z.now());       
    }
}