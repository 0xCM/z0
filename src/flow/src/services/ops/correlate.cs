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
        public static CorrelationToken correlate(CorrelationToken? ct = null)
            => ct ?? CorrelationToken.define(0);        

        [MethodImpl(Inline), Op]
        public static CorrelationToken correlate(ulong value)
            => CorrelationToken.define(value);
    }
}