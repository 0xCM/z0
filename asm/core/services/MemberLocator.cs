//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static Root;

    readonly struct MemberLocator : IMemberLocator
    {         
      public IAsmContext Context {get;}

      [MethodImpl(Inline)]
      public static MemberLocator New(IAsmContext context)
            => new MemberLocator(context);

      [MethodImpl(Inline)]
      MemberLocator(IAsmContext context)
      {
            this.Context = context;
      }

      public IEnumerable<ApiStatelessMember> Hosted(Assembly src)
            => src.ApiHosts().SelectMany(Hosted);   


      public IEnumerable<ApiStatelessMember> Hosted(Type src)
      {
          var host = Api.Host(src);
          return HostedGeneric(host).Union(HostedDirect(host)).OrderBy(x => x.Method.MetadataToken);
      }

      public IEnumerable<ApiStatelessMember> Hosted(ApiHost src)
            => HostedGeneric(src).Union(HostedDirect(src)).OrderBy(x => x.Method.MetadataToken);

      public IEnumerable<ApiLocatedMember> Located(Assembly src)
            => src.ApiHosts().SelectMany(Located);   

      public IEnumerable<ApiLocatedMember> Located(Type src)
      {
            var host = Api.Host(src);
            return LocatedGeneric(host).Union(LocatedDirect(host)).OrderBy(x => x.Address);
      }

      public IEnumerable<ApiLocatedMember> Located(ApiHost src)
            => LocatedGeneric(src).Union(LocatedDirect(src)).OrderBy(x => x.Address);

      static IEnumerable<ApiStatelessMember> HostedDirect(ApiHost src)
            => from m in src.HostingType.DeclaredMethods().NonGeneric()
            where m.Tagged<OpAttribute>() && !m.AcceptsImmediate()
            select ApiStatelessMember.Define(src.Path, m.Identify(), m);

      static IEnumerable<ApiStatelessMember> HostedGeneric(ApiHost src)
            =>   from m in src.HostingType.DeclaredMethods().OpenGeneric(1)
                  where m.Tagged<OpAttribute>() && m.Tagged<NumericClosuresAttribute>()  && !m.AcceptsImmediate()
                  let c = m.Tag<NumericClosuresAttribute>().MapValueOrDefault(a => a.NumericPrimitive, NumericKind.None)
                  where c != NumericKind.None
                  from t in c.DistinctKinds().Select(x => x.SystemType().ToOption())
                  where t.IsSome()
                  let concrete = m.MakeGenericMethod(t.Value)
                  select ApiStatelessMember.Define(src.Path, concrete.Identify(), concrete);

      static IEnumerable<ApiLocatedMember> LocatedGeneric(ApiHost src)
            =>   from m in src.HostingType.DeclaredMethods().OpenGeneric(1)
                  where m.Tagged<OpAttribute>() && m.Tagged<NumericClosuresAttribute>()  && !m.AcceptsImmediate()
                  let c = m.Tag<NumericClosuresAttribute>().MapValueOrDefault(a => a.NumericPrimitive, NumericKind.None)
                  where c != NumericKind.None
                  from t in c.DistinctKinds().Select(x => x.SystemType().ToOption())
                  where t.IsSome()
                  let concrete = m.MakeGenericMethod(t.Value)
                  let address = MemoryAddress.Define(concrete.Jit())
                  select ApiLocatedMember.Define(src.Path, concrete.Identify(), concrete, address);

      static IEnumerable<ApiLocatedMember> LocatedDirect(ApiHost src)
            => from m in src.HostingType.DeclaredMethods().NonGeneric()
            where m.Tagged<OpAttribute>() && !m.AcceptsImmediate()
            let address = MemoryAddress.Define(m.Jit())
            select ApiLocatedMember.Define(src.Path, m.Identify(), m, address);
      }
}