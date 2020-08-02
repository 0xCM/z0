//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Flow    
    {
        [MethodImpl(Inline), Op]
        public static WfEventId wfid(string name, CorrelationToken? ct = null, Timestamp? ts = null)
            => new WfEventId(name, ct ?? CorrelationToken.create(), ts ?? z.now());       
    }
}