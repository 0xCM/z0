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

    public readonly struct ApiQuery : IService<IApiCatalog>
    {
        public IApiCatalog Context {get;}

        [MethodImpl(Inline)]
        public static ApiQuery Over(IApiCatalog src)
            => new ApiQuery(src);

        [MethodImpl(Inline)]
        ApiQuery(IApiCatalog src)
        {
            this.Context = src;
        }

        public IEnumerable<MethodInfo> Generic
            => from host in Context.GenericApiHosts
                from m in host.DeclaredMethods.OpenGeneric()
                select m;

        public IEnumerable<MethodInfo> Direct
            => from host in Context.DirectApiHosts
                from m in host.DeclaredMethods.NonGeneric()
                select m;

        public IEnumerable<MethodInfo> Vectorized<T>(W256 w, bool generic)
            where T : unmanaged
                => from host in (generic ? Context.GenericApiHosts : Context.DirectApiHosts)
                    from m in host.DeclaredMethods.VectorizedDirect<T>(w)
                    where m.IsGenericMethod == generic
                    select m;

        public IEnumerable<MethodInfo> Vectorized<T>(W128 w, bool generic, string name)
            where T : unmanaged
                => Vectorized<T>(w, generic).WithName(name);

        public IEnumerable<MethodInfo> Vectorized<T>(W256 w, bool generic, string name)
            where T : unmanaged
                => Vectorized<T>(w, generic).WithName(name);

        public IEnumerable<MethodInfo> VectorizedGeneric(W128 w)
            => Generic.VectorizedGeneric(w);
                
        public IEnumerable<MethodInfo> VectorizedGeneric(W256 w)
            => Generic.VectorizedGeneric(w);

        public IEnumerable<MethodInfo> VectorizedGeneric(W512 w)
            => Generic.VectorizedGeneric(w);

        public IEnumerable<MethodInfo> VectorizedGeneric(W128 w, string name)
            => Generic.VectorizedGeneric(w,name);

        public IEnumerable<MethodInfo> VectorizedGeneric(W256 w, string name)
            => Generic.VectorizedGeneric(w,name);

        public IEnumerable<MethodInfo> VectorizedGeneric(W512 w, string name)
            => Generic.VectorizedGeneric(w,name);

        public IEnumerable<MethodInfo> VectorizedDirect(W128 w)
            => Direct.VectorizedDirect(w);

        public IEnumerable<MethodInfo> VectorizedDirect(W256 w)
            => Direct.VectorizedDirect(w);

        public IEnumerable<MethodInfo> VectorizedDirect(W512 w)
            => Direct.VectorizedDirect(w);

        public IEnumerable<MethodInfo> VectorizedDirect(W128 w, string name)
            => Direct.VectorizedDirect(w, name);

        public IEnumerable<MethodInfo> VectorizedDirect(W256 w, string name)
            => Direct.VectorizedDirect(w, name);

        public IEnumerable<MethodInfo> VectorizedDirect(W512 w, string name)
            => Direct.VectorizedDirect(w, name);

        public IEnumerable<MethodInfo> Vectorized<T>(W128 w, bool generic)
            where T : unmanaged
                => from host in (generic ? Context.GenericApiHosts : Context.DirectApiHosts)
                    from m in host.DeclaredMethods.VectorizedDirect<T>(w)                    
                    where m.IsGenericMethod == generic
                    select m;
    }
}