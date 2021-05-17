//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static memory;

    [ApiHost]
    public readonly struct ApiResolutions
    {
        [Op]
        public static uint MethodCount(ReadOnlySpan<ResolvedPart> src)
        {
            var counter = 0u;
            var k0 = (uint)src.Length;
            for(var i0=0u; i0<k0; i0++)
            {
                ref readonly var part = ref skip(src,i0);
                var hosts = part.Hosts.View;
                var k1 = (uint)hosts.Length;
                for(var i1=0u; i1<k1; i1++)
                    counter += skip(hosts, i1).Methods.Count;
            }
            return counter;
        }
    }
}