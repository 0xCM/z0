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

    using static Api;

    readonly struct MemberLocator : IMemberLocator
    {
        public IContext Context { get; }

        [MethodImpl(Inline)]
        public static MemberLocator New(IContext context)
              => new MemberLocator(context);

        [MethodImpl(Inline)]
        MemberLocator(IContext context)
        {
            this.Context = context;
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

        static IEnumerable<ApiStatelessMember> HostedDirect(ApiHost src)
              => from m in src.HostingType.DeclaredMethods().NonGeneric()
                 where m.Tagged<OpAttribute>() && !m.AcceptsImmediate()
                 select ApiStatelessMember.Define(src.Path, m.Identify(), m);

        static IEnumerable<ApiStatelessMember> HostedGeneric(ApiHost src)
              => from m in src.HostingType.DeclaredMethods().OpenGeneric(1)
                 where m.Tagged<OpAttribute>() && m.Tagged<NumericClosuresAttribute>() && !m.AcceptsImmediate()
                 let c = m.Tag<NumericClosuresAttribute>().MapValueOrDefault(a => a.NumericPrimitive, NumericKind.None)
                 where c != NumericKind.None
                 from t in c.DistinctKinds().Select(x => x.SystemType().ToOption())
                 where t.IsSome()
                 let concrete = m.MakeGenericMethod(t.Value)
                 select ApiStatelessMember.Define(src.Path, concrete.Identify(), concrete);

        static IEnumerable<ApiLocatedMember> LocatedGeneric(ApiHost src)
              => from m in src.HostingType.DeclaredMethods().OpenGeneric(1)
                 where m.Tagged<OpAttribute>() && m.Tagged<NumericClosuresAttribute>() && !m.AcceptsImmediate()
                 let c = m.Tag<NumericClosuresAttribute>().MapValueOrDefault(a => a.NumericPrimitive, NumericKind.None)
                 where c != NumericKind.None
                 from t in c.DistinctKinds().Select(x => x.SystemType().ToOption())
                 where t.IsSome()
                 let concrete = m.MakeGenericMethod(t.Value)
                 let address = MemoryAddress.Define(Jit(concrete))
                 select ApiLocatedMember.Define(src.Path, concrete.Identify(), concrete, address);

        static IEnumerable<ApiLocatedMember> LocatedDirect(ApiHost src)
              => from m in src.HostingType.DeclaredMethods().NonGeneric()
                 where m.Tagged<OpAttribute>() && !m.AcceptsImmediate()
                 let address = MemoryAddress.Define(Jit(m))
                 select ApiLocatedMember.Define(src.Path, m.Identify(), m, address);
    }
}