//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;
    using static Memories;
    
    [ApiHost]
    public readonly struct ResMemStores : IApiHost<ResMemStores>
    {
        [MethodImpl(Inline), Op]
        public static MemStore Create()
            => MemStore.Service(ResMemStore.Data.provided());
    
        [Op]
        static void UseCase(in MemStore store, Span<MemoryAddress> results)
        {
            var sources = store.Sources;
            for(var i=0; i< sources.Length; i++)
            {
                ref readonly var source = ref skip(sources,i);
                var length = source.Length;
                var data = MemStores.Service.load(source);                                
                var check1 = data.Length == length;
                
                if(check1)
                {
                    for(var j = 0; j<length; j++)
                    {
                        ref readonly var x = ref skip(data,j);
                        if(j == 0)
                        {
                            var a = address(x);
                            var check2 = source.Address == a;  
                            if(check2)
                                seek(results,i) = a;
                        }
                    }
                }
            }
        }

        public static ReadOnlySpan<MemoryAddress> UseCase()
        {
            var store = ResMemStores.Create();
            var sources = store.Sources;
            var results = Spans.alloc<MemoryAddress>(sources.Length);
            UseCase(store,results);
            return results;
        }
    }
}