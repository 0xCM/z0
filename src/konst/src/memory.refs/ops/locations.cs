//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    partial struct MemRefs
    {
        [Op]
        public static void locations(in MemorySegments store, Span<MemoryAddress> results)
        {
            var sources = store.View;
            var kSources = sources.Length;
            for(var i=0u; i<kSources; i++)
            {
                ref readonly var source = ref skip(sources,i);
                var length = source.Length;
                var data = MemoryStore.Service.load(source);

                if(data.Length == length)
                {
                    for(var j = 0u; j<length; j++)
                    {
                        ref readonly var x = ref skip(data,j);
                        if(j == 0)
                        {
                            var a = address(x);
                            if(source.BaseAddress == a)
                                seek(results,i) = a;
                        }
                    }
                }
            }
        }
    }
}