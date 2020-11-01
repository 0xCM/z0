//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.ApiRuntime, true)]
    public readonly struct ApiRuntime
    {
        const string ProgressMessage = "{2} | {0} | {1} | Api summary accumulation";

        public static ApiRuntimeIndex index(IWfShell wf)
        {
            var db = wf.Db();
            var hosts = @readonly(wf.Api.ApiHosts);
            var kHost = hosts.Length;
            var buffer = alloc<ApiRuntimeMember>(ushort.MaxValue);
            var target = span(buffer);
            var stats = 0u;
            for(var i=0; i<kHost; i++)
            {
                var catalog = ApiCatalogs.members(skip(hosts,i));
                if(catalog.IsNonEmpty)
                {
                    var partId = catalog.Part;
                    var hostType = catalog.Host.HostType;

                    var members = @readonly(catalog.Members.Storage);
                    var apicount = (uint)members.Length;

                    for(var j=0; j<apicount; j++)
                    {
                        ref readonly var member = ref skip(members,j);
                        try
                        {
                            var method = member.Method;
                            var rt = new ApiRuntimeMember();
                            rt.Address = member.Address;
                            rt.Uri = member.MetaUri;
                            rt.Genericity = method.GenericState();
                            rt.Sig = ApiSigs.define(partId, hostType, method);
                            rt.Definition = member.Method;
                            rt.Metadata = method.Metadata();

                        }
                        catch(Exception e)
                        {
                            wf.Error(e);
                        }
                    }

                    stats += apicount;

                    wf.Status(string.Format(ProgressMessage, apicount, catalog.Host, stats));
                }
            }

            return default;
        }
    }
}