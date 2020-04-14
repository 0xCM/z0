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

            readonly IMultiDiviner Diviner;

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

            IEnumerable<ApiMember> HostedDirect(IApiHost src)
                  => from m in DirectMethods(src)
                  let kid = m.KindId()
                  let id = Diviner.Identify(m)
                  let uri = OpUri.Define(OpUriScheme.Type, src.UriPath, m.Name, id)
                  select ApiMember.Define(uri, m, kid);

            IEnumerable<ApiMember> LocatedDirect(IApiHost src)
                  => from m in DirectMethods(src)
                  let kid = m.KindId()
                  let address = MemoryAddress.Define(Jit(m))
                  let id = Diviner.Identify(m)
                  let uri = OpUri.Define(OpUriScheme.Located, src.UriPath, m.Name, id)
                  select ApiMember.Define(uri, m, kid, address);
                        
            IEnumerable<ApiMember> HostedGeneric(IApiHost src)
                  => from m in GenericMethods(src)
                  let kid = m.KindId()
                  from t in ApiCollector.NumericClosures(m)
                  let reified = m.MakeGenericMethod(t)
                  let id = Diviner.Identify(reified)
                  let uri = OpUri.Define(OpUriScheme.Type, src.UriPath, m.Name, id)
                  select ApiMember.Define(uri, reified, kid);

            IEnumerable<ApiMember> LocatedGeneric(IApiHost src)
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
      }
}