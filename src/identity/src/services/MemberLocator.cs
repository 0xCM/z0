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

      public readonly struct MemberLocator : IMemberLocator
      {
            public static MemberLocator Service 
                  => default;

            public static ApiMembers locate(IApiHost src)
            {
                  var generic = HostedGeneric(src);
                  var direct = HostedDirect(src);
                  var all = direct.Concat(generic).Array();
                  return all.OrderBy(x => x.Method.MetadataToken);
            }

            public ApiMembers Locate(IApiHost src)
                  => locate(src);

            static IEnumerable<ApiMember> HostedKind<K>(IApiHost src, K kind, bool generic = false)
                  where K : unmanaged, Enum
                        => HostedGeneric(src,kind).Concat(HostedDirect(src,kind)).OrderBy(x => x.Method.MetadataToken);

            static IEnumerable<ApiMember> Hosted<K>(IApiHost src, K kind, GenericState g)
                  where K : unmanaged, Enum
                        => g.IsGeneric() ? HostedGeneric(src,kind) : HostedDirect(src, kind);

            static IEnumerable<ApiMember> HostedDirect<K>(IApiHost src, K kind)
                  where K : unmanaged, Enum
                        => from m in DirectMethods(src,kind)
                        let id = Diviner.Identify(m)
                        let uri = OpUri.Define(OpUriScheme.Type, src.Uri, m.Name, id)
                        select new ApiMember(uri, m, m.KindId());

            static IEnumerable<ApiMember> HostedGeneric<K>(IApiHost src, K kind)
                  where K : unmanaged, Enum
                        => from m in GenericMethods(src,kind)
                        from closure in ClosureQuery.numeric(m)
                        let reified = m.MakeGenericMethod(closure)
                        let id = Diviner.Identify(reified)
                        let uri = OpUri.Define(OpUriScheme.Type, src.Uri, m.Name, id)
                        select new ApiMember(uri, reified, m.KindId());

            static IEnumerable<ApiMember> HostedDirect(IApiHost src)
                  => from m in DirectMethods(src)
                  let id = Diviner.Identify(m)
                  let uri = OpUri.Define(OpUriScheme.Type, src.Uri, m.Name, id)
                  select new ApiMember(uri, m, m.KindId());

            static IEnumerable<ApiMember> HostedGeneric(IApiHost src)
                  => from m in GenericMethods(src)
                  from closure in ClosureQuery.numeric(m)
                  let reified = m.MakeGenericMethod(closure)
                  let id = Diviner.Identify(reified)
                  let uri = OpUri.Define(OpUriScheme.Type, src.Uri, m.Name, id)
                  select new ApiMember(uri, reified, m.KindId());

            static IEnumerable<MethodInfo> GenericMethods(IApiHost src)
                  => from m in src.HostType.DeclaredMethods().OpenGeneric(1)
                        where m.Tagged<OpAttribute>() 
                        && m.Tagged<ClosuresAttribute>() 
                        && !m.AcceptsImmediate()
                        select m;
      
            static IEnumerable<MethodInfo> DirectMethods(IApiHost src)
                  => from m in src.HostType.DeclaredMethods().NonGeneric()
                  where m.Tagged<OpAttribute>() && !m.AcceptsImmediate()
                  select m;

            static IEnumerable<MethodInfo> GenericMethods<K>(IApiHost src, K kind)
                  where K : unmanaged, Enum
                  => from m in src.HostType.DeclaredMethods().OpenGeneric(1)
                  where m.Tagged<OpAttribute>() 
                        && m.Tagged<ClosuresAttribute>() 
                        && !m.AcceptsImmediate() 
                        && m.KindId().ToString() == kind.ToString()
                  select m;

            static IEnumerable<MethodInfo> DirectMethods<K>(IApiHost src, K kind)
                  where K : unmanaged, Enum
                  => from m in src.HostType.DeclaredMethods().NonGeneric()
                  where m.Tagged<OpAttribute>() 
                        && !m.AcceptsImmediate() 
                        && m.KindId().ToString() == kind.ToString()                  
                  select m;

            static IMultiDiviner Diviner 
                  => MultiDiviner.Service;
      }
}