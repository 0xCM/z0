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
            public static MemberLocator Create(IContext context, IMultiDiviner diviner)
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

            public ApiMembers Hosted(IApiHost src)
                  => HostedGeneric(src).Concat(HostedDirect(src)).OrderBy(x => x.Method.MetadataToken).ToArray();

            public ApiMembers Located(IApiHost src)
                  => LocatedGeneric(src).Concat(LocatedDirect(src)).OrderBy(x => x.Address).ToArray();

            public IEnumerable<Member> HostedKind<K>(IApiHost src, K kind, bool generic = false)
                  where K : unmanaged, Enum
                  => HostedGeneric(src,kind).Concat(HostedDirect(src,kind)).OrderBy(x => x.Method.MetadataToken);

            public IEnumerable<Member> HostedNaturalNumeric(IApiHost src)  
                  => from m in src.HostingType.DeclaredMethods().NaturalNumeric()  
                  let kid = m.KindId()
                  from c in ApiCollector.NaturalNumericClosures(m) 
                  let reified = c.ClosedMethod
                  let id = Diviner.Identify(reified)
                  let uri = OpUri.Define(OpUriScheme.Type, src.UriPath, m.Name, id)
                  select Member.Define(uri, reified, kid);

            public IEnumerable<Member> LocatedNaturalNumeric(IApiHost src)  
                  => from m in HostedNaturalNumeric(src)
                  let address = MemoryAddress.Define(Jit(m.Method))
                  let uri = OpUri.Define(OpUriScheme.Located, src.UriPath, m.Method.Name, m.Id)
                  select Member.Define(uri, m.Method, m.KindId ?? OpKindId.None, address);

            public IEnumerable<Member> Hosted<K>(IApiHost src, K kind, GenericPartition g)
                  where K : unmanaged, Enum
                  => g.IsGeneric() ? HostedGeneric(src,kind) : HostedDirect(src, kind);

            public IEnumerable<Member> Located<K>(IApiHost src, K kind, GenericPartition g)
                  where K : unmanaged, Enum
                  => g.IsGeneric() ? LocatedGeneric(src,kind) : LocatedDirect(src, kind);

            public IEnumerable<Member> HostedDirect<K>(IApiHost src, K kind)
                  where K : unmanaged, Enum
                        => from m in DirectMethods(src,kind)
                        let id = Diviner.Identify(m)
                        let uri = OpUri.Define(OpUriScheme.Type, src.UriPath, m.Name, id)
                        select Member.Define(uri, m, m.KindId());

            public IEnumerable<Member> LocatedDirect<K>(IApiHost src, K kind)
                  where K : unmanaged, Enum
                  => from m in HostedDirect(src,kind)                        
                  let address = MemoryAddress.Define(Jit(m.Method))
                  let uri = OpUri.Define(OpUriScheme.Located, src.UriPath, m.Method.Name, m.Id)
                  select Member.Define(uri, m.Method, m.KindId ?? OpKindId.None, address);

            public IEnumerable<Member> LocatedGeneric<K>(IApiHost src, K kind)
                  where K : unmanaged, Enum
                  => from m in GenericMethods(src,kind)
                  let kid = m.KindId()
                  from t in ApiCollector.NumericClosures(m)
                  let reified = m.MakeGenericMethod(t)
                  let address = MemoryAddress.Define(Jit(reified))
                  let id = Diviner.Identify(reified)
                  let uri = OpUri.Define(OpUriScheme.Located, src.UriPath, m.Name, id)
                  select Member.Define(uri, reified, kid, address);

            public IEnumerable<Member> HostedGeneric<K>(IApiHost src, K kind)
                  where K : unmanaged, Enum
                        => from m in GenericMethods(src,kind)
                        let kid = m.KindId()
                        from t in ApiCollector.NumericClosures(m)
                        let reified = m.MakeGenericMethod(t)
                        let id = Diviner.Identify(reified)
                        let uri = OpUri.Define(OpUriScheme.Type, src.UriPath, m.Name, id)
                        select Member.Define(uri, reified, kid);

            public IEnumerable<Member> HostedDirect(IApiHost src)
                  => from m in DirectMethods(src)
                  let kid = m.KindId()
                  let id = Diviner.Identify(m)
                  let uri = OpUri.Define(OpUriScheme.Type, src.UriPath, m.Name, id)
                  select Member.Define(uri, m, kid);

            public IEnumerable<Member> LocatedDirect(IApiHost src)
                  => from m in DirectMethods(src)
                  let kid = m.KindId()
                  let address = MemoryAddress.Define(Jit(m))
                  let id = Diviner.Identify(m)
                  let uri = OpUri.Define(OpUriScheme.Located, src.UriPath, m.Name, id)
                  select Member.Define(uri, m, kid, address);
                        
            public IEnumerable<Member> HostedGeneric(IApiHost src)
                  => from m in GenericMethods(src)
                  let kid = m.KindId()
                  from t in ApiCollector.NumericClosures(m)
                  let reified = m.MakeGenericMethod(t)
                  let id = Diviner.Identify(reified)
                  let uri = OpUri.Define(OpUriScheme.Type, src.UriPath, m.Name, id)
                  select Member.Define(uri, reified, kid);

            public IEnumerable<Member> LocatedGeneric(IApiHost src)
                  => from m in GenericMethods(src)
                  let kid = m.KindId()
                  from t in ApiCollector.NumericClosures(m)
                  let reified = m.MakeGenericMethod(t)
                  let address = MemoryAddress.Define(Jit(reified))
                  let id = Diviner.Identify(reified)
                  let uri = OpUri.Define(OpUriScheme.Located, src.UriPath, m.Name, id)
                  select Member.Define(uri, reified, kid, address);

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