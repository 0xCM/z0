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
        public static CorrelationToken correlate(PartId src)
            => new CorrelationToken(src);
    }
}