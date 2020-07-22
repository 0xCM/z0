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

    public readonly struct ApiQuery
    {
        [MethodImpl(Inline)]
        public static ApiQuery create(IPartCatalog src)
            => new ApiQuery(src);

        public IPartCatalog Context {get;}

        [MethodImpl(Inline)]
        internal ApiQuery(IPartCatalog src)
            => Context = src;

        public MethodInfo[] Vectorized<T>(W128 w, bool generic)
            where T : unmanaged
                => (from host in Context.ApiHosts
                    from m in host.HostedMethods.VectorizedDirect<T>(w)                    
                    where m.IsGenericMethod == generic
                    select m).Array();
        public MethodInfo[] Generic
            => (from host in Context.ApiHosts
                from m in host.HostedMethods.OpenGeneric()
                select m).Array();

        public MethodInfo[] Direct
            => (from host in Context.ApiHosts
                from m in host.HostedMethods.NonGeneric()
                select m).Array();

        public MethodInfo[] Vectorized<T>(W256 w, bool generic)
            where T : unmanaged
                => (from host in Context.ApiHosts
                    from m in host.HostedMethods.VectorizedDirect<T>(w)
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