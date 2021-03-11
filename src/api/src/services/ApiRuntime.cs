//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static Part;
    using static memory;

    [ApiHost(ApiNames.ApiRuntime, true)]
    public readonly struct ApiRuntime
    {
        const string RenderPattern = "| {0,-16} | {1,-112} | {2, -64} | {3}";

        public static string format(in ApiRuntimeMember src)
            => string.Format(RenderPattern, src.Address, src.Uri, src.Sig, src.Cil);

        [Op]
        public static Outcome<FS.FilePath> EmitRuntimeIndex(IWfShell wf)
        {
            try
            {
                var hosts = wf.Api.ApiHosts;
                var kHost = (uint)hosts.Length;
                var view  = @readonly(members(wf));
                var target = wf.Db().IndexFile("api.members");
                using var writer = target.Writer();
                var count = view.Length;
                for(var i=0; i<count; i++)
                    writer.WriteLine(format(skip(view,i)));
                return target;
            }
            catch(Exception e)
            {
                return e;
            }
        }

        [Op]
        public static ApiRuntimeMember[] members(IWfShell wf)
        {
            var db = wf.Db();
            var hosts = @readonly(wf.Api.ApiHosts);
            var kHost = (uint)hosts.Length;
            var buffer = root.list<ApiRuntimeMember>();
            var services = wf.ApiServices();

            var flow = wf.Running(Msg.IndexingHosts.Format(kHost));

            var counter = 0u;
            for(var i=0; i<kHost; i++)
            {
                var host = skip(hosts,i);
                var hostcat = services.HostCatalog(host);
                var component = host.HostType.Assembly;
                var members = @readonly(hostcat.Members.Storage);
                var apicount = (uint)members.Length;
                if(apicount != 0)
                {
                    for(var j=0u; j<apicount; j++, counter++)
                    {
                        var member = default(ApiRuntimeMember);
                        fill(host, skip(members,j), ref member);
                        buffer.Add(member);
                    }

                    wf.Status(Msg.IndexedHost.Format(hostcat.Host.Uri, apicount, counter));
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
            dst.Sig = ClrDisplaySig.from(method.Artifact());
            dst.Cil = src.Cil;
            return ref dst;
        }
    }

    partial struct Msg
    {
        public static MsgPattern<Count,Count,string> FieldCountMismatch => "{0} fields were found while {1} were expected: {2}";

    }
}