//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;

    using Z0.Events;

    using static Konst;
    using static z;

    public readonly struct ApiMemberJit
    {
        [MethodImpl(Inline)]
        public static MemoryAddress jit(MethodInfo src)
        {
            RuntimeHelpers.PrepareMethod(src.MethodHandle);
            return src.MethodHandle.GetFunctionPointer();
        }

        public static ApiMembers jit(IApiHost src)
        {
            var direct = JitLocatedDirect(src).Array();
            var generic = JitGeneric(src).Array();
            var all = direct.Concat(generic).Array();
            return all.OrderBy(x => x.Address);
        }

        public static ApiMembers jit(IApiHost[] src, IWfEventSink sink)
        {
            var xyz = src.Where(h => h.IsDataType).Cast<ApiDataType>().GroupBy(x => x.PartId).Select(x => new ApiDataTypes(x.Key, x.ToArray())).Array();
            var datatypes = jit(xyz);
            var direct = JitDirectMembers(src, sink);
            var generic = JitGenericMembers(src, sink);
            var all = datatypes.Concat(direct).Concat(generic).Array();
            return all.OrderBy(x => x.Address);
        }

        public static ApiMember[] jit(ApiDataType src)
            => jit(src, ApiDataType.Ignore);

        public static ApiMember[] jit(ApiDataType src, HashSet<string> exclusions)
        {
            var methods = src.HostType.DeclaredMethods().Unignored().NonGeneric().Exclude(exclusions).Select(m => new HostedMethod(src.Uri, m));
            var located = methods.Select(m => m.WithLocation(z.address(Jit(m.Method))));
            Array.Sort(located);
            return members(located);
        }

        public static ApiMember[] jit(ApiDataTypes[] src)
        {
            var dst = z.list<ApiMember>();
            foreach(var types in src)
                dst.AddRange(jit(types));
            var collected = dst.ToArray();
            Array.Sort(collected);
            return collected;
        }

        public static ApiMember[] jit(ApiDataTypes src)
        {
            var dst = z.list<ApiMember>();
            var count = src.Count;
            var exclusions = ApiDataType.Ignore;
            ref var lead = ref src.LeadingCell;

            for(var i=0u; i<count; i++)
                dst.AddRange(jit(skip(lead,i), exclusions));
            var collected = dst.ToArray();
            Array.Sort(collected);
            return collected;
        }

        public static ApiMember[] JitGenericMembers(IApiHost[] src, IWfEventSink sink)
            => members(JitGeneric(src, sink));

        public static HostedMethod[] JitDirect(IApiHost[] src, IWfEventSink sink)
        {
            var methods = DirectMethods(src, sink);
            var located = methods.Select(m => m.WithLocation(Root.address(Jit(m.Method))));
            Array.Sort(located);
            return located;
        }

        public static ApiMember[] JitDirectMembers(IApiHost[] src, IWfEventSink sink)
            => members(JitDirect(src, sink));

        public static HostedMethod[] JitGeneric(IApiHost[] src, IWfEventSink sink)
        {
            var methods = GenericMethods(src, sink);
            var closed = methods.SelectMany(m => (from t in ApiQuery.NumericClosureTypes(m.Method) select new HostedMethod(m.Host, m.Method.MakeGenericMethod(t))));
            var located = closed.Select(m => m.WithLocation(Root.address(Jit(m.Method))));
            Array.Sort(located);
            return located;
        }

        public static ApiMember[] members(HostedMethod[] located)
        {
            var dst = sys.alloc<ApiMember>(located.Length);

            for(var i=0; i<located.Length; i++)
            {
                var member = located[i];
                var method = member.Method;
                var kind = method.KindId();
                var id = Diviner.Identify(method);
                var uri = OpUri.Define(ApiUriScheme.Located, member.Host, method.Name, id);
                dst[i] = new ApiMember(uri,method, kind, member.Location);
            }

            return dst;
        }

        public static ApiMember[] JitLocatedDirect(IApiHost src)
            =>  from m in ApiQuery.DirectMethods(src)
                let kid = m.Method.KindId()
                let id = Diviner.Identify(m.Method)
                let uri = OpUri.Define(ApiUriScheme.Located, src.Uri, m.Method.Name, id)
                let address = z.address(Jit(m.Method))
                select new ApiMember(uri, m.Method, kid, address);

        public static ApiMember[] JitGeneric(IApiHost src)
            =>  (from m in ApiQuery.GenericMethods(src)
                let kid = m.Method.KindId()
                from t in ApiQuery.NumericClosureTypes(m.Method)
                let reified = m.Method.MakeGenericMethod(t)
                let address = Root.address(Jit(reified))
                let id = Diviner.Identify(reified)
                let uri = OpUri.Define(ApiUriScheme.Located, src.Uri, m.Method.Name, id)
                select new ApiMember(uri, reified, kid, address)).Array();


        public static HostedMethod[] DirectMethods(IApiHost[] src, IWfEventSink broker)
        {
            var dst = z.list<HostedMethod>();
            foreach(var host in src)
            {
                var methods = ApiQuery.DirectMethods(host);
                if(methods.Length != 0)
                {
                    broker.Deposit(new MethodsPrepared(WfActor.create(), host.Uri, methods.Length, correlate(0ul)));
                    dst.AddRange(methods);
                }
            }
            return dst.ToArray();
        }

        public static HostedMethod[] GenericMethods(IApiHost[] src, IWfEventSink broker)
        {
            var dst = z.list<HostedMethod>();
            foreach(var host in src)
            {
                var methods = ApiQuery.GenericMethods(host);
                if(methods.Length != 0)
                {
                    broker.Deposit(new MethodsPrepared(WfActor.create(), host.Uri, methods.Length, correlate(0ul)));
                    dst.AddRange(methods);
                }
            }
            return dst.ToArray();
        }

        static IMultiDiviner Diviner
            => MultiDiviner.Service;

        [MethodImpl(Inline)]
        static IntPtr Jit(MethodInfo src)
        {
            RuntimeHelpers.PrepareMethod(src.MethodHandle);
            return src.MethodHandle.GetFunctionPointer();
        }
    }
}