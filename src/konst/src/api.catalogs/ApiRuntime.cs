//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    using static Part;
    using static z;

    [ApiHost(ApiNames.ApiRuntime, true)]
    public readonly struct ApiRuntime
    {
        const string SummaryRenderPattern = "| {0,-16} | {1,-64} | {2,16} | {3, -64} | {4}";

        public static string format(in ApiRuntimeSummary src)
            => string.Format(SummaryRenderPattern, src.Address, src.Uri, src.Genericity, src.Sig, src.Metadata);

        [MethodImpl(Inline), Op]
        public static FS.FilePath target(IWfDb db, string id)
            => db.IndexFile(id);

        [Op]
        public static void emit(ReadOnlySpan<ApiRuntimeSummary> src, FS.FilePath dst)
        {
            var count = src.Length;
            using var writer = dst.Writer();
            for(var i=0; i<count; i++)
                writer.WriteLine(format(skip(src,i)));
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
        public static Count render(in ApiMetadataUri src, ITextBuffer dst)
        {
            var content = string.Format("{0,-64}", src.Format());
            dst.Append(content);
            return content.Length;
        }

        [RenderFunction]
        public static Count render(PartId src, ITextBuffer dst)
        {
            var content = Hex.format((ushort)src, w16);
            dst.Append(content);
            return content.Length;
        }

        [RenderFunction]
        public static Count render(in utf8 src, ITextBuffer dst)
        {
            var content = Hex.format(src.View, Space, true, false);
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
        public static string sig(MethodInfo src)
            => string.Format("{0}/{1}/{2}",src.DeclaringType.Assembly.GetSimpleName(), src.DeclaringType.Name, CliSigs.resolve(src));

        [Op]
        public static ref ApiRuntimeMember populate(IApiHost host, ApiMember src, ref ApiRuntimeMember dst)
        {
            var method = src.Method;
            dst.Address = src.Address;
            dst.Uri = src.MetaUri;
            dst.Genericity = method.GenericState();
            dst.Sig = sig(method);
            dst.Metadata = method.Metadata();
            dst.Cil = src.Cil;
            return ref dst;
        }

        [Op]
        public static ApiRuntimeMember[] index(IWfShell wf)
        {
            var db = wf.Db();
            var hosts = @readonly(wf.Api.ApiHosts);
            var kHost = (uint)hosts.Length;
            var buffer = list<ApiRuntimeMember>();

            wf.Status(Msg.IndexingHosts.Format(kHost));

            var counter = 0u;
            for(var i=0; i<kHost; i++)
            {
                var host = skip(hosts,i);
                var catalog = ApiCatalogs.members(host);
                var component = host.HostType.Assembly;
                var members = @readonly(catalog.Members.Storage);
                var apicount = (uint)members.Length;
                if(apicount != 0)
                {
                    for(var j=0u; j<apicount; j++, counter++)
                    {
                        var member = default(ApiRuntimeMember);
                        populate(host, skip(members,j), ref member);
                        buffer.Add(member);
                    }

                    wf.Status(Msg.IndexedHost.Format(apicount, catalog.Host.Uri, counter));
                }
            }

            return buffer.OrderBy(x => x.Address).Array();
        }
    }
}