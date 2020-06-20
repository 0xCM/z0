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

      public class MemberLocator : IMemberLocator
      {
            IMultiDiviner Diviner  => MultiDiviner.Service;

            public static IMemberLocator Service => new MemberLocator();

            [MethodImpl(Inline)]
            static IntPtr Jit(MethodInfo src)
            {
                  RuntimeHelpers.PrepareMethod(src.MethodHandle);
                  return src.MethodHandle.GetFunctionPointer();
            }

            public ApiMembers Hosted(IApiHost src)
                  => HostedGeneric(src).Concat(HostedDirect(src)).OrderBy(x => x.Method.MetadataToken).ToArray();

            public ApiMembers Located(IApiHost src)
                  => LocatedGeneric(src).Concat(LocatedDirect(src)).OrderBy(x => x.Address).ToArray();

            public IEnumerable<ApiMember> HostedKind<K>(IApiHost src, K kind, bool generic = false)
                  where K : unmanaged, Enum
                  => HostedGeneric(src,kind).Concat(HostedDirect(src,kind)).OrderBy(x => x.Method.MetadataToken);

            public IEnumerable<ApiMember> Hosted<K>(IApiHost src, K kind, GenericPartition g)
                  where K : unmanaged, Enum
                  => g.IsGeneric() ? HostedGeneric(src,kind) : HostedDirect(src, kind);

            public IEnumerable<ApiMember> Located<K>(IApiHost src, K kind, GenericPartition g)
                  where K : unmanaged, Enum
                        => g.IsGeneric() ? LocatedGeneric(src,kind) : LocatedDirect(src, kind);

            public IEnumerable<ApiMember> HostedDirect<K>(IApiHost src, K kind)
                  where K : unmanaged, Enum
                        => from m in DirectMethods(src,kind)
                        let id = Diviner.Identify(m)
                        let uri = OpUri.Define(OpUriScheme.Type, src.Uri, m.Name, id)
                        select new ApiMember(uri, m, m.KindId());

            public IEnumerable<ApiMember> HostedGeneric<K>(IApiHost src, K kind)
                  where K : unmanaged, Enum
                        => from m in GenericMethods(src,kind)
                        from closure in ApiCollector.NumericClosures(m)
                        let reified = m.MakeGenericMethod(closure)
                        let id = Diviner.Identify(reified)
                        let uri = OpUri.Define(OpUriScheme.Type, src.Uri, m.Name, id)
                        select new ApiMember(uri, reified, m.KindId());

            public IEnumerable<ApiMember> HostedDirect(IApiHost src)
                  => from m in DirectMethods(src)
                  let id = Diviner.Identify(m)
                  let uri = OpUri.Define(OpUriScheme.Type, src.Uri, m.Name, id)
                  select new ApiMember(uri, m, m.KindId());

            public IEnumerable<ApiMember> HostedGeneric(IApiHost src)
                  => from m in GenericMethods(src)
                  from closure in ApiCollector.NumericClosures(m)
                  let reified = m.MakeGenericMethod(closure)
                  let id = Diviner.Identify(reified)
                  let uri = OpUri.Define(OpUriScheme.Type, src.Uri, m.Name, id)
                  select new ApiMember(uri, reified, m.KindId());

            public IEnumerable<ApiMember> LocatedDirect<K>(IApiHost src, K kind)
                  where K : unmanaged, Enum
                        => from m in HostedDirect(src, kind)                        
                        let uri = OpUri.Define(OpUriScheme.Located, src.Uri, m.Method.Name, m.Id)
                        let address = Addresses.address(Jit(m.Method))
                        select new ApiMember(uri, m.Method, m.KindId, address);

            public IEnumerable<ApiMember> LocatedGeneric<K>(IApiHost src, K kind)
                  where K : unmanaged, Enum
                  => from m in GenericMethods(src,kind)
                  from t in ApiCollector.NumericClosures(m)
                  let reified = m.MakeGenericMethod(t)
                  let id = Diviner.Identify(reified)
                  let uri = OpUri.Define(OpUriScheme.Located, src.Uri, m.Name, id)
                  let address = Addresses.address(Jit(reified))
                  select new ApiMember(uri, reified, m.KindId(), address);

            public IEnumerable<ApiMember> LocatedDirect(IApiHost src)
                  => from m in DirectMethods(src)
                  let kid = m.KindId()
                  let id = Diviner.Identify(m)
                  let uri = OpUri.Define(OpUriScheme.Located, src.Uri, m.Name, id)
                  let address = Addresses.address(Jit(m))
                  select new ApiMember(uri, m, kid, address);
                        
            public IEnumerable<ApiMember> LocatedGeneric(IApiHost src)
                  => from m in GenericMethods(src)
                  let kid = m.KindId()
                  from t in ApiCollector.NumericClosures(m)
                  let reified = m.MakeGenericMethod(t)
                  let address = Addresses.address(Jit(reified))
                  let id = Diviner.Identify(reified)
                  let uri = OpUri.Define(OpUriScheme.Located, src.Uri, m.Name, id)
                  select new ApiMember(uri, reified, kid, address);

            IEnumerable<MethodInfo> GenericMethods(IApiHost src)
                  => from m in src.HostType.DeclaredMethods().OpenGeneric(1)
                        where m.Tagged<OpAttribute>() 
                        && m.Tagged<ClosuresAttribute>() 
                        && !m.AcceptsImmediate()
                        select m;
      
            IEnumerable<MethodInfo> DirectMethods(IApiHost src)
                  => from m in src.HostType.DeclaredMethods().NonGeneric()
                  where m.Tagged<OpAttribute>() && !m.AcceptsImmediate()
                  select m;

            IEnumerable<MethodInfo> GenericMethods<K>(IApiHost src, K kind)
                  where K : unmanaged, Enum
                  => from m in src.HostType.DeclaredMethods().OpenGeneric(1)
                  where m.Tagged<OpAttribute>() 
                        && m.Tagged<ClosuresAttribute>() 
                        && !m.AcceptsImmediate() 
                        && m.KindId().ToString() == kind.ToString()
                  select m;

            IEnumerable<MethodInfo> DirectMethods<K>(IApiHost src, K kind)
                  where K : unmanaged, Enum
                  => from m in src.HostType.DeclaredMethods().NonGeneric()
                  where m.Tagged<OpAttribute>() 
                        && !m.AcceptsImmediate() 
                        && m.KindId().ToString() == kind.ToString()                  
                  select m;
      }
}