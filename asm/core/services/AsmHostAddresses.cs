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

    readonly struct AsmHostAddresses : IAsmHostAddresses
    {        
        public IAsmContext Context {get;}

        [MethodImpl(Inline)]
        public static AsmHostAddresses Create(IAsmContext context)
            => new AsmHostAddresses(context);

        [MethodImpl(Inline)]
        AsmHostAddresses(IAsmContext context)
        {
            this.Context = context;
        }

        public IEnumerable<OpAddress> Addresses(Type src)
              => GenericOps(src).Union(DirectOps(src)).OrderBy(x => x.Address);

        static IEnumerable<OpAddress> GenericOps(Type src)
              =>  from m in src.DeclaredMethods().OpenGeneric(1)
                where m.Tagged<OpAttribute>() && m.Tagged<NumericClosuresAttribute>()  && !m.AcceptsImmediate()
                let c = m.Tag<NumericClosuresAttribute>().MapValueOrDefault(a => a.NumericPrimitive, NumericKind.None)
                    where c != NumericKind.None
                    from t in c.DistinctKinds().Select(x => x.ToClrType())
                        where t.IsSome()
                        let concrete = m.MakeGenericMethod(t.Value)
                        let address = MemoryAddress.Define(concrete.Jit())
                        select OpAddress.Define(concrete.Identify(), concrete, address);

        static IEnumerable<OpAddress> DirectOps(Type src)
              => from m in src.DeclaredMethods().NonGeneric()
                 where m.Tagged<OpAttribute>() && !m.AcceptsImmediate()
                 let address = MemoryAddress.Define(m.Jit())
                  select OpAddress.Define(m.Identify(), m, address);
    }
}