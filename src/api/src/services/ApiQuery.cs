//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static memory;
    using static Part;

    [ApiHost(ApiNames.ApiQuery, true)]
    public readonly partial struct ApiQuery
    {
        const NumericKind Closure = UnsignedInts;

        [Op]
        public static MethodInfo[] methods(in ApiRuntimeType src, HashSet<string> exclusions)
            => src.HostType.DeclaredMethods().Unignored().NonGeneric().Exclude(exclusions);

        [Op]
        public static Identifier hostname(Type src)
        {
            var attrib = src.Tag<ApiHostAttribute>();
            return text.ifempty(attrib.MapValueOrDefault(a => a.HostName, src.Name), src.Name).ToLower();
        }

        [Op]
        public static ApiHostInfo hostinfo(Type t)
        {
            var methods = t.DeclaredMethods();
            return new ApiHostInfo(t, t.HostUri(), t.Assembly.Id(), methods, index(methods));
        }

        [Op]
        public static ApiHostInfo hostinfo<T>()
            => hostinfo(typeof(T));

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="FunctionalServiceAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        [Op]
        public static Type[] svchosts(Assembly src)
            => src.GetTypes().Where(t => t.Tagged<FunctionalServiceAttribute>());

        [Op]
        public static Index<ApiHostUri> NestedHosts(Type src)
        {
            var dst = root.list<ApiHostUri>();
            var nested = @readonly(src.GetNestedTypes());
            var count = nested.Length;
            for(var i=0; i<count; i++)
            {
                var candidate = skip(nested,i);
                var uri = candidate.HostUri();
                if(uri.IsNonEmpty)
                    dst.Add(uri);
            }
            return dst.ToArray();
        }

        [MethodImpl(Inline), Op]
        public static ApiHostMethods hostops(IApiHost host, MethodInfo[] methods)
            => new ApiHostMethods(host, methods);

        [MethodImpl(Inline), Op]
        public static ApiHostMethods hostops(IApiHost src)
            => hostops(src, src.Methods);

        /// <summary>
        /// Queries the host for operations of specified kind
        /// </summary>
        /// <param name="k">The kind classifier</param>
        /// <typeparam name="K">The kind type</typeparam>
        [Op, Closures(Closure)]
        public static ApiHostMethods methods<K>(IApiHost src, K k)
            where K : unmanaged
                => hostops(src,(from m in hostops(src).Storage.Tagged(typeof(OpKindAttribute))
                let a = m.Tag<OpKindAttribute>().Require()
                where a.ClassId.ToString() == k.ToString()
                    select m).Array());

        /// <summary>
        /// Queries the host for generic operations of specified kind
        /// </summary>
        /// <param name="k">The kind classifier</param>
        /// <typeparam name="K">The kind type</typeparam>
        [Op, Closures(Closure)]
        public static ApiHostMethods methods<K>(IApiHost host, K k, GenericState g)
            where K : unmanaged
                => hostops(host,methods(host,k).Storage.MemberOf(g));

        /// <summary>
        /// Queries the host for binary operators belonging to a specified generic partition
        /// </summary>
        /// <param name="g">The generic partition</param>
        [Op]
        public static ApiHostMethods operators(IApiHost host, N1 arity, GenericState g = default)
            => hostops(host,hostops(host).Storage.MemberOf(g).UnaryOperators());

        /// <summary>
        /// Queries the host for binary operators belonging to a specified generic partition
        /// </summary>
        /// <param name="g">The generic partition</param>
        [Op]
        public static ApiHostMethods operators(IApiHost host, N2 arity, GenericState g = default)
            => hostops(host, hostops(host).Storage.MemberOf(g).BinaryOperators());

        /// <summary>
        /// Queries the host for binary operators belonging to a specified generic partition
        /// </summary>
        /// <param name="g">The generic partition</param>
        [Op]
        public ApiHostMethods operators(IApiHost host, N3 arity, GenericState g = default)
            => hostops(host,hostops(host).Storage.MemberOf(g).TernaryOperators());

        /// <summary>
        /// Queries the host for operations vectorized over 128-bit vectors
        /// </summary>
        /// <param name="w">The vector width</param>
        /// <param name="generic">Whether generic or non-generic methods should be selected</param>
        [Op]
        public static ApiHostMethods vectorized(IApiHost host, W128 w, GenericState g = default)
            => hostops(host, g.IsGeneric() ? hostops(host).Storage.VectorizedGeneric(w) : hostops(host).Storage.VectorizedDirect(w));

        /// <summary>
        /// Queries the host for operations vectorized over 128-bit vectors
        /// </summary>
        /// <param name="w">The vector width</param>
        /// <param name="generic">Whether generic or non-generic methods should be selected</param>
        [Op]
        public static ApiHostMethods vectorized(IApiHost host, W256 w, GenericState g = default)
            => hostops(host, g.IsGeneric() ? hostops(host).Storage.VectorizedGeneric(w) : hostops(host).Storage.VectorizedDirect(w));

        [Op, Closures(Closure)]
        public static ApiHostMethods vectorized<K>(IApiHost host, W128 w, K kind, GenericState g = default)
            where K : unmanaged
                => hostops(host, methods(host,kind,g).Storage.VectorizedDirect(w));

        [Op, Closures(Closure)]
        public static ApiHostMethods vectorized<K>(IApiHost host, W256 w, K kind, GenericState g = default)
            where K : unmanaged
                => hostops(host, methods(host,kind,g).Storage.VectorizedDirect(w));

        /// <summary>
        /// Queries the host for vectorized methods of specified vector width, name and generic partition
        /// </summary>
        /// <param name="w">The width to match</param>
        /// <param name="name">The name to match</param>
        /// <param name="g">The generic partition to consider</param>
        [Op]
        public static ApiHostMethods vectorized(IApiHost host, W128 w, string name, GenericState g = default)
            => hostops(host, hostops(host).Storage.Vectorized(w,name,g));

        /// <summary>
        /// Queries the host for vectorized methods of specified vector width, name and generic partition
        /// </summary>
        /// <param name="w">The width to match</param>
        /// <param name="name">The name to match</param>
        /// <param name="g">The generic partition to consider</param>
        [Op]
        public static ApiHostMethods vectorized(IApiHost host, W256 w, string name, GenericState g = default)
            => hostops(host, hostops(host).Storage.Vectorized(w,name,g));

        [Op]
        static Dictionary<string,MethodInfo> index(Index<MethodInfo> methods)
        {
            var index = new Dictionary<string, MethodInfo>();
            root.iter(methods, m => index.TryAdd(ApiIdentity.identify(m).IdentityText, m));
            return index;
        }

        static MethodInfo[] tagged(IApiHost src)
            => src.Methods.Storage.Tagged<OpAttribute>();
    }
}