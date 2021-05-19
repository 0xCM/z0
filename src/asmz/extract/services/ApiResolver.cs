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

        public ReadOnlySpan<ApiMemberInfo> Describe(in ResolvedPart src)
        {
            var buffer = alloc<ApiMemberInfo>(src.MethodCount);
            Describe(src,buffer);
            return buffer;
        }

        public ReadOnlySpan<ApiMemberInfo> ResolveParts(params PartId[] parts)
        {
            var count = parts.Length;
            var buffer = root.list<ResolvedPart>();
            for(var i=0; i<count; i++)
                buffer.Add(ResolvePart(skip(parts,i)));

            var kMethods = 0u;
            root.iter(buffer, p => kMethods += (uint)p.MethodCount);
            var methods = alloc<ApiMemberInfo>(kMethods);
            Describe(buffer.ViewDeposited(), methods);
            return methods;
        }

        void Describe(ReadOnlySpan<ResolvedPart> src, Span<ApiMemberInfo> dst)
        {
            var count = src.Length;
            var offset = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var part = ref skip(src,i);
                offset += Describe(part, slice(dst,offset));
            }

            dst.Sort();
            var path = Db.IndexTable<ApiMemberInfo>();
            TableEmit(dst, ApiMemberInfo.RenderWidths, path);
        }

        public uint Describe(in ResolvedPart src, Span<ApiMemberInfo> dst)
        {
            var hosts = src.Hosts.View;
            var count = hosts.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var host = ref skip(hosts,i);
                var methods = host.Methods.View;
                var mCount = methods.Length;
                for(var j=0; j<mCount; j++)
                    describe(skip(methods,j), ref seek(dst,counter++));
            }
            return counter;
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

        public ResolvedPart ResolvePart(PartId id)
        {
            if(Wf.ApiCatalog.FindPart(id, out var part))
                return ResolvePart(part, out _);
            else
                return ResolvedPart.Empty;
        }

        public uint ResolvePart(IPart src, List<ResolvedPart> dst)
        {
            dst.Add(ResolvePart(src, out var counter));
            return counter;
        }

        public ResolvedHost ResolveHost(IApiHost src)
        {
            var dst = root.list<ResolvedMethod>();
            ResolveHost(src, dst);
            if(dst.Count != 0)
            {
                dst.Sort();
                var methods = dst.ToArray();
                return new ResolvedHost(src.HostUri, first(methods).EntryPoint, methods);
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
                    var @base = first(resolved).EntryPoint;
                    hosts.Add(new ResolvedHost(host, @base, resolved));
                    counter += (uint)resolved.Length;
                }
            }

            foreach(var host in catalog.ApiHosts)
            {
                var methods = root.list<ResolvedMethod>();
                var count = ResolveHost(host, methods);
                if(count != 0)
                {
                    var resolved = methods.ToArray().Sort();
                    var @base = first(resolved).EntryPoint;
                    hosts.Add(new ResolvedHost(host.HostUri, @base, resolved));
                    counter += (uint)resolved.Length;
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
                dst.Add(new ResolvedMethod(method, MemberUri(src.HostUri, method), ApiJit.jit(method)));
                counter++;
            }

            foreach(var method in ApiQuery.generic(src))
            {
                foreach(var arg in ApiIdentityKinds.NumericClosureTypes(method))
                {
                    try
                    {
                        var constructed = method.MakeGenericMethod(arg);
                        dst.Add(new ResolvedMethod(constructed, MemberUri(src.HostUri, constructed), ApiJit.jit(constructed)));
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
                dst.Add(new ResolvedMethod(method, MemberUri(src.HostUri, method), ApiJit.jit(method)));
                counter++;
            }

            Wf.Ran(flow, string.Format("Resolved {0} members from {1}", counter, src.HostUri));
            return counter;
        }

        OpUri MemberUri(ApiHostUri host, MethodInfo method)
            => ApiUri.define(ApiUriScheme.Located, host, method.Name, Identity.Identify(method));

        [Op]
        static ref ApiMemberInfo describe(in ResolvedMethod src, ref ApiMemberInfo dst)
        {
            var msil = ClrDynamic.msil(src.EntryPoint, src.Uri, src.Method);
            dst.EntryPoint = src.EntryPoint;
            dst.ApiKind = src.Method.KindId();
            dst.MsilCode = msil.Code;
            dst.CliSig = msil.CliSig;
            dst.DisplaySig = src.Method.DisplaySig().Format();
            dst.Token = msil.Token;
            return ref dst;
        }
    }
}