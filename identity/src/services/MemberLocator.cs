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

            public IEnumerable<ApiMember> Hosted(Assembly src)
                  => src.ApiHosts().SelectMany(Hosted);

            [MethodImpl(Inline)]
            static IntPtr Jit(MethodInfo src)
            {
                  RuntimeHelpers.PrepareMethod(src.MethodHandle);
                  return src.MethodHandle.GetFunctionPointer();
            }

            public IEnumerable<ApiMember> Hosted(ApiHost src)
                  => HostedGeneric(src).Union(HostedDirect(src)).OrderBy(x => x.Method.MetadataToken);

            public IEnumerable<ApiMember> Located(Assembly src)
                  => src.ApiHosts().SelectMany(Located);

            public IEnumerable<ApiMember> Located(ApiHost src)
                  => LocatedGeneric(src).Union(LocatedDirect(src)).OrderBy(x => x.Address);

            IEnumerable<ApiMember> HostedDirect(ApiHost src)
                  => from m in src.HostingType.DeclaredMethods().NonGeneric()
                  where m.Tagged<OpAttribute>() && !m.AcceptsImmediate()
                  let id = Diviner.Identify(m)
                  let uri = OpUri.Define(OpUriScheme.Type, src.Path, m.Name, id)
                  select ApiMember.Define(uri, m, m.KindId() ?? OpKindId.None);

            IEnumerable<ApiMember> LocatedDirect(ApiHost src)
                  => from m in src.HostingType.DeclaredMethods().NonGeneric()
                  where m.Tagged<OpAttribute>() && !m.AcceptsImmediate()
                  let address = MemoryAddress.Define(Jit(m))
                  let id = Diviner.Identify(m)
                  let uri = OpUri.Define(OpUriScheme.Located, src.Path, m.Name, id)
                  select ApiMember.Define(uri, m, m.KindId() ?? OpKindId.None, address);

            IEnumerable<ApiMember> HostedGeneric(ApiHost src)
                  => from m in src.HostingType.DeclaredMethods().OpenGeneric(1)
                  where m.Tagged<OpAttribute>() && m.Tagged<ClosuresAttribute>() && !m.AcceptsImmediate()
                  from t in NumericClosures(m).Select(x => x.SystemType().ToOption())
                  where t.IsSome()
                  let reified = m.MakeGenericMethod(t.Value)
                  let id = Diviner.Identify(reified)
                  let uri = OpUri.Define(OpUriScheme.Type, src.Path, m.Name, id)
                  select ApiMember.Define(uri, reified, m.KindId() ?? OpKindId.None);

            IEnumerable<ApiMember> LocatedGeneric(ApiHost src)
                  => from m in src.HostingType.DeclaredMethods().OpenGeneric(1)
                  where m.Tagged<OpAttribute>() && m.Tagged<ClosuresAttribute>() && !m.AcceptsImmediate()
                  from t in NumericClosures(m).Select(x => x.SystemType().ToOption())
                  where t.IsSome()
                  let reified = m.MakeGenericMethod(t.Value)
                  let address = MemoryAddress.Define(Jit(reified))
                  let id = Diviner.Identify(reified)
                  let uri = OpUri.Define(OpUriScheme.Located, src.Path, m.Name, id)
                  select ApiMember.Define(uri, reified, m.KindId() ?? OpKindId.None, address);

      }
}