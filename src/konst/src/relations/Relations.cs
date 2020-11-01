//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.Relations, true)]
    public readonly struct Relations
    {
        [MethodImpl(Inline)]
        public static ArtifactIdentity<K,A> identify<K,A>(K kind, A id)
            where K : unmanaged
            where A : unmanaged
                => (kind, id);

        [MethodImpl(Inline), Op]
        public static ObjectName name(string src)
            => new ObjectName(src);

        [MethodImpl(Inline), Op]
        public static Relation relate(in ObjectName src, in ObjectName dst)
            => new Relation(src,dst);

        [MethodImpl(Inline), Op]
        public static Relation relate(string src, string dst)
            => relate(name(src), name(dst));

        [MethodImpl(Inline), Op]
        public static RelationKey key(in ObjectName id)
            => new RelationKey(id.Surrogate);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static RelationKey<T> key<T>(T src)
            where T : unmanaged
                => new RelationKey<T>(src);

        /// <summary>
        /// Creates a K-indexed bijection
        /// </summary>
        /// <param name="src">The source points</param>
        /// <param name="dst">The target points</param>
        /// <typeparam name="S">The domain type</typeparam>
        /// <typeparam name="T">The range type</typeparam>
        /// <typeparam name="K">The index type</typeparam>
        [MethodImpl(Inline)]
        public Bijection<K,S,T> bijection<S,T,K>(S[] src, T[] dst, K index = default)
            where K : unmanaged
                => new Bijection<K,S,T>(src,dst);

        [MethodImpl(Inline)]
        public Bijection<K,S,T> bijection<S,T,K>(Paired<S,T>[] src, K index = default)
            where K : unmanaged
                => new Bijection<K,S,T>(src);

        [MethodImpl(Inline)]
        internal static void project<S,T>(ReadOnlySpan<S> a, ReadOnlySpan<T> b, Span<Paired<S,T>> dst)
        {
            var count = dst.Length;
            for(var i=0u; i<count; i++)
                seek(dst,i) = paired(skip(a,i), skip(b,i));
        }
    }
}