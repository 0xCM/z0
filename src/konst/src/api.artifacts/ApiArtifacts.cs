//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct ApiArtifacts
    {
        [MethodImpl(Inline)]
        public static ArtifactToken<K,A> identify<K,A>(K kind, A id)
            where K : unmanaged
            where A : unmanaged
                => (kind, id);

        /// <summary>
        /// Defines a type-identified <see cref='ArtifactRef'/>
        /// </summary>
        /// <param name="src">The defining type</param>
        [MethodImpl(Inline), Op]
        public static ArtifactRef reference(Type src)
            => new ArtifactRef(src);

        /// <summary>
        /// Defines an <see cref='ArtifactRef'/> predicated on an a <see cref='ApiArtifactKey'/>
        /// </summary>
        /// <param name="src">The defining type</param>
        [MethodImpl(Inline), Op]
        public static ArtifactRef reference(ApiArtifactKey src)
            => new ArtifactRef(src);

        /// <summary>
        /// Defines a facet closed over a <see cref='ApiArtifactKey'/>
        /// </summary>
        /// <param name="src">The source artifact identifier</param>
        /// <param name="dst">The target artifact identifier</param>
        /// <param name="name">The facet name</param>
        /// <param name="value">The facet value</param>
        [MethodImpl(Inline), Op]
        public static RelationFacet<ApiArtifactKey> facet(ApiArtifactKey src, ApiArtifactKey dst, in asci32 name, in variant value)
            => new RelationFacet<ApiArtifactKey>((src,dst), name, value);

        /// <summary>
        /// Defines a facet closed over a <see cref='ApiArtifactKey'/>
        /// </summary>
        /// <param name="src">The source artifact identifier</param>
        /// <param name="dst">The target artifact identifier</param>
        /// <param name="name">The facet name</param>
        /// <param name="value">The facet value</param>
        [MethodImpl(Inline), Op]
        public static RelationFacet<ApiArtifactKey> facet(ApiArtifactKey src, ApiArtifactKey dst, string name, in variant value)
            => new RelationFacet<ApiArtifactKey>((src,dst), name, value);

        /// <summary>
        /// Defines a facet closed over a <see cref='ApiArtifactKey'/>
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <typeparam name="A"></typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static RelationFacet<ApiArtifactKey> facet<A>(ApiArtifactKey src, ApiArtifactKey dst, string name, A value)
            where A : unmanaged
                => new RelationFacet<ApiArtifactKey>((src,dst), name, Variant.from(value));
    }
}