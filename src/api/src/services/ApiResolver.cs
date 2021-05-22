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

    using static Root;
    using static core;


    partial class XApi
    {
        [Op]
        public static ApiMemberInfo Describe(this ResolvedMethod src)
        {
            var dst = new ApiMemberInfo();
            var msil = ClrDynamic.msil(src.EntryPoint, src.Uri, src.Method);
            dst.EntryPoint = src.EntryPoint;
            dst.ApiKind = src.Method.KindId();
            dst.CliSig = msil.CliSig;
            dst.DisplaySig = src.Method.DisplaySig().Format();
            dst.Token = msil.Token;
            dst.Uri = src.Uri.Format();
            dst.MsilCode = msil.Code;
            return dst;
        }

    }
    [ApiHost]
    public class ApiResolver : AppService<ApiResolver>
    {
        HashSet<string> Exclusions;

        IMultiDiviner Identity {get;}

        [Op]
        public static uint MethodCount(ReadOnlySpan<ResolvedPart> src)
        {
            var counter = 0u;
            var k0 = (uint)src.Length;
            for(var i0=0u; i0<k0; i0++)
            {
                ref readonly var part = ref skip(src,i0);
                var hosts = part.Hosts.View;
                var k1 = (uint)hosts.Length;
                for(var i1=0u; i1<k1; i1++)
                    counter += skip(hosts, i1).Methods.Count;
            }
            return counter;
        }

        [Op]
        public static uint methods(ReadOnlySpan<ResolvedPart> src, Span<ResolvedMethod> dst)
        {
            var k0 = src.Length;
            var counter = 0u;
            for(var i0=0; i0<k0; i0++)
            {
                ref readonly var part = ref skip(src,i0);
                var hosts = part.Hosts.View;
                var k1 = (uint)hosts.Length;
                for(var i1=0u; i1<k1; i1++)
                {
                    var methods = skip(hosts,i1).Methods.View;
                    var k2 = methods.Length;
                    for(var i2=0; i2<k2; i2++)
                        seek(dst, counter++) = skip(methods,i2);
                }
            }
            return counter;
        }

        public static uint describe(ReadOnlySpan<ResolvedMethod> src, Span<ApiMemberInfo> dst)
        {
            var count = (uint)src.Length;
            for(var i=0; i<count; i++)
                seek(dst,i) = skip(src,i).Describe();
            dst.Sort();
            return count;
        }

        public static ReadOnlySpan<ResolvedMethod> methods(ReadOnlySpan<ResolvedPart> src)
        {
            var dst = root.list<ResolvedMethod>();
            for(var i=0; i<src.Length; i++)
            {
                var hosts = skip(src,i).Hosts.View;
                for(var j=0; j<hosts.Length; j++)
                {
                    var methods = skip(hosts,j).Methods.View;
                    root.iter(methods, m => dst.Add(m));
                }
            }
            return dst.ViewDeposited();
        }

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
                    seek(dst,counter++) = skip(methods,j).Describe();
            }
            return counter;
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

        public ReadOnlySpan<ResolvedPart> ResolveCatalog(IApiCatalog src)
        {
            var dst = root.datalist<ResolvedPart>();
            var parts = @readonly(src.Parts);
            var count = parts.Length;
            for(var i=0; i<count; i++)
                dst.Add(ResolvePart(skip(parts,i)));
            return dst.Close();
        }

        public ReadOnlySpan<ApiMemberInfo> LogResolutions(ReadOnlySpan<ResolvedPart> src, FS.FolderPath dir)
        {
            var _methods = methods(src);
            var count = _methods.Length;
            Wf.Status(string.Format("{0} Resolved {1} methods from {2} parts", Worker(), count, src.Length));
            var buffer = span<ApiMemberInfo>(count);
            describe(_methods, buffer);
            Wf.Status(string.Format("{0} Collected descriptions for {1} method resolutions", Worker(), count));
            TableEmit(buffer, ApiMemberInfo.RenderWidths, Db.Table<ApiMemberInfo>(dir));
            return buffer;
        }

        public ReadOnlySpan<ResolvedPart> ResolveParts(ReadOnlySpan<PartId> src)
        {
            var flow = Wf.Running(string.Format("{0} Resolving parts [{1}]", Worker(), src.Delimit(Chars.Comma).Format()));
            var count = src.Length;
            var buffer = alloc<ResolvedPart>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
                seek(dst, i) = ResolvePart(skip(src, i));
            Wf.Ran(flow);
            return buffer;
        }

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
            dst.CliSig = msil.CliSig;
            dst.DisplaySig = src.Method.DisplaySig().Format();
            dst.Token = msil.Token;
            dst.Uri = src.Uri.Format();
            dst.MsilCode = msil.Code;
            return ref dst;
        }
    }
}