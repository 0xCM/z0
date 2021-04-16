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

    public class ApiRuntime : WfService<ApiRuntime>
    {
        const string RenderPattern = "{0,-16} | {1,-112} | {2, -82} | {3}";

        public static string format(in ApiRuntimeMember src)
            => string.Format(RenderPattern, src.Address, src.Uri, src.Sig, src.Cil.Encoded.Format());

        public Index<ApiRuntimeMember> EmitRuntimeIndex()
        {
            try
            {
                var hosts = Wf.Api.ApiHosts;
                var kHost = (uint)hosts.Length;
                var members = RuntimeMembers();
                var view  = members.View;
                var target = Db.IndexFile("api.members");
                var flow = Wf.EmittingFile(target);
                using var writer = target.Writer();
                var count = view.Length;
                for(var i=0; i<count; i++)
                    writer.WriteLine(format(skip(view,i)));
                Wf.EmittedFile(flow, count);
                return members;
            }
            catch(Exception e)
            {
                Wf.Error(e);
                return Index<ApiRuntimeMember>.Empty;
            }
        }

        public Index<ApiRuntimeMember> RuntimeMembers()
        {
            var hosts = @readonly(Wf.Api.ApiHosts);
            var kHost = (uint)hosts.Length;
            var buffer = root.list<ApiRuntimeMember>();
            var flow = Wf.Running(Msg.IndexingHosts.Format(kHost));
            var catalogs = Wf.ApiCatalogs();

            var counter = 0u;
            for(var i=0; i<kHost; i++)
            {
                var host = skip(hosts,i);
                var hostcat = catalogs.HostCatalog(host);
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

                    Wf.Status(Msg.IndexedHost.Format(hostcat.Host.Uri, apicount, counter));
                }
            }

            Wf.Ran(flow);

            return buffer.OrderBy(x => x.Address).Array();
        }

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