//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public class ApiKeyChecks : AppService<ApiKeyChecks>
    {
        public void Run()
        {
            var kinds = Symbols.symbolic<ApiClassKind>().View;
            var catalog = Wf.ApiCatalog;
            var hosts = @readonly(catalog.ApiHosts);
            var parts = @readonly(catalog.Parts);
            var count = hosts.Length;

            for(var i=0; i<count; i++)
            {
                ref readonly var host = ref skip(hosts, i);
                var methods = host.Methods.View;
                var mcount = methods.Length;
                for(var j=0; j<mcount; j++)
                {
                    ref readonly var method = ref skip(methods,j);
                }
            }
        }
    }
}