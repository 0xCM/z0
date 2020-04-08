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

            public static NumericKind[] NumericClosures(MethodInfo m)
                  => (from tag in m.Tag<ClosuresAttribute>()
                  where tag.Kind == TypeClosureKind.Numeric
                  let spec = (NumericKind)tag.Spec
                  select spec.DistinctKinds().ToArray()).ValueOrElse(() => Arrays.empty<NumericKind>());              

            [MethodImpl(Inline)]
            public static MemberLocator New(IContext context, IMultiDiviner diviner)
                  => new MemberLocator(context,diviner);

            [MethodImpl(Inline)]
            MemberLocator(IContext context, IMultiDiviner diviner)
            {
                  this.Context = context;
                  this.Diviner = diviner;
            }

            public IEnumerable<ApiStatelessMember> Hosted(Assembly src)
                  => src.ApiHosts().SelectMany(Hosted);

            [MethodImpl(Inline)]
            static IntPtr Jit(MethodInfo src)
            {
                  RuntimeHelpers.PrepareMethod(src.MethodHandle);
                  return src.MethodHandle.GetFunctionPointer();
            }

            public IEnumerable<ApiStatelessMember> Hosted(ApiHost src)
                  => HostedGeneric(src).Union(HostedDirect(src)).OrderBy(x => x.Method.MetadataToken);

            public IEnumerable<ApiLocatedMember> Located(Assembly src)
                  => src.ApiHosts().SelectMany(Located);

            public IEnumerable<ApiLocatedMember> Located(ApiHost src)
                  => LocatedGeneric(src).Union(LocatedDirect(src)).OrderBy(x => x.Address);

            IEnumerable<ApiStatelessMember> HostedDirect(ApiHost src)
                  => from m in src.HostingType.DeclaredMethods().NonGeneric()
                  where m.Tagged<OpAttribute>() && !m.AcceptsImmediate()
                  select ApiStatelessMember.Define(src.Path, Diviner.Identify(m), m);

            IEnumerable<ApiStatelessMember> HostedGeneric(ApiHost src)
                  => from m in src.HostingType.DeclaredMethods().OpenGeneric(1)
                  where m.Tagged<OpAttribute>() && m.Tagged<ClosuresAttribute>() && !m.AcceptsImmediate()
                  from t in NumericClosures(m).Select(x => x.SystemType().ToOption())
                  where t.IsSome()
                  let concrete = m.MakeGenericMethod(t.Value)
                  select ApiStatelessMember.Define(src.Path, Diviner.Identify(concrete), concrete);

            IEnumerable<ApiLocatedMember> LocatedGeneric(ApiHost src)
                  => from m in src.HostingType.DeclaredMethods().OpenGeneric(1)
                  where m.Tagged<OpAttribute>() && m.Tagged<ClosuresAttribute>() && !m.AcceptsImmediate()
                  from t in NumericClosures(m).Select(x => x.SystemType().ToOption())
                  where t.IsSome()
                  let concrete = m.MakeGenericMethod(t.Value)
                  let address = MemoryAddress.Define(Jit(concrete))
                  select ApiLocatedMember.Define(src.Path, Diviner.Identify(concrete), concrete, address);

            IEnumerable<ApiLocatedMember> LocatedDirect(ApiHost src)
                  => from m in src.HostingType.DeclaredMethods().NonGeneric()
                  where m.Tagged<OpAttribute>() && !m.AcceptsImmediate()
                  let address = MemoryAddress.Define(Jit(m))
                  select ApiLocatedMember.Define(src.Path, Diviner.Identify(m), m, address);
      }
}