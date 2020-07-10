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

        public static ApiMembers jit<K>(IApiHost src, K kind, GenericPartition g)
            where K : unmanaged, Enum
                => g.IsGeneric() ? JitLocatedGeneric(src, kind) : JitLocatedDirect(src, kind);

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