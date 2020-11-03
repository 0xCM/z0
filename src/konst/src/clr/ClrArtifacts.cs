//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines the primary interface for clr artifact interrogation
    /// </summary>
    [ApiHost(ApiNames.ClrArtifacts, true)]
    public readonly partial struct ClrArtifacts
    {
        /// <summary>
        /// Defines a facet closed over a <see cref='ClrArtifactKey'/>
        /// </summary>
        /// <param name="src">The source artifact identifier</param>
        /// <param name="dst">The target artifact identifier</param>
        /// <param name="name">The facet name</param>
        /// <param name="value">The facet value</param>
        [MethodImpl(Inline), Op]
        public static RelationFacet<ClrArtifactKey> facet(ClrArtifactKey src, ClrArtifactKey dst, in asci32 name, in variant value)
            => new RelationFacet<ClrArtifactKey>((src,dst), name, value);

        /// <summary>
        /// Defines a facet closed over a <see cref='ClrArtifactKey'/>
        /// </summary>
        /// <param name="src">The source artifact identifier</param>
        /// <param name="dst">The target artifact identifier</param>
        /// <param name="name">The facet name</param>
        /// <param name="value">The facet value</param>
        [MethodImpl(Inline), Op]
        public static RelationFacet<ClrArtifactKey> facet(ClrArtifactKey src, ClrArtifactKey dst, string name, in variant value)
            => new RelationFacet<ClrArtifactKey>((src,dst), name, value);

        /// <summary>
        /// Defines a facet closed over a <see cref='ClrArtifactKey'/>
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <typeparam name="A"></typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static RelationFacet<ClrArtifactKey> facet<A>(ClrArtifactKey src, ClrArtifactKey dst, string name, A value)
            where A : unmanaged
                => new RelationFacet<ClrArtifactKey>((src,dst), name, Variant.from(value));

        [MethodImpl(Inline), Op]
        public static ClrTypeCodes TypeCodes()
            => ClrTypeCodes.cached();

        [MethodImpl(Inline), Op]
        public static ClrMemberName name(FieldInfo src)
            => new ClrMemberName(src.Name);

        [MethodImpl(Inline), Op]
        public static ClrMemberName name(PropertyInfo src)
            => new ClrMemberName(src.Name);

        [MethodImpl(Inline), Op]
        public static ClrMemberName name(MethodInfo src)
            => new ClrMemberName(src.Name);

        [MethodImpl(Inline), Op]
        public static ClrMemberName name(EventInfo src)
            => new ClrMemberName(src.Name);

        [MethodImpl(Inline), Op]
        public static ClrTypeName name(Type src)
            => new ClrTypeName(src.AssemblyQualifiedName);
    }
}