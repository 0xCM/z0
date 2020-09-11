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
        public static MemoryAddress jit(ApiMember src)
        {
            RuntimeHelpers.PrepareMethod(src.Method.MethodHandle);
            return src.Method.MethodHandle.GetFunctionPointer();
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
            var datatypes = jit(src.Where(h => h is ApiDataType).Cast<ApiDataType>());
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

        public static ApiMember[] jit(ApiDataType[] src)
        {
            var dst = z.list<ApiMember>();
            var count = src.Length;
            var exclusions = ApiDataType.Ignore;

            Array.Sort(src);

            for(var i=0; i<count; i++)
            {
                var host = src[i];
                dst.AddRange(jit(host, exclusions));
            }
            return dst.ToArray();
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
            var closed = methods.SelectMany(m => (from t in MemberLocator.numeric(m.Method) select new HostedMethod(m.Host, m.Method.MakeGenericMethod(t))));
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
                var uri = OpUri.Define(OpUriScheme.Located, member.Host, method.Name, id);
                dst[i] = new ApiMember(uri,method, kind, member.Location);
            }

            return dst;
        }

        public static ApiMember[] JitLocatedDirect(IApiHost src)
            =>  from m in ApiMemberQuery.DirectMethods(src)
                let kid = m.Method.KindId()
                let id = Diviner.Identify(m.Method)
                let uri = OpUri.Define(OpUriScheme.Located, src.Uri, m.Method.Name, id)
                let address = z.address(Jit(m.Method))
                select new ApiMember(uri, m.Method, kid, address);

        public static ApiMember[] JitGeneric(IApiHost src)
            =>  (from m in ApiMemberQuery.GenericMethods(src)
                let kid = m.Method.KindId()
                from t in MemberLocator.numeric(m.Method)
                let reified = m.Method.MakeGenericMethod(t)
                let address = Root.address(Jit(reified))
                let id = Diviner.Identify(reified)
                let uri = OpUri.Define(OpUriScheme.Located, src.Uri, m.Method.Name, id)
                select new ApiMember(uri, reified, kid, address)).Array();


        public static HostedMethod[] DirectMethods(IApiHost[] src, IWfEventSink broker)
        {
            var dst = z.list<HostedMethod>();
            foreach(var host in src)
            {
                var methods = ApiMemberQuery.DirectMethods(host);
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
                var methods = ApiMemberQuery.GenericMethods(host);
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