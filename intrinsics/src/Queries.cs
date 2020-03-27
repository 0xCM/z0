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


    public static class Intrinsics
    {
        public static IApiCatalog Catalog => Z0.Parts.Intrinsics.Resolution.ApiCatalog();
                
        public static IEnumerable<MethodInfo> Generic
            => from host in Catalog.GenericApiHosts
                from m in host.DeclaredMethods.OpenGeneric()
                select m;

        public static IEnumerable<MethodInfo> Direct
            => from host in Catalog.DirectApiHosts
                from m in host.DeclaredMethods.NonGeneric()
                select m;

        public static IEnumerable<MethodInfo> VectorizedGeneric(W128 w)
            => Intrinsics.Generic.VectorizedGeneric(w);
                
        public static IEnumerable<MethodInfo> VectorizedGeneric(W256 w)
            => Intrinsics.Generic.VectorizedGeneric(w);

        public static IEnumerable<MethodInfo> VectorizedGeneric(W512 w)
            => Intrinsics.Generic.VectorizedGeneric(w);

        public static IEnumerable<MethodInfo> VectorizedGeneric(W128 w, string name)
            => Intrinsics.Generic.VectorizedGeneric(w,name);

        public static IEnumerable<MethodInfo> VectorizedGeneric(W256 w, string name)
            => Intrinsics.Generic.VectorizedGeneric(w,name);

        public static IEnumerable<MethodInfo> VectorizedGeneric(W512 w, string name)
            => Intrinsics.Generic.VectorizedGeneric(w,name);

        public static IEnumerable<MethodInfo> VectorizedDirect(W128 w)
            => Intrinsics.Direct.VectorizedDirect(w);

        public static IEnumerable<MethodInfo> VectorizedDirect(W256 w)
            => Intrinsics.Direct.VectorizedDirect(w);

        public static IEnumerable<MethodInfo> VectorizedDirect(W512 w)
            => Intrinsics.Direct.VectorizedDirect(w);

        public static IEnumerable<MethodInfo> VectorizedDirect(W128 w, string name)
            => Intrinsics.Direct.VectorizedDirect(w, name);

        public static IEnumerable<MethodInfo> VectorizedDirect(W256 w, string name)
            => Intrinsics.Direct.VectorizedDirect(w, name);

        public static IEnumerable<MethodInfo> VectorizedDirect(W512 w, string name)
            => Intrinsics.Direct.VectorizedDirect(w, name);

        public static IEnumerable<MethodInfo> Vectorized<T>(W128 w, bool generic)
            where T : unmanaged
                => from host in (generic ? Catalog.GenericApiHosts : Catalog.DirectApiHosts)
                    from m in host.DeclaredMethods.VectorizedDirect<T>(w)                    
                    where m.IsGenericMethod == generic
                    select m;

        public static IEnumerable<MethodInfo> Vectorized<T>(W256 w, bool generic)
            where T : unmanaged
                => from host in (generic ? Catalog.GenericApiHosts : Catalog.DirectApiHosts)
                    from m in host.DeclaredMethods.VectorizedDirect<T>(w)
                    where m.IsGenericMethod == generic
                    select m;

        public static IEnumerable<MethodInfo> Vectorized<T>(W128 w, bool generic, string name)
            where T : unmanaged
                => Vectorized<T>(w, generic).WithName(name);

        public static IEnumerable<MethodInfo> Vectorized<T>(W256 w, bool generic, string name)
            where T : unmanaged
                => Vectorized<T>(w, generic).WithName(name);
    }
}