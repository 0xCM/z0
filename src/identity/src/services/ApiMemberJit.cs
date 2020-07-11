//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static Konst;
        
    public readonly struct ApiMemberJit
    {
        public static ApiMembers jit(IApiHost src)
        {
            var direct = JitLocatedDirect(src).Array();
            var generic = JitLocatedGeneric(src).Array();
            var all = direct.Concat(generic).Array();
            return all.OrderBy(x => x.Address);
        }
        
        public static ApiMembers jit(ApiHost[] src, IEventBroker broker)
        {
            void OnProgress(IAppEvent broker)
                => term.print(broker);

            var direct = JitDirectMembers(src, broker);
            var generic = JitGenericMembers(src, broker);
            var all = direct.Concat(generic).Array(); 
            return all.OrderBy(x => x.Address);
        }

        public static ApiMembers jit<K>(IApiHost src, K kind, GenericPartition g)
            where K : unmanaged, Enum
                => g.IsGeneric() ? JitLocatedGeneric(src, kind) : JitLocatedDirect(src, kind);

        static ApiMember[] JitDirectMembers(ApiHost[] src, IEventBroker broker)
            => DefineMembers(JitDirect(src, broker), broker);

        static ApiMember[] JitGenericMembers(ApiHost[] src, IEventBroker broker)
            => DefineMembers(JitGeneric(src, broker), broker);

        static HostedMethod[] JitDirect(ApiHost[] src, IEventBroker broker)
        {   
            var methods = DirectMethods(src, broker);            
            var located = methods.Select(m => m.WithLocation(Root.address(Jit(m.Method))));  
            Array.Sort(located);
            return located;
        }

        static HostedMethod[] JitGeneric(ApiHost[] src, IEventBroker broker)
        {   
            var methods = GenericMethods(src, broker);            
            var closed = methods.SelectMany(m => (from t in ClosureQuery.numeric(m.Method) select new HostedMethod(m.Host, m.Method.MakeGenericMethod(t))));
            var located = closed.Select(m => m.WithLocation(Root.address(Jit(m.Method))));
            Array.Sort(located);
            return located;
        }

        static ApiMember[] DefineMembers(HostedMethod[] located, IEventBroker broker)
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

        static ApiMember[] JitLocatedDirect(IApiHost src)
            =>  from m in DirectMethods(src)
                let kid = m.KindId()
                let id = Diviner.Identify(m)
                let uri = OpUri.Define(OpUriScheme.Located, src.Uri, m.Name, id)
                let address = Root.address(Jit(m))
                select new ApiMember(uri, m, kid, address);

        static ApiMember[] JitLocatedGeneric(IApiHost src)
            =>  (from m in GenericMethods(src)
                let kid = m.KindId()
                from t in ClosureQuery.numeric(m)
                let reified = m.MakeGenericMethod(t)
                let address = Root.address(Jit(reified))
                let id = Diviner.Identify(reified)
                let uri = OpUri.Define(OpUriScheme.Located, src.Uri, m.Name, id)
                select new ApiMember(uri, reified, kid, address)).Array();

        static ApiMember[] JitLocatedDirect<K>(IApiHost src, K kind)
            where K : unmanaged, Enum
                => from m in HostedDirect(src, kind)                        
                let uri = OpUri.Define(OpUriScheme.Located, src.Uri, m.Method.Name, m.Id)
                let address = Root.address(Jit(m.Method))
                select new ApiMember(uri, m.Method, m.KindId, address);

        static ApiMember[] HostedDirect<K>(IApiHost src, K kind)
            where K : unmanaged, Enum
                => from m in DirectMethods(src,kind)
                let id = Diviner.Identify(m)
                let uri = OpUri.Define(OpUriScheme.Type, src.Uri, m.Name, id)
                select new ApiMember(uri, m, m.KindId());

        static ApiMember[] JitLocatedGeneric<K>(IApiHost src, K kind)
            where K : unmanaged, Enum
                => (from m in GenericMethods(src,kind)
                from t in ClosureQuery.numeric(m)
                let reified = m.MakeGenericMethod(t)
                let id = Diviner.Identify(reified)
                let uri = OpUri.Define(OpUriScheme.Located, src.Uri, m.Name, id)
                let address = Root.address(Jit(reified))
                select new ApiMember(uri, reified, m.KindId(), address)).Array();

        static ApiMember[] HostedGeneric<K>(IApiHost src, K kind)
            where K : unmanaged, Enum
                => (from m in GenericMethods(src,kind)
                from closure in ClosureQuery.numeric(m)
                let reified = m.MakeGenericMethod(closure)
                let id = Diviner.Identify(reified)
                let uri = OpUri.Define(OpUriScheme.Type, src.Uri, m.Name, id)
                select new ApiMember(uri, reified, m.KindId())).Array();

        static MethodInfo[] GenericMethods(IApiHost src)
            => from m in src.HostType.DeclaredMethods().OpenGeneric(1)
                where m.Tagged<OpAttribute>() 
                && m.Tagged<ClosuresAttribute>() 
                && !m.AcceptsImmediate()
                select m;

        static MethodInfo[] DirectMethods(IApiHost src)
            => from m in src.HostType.DeclaredMethods().NonGeneric()
            where m.Tagged<OpAttribute>() && !m.AcceptsImmediate()
            select m;

        static HostedMethod[] DirectMethods(ApiHost[] src, IEventBroker broker)
        {
            var dst = z.list<HostedMethod>();
            foreach(var host in src)
            {
                var methods = DirectMethods(host);
                broker.Raise(AppStatusEvent.Create($"{methods.Length} {host.Uri} direct  methods were jitted"));
                dst.AddRange(methods);
            }
            return dst.ToArray();
        }

        static HostedMethod[] GenericMethods(ApiHost[] src, IEventBroker broker)
        {
            var dst = z.list<HostedMethod>();
            foreach(var host in src)
            {
                var methods = GenericMethods(host);
                broker.Raise(AppStatusEvent.Create($"{methods.Length} {host.Uri} generic methods were jitted"));                
                dst.AddRange(methods);
            }
            return dst.ToArray();
        }

        static HostedMethod[] DirectMethods(ApiHost host)
            => host.HostType.DeclaredMethods().NonGeneric().Where(IsDirectApiMember).Select(m => new HostedMethod(host.Uri, m));

        static HostedMethod[] GenericMethods(ApiHost host)
            => host.HostType.DeclaredMethods().OpenGeneric(1).Where(IsGenericApiMember).Select(m => new HostedMethod(host.Uri, m));

            
        static bool IsDirectApiMember(MethodInfo src)
            => src.Tagged<OpAttribute>() && !src.AcceptsImmediate();

        static bool IsGenericApiMember(MethodInfo src)
            => src.Tagged<OpAttribute>() && src.Tagged<ClosuresAttribute>() && !src.AcceptsImmediate();

        static MethodInfo[] GenericMethods<K>(IApiHost src, K kind)
            where K : unmanaged, Enum
                => from m in src.HostType.DeclaredMethods().OpenGeneric(1)
                where m.Tagged<OpAttribute>() 
                && m.Tagged<ClosuresAttribute>() 
                && !m.AcceptsImmediate() 
                && m.KindId().ToString() == kind.ToString()
                select m;

        static MethodInfo[] DirectMethods<K>(IApiHost src, K kind)
            where K : unmanaged, Enum
                => from m in src.HostType.DeclaredMethods().NonGeneric()
                where m.Tagged<OpAttribute>() 
                && !m.AcceptsImmediate() 
                && m.KindId().ToString() == kind.ToString()                  
                select m;

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