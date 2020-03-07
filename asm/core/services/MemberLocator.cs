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

        public IEnumerable<LocatedMember> Members(Assembly src)
              => src.ApiHosts().SelectMany(Members);   

        public IEnumerable<LocatedMember> Members(Type src)
        {
            var host = ApiHost.Define(src);
            return GenericOps(host).Union(DirectOps(host)).OrderBy(x => x.Address);
        }

        public IEnumerable<LocatedMember> Members(ApiHost src)
              => GenericOps(src).Union(DirectOps(src)).OrderBy(x => x.Address);

        static IEnumerable<LocatedMember> GenericOps(ApiHost src)
              =>   from m in src.HostingType.DeclaredMethods().OpenGeneric(1)
                    where m.Tagged<OpAttribute>() && m.Tagged<NumericClosuresAttribute>()  && !m.AcceptsImmediate()
                    let c = m.Tag<NumericClosuresAttribute>().MapValueOrDefault(a => a.NumericPrimitive, NumericKind.None)
                    where c != NumericKind.None
                    from t in c.DistinctKinds().Select(x => x.ToClrType())
                    where t.IsSome()
                    let concrete = m.MakeGenericMethod(t.Value)
                    let address = MemoryAddress.Define(concrete.Jit())
                    select LocatedMember.Define(src.Path, concrete.Identify(), concrete, address);

        static IEnumerable<LocatedMember> DirectOps(ApiHost src)
              => from m in src.HostingType.DeclaredMethods().NonGeneric()
                 where m.Tagged<OpAttribute>() && !m.AcceptsImmediate()
                 let address = MemoryAddress.Define(m.Jit())
                 select LocatedMember.Define(src.Path, m.Identify(), m, address);
    }
}