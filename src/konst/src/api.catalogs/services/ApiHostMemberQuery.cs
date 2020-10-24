//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    using static Konst;

    /// <summary>
    /// Defines api queries over a specific host
    /// </summary>
    [ApiHost(ApiNames.ApiHostMemberQuery, true)]
    public readonly struct ApiHostMemberQuery : IApiView<ApiHostMemberQuery,IApiHost>
    {
        /// <summary>
        /// The host to interrogate
        /// </summary>
        public IApiHost Source {get;}

        [MethodImpl(Inline)]
        public ApiHostMemberQuery(IApiHost host)
            => Source = host;

        /// <summary>
        /// All hosted methods
        /// </summary>
        public MethodInfo[] Hosted
            => Source.DeclaredMethods;

        /// <summary>
        /// All hosted generic methods
        /// </summary>
        public MethodInfo[] Generic
            => Hosted.OpenGeneric();

        /// <summary>
        /// All hosted non-generic methods
        /// </summary>
        public MethodInfo[] Direct
            => Hosted.NonGeneric();

        /// <summary>
        /// Queries the host for operations of specified kind
        /// </summary>
        /// <param name="k">The kind classifier</param>
        /// <typeparam name="K">The kind type</typeparam>
        [Op, MethodImpl(NotInline), Closures(UnsignedInts)]
        public MethodInfo[] OfKind<K>(K k)
            where K : unmanaged
                => (from m in Hosted.Tagged(typeof(OpKindAttribute))
                let a = m.Tag<OpKindAttribute>().Require()
                where a.Id.ToString() == k.ToString()
                    select m).Array();

        /// <summary>
        /// Queries the host for generic operations of specified kind
        /// </summary>
        /// <param name="k">The kind classifier</param>
        /// <typeparam name="K">The kind type</typeparam>
        [Op, MethodImpl(NotInline), Closures(UnsignedInts)]
        public MethodInfo[] OfKind<K>(K k, GenericState g)
            where K : unmanaged
                => OfKind(k).MemberOf(g).Array();

        /// <summary>
        /// Queries the host for binary operators belonging to a specified generic partition
        /// </summary>
        /// <param name="g">The generic partition</param>
        [Op, MethodImpl(NotInline)]
        public MethodInfo[] UnaryOps(GenericState g = default)
            => Hosted.MemberOf(g).UnaryOperators();

        /// <summary>
        /// Queries the host for binary operators belonging to a specified generic partition
        /// </summary>
        /// <param name="g">The generic partition</param>
        [Op, MethodImpl(NotInline)]
        public MethodInfo[] BinaryOps(GenericState g = default)
            => Hosted.MemberOf(g).BinaryOperators();

        /// <summary>
        /// Queries the host for binary operators belonging to a specified generic partition
        /// </summary>
        /// <param name="g">The generic partition</param>
        [Op, MethodImpl(NotInline)]
        public MethodInfo[] TernaryOps(GenericState g = default)
            => Hosted.MemberOf(g).TernaryOperators();

        /// <summary>
        /// Queries the host for operations vectorized over 128-bit vectors
        /// </summary>
        /// <param name="w">The vector width</param>
        /// <param name="generic">Whether generic or non-generic methods should be selected</param>
        [Op, MethodImpl(NotInline)]
        public MethodInfo[] Vectorized(W128 w, GenericState g = default)
            => g.IsGeneric() ? Hosted.VectorizedGeneric(w) : Hosted.VectorizedDirect(w);

        /// <summary>
        /// Queries the host for operations vectorized over 128-bit vectors
        /// </summary>
        /// <param name="w">The vector width</param>
        /// <param name="generic">Whether generic or non-generic methods should be selected</param>
        [Op, MethodImpl(NotInline)]
        public MethodInfo[] Vectorized(W256 w, GenericState g = default)
            => g.IsGeneric() ? Hosted.VectorizedGeneric(w) : Hosted.VectorizedDirect(w);

        /// <summary>
        /// Queries the host for vectorized methods of specified vector width, name and generic partition
        /// </summary>
        /// <param name="w">The width to match</param>
        /// <param name="name">The name to match</param>
        /// <param name="g">The generic partition to consider</param>
        [Op, MethodImpl(NotInline)]
        public MethodInfo[] Vectorized(W128 w, string name, GenericState g = default)
            => Hosted.Vectorized(w,name,g);

        /// <summary>
        /// Queries the host for vectorized methods of specified vector width, name and generic partition
        /// </summary>
        /// <param name="w">The width to match</param>
        /// <param name="name">The name to match</param>
        /// <param name="g">The generic partition to consider</param>
        [Op, MethodImpl(NotInline)]
        public MethodInfo[] Vectorized(W256 w, string name, GenericState g = default)
            => Hosted.Vectorized(w,name,g);

        /// <summary>
        /// Queries the host for vectorized methods of specified vector width, name and generic partition
        /// </summary>
        /// <param name="w">The width to match</param>
        /// <param name="name">The name to match</param>
        /// <param name="g">The generic partition to consider</param>
        [Op, MethodImpl(NotInline)]
        public MethodInfo[] Vectorized(W512 w, string name, GenericState g = default)
            => Hosted.Vectorized(w,name,g);

        public MethodInfo[] OfKind<K>(W128 w, K kind, GenericState g = default)
            where K : unmanaged, Enum
                => OfKind(kind,g).VectorizedDirect(w);

        public MethodInfo[] OfKind<K>(W256 w, K kind, GenericState g = default)
            where K : unmanaged, Enum
                => OfKind(kind,g).VectorizedDirect(w);

        /// <summary>
        /// Queries the host for vectorized methods closed over cells of specified parametric type
        /// </summary>
        /// <param name="w">The width to match</param>
        /// <typeparam name="T">The cell type to match</typeparam>
        public MethodInfo[] Vectorized<T>(W128 w)
            where T : unmanaged
                => Hosted.VectorizedDirect<T>(w);

        /// <summary>
        /// Queries the host for vectorized methods closed over cells of specified parametric type
        /// </summary>
        /// <param name="w">The width to match</param>
        /// <typeparam name="T">The cell type to match</typeparam>
        public MethodInfo[] Vectorized<T>(W256 w)
            where T : unmanaged
                => Hosted.VectorizedDirect<T>(w);

        /// <summary>
        /// Queries the host for vectorized methods closed over cells of specified parametric type
        /// </summary>
        /// <param name="w">The width to match</param>
        /// <typeparam name="T">The cell type to match</typeparam>
        public MethodInfo[] Vectorized<T>(W512 w)
            where T : unmanaged
                => Hosted.VectorizedDirect<T>(w);

        /// <summary>
        /// Queries the host for vectorized methods closed over cells of specified parametric type and that have a specified name
        /// </summary>
        /// <param name="w">The width to match</param>
        /// <param name="name">The name to match</param>
        /// <typeparam name="T">The cell type to match</typeparam>
        public MethodInfo[] Vectorized<T>(W128 w, string name)
            where T : unmanaged
                => Vectorized<T>(w).WithName(name);

        /// <summary>
        /// Queries the host for vectorized methods closed over cells of specified parametric type and that have a specified name
        /// </summary>
        /// <param name="w">The width to match</param>
        /// <param name="name">The name to match</param>
        /// <typeparam name="T">The cell type to match</typeparam>
        public MethodInfo[] Vectorized<T>(W256 w, string name)
            where T : unmanaged
                => Vectorized<T>(w).WithName(name);

        /// <summary>
        /// Queries the host for vectorized methods closed over cells of specified parametric type and that have a specified name
        /// </summary>
        /// <param name="w">The width to match</param>
        /// <param name="name">The name to match</param>
        /// <typeparam name="T">The cell type to match</typeparam>
        public MethodInfo[] Vectorized<T>(W512 w, string name)
            where T : unmanaged
                => Vectorized<T>(w).WithName(name);
    }
}