//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using static Seed;
    using static Memories;
 
    using Z0.Asm.Data;

    public class t_memstore : t_asmd<t_memstore>
    {

        public  void run_it()
        {
            var results = MemoryStores.UseCase();
            for(var i=0; i<results.Length; i++)
            {
                var result = results[i];
                Claim.yea(result.IsNonEmpty);
                Trace(result);
            }
        }
    }
}