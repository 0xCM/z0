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

      using static Seed;

      class MemberLocator : IMemberLocator
      {
            public IContext Context {get;}

            public IMultiDiviner Diviner {get;}

            [MethodImpl(Inline)]
            public static MemberLocator New(IContext context, IMultiDiviner diviner)
                  => new MemberLocator(context,diviner);

            [MethodImpl(Inline)]
            MemberLocator(IContext context, IMultiDiviner diviner)
            {
                  Context = context;
                  Diviner = diviner;
            }

            [MethodImpl(Inline)]
            static IntPtr Jit(MethodInfo src)
            {
                  RuntimeHelpers.PrepareMethod(src.MethodHandle);
                  return src.MethodHandle.GetFunctionPointer();
            }

            public IEnumerable<ApiMember> HostedKind<K>(IApiHost src, K kind, GenericPartition g = GenericPartition.NonGeneric)
                  where K : unmanaged, Enum
                  => HostedGeneric(src,kind).Concat(HostedDirect(src,kind)).OrderBy(x => x.Method.MetadataToken);

            public IEnumerable<ApiMember> Hosted(IApiHost src)
                  => HostedGeneric(src).Concat(HostedDirect(src)).OrderBy(x => x.Method.MetadataToken);

            public IEnumerable<ApiMember> Located(IApiHost src)
                  => LocatedGeneric(src).Concat(LocatedDirect(src)).OrderBy(x => x.Address);

            public IEnumerable<ApiMember> HostedNaturalNumeric(IApiHost src)  
                  => from m in src.HostingType.DeclaredMethods().NaturalNumeric()  
                  let kid = m.KindId()
                  from c in ApiCollector.NaturalNumericClosures(m) 
                  let reified = c.ClosedMethod
                  let id = Diviner.Identify(reified)
                  let uri = OpUri.Define(OpUriScheme.Type, src.UriPath, m.Name, id)
                  select ApiMember.Define(uri, reified, kid);

            public IEnumerable<ApiMember> LocatedNaturalNumeric(IApiHost src)  
                  => from m in HostedNaturalNumeric(src)
                  let address = MemoryAddress.Define(Jit(m.Method))
                  let uri = OpUri.Define(OpUriScheme.Located, src.UriPath, m.Method.Name, m.Id)
                  select ApiMember.Define(uri, m.Method, m.KindId ?? OpKindId.None, address);

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
                        let uri = OpUri.Define(OpUriScheme.Type, src.UriPath, m.Name, id)
                        select ApiMember.Define(uri, m, m.KindId());

            public IEnumerable<ApiMember> LocatedDirect<K>(IApiHost src, K kind)
                  where K : unmanaged, Enum
                  => from m in HostedDirect(src,kind)                        
                  let address = MemoryAddress.Define(Jit(m.Method))
                  let uri = OpUri.Define(OpUriScheme.Located, src.UriPath, m.Method.Name, m.Id)
                  select ApiMember.Define(uri, m.Method, m.KindId ?? OpKindId.None, address);

            public IEnumerable<ApiMember> LocatedGeneric<K>(IApiHost src, K kind)
                  where K : unmanaged, Enum
                  => from m in GenericMethods(src,kind)
                  let kid = m.KindId()
                  from t in ApiCollector.NumericClosures(m)
                  let reified = m.MakeGenericMethod(t)
                  let address = MemoryAddress.Define(Jit(reified))
                  let id = Diviner.Identify(reified)
                  let uri = OpUri.Define(OpUriScheme.Located, src.UriPath, m.Name, id)
                  select ApiMember.Define(uri, reified, kid, address);

            public IEnumerable<ApiMember> HostedGeneric<K>(IApiHost src, K kind)
                  where K : unmanaged, Enum
                        => from m in GenericMethods(src,kind)
                        let kid = m.KindId()
                        from t in ApiCollector.NumericClosures(m)
                        let reified = m.MakeGenericMethod(t)
                        let id = Diviner.Identify(reified)
                        let uri = OpUri.Define(OpUriScheme.Type, src.UriPath, m.Name, id)
                        select ApiMember.Define(uri, reified, kid);

            public IEnumerable<ApiMember> HostedDirect(IApiHost src)
                  => from m in DirectMethods(src)
                  let kid = m.KindId()
                  let id = Diviner.Identify(m)
                  let uri = OpUri.Define(OpUriScheme.Type, src.UriPath, m.Name, id)
                  select ApiMember.Define(uri, m, kid);

            public IEnumerable<ApiMember> LocatedDirect(IApiHost src)
                  => from m in DirectMethods(src)
                  let kid = m.KindId()
                  let address = MemoryAddress.Define(Jit(m))
                  let id = Diviner.Identify(m)
                  let uri = OpUri.Define(OpUriScheme.Located, src.UriPath, m.Name, id)
                  select ApiMember.Define(uri, m, kid, address);
                        
            public IEnumerable<ApiMember> HostedGeneric(IApiHost src)
                  => from m in GenericMethods(src)
                  let kid = m.KindId()
                  from t in ApiCollector.NumericClosures(m)
                  let reified = m.MakeGenericMethod(t)
                  let id = Diviner.Identify(reified)
                  let uri = OpUri.Define(OpUriScheme.Type, src.UriPath, m.Name, id)
                  select ApiMember.Define(uri, reified, kid);

            public IEnumerable<ApiMember> LocatedGeneric(IApiHost src)
                  => from m in GenericMethods(src)
                  let kid = m.KindId()
                  from t in ApiCollector.NumericClosures(m)
                  let reified = m.MakeGenericMethod(t)
                  let address = MemoryAddress.Define(Jit(reified))
                  let id = Diviner.Identify(reified)
                  let uri = OpUri.Define(OpUriScheme.Located, src.UriPath, m.Name, id)
                  select ApiMember.Define(uri, reified, kid, address);

            IEnumerable<MethodInfo> GenericMethods(IApiHost src)
                  => from m in src.HostingType.DeclaredMethods().OpenGeneric(1)
                  where m.Tagged<OpAttribute>() && m.Tagged<ClosuresAttribute>() && !m.AcceptsImmediate()
                  select m;
      
            IEnumerable<MethodInfo> DirectMethods(IApiHost src)
                  => from m in src.HostingType.DeclaredMethods().NonGeneric()
                  where m.Tagged<OpAttribute>() && !m.AcceptsImmediate()
                  select m;

            IEnumerable<MethodInfo> GenericMethods<K>(IApiHost src, K kind)
                  where K : unmanaged, Enum
                  => from m in src.HostingType.DeclaredMethods().OpenGeneric(1)
                  where m.Tagged<OpAttribute>() 
                        && m.Tagged<ClosuresAttribute>() 
                        && !m.AcceptsImmediate() 
                        && m.KindId().ToString() == kind.ToString()
                  select m;

            IEnumerable<MethodInfo> DirectMethods<K>(IApiHost src, K kind)
                  where K : unmanaged, Enum
                  => from m in src.HostingType.DeclaredMethods().NonGeneric()
                  where m.Tagged<OpAttribute>() 
                        && !m.AcceptsImmediate() 
                        && m.KindId().ToString() == kind.ToString()                  
                  select m;

      }
}