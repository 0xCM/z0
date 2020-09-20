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
        /// Defines an <see cref='ArtifactRef'/> predicated on an a <see cref='ArtifactIdentifier'/>
        /// </summary>
        /// <param name="src">The defining type</param>
        [MethodImpl(Inline), Op]
        public static ArtifactRef reference(ArtifactIdentifier src)
            => new ArtifactRef(src);

        /// <summary>
        /// Defines a facet closed over a <see cref='ArtifactIdentifier'/>
        /// </summary>
        /// <param name="src">The source artifact identifier</param>
        /// <param name="dst">The target artifact identifier</param>
        /// <param name="name">The facet name</param>
        /// <param name="value">The facet value</param>
        [MethodImpl(Inline), Op]
        public static ArrowFacet<ArtifactIdentifier> facet(ArtifactIdentifier src, ArtifactIdentifier dst, in asci32 name, in variant value)
            => new ArrowFacet<ArtifactIdentifier>((src,dst), name, value);

        /// <summary>
        /// Defines a facet closed over a <see cref='ArtifactIdentifier'/>
        /// </summary>
        /// <param name="src">The source artifact identifier</param>
        /// <param name="dst">The target artifact identifier</param>
        /// <param name="name">The facet name</param>
        /// <param name="value">The facet value</param>
        [MethodImpl(Inline), Op]
        public static ArrowFacet<ArtifactIdentifier> facet(ArtifactIdentifier src, ArtifactIdentifier dst, string name, in variant value)
            => new ArrowFacet<ArtifactIdentifier>((src,dst), name, value);

        /// <summary>
        /// Defines a facet closed over a <see cref='ArtifactIdentifier'/>
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <typeparam name="A"></typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ArrowFacet<ArtifactIdentifier> facet<A>(ArtifactIdentifier src, ArtifactIdentifier dst, string name, A value)
            where A : unmanaged
                => new ArrowFacet<ArtifactIdentifier>((src,dst), name, Variant.from(value));
    }
}