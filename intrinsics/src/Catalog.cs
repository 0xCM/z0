//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    class Catalog : OpCatalog<Catalog>
    {
        public Catalog(AssemblyId id)
            : base(id)
        {

        }

        public Catalog()
            : base(AssemblyId.Intrinsics)
        {

        }

        public override IEnumerable<Type> ServiceHosts
            => typeof(VXTypes).GetNestedTypes().Realize<IFunc>();

        public override IEnumerable<Type> GenericApiHosts
            => items(typeof(ginx),typeof(vblocks),typeof(VPattern), typeof(BitPack), typeof(CpuVector));

        public override IEnumerable<Type> DirectApiHosts
            => items(typeof(dinx), typeof(BitPack), typeof(CpuVector));
    }

    public static class Intrinsics
    {
        public static IOperationCatalog Catalog
            => new Catalog();
        
        public static IEnumerable<MethodInfo> Vectorized<T>(N128 w)
            where T : unmanaged
                => from host in Catalog.GenericApiHosts.Union(Catalog.DirectApiHosts)
                    from m in host.Methods().Vectorized<T>(w)
                    select m;

        public static IEnumerable<MethodInfo> Vectorized<T>(N256 w)
            where T : unmanaged
                => from host in Catalog.GenericApiHosts.Union(Catalog.DirectApiHosts)
                    from m in host.Methods().Vectorized<T>(w)
                    select m;

        public static IEnumerable<MethodInfo> Vectorized<T>(N128 w, bool generic)
            where T : unmanaged
                => from host in (generic ? Catalog.GenericApiHosts : Catalog.DirectApiHosts)
                    from m in host.Methods().Vectorized<T>(w)                    
                    where m.IsGenericMethod == generic
                    select m;

        public static IEnumerable<MethodInfo> Vectorized<T>(N256 w, bool generic)
            where T : unmanaged
                => from host in (generic ? Catalog.GenericApiHosts : Catalog.DirectApiHosts)
                    from m in host.Methods().Vectorized<T>(w)
                    where m.IsGenericMethod == generic
                    select m;

        public static IEnumerable<MethodInfo> Vectorized<T>(N128 w, bool generic, string name)
            where T : unmanaged
                => Vectorized<T>(w, generic).WithName(name);

        public static IEnumerable<MethodInfo> Vectorized<T>(N256 w, bool generic, string name)
            where T : unmanaged
                => Vectorized<T>(w, generic).WithName(name);
    }
}