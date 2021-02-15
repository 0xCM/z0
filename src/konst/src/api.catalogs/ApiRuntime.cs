//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static Part;
    using static z;

    using Q = ApiQuery;

    [ApiHost(ApiNames.ApiRuntime, true)]
    public readonly struct ApiRuntime
    {
        const string RenderPattern = "| {0,-16} | {1,-112} | {2, -64} | {3}";

        public static string format(in ApiRuntimeMember src)
            => string.Format(RenderPattern, src.Address, src.Uri, src.Sig, src.Cil);

        /// <summary>
        /// Describes an api host
        /// </summary>
        /// <param name="part">The defining part</param>
        /// <param name="src">The reifying type</param>
        [Op]
        public static ApiHost ApiHost(Type src)
        {
            var part = src.Assembly.Id();
            var name =  HostName(src);
            return new ApiHost(src, name, part, new ApiHostUri(part, name));
        }

        [Op]
        public static Identifier HostName(Type src)
        {
            var attrib = src.Tag<ApiHostAttribute>();
            return text.ifempty(attrib.MapValueOrDefault(a => a.HostName, src.Name), src.Name).ToLower();
        }

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="ApiHostAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        [Op]
        public static Type[] ApiHostTypes(Assembly src)
            => src.GetTypes().Where(ApiRuntime.IsApiHost);

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="ApiCompleteAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        [Op]
        public static ApiRuntimeType[] ApiTypes(Assembly src)
        {
            var part = src.Id();
            var types = span(src.GetTypes().Where(t => t.Tagged<ApiCompleteAttribute>()));
            var count = types.Length;
            var buffer = alloc<ApiRuntimeType>(count);
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var type = ref skip(types,i);
                var attrib = type.Tag<ApiCompleteAttribute>();
                var name =  text.ifempty(attrib.MapValueOrDefault(a => a.Name, type.Name),type.Name).ToLower();
                var uri = new ApiHostUri(part, name);
                seek(dst, i) = new ApiRuntimeType(type, name, part, uri);
            }
            return buffer;
        }

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="FunctionalServiceAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        [Op]
        public static Type[] ServiceHostTypes(Assembly src)
            => src.GetTypes().Where(t => t.Tagged<FunctionalServiceAttribute>());

        [Op]
        public static ApiHost[] ApiHosts(Assembly src)
        {
            var _id = Q.id(src);
            return ApiHostTypes(src).Select(h => host(_id, h));
        }

        [Op]
        public static bool IsApiHost(Type src)
            => src.Tagged<ApiHostAttribute>();

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

        /// <summary>
        /// Describes an api host
        /// </summary>
        /// <param name="part">The defining part</param>
        /// <param name="t">The reifying type</param>
        [Op]
        static ApiHost host(PartId part, Type t)
        {
            var attrib = t.Tag<ApiHostAttribute>();
            var name =  ApiRuntime.HostName(t);
            return new ApiHost(t, name, part, new ApiHostUri(part, name));
        }
    }
}