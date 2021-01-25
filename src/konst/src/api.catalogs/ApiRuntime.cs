//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static Part;
    using static z;

    [ApiHost(ApiNames.ApiRuntime, true)]
    public readonly struct ApiRuntime
    {
        const string RenderPattern = "| {0,-16} | {1,-112} | {2, -64} | {3}";

        public static string format(in ApiRuntimeMember src)
            => string.Format(RenderPattern, src.Address, src.Uri, src.Sig, src.Cil);

        [Op]
        public static Outcome<FS.FilePath> EmitIndex(IWfShell wf)
        {
            try
            {
                var hosts = wf.Api.ApiHosts;
                var kHost = (uint)hosts.Length;
                var members  = @readonly(ApiRuntime.index(wf));
                var target = wf.Db().IndexFile("api.members");
                using var writer = target.Writer();
                var count = members.Length;
                for(var i=0; i<count; i++)
                    writer.WriteLine(format(skip(members,i)));
                return target;
            }
            catch(Exception e)
            {
                return e;
            }
        }

        [Op]
        public static ApiRuntimeMember[] index(IWfShell wf)
        {
            var db = wf.Db();
            var hosts = @readonly(wf.Api.ApiHosts);
            var kHost = (uint)hosts.Length;
            var buffer = list<ApiRuntimeMember>();

            var flow = wf.Running(Msg.IndexingHosts.Format(kHost));

            var counter = 0u;
            for(var i=0; i<kHost; i++)
            {
                var host = skip(hosts,i);
                var catalog = ApiCatalogs.host(wf, host);
                var component = host.HostType.Assembly;
                var members = @readonly(catalog.Members.Storage);
                var apicount = (uint)members.Length;
                if(apicount != 0)
                {
                    for(var j=0u; j<apicount; j++, counter++)
                    {
                        var member = default(ApiRuntimeMember);
                        fill(host, skip(members,j), ref member);
                        buffer.Add(member);
                    }

                    wf.Status(Msg.IndexedHost.Format(catalog.Host.Uri, apicount, counter));
                }
            }

            wf.Ran(flow);

            return buffer.OrderBy(x => x.Address).Array();
        }

        [Op]
        static ref ApiRuntimeMember fill(IApiHost host, ApiMember src, ref ApiRuntimeMember dst)
        {
            var method = src.Method;
            dst.Address = src.BaseAddress;
            dst.Uri = src.OpUri;
            dst.Sig = ClrDisplaySig.from(method.Metadata());
            dst.Cil = src.Cil;
            return ref dst;
        }
    }
}