//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static ApiExtracts;

    public class ApiExtractor : AppService<ApiExtractor>
    {
        byte[] Buffer;

        HashSet<string> Exclusions;

        IMultiDiviner Identity {get;}

        public ApiExtractor()
        {
            Identity = MultiDiviner.Service;
            Buffer = ApiExtracts.buffer();
            Exclusions = root.hashset(root.array("ToString","GetHashCode", "Equals", "ToString"));
        }

        public Index<ResolvedPart> ResolveCatalog(IApiRuntimeCatalog src)
        {
            var dst = root.list<ResolvedPart>();
            ResolveCatalog(src,dst);
            return dst.ToArray();
        }

        public uint ResolveCatalog(IApiRuntimeCatalog src, List<ResolvedPart> dst)
        {
            var counter = 0u;
            foreach(var part in src.Parts)
                counter += ResolvePart(part, dst);
            return counter;
        }

        public uint ResolvePart(IPart src, List<ResolvedPart> dst)
        {
            var counter = 0u;
            var catalog = ApiQuery.partcat(src);
            var flow = Wf.Running(string.Format("Resolving part {0}", src.Id));

            var hosts = root.list<ResolvedHost>();

            foreach(var host in catalog.ApiTypes)
            {
                var methods = root.list<ResolvedMethod>();
                var count = ResolveType(host, methods);
                if(count != 0)
                {
                    var resolved = methods.ToArray().Sort();
                    var @base = first(resolved).Address;
                    hosts.Add(new ResolvedHost(host.HostUri, @base, resolved));
                    counter += count;
                }
            }

            foreach(var host in catalog.ApiHosts)
            {
                var methods = root.list<ResolvedMethod>();
                var count = ResolveHost(host, methods);
                if(count != 0)
                {
                    var resolved = methods.ToArray().Sort();
                    var @base = first(resolved).Address;
                    hosts.Add(new ResolvedHost(host.HostUri, @base, resolved));
                    counter += count;
                }
            }

            dst.Add(new ResolvedPart(src.Id, hosts.ToArray()));

            Wf.Ran(flow, string.Format("Resolved {0} members from {1}", counter, src.Id));
            return counter;
        }

        public uint ResolveHost(IApiHost src, List<ResolvedMethod> dst)
        {
            var counter = 0u;

            var flow = Wf.Running(string.Format("Resolving {0} members", src.HostUri));

            foreach(var method in ApiQuery.nongeneric(src))
            {
                dst.Add(resolve(method, MemberUri(src.HostUri, method), ApiJit.jit(method)));
                counter++;
            }

            foreach(var method in ApiQuery.generic(src))
            {
                foreach(var arg in ApiIdentityKinds.NumericClosureTypes(method))
                {
                    var constructed = method.MakeGenericMethod(arg);
                    dst.Add(resolve(constructed, MemberUri(src.HostUri, constructed), ApiJit.jit(constructed)));
                    counter++;
                }
            }

            Wf.Ran(flow, string.Format("Resolved {0} {1} members", counter, src.HostUri));
            return counter;
        }

        public uint ResolveType(ApiRuntimeType src, List<ResolvedMethod> dst)
        {
            var flow = Wf.Running(string.Format("Resolving type {0}", src.HostUri));

            var counter = 0u;
            foreach(var method in ApiQuery.methods(src, Exclusions))
            {
                dst.Add(resolve(method, MemberUri(src.HostUri, method), ApiJit.jit(method)));
                counter++;
            }

            Wf.Ran(flow, string.Format("Resolved {0} members from {1}", counter, src.HostUri));
            return counter;
        }

        public Index<ApiExtractBlock> ExtractCatalog(IApiRuntimeCatalog catalog)
        {
            var dst = root.list<ApiExtractBlock>(Pow2.T15);
            ExtractCatalog(catalog, dst);
            return dst.ToArray();
        }

        public Index<ApiExtractBlock> ExtractResolved(ReadOnlySpan<ResolvedPart> src)
        {
            var count = src.Length;
            var counter = 0u;
            var flow = Wf.Running(string.Format("Extracting {0} parts", count));
            var dst = root.list<ApiExtractBlock>();
            for(var i=0; i<count; i++)
                counter += ExtractResolved(skip(src,i).Hosts, dst);

            Wf.Ran(flow, string.Format("Extracted {0} methods from {1} parts", counter, count));
            return dst.ToArray();
        }

        public uint ExtractResolved(ReadOnlySpan<ResolvedHost> src, List<ApiExtractBlock> dst)
        {
            var counter = 0u;
            var count = src.Length;
            for(var i=0; i<count; i++)
                counter += ExtractResolved(skip(src,i), dst);
            return counter;
        }

        public uint ExtractResolved(ResolvedHost src, List<ApiExtractBlock> dst)
        {
            var methods = src.Methods.View;
            var count = methods.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                dst.Add(extract(skip(methods,i), Buffer));
                counter++;
            }
            return counter;
        }

        public uint ExtractCatalog(IApiRuntimeCatalog catalog, List<ApiExtractBlock> dst)
        {
            var counter = 0u;
            var parts = @readonly(catalog.Parts);
            var count = parts.Length;

            var flow = Wf.Running(string.Format("Extracting {0} parts", count));
            for(var i=0; i<count; i++)
                counter += ExtractPart(skip(parts,i),dst);

            Wf.Ran(flow, string.Format("Extracted {0} members from {1} parts", counter, count));
            return counter;
        }

        public uint ExtractPart(IPart src, List<ApiExtractBlock> dst)
        {
            var counter = 0u;
            var buffer = root.list<ApiMember>();
            var catalog = ApiQuery.partcat(src);
            var types = catalog.ApiTypes;
            var hosts = catalog.ApiHosts;

            foreach(var type in types)
                counter += ExtractType(type, dst);

            foreach(var host in hosts)
                counter  += ExtractHost(host, dst);

            return counter;
        }

        [Op]
        public uint ExtractType(ApiRuntimeType src, List<ApiExtractBlock> dst)
        {
            var flow = Wf.Running(string.Format("Extracting type {0}", src.HostUri));
            var counter = 0u;
            var methods = @readonly(ApiQuery.methods(src, Exclusions));
            var count = methods.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var method = ref skip(methods,i);
                var resolved = resolve(method, MemberUri(src.HostUri, method), ApiJit.jit(method));
                dst.Add(extract(resolved, Buffer));
                counter++;
            }

            Wf.Ran(flow, string.Format("Extracted {0} members from {1}", counter, src.HostUri));
            return counter;
        }

        public uint ExtractHost(IApiHost src, List<ApiExtractBlock> dst)
        {
            var flow = Wf.Running(string.Format("Extracting {0} members", src.HostUri));
            var counter = 0u;
            counter += ExtractNongeneric(src, dst);
            counter += ExtractGeneric(src,dst);
            Wf.Ran(flow,string.Format("Extracted {0} members from {1}", counter, src));
            return counter;
        }

        uint ExtractNongeneric(IApiHost src, List<ApiExtractBlock> dst)
        {
            var counter = 0u;
            var methods = @readonly(ApiQuery.nongeneric(src));
            var count = methods.Length;

            for(var i=0; i<count; i++)
            {
                ref readonly var method = ref skip(methods,i);
                var resolved = resolve(method, MemberUri(src.HostUri, method), ApiJit.jit(method));
                dst.Add(extract(resolved, Buffer));
                counter++;
            }
            return counter;
        }

        uint ExtractGeneric(IApiHost src, List<ApiExtractBlock> dst)
        {
            var counter = 0u;
            var methods = @readonly(ApiQuery.generic(src));
            var count = methods.Length;
            for(var i=0; i<count; i++)
                counter += ExtractGeneric(src.HostUri, skip(methods,i), dst);
            return counter;
        }

        uint ExtractGeneric(ApiHostUri host, MethodInfo src, List<ApiExtractBlock> dst)
        {
            var counter = 0u;
            var args = @readonly(ApiIdentityKinds.NumericClosureTypes(src));
            var count = args.Length;
            var @class = src.KindId();
            try
            {
                for(var i=0u; i<count; i++)
                {
                    ref readonly var arg = ref skip(args, i);
                    var constructed = src.MakeGenericMethod(arg);
                    var resolved = resolve(constructed, MemberUri(host, constructed), ApiJit.jit(constructed));
                    dst.Add(extract(resolved, Buffer));
                    counter++;
                }
            }
            catch(ArgumentException e)
            {
                var msg = string.Format("{0}: Closure creation failed for {1}/{2}", e.GetType().Name, src.DeclaringType.DisplayName(), src.DisplayName());
                Wf.Warn(msg);
                return 0;
            }
            catch(Exception e)
            {
                Wf.Warn(e.ToString());
            }
            return counter;
        }

        [MethodImpl(Inline)]
        static ResolvedMethod resolve(MethodInfo method, OpUri uri, MemoryAddress address)
            => new ResolvedMethod(method, uri, address);

        OpUri MemberUri(ApiHostUri host, MethodInfo method)
            => ApiUri.define(ApiUriScheme.Located, host, method.Name, Identity.Identify(method));
    }
}