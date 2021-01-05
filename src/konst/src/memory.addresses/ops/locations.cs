//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    partial struct Addresses
    {
        [Op]
        public static void locations(MemorySegments store, Span<MemoryAddress> results)
        {
            var sources = store.View;
            var kSources = sources.Length;
            for(var i=0u; i<kSources; i++)
            {
                ref readonly var source = ref memory.skip(sources,i);
                var length = source.Length;
                var data = MemoryStore.Service.load(source);

                if(data.Length == length)
                {
                    for(var j = 0u; j<length; j++)
                    {
                        ref readonly var x = ref memory.skip(data,j);
                        if(j == 0)
                        {
                            var a = memory.address(x);
                            if(source.BaseAddress == a)
                                memory.seek(results,i) = a;
                        }
                    }
                }
            }
        }
    }
}