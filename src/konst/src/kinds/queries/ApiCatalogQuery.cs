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

    using static Konst;

    /// <summary>
    /// Defines api queries over a specific catalog
    /// </summary>
    public readonly struct ApiCatalogQuery
    {
        /// <summary>
        /// The catalog to interrogate
        /// </summary>
        public IPartCatalog Source {get;}

        [MethodImpl(Inline)]
        public static ApiCatalogQuery create(IPartCatalog src)
            => new ApiCatalogQuery(src);

        [MethodImpl(Inline)]
        public ApiCatalogQuery(IPartCatalog src)
            => Source = src;

        public MethodInfo[] Vectorized<T>(W128 w, bool generic)
            where T : unmanaged
                => (from host in Source.ApiHosts
                    from m in host.Methods.VectorizedDirect<T>(w)
                    where m.IsGenericMethod == generic
                    select m).Array();
        public MethodInfo[] Generic
            => (from host in Source.ApiHosts
                from m in host.Methods.OpenGeneric()
                select m).Array();

        public MethodInfo[] Direct
            => (from host in Source.ApiHosts
                from m in host.Methods.NonGeneric()
                select m).Array();

        public MethodInfo[] Vectorized<T>(W256 w, bool generic)
            where T : unmanaged
                => (from host in Source.ApiHosts
                    from m in host.Methods.VectorizedDirect<T>(w)
                    where m.IsGenericMethod == generic
                    select m).Array();

        public MethodInfo[] Vectorized<T>(W128 w, bool generic, string name)
            where T : unmanaged
                => Vectorized<T>(w, generic).WithName(name);

        public MethodInfo[] Vectorized<T>(W256 w, bool generic, string name)
            where T : unmanaged
                => Vectorized<T>(w, generic).WithName(name);

        public MethodInfo[] VectorizedGeneric(W128 w)
            => Generic.VectorizedGeneric(w);

        public MethodInfo[] VectorizedGeneric(W256 w)
            => Generic.VectorizedGeneric(w);

        public MethodInfo[] VectorizedGeneric(W512 w)
            => Generic.VectorizedGeneric(w);

        public MethodInfo[] VectorizedGeneric(W128 w, string name)
            => Generic.VectorizedGeneric(w,name);

        public MethodInfo[] VectorizedGeneric(W256 w, string name)
            => Generic.VectorizedGeneric(w,name);

        public MethodInfo[] VectorizedGeneric(W512 w, string name)
            => Generic.VectorizedGeneric(w,name);

        public MethodInfo[] VectorizedDirect(W128 w)
            => Direct.VectorizedDirect(w);

        public MethodInfo[] VectorizedDirect(W256 w)
            => Direct.VectorizedDirect(w);

        public MethodInfo[] VectorizedDirect(W512 w)
            => Direct.VectorizedDirect(w);

        public MethodInfo[] VectorizedDirect(W128 w, string name)
            => Direct.VectorizedDirect(w, name);

        public MethodInfo[] VectorizedDirect(W256 w, string name)
            => Direct.VectorizedDirect(w, name);

        public MethodInfo[] VectorizedDirect(W512 w, string name)
            => Direct.VectorizedDirect(w, name);
    }
}