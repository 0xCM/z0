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

    using static memory;

    [Service(typeof(IApiJit))]
    public sealed class ApiJitService : WfService<ApiJitService,IApiJit>, IApiJit
    {
        public BasedApiMembers JitApi()
        {
            var @base = Runtime.CurrentProcess.BaseAddress;
            var catalog = Wf.ApiParts.Api;
            var parts = catalog.Parts;
            var kParts = parts.Length;
            var flow = Wf.Running(Msg.JittingParts.Format(kParts));
            var all = root.list<ApiMembers>();
            var total = 0u;
            foreach(var part in parts)
            {
                var subflow = Wf.Running(Msg.JittingPart.Format(part.Id));
                var partMembers = Jit(part);
                all.Add(partMembers);
                Wf.Ran(subflow, Msg.JittedPart.Format(partMembers.Length, part.Id));
            }

            var members = new BasedApiMembers(@base, all.SelectMany(x => x).OrderBy(x => x.BaseAddress).Array());
            Wf.Ran(flow, Msg.JittedMembers.Format(members.MemberCount, parts.Length));
            return members;
        }

        public BasedApiMembers JitApi(FS.FilePath dst)
        {
            var members = JitApi();
            EmitAddresses(members, dst);
            return members;
        }

        public ApiMembers Jit(IApiHost src)
        {
            var direct = JitDirect(src);
            var generic = JitGeneric(src);
            var all = direct.Concat(generic).Array();
            return all.OrderBy(x => x.BaseAddress);
        }

        public ApiMember[] Jit(Index<ApiTypeInfo> src)
        {
            var dst = root.list<ApiMember>();
            var count = src.Count;
            var exclusions = ApiTypeInfo.Ignore;
            ref var lead = ref src.First;
            for(var i=0u; i<count; i++)
                dst.AddRange(Jit(skip(lead,i), exclusions));
            var collected = dst.ToArray();
            Array.Sort(collected);
            return collected;
        }

        public ApiMembers Jit(IPart src)
        {
            var dst = root.list<ApiMember>();
            var catalog = ApiCatalogs.create(src);
            var types = catalog.ApiTypes;
            var hosts = catalog.ApiHosts;

            foreach(var t in types.Storage)
                dst.AddRange(Jit(t));
            foreach(var h in hosts.Storage)
                dst.AddRange(Jit(h).Storage);

            return dst.ToArray();
        }

        ApiMember[] Jit(ApiTypeInfo src)
            => Jit(src, ApiTypeInfo.Ignore);

        [Op]
        ApiMember[] Jit(ApiTypeInfo src, HashSet<string> exclusions)
        {
            var methods = src.HostType.DeclaredMethods().Unignored().NonGeneric().Exclude(exclusions).Select(m => new HostedMethod(src.Uri, m));
            var located = methods.Select(m => m.WithLocation(address(Jit(m.Method))));
            Array.Sort(located);
            return Members(located);
        }

        [Op]
        ApiMember[] Members(HostedMethod[] located)
        {
            var count = located.Length;
            var dst = sys.alloc<ApiMember>(count);
            for(var i=0; i<count; i++)
            {
                var member = located[i];
                var method = member.Method;
                var kind = method.KindId();
                var id = Diviner.Identify(method);
                var uri = ApiIdentity.uri(ApiUriScheme.Located, member.Host, method.Name, id);
                dst[i] = new ApiMember(uri,method, kind, member.Location);
            }

            return dst;
        }

        IMultiDiviner Diviner
            => MultiDiviner.Service;

        IntPtr Jit(MethodInfo src)
        {
            RuntimeHelpers.PrepareMethod(src.MethodHandle);
            return src.MethodHandle.GetFunctionPointer();
        }

        ApiMember[] JitDirect(IApiHost src)
        {
            var methods = ApiQuery.DirectMethods(src);
            var count = methods.Length;
            var buffer = alloc<ApiMember>(count);
            ref var dst = ref first(buffer);

            for(var i=0; i<count; i++)
            {
                var m = methods[i];
                var kid = m.Method.KindId();
                var id = Diviner.Identify(m.Method);
                var uri = ApiIdentity.uri(ApiUriScheme.Located, src.Uri, m.Method.Name, id);
                var location = address(Jit(m.Method));
                seek(dst,i) = new ApiMember(uri, m.Method, kid, location);

            }
            return buffer;
            // return from m in methods
            //     let kid = m.Method.KindId()
            //     let id = Diviner.Identify(m.Method)
            //     let uri = ApiIdentity.uri(ApiUriScheme.Located, src.Uri, m.Method.Name, id)
            //     let address = address(Jit(m.Method))
            //     select new ApiMember(uri, m.Method, kid, address);
        }

        ApiMember[] JitGeneric(IApiHost src)
        {
            var generic = @readonly(ApiQuery.GenericMethods(src));
            var gCount = generic.Length;
            var buffer = root.list<ApiMember>();
            for(var i=0; i<gCount; i++)
                buffer.AddRange(JitGeneric(skip(generic,i)));
            return buffer.ToArray();
        }

        [Op]
        ApiMember[] JitGeneric(HostedMethod src)
        {
            var method = src.Method;
            var types = @readonly(ApiQuery.NumericClosureTypes(method));
            var count = types.Length;
            var buffer = alloc<ApiMember>(count);
            var dst = span(buffer);
            var @class = method.KindId();
            try
            {
                for(var i=0u; i<count; i++)
                {
                    ref readonly var t = ref skip(types, i);
                    var reified = src.Method.MakeGenericMethod(t);
                    var address = z.address(Jit(reified));
                    var id = Diviner.Identify(reified);
                    var uri = ApiIdentity.uri(ApiUriScheme.Located, src.Host, method.Name, id);
                    seek(dst,i) = new ApiMember(uri, reified, @class, address);
                }
            }
            catch(ArgumentException e)
            {
                var msg = string.Format("{0}: Closure creation failed for {1}/{2}", e.GetType().Name, method.DeclaringType.DisplayName(), method.DisplayName());
                term.warn(msg);
                return sys.empty<ApiMember>();
            }
            catch(Exception e)
            {
                term.warn(e.ToString());
            }
            return buffer;
        }


        public IDictionary<MethodInfo,Type> ClosureProviders(IEnumerable<Type> src)
        {
            var query = from t in src
                        from m in t.DeclaredStaticMethods()
                        let tag = m.Tag<ClosureProviderAttribute>()
                        where tag.IsSome()
                        select (m, tag.Value.ProviderType);
            return query.ToDictionary();
        }

        public Index<ApiAddressRecord> EmitAddresses(BasedApiMembers src, FS.FilePath dst)
        {
            var summaries = Summarize(src.Base, src.Members.View);
            var emitting = Wf.EmittingTable<ApiAddressRecord>(dst);
            var emitted = Records.emit<ApiAddressRecord>(summaries, dst);
            Wf.EmittedTable<ApiAddressRecord>(emitting, emitted.RowCount, dst);
            return summaries;
        }

        Index<ApiAddressRecord> Summarize(MemoryAddress @base, ReadOnlySpan<ApiMember> members)
        {
            var count = members.Length;
            var buffer = alloc<ApiAddressRecord>(count);
            ref var dst = ref first(buffer);
            var rebase = first(members).BaseAddress;
            for(uint seq=0; seq<count; seq++)
            {
                ref var record = ref seek(dst,seq);
                ref readonly var member = ref skip(members, seq);
                record.Sequence = seq;
                record.ProcessBase = @base;
                record.MemberBase = member.BaseAddress;
                record.MemberOffset = member.BaseAddress - @base;
                record.MemberRebase = member.BaseAddress - rebase;
                record.MaxSize = seq < count - 1 ? (ulong)(skip(members, seq + 1).BaseAddress - record.MemberBase) : 0ul;
                record.HostName = member.Host.Name;
                record.PartName = member.Host.Owner.Format();
                record.Identifier = member.Id;
            }
            return buffer;
        }
    }

    partial struct Msg
    {
        public static RenderPattern<int> JittingParts => "Jitting {0} parts";

        public static RenderPattern<PartId> JittingPart => "Jitting {0} members";

        public static RenderPattern<int,PartId> JittedPart => "Jitting {0} {1} members";

        public static RenderPattern<dynamic,dynamic> JittedMembers => "Jitted {0} members from {1} parts";
    }
}