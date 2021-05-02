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

    public class ApiResolver : AppService<ApiResolver>
    {
        HashSet<string> Exclusions;

        IMultiDiviner Identity {get;}

        public ApiResolver()
        {
            Identity = MultiDiviner.Service;
            Exclusions = root.hashset(root.array("ToString","GetHashCode", "Equals", "ToString"));
        }

        public Index<ResolvedPart> ResolveCatalog(IApiCatalog src)
        {
            var dst = root.list<ResolvedPart>();
            ResolveCatalog(src,dst);
            return dst.ToArray();
        }

        public uint ResolveCatalog(IApiCatalog src, List<ResolvedPart> dst)
        {
            var counter = 0u;
            foreach(var part in src.Parts)
                counter += ResolvePart(part, dst);
            return counter;
        }

        public uint ResolvePart(IPart src, List<ResolvedPart> dst)
        {
            dst.Add(ResolvePart(src, out var counter));
            return counter;
        }



        public ResolvedHost ResolveHost(IApiHost src)
        {
            var dst = root.list<ResolvedMethod>();
            ResolveHost(src,dst);
            if(dst.Count != 0)
            {
                dst.Sort();
                var methods = dst.ToArray();
                return new ResolvedHost(src.HostUri, first(methods).Address, methods);
            }
            else
                return ResolvedHost.Empty;
        }

        public ResolvedPart ResolvePart(IPart src)
            => ResolvePart(src, out var counter);

        public ResolvedPart ResolvePart(IPart src, out uint counter)
        {
            counter = 0u;
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
                    hosts.Add(new ResolvedHost(host, @base, resolved));
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

            var result = new ResolvedPart(src.Id, hosts.ToArray());
            Wf.Ran(flow, string.Format("Resolved {0} members from {1}", counter, src.Id));
            return result;
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
                    try
                    {
                        var constructed = method.MakeGenericMethod(arg);
                        dst.Add(resolve(constructed, MemberUri(src.HostUri, constructed), ApiJit.jit(constructed)));
                        counter++;
                    }
                    catch(Exception e)
                    {
                        Wf.Warn(e.Message);
                    }
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

        [MethodImpl(Inline)]
        static ResolvedMethod resolve(MethodInfo method, OpUri uri, MemoryAddress address)
            => new ResolvedMethod(method, uri, address);

        OpUri MemberUri(ApiHostUri host, MethodInfo method)
            => ApiUri.define(ApiUriScheme.Located, host, method.Name, Identity.Identify(method));
    }
}