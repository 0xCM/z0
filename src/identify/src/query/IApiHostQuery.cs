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

    public interface IApiHostQuery : IService
    {
        IApiHost Host {get;}

        /// <summary>
        /// All hosted methods
        /// </summary>
        MethodInfo[] Hosted 
            => Host.HostedMethods;

        /// <summary>
        /// All hosted generic methods
        /// </summary>
        MethodInfo[] Generic
            => Hosted.OpenGeneric();
               
        /// <summary>
        /// All hosted non-generic methods
        /// </summary>
        MethodInfo[] Direct
            => Hosted.NonGeneric();

        /// <summary>
        /// Queries the host for operations of specified kind
        /// </summary>
        /// <param name="k">The kind classifier</param>
        /// <typeparam name="K">The kind type</typeparam>
        MethodInfo[] OfKind<K>(K k)
            where K : unmanaged, Enum
                => (from m in Hosted.Tagged(typeof(OpKindAttribute))
                let a = m.Tag<OpKindAttribute>().Require()
                where a.KindId.ToString() == k.ToString()
                    select m).Array();

        /// <summary>
        /// Queries the host for genric operations of specified kind
        /// </summary>
        /// <param name="k">The kind classifier</param>
        /// <typeparam name="K">The kind type</typeparam>
        MethodInfo[] OfKind<K>(K k, GenericPartition g)
            where K : unmanaged, Enum
                => OfKind(k).MemberOf(g).Array();

        /// <summary>
        /// Queries the host for binary operators belonging to a specifed generic partition
        /// </summary>
        /// <param name="g">The generic partition</param>
        MethodInfo[] UnaryOps(GenericPartition g = default)
            => Hosted.MemberOf(g).UnaryOperators();

        /// <summary>
        /// Queries the host for binary operators belonging to a specifed generic partition
        /// </summary>
        /// <param name="g">The generic partition</param>
        MethodInfo[] BinaryOps(GenericPartition g = default)
            => Hosted.MemberOf(g).BinaryOperators();

        /// <summary>
        /// Queries the host for binary operators belonging to a specifed generic partition
        /// </summary>
        /// <param name="g">The generic partition</param>
        MethodInfo[] TernaryOps(GenericPartition g = default)
            => Hosted.MemberOf(g).TernaryOperators();

        /// <summary>
        /// Queries the host for operations vectorized over 128-bit vectors
        /// </summary>
        /// <param name="w">The vector width</param>
        /// <param name="generic">Whether generic or non-generc methods should be selected</param>
        MethodInfo[] Vectorized(W128 w, GenericPartition g = default)
            => g.IsGeneric() ? Hosted.VectorizedGeneric(w) : Hosted.VectorizedDirect(w);

        /// <summary>
        /// Queries the host for operations vectorized over 128-bit vectors
        /// </summary>
        /// <param name="w">The vector width</param>
        /// <param name="generic">Whether generic or non-generc methods should be selected</param>
        MethodInfo[] Vectorized(W256 w, GenericPartition g = default)
            => g.IsGeneric() ? Hosted.VectorizedGeneric(w) : Hosted.VectorizedDirect(w);

        /// <summary>
        /// Queries the host for vectorized methods of specified vector width, name and generic partition
        /// </summary>
        /// <param name="w">The width to match</param>
        /// <param name="name">The name to match</param>
        /// <param name="g">The generic parition to consider</param>
        MethodInfo[] Vectorized(W128 w, string name, GenericPartition g = default)
            => Hosted.Vectorized(w,name,g);

        /// <summary>
        /// Queries the host for vectorized methods of specified vector width, name and generic partition
        /// </summary>
        /// <param name="w">The width to match</param>
        /// <param name="name">The name to match</param>
        /// <param name="g">The generic parition to consider</param>
        MethodInfo[] Vectorized(W256 w, string name, GenericPartition g = default)
            => Hosted.Vectorized(w,name,g);

        /// <summary>
        /// Queries the host for vectorized methods of specified vector width, name and generic partition
        /// </summary>
        /// <param name="w">The width to match</param>
        /// <param name="name">The name to match</param>
        /// <param name="g">The generic parition to consider</param>
        MethodInfo[] Vectorized(W512 w, string name, GenericPartition g = default)
            => Hosted.Vectorized(w,name,g);

        MethodInfo[] OfKind<K>(W128 w, K kind, GenericPartition g = default)
            where K : unmanaged, Enum
                => OfKind(kind,g).VectorizedDirect(w);

        MethodInfo[] OfKind<K>(W256 w, K kind, GenericPartition g = default)
            where K : unmanaged, Enum
                => OfKind(kind,g).VectorizedDirect(w);

        /// <summary>
        /// Queries the host for vectorized methods closed over cells of specified parametric type
        /// </summary>
        /// <param name="w">The width to match</param>
        /// <typeparam name="T">The cell type to match</typeparam>
        MethodInfo[] Vectorized<T>(W128 w)
            where T : unmanaged
                => Hosted.VectorizedDirect<T>(w);

        /// <summary>
        /// Queries the host for vectorized methods closed over cells of specified parametric type
        /// </summary>
        /// <param name="w">The width to match</param>
        /// <typeparam name="T">The cell type to match</typeparam>
        MethodInfo[] Vectorized<T>(W256 w)
            where T : unmanaged
                => Hosted.VectorizedDirect<T>(w);

        /// <summary>
        /// Queries the host for vectorized methods closed over cells of specified parametric type
        /// </summary>
        /// <param name="w">The width to match</param>
        /// <typeparam name="T">The cell type to match</typeparam>
        MethodInfo[] Vectorized<T>(W512 w)
            where T : unmanaged
                => Hosted.VectorizedDirect<T>(w);

        /// <summary>
        /// Queries the host for vectorized methods closed over cells of specified parametric type and that have a specified name
        /// </summary>
        /// <param name="w">The width to match</param>
        /// <param name="name">The name to match</param>
        /// <typeparam name="T">The cell type to match</typeparam>
        MethodInfo[] Vectorized<T>(W128 w, string name)
            where T : unmanaged
                => Vectorized<T>(w).WithName(name);

        /// <summary>
        /// Queries the host for vectorized methods closed over cells of specified parametric type and that have a specified name
        /// </summary>
        /// <param name="w">The width to match</param>
        /// <param name="name">The name to match</param>
        /// <typeparam name="T">The cell type to match</typeparam>
        MethodInfo[] Vectorized<T>(W256 w, string name)
            where T : unmanaged
                => Vectorized<T>(w).WithName(name);

        /// <summary>
        /// Queries the host for vectorized methods closed over cells of specified parametric type and that have a specified name
        /// </summary>
        /// <param name="w">The width to match</param>
        /// <param name="name">The name to match</param>
        /// <typeparam name="T">The cell type to match</typeparam>
        MethodInfo[] Vectorized<T>(W512 w, string name)
            where T : unmanaged
                => Vectorized<T>(w).WithName(name);
    }

    public interface IApiHostQuery<H> : IApiHostQuery
        where H : IApiHost<H>, new()
    {
        /// <summary>
        /// The interrogation subject
        /// </summary>
        new H Host  => new H();

        IApiHost IApiHostQuery.Host => Host;
    }
}