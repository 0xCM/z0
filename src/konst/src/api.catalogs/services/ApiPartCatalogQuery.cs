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
    /// Defines a view over a <see cref='IApiPartCatalog'/>
    /// </summary>
    [ApiHost(ApiNames.ApiPartCatalogQuery, true)]
    public readonly struct ApiPartCatalogQuery
    {
        /// <summary>
        /// The catalog to interrogate
        /// </summary>
        public IApiPartCatalog Source {get;}

        [MethodImpl(Inline)]
        public ApiPartCatalogQuery(IApiPartCatalog src)
            => Source = src;

        [Op, MethodImpl(NotInline), Closures(UnsignedInts)]
        public MethodInfo[] Vectorized<T>(W128 w, bool generic)
            where T : unmanaged
                => (from host in Source.ApiHosts.Storage
                    from m in host.DeclaredMethods.VectorizedDirect<T>(w)
                    where m.IsGenericMethod == generic
                    select m).Array();

        public MethodInfo[] Generic
        {
            get => (from host in Source.ApiHosts.Storage
                from m in host.DeclaredMethods.OpenGeneric()
                select m).Array();
        }

        public MethodInfo[] Direct
        {
            [Op, MethodImpl(NotInline)]
            get => (from host in Source.ApiHosts.Storage
                from m in host.DeclaredMethods.NonGeneric()
                select m).Array();
        }

        [MethodImpl(NotInline), Op, Closures(UnsignedInts)]
        public MethodInfo[] Vectorized<T>(W256 w, bool generic)
            where T : unmanaged
                => (from host in Source.ApiHosts.Storage
                    from m in host.DeclaredMethods.VectorizedDirect<T>(w)
                    where m.IsGenericMethod == generic
                    select m).Array();

        [MethodImpl(NotInline), Op, Closures(UnsignedInts)]
        public MethodInfo[] Vectorized<T>(W128 w, bool generic, string name)
            where T : unmanaged
                => Vectorized<T>(w, generic).WithName(name);

        [MethodImpl(NotInline), Op, Closures(UnsignedInts)]
        public MethodInfo[] Vectorized<T>(W256 w, bool generic, string name)
            where T : unmanaged
                => Vectorized<T>(w, generic).WithName(name);

        [MethodImpl(Inline), Op]
        public MethodInfo[] VectorizedGeneric(W128 w)
            => Generic.VectorizedGeneric(w);

        [MethodImpl(Inline), Op]
        public MethodInfo[] VectorizedGeneric(W256 w)
            => Generic.VectorizedGeneric(w);

        [MethodImpl(Inline), Op]
        public MethodInfo[] VectorizedGeneric(W512 w)
            => Generic.VectorizedGeneric(w);

        [MethodImpl(Inline), Op]
        public MethodInfo[] VectorizedGeneric(W128 w, string name)
            => Generic.VectorizedGeneric(w,name);

        [MethodImpl(Inline), Op]
        public MethodInfo[] VectorizedGeneric(W256 w, string name)
            => Generic.VectorizedGeneric(w,name);

        [MethodImpl(Inline), Op]
        public MethodInfo[] VectorizedGeneric(W512 w, string name)
            => Generic.VectorizedGeneric(w,name);

        [MethodImpl(Inline), Op]
        public MethodInfo[] VectorizedDirect(W128 w)
            => Direct.VectorizedDirect(w);

        [MethodImpl(Inline), Op]
        public MethodInfo[] VectorizedDirect(W256 w)
            => Direct.VectorizedDirect(w);

        [MethodImpl(Inline), Op]
        public MethodInfo[] VectorizedDirect(W512 w)
            => Direct.VectorizedDirect(w);

        [MethodImpl(Inline), Op]
        public MethodInfo[] VectorizedDirect(W128 w, string name)
            => Direct.VectorizedDirect(w, name);

        [MethodImpl(Inline), Op]
        public MethodInfo[] VectorizedDirect(W256 w, string name)
            => Direct.VectorizedDirect(w, name);

        [MethodImpl(Inline), Op]
        public MethodInfo[] VectorizedDirect(W512 w, string name)
            => Direct.VectorizedDirect(w, name);
    }
}