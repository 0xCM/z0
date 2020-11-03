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
        [CmdWorker]
        public static CmdResult execute(IWfShell wf, EmitRuntimeIndexCmd cmd)
        {
            var hosts = wf.Api.ApiHosts;
            wf.Status(Status.IndexingHosts.Format((uint)hosts.Length));

            var data  = index(wf);
            var target = wf.Db().IndexFile("api.members");

            using var writer = target.Writer();
            var count = data.EntryCount;
            ref var lead = ref data.LeadingEntry;
            var buffer = Buffers.text();
            for(var i=0; i<count; i++)
            {
                ref readonly var member = ref skip(lead,i);
                var length = render(member, buffer);
                writer.WriteLine(buffer.Emit());
            }

            return new CmdResult(Cmd.id(cmd), true);
        }

        [RenderFunction]
        public static Count render(in ApiRuntimeMember src, ITextBuffer dst)
        {
            var count = render(src.Address, dst);

            count += delimiter(dst);
            count += render(src.Uri, dst);

            count += delimiter(dst);
            count += render(src.Genericity, dst);

            count += delimiter(dst);
            count += render(src.Metadata, dst);

            count += delimiter(dst);
            count += render(src.Sig, dst);

            return count;
        }

        [RenderFunction]
        public static Count render(in MethodMetadata src, ITextBuffer dst)
        {
            var content = string.Format("{0,-64}",src.Format());
            dst.Append(content);
            return content.Length;
        }

        [RenderFunction]
        public static Count render(GenericState src, ITextBuffer dst)
        {
            var content = src.Format();
            dst.Append(content);
            return content.Length;
        }

        [Op]
        static Count delimiter(ITextBuffer dst)
        {
            const string Delimiter = "| ";
            dst.Append(Delimiter);
            return Delimiter.Length;
        }

        [RenderFunction]
        public static Count render(MemoryAddress src, ITextBuffer dst)
        {
            var content = string.Format("{0,-12}",src.Format());
            dst.Append(content);
            return (uint)content.Length;
        }

        [RenderFunction]
        public static Count render(in ApiSig src, ITextBuffer dst)
        {
            var count = Count.Zero;
            var subject = Hex.format(bytes(src.SubjectType), Space, true, false);
            dst.Append(subject);
            count += subject.Length;
            count += render(src.Part, dst);
            count += render(src.Host, dst);
            var filler = Hex.format(bytes(0u), Space, true, false);
            dst.Append(filler);
            count += filler.Length;

            count += render(src.Member,dst);
            return count;
        }

        [RenderFunction]
        public static Count render(in ApiMetadataUri src, ITextBuffer dst)
        {
            var content = src.Format();
            dst.Append(content);
            return content.Length;
        }

        [RenderFunction]
        public static Count render(in CliSig src, ITextBuffer dst)
        {
            var content = Hex.format(src.Data.View, Space, true, false);
            dst.Append(content);
            return content.Length;
        }

        [Op]
        public static ref ApiRuntimeMember populate(IApiHost host, ApiMember src, ref ApiRuntimeMember dst)
        {
            var method = src.Method;
            dst.Address = src.Address;
            dst.Uri = src.MetaUri;
            dst.Genericity = method.GenericState();
            dst.Sig = ApiSigs.define(src.Host.Owner, host.HostType, method);
            dst.Definition = src.Method;
            dst.Metadata = method.Metadata();
            return ref dst;
        }

        static Outcome TryPopulate(IApiHost host, ApiMember src, ref ApiRuntimeMember dst)
        {
            try
            {
                populate(host, src, ref dst);
                return true;
            }
            catch(Exception e)
            {
                return e;
            }
        }

        [Op]
        public static ApiRuntimeIndex index(IWfShell wf)
        {
            var db = wf.Db();
            var hosts = @readonly(wf.Api.ApiHosts);
            var kHost = (uint)hosts.Length;

            wf.Status(Status.IndexingHosts.Format(kHost));

            var index = ApiRuntimeIndex.init();
            var target = index.Entries;
            var counter = 0u;
            for(var i=0; i<kHost; i++)
            {
                var host = skip(hosts,i);
                var catalog = ApiCatalogs.members(host);
                var component = host.HostType.Assembly;
                var members = @readonly(catalog.Members.Storage);
                var apicount = (uint)members.Length;
                if(apicount == 0)
                    wf.Warn(Status.HostHasNoMemers.Format(host.Uri));

                for(var j=0u; j<apicount; j++, counter++)
                {
                    var result = TryPopulate(host, skip(members,j), ref seek(target,j));
                    if(result.Fail)
                        wf.Error(result.Message);
                }

                wf.Status(Status.IndexedHost.Format(apicount, catalog.Host.Uri, counter));
            }

            return index.SealEntries(counter);
        }
    }
}