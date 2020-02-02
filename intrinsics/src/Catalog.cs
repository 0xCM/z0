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
                
        public static IEnumerable<MethodInfo> OpenGenericMethods
            => from host in Catalog.GenericApiHosts
                from m in host.Methods().OpenGeneric()
                select m;

        public static IEnumerable<MethodInfo> DirectMethods
            => from host in Catalog.DirectApiHosts
                from m in host.Methods().NonGeneric()
                select m;

        public static IEnumerable<MethodInfo> VectorizedGeneric(N128 w)
            => Intrinsics.OpenGenericMethods.VectorizedGeneric(w);
                
        public static IEnumerable<MethodInfo> VectorizedGeneric(N256 w)
            => Intrinsics.OpenGenericMethods.VectorizedGeneric(w);

        public static IEnumerable<MethodInfo> VectorizedGeneric(N512 w)
            => Intrinsics.OpenGenericMethods.VectorizedGeneric(w);

        public static IEnumerable<MethodInfo> VectorizedGeneric(N128 w, string name)
            => Intrinsics.OpenGenericMethods.VectorizedGeneric(w,name);

        public static IEnumerable<MethodInfo> VectorizedGeneric(N256 w, string name)
            => Intrinsics.OpenGenericMethods.VectorizedGeneric(w,name);

        public static IEnumerable<MethodInfo> VectorizedGeneric(N512 w, string name)
            => Intrinsics.OpenGenericMethods.VectorizedGeneric(w,name);

        public static IEnumerable<MethodInfo> VectorizedDirect(N128 w)
            => Intrinsics.DirectMethods.VectorizedDirect(w);

        public static IEnumerable<MethodInfo> VectorizedDirect(N256 w)
            => Intrinsics.DirectMethods.VectorizedDirect(w);

        public static IEnumerable<MethodInfo> VectorizedDirect(N512 w)
            => Intrinsics.DirectMethods.VectorizedDirect(w);

        public static IEnumerable<MethodInfo> VectorizedDirect(N128 w, string name)
            => Intrinsics.DirectMethods.VectorizedDirect(w, name);

        public static IEnumerable<MethodInfo> VectorizedDirect(N256 w, string name)
            => Intrinsics.DirectMethods.VectorizedDirect(w, name);

        public static IEnumerable<MethodInfo> VectorizedDirect(N512 w, string name)
            => Intrinsics.DirectMethods.VectorizedDirect(w, name);

        public static IEnumerable<MethodInfo> Vectorized<T>(N128 w, bool generic)
            where T : unmanaged
                => from host in (generic ? Catalog.GenericApiHosts : Catalog.DirectApiHosts)
                    from m in host.Methods().VectorizedDirect<T>(w)                    
                    where m.IsGenericMethod == generic
                    select m;

        public static IEnumerable<MethodInfo> Vectorized<T>(N256 w, bool generic)
            where T : unmanaged
                => from host in (generic ? Catalog.GenericApiHosts : Catalog.DirectApiHosts)
                    from m in host.Methods().VectorizedDirect<T>(w)
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