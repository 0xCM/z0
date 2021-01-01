//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    using static memory;
    using static ReflectionFlags;

    /// <summary>
    /// Defines the primary interface for clr artifact interrogation
    /// </summary>
    [ApiHost]
    readonly partial struct ClrViews
    {
        public static ClrField field => default;

        public static ClrMethod method => default;

        public static ClrType type => default;

        public static ClrModule module => default;

        [MethodImpl(Inline), Op]
        public static ClrModule vManifest(Assembly src)
            => view(src.ManifestModule);

        /// <summary>
        /// Defines a reference to an artifact of parametric type
        /// </summary>
        /// <param name="src">The source artifact</param>
        /// <typeparam name="A">The artifact type</typeparam>
        [MethodImpl(Inline)]
        public static ClrArtifactRef<A> reference<A>(A src)
            where A : struct, IClrArtifact<A>
                => src;

        /// <summary>
        /// Defines an <see cref='CliArtfactRef'/> predicated on an a <see cref='ClrToken'/>
        /// </summary>
        /// <param name="src">The defining type</param>
        [MethodImpl(Inline), Op]
        public static ClrArtifactRef reference(ClrToken id, ClrArtifactKind kind, StringRef name)
            => new ClrArtifactRef(id,kind,name);

        /// <summary>
        /// Defines a <see cref='ClrModule'/> over the source
        /// </summary>
        /// <param name="src">The source module</param>
        [MethodImpl(Inline), Op]
        public static ClrModule view(Module src)
            => src;

        /// <summary>
        /// Defines a <see cref='ClrField'/> over the source
        /// </summary>
        /// <param name="src">The source module</param>
        [MethodImpl(Inline), Op]
        public static ClrField view(FieldInfo src)
            => src;

        [MethodImpl(Inline), Op]
        public static MethodInfo[] methods(Type src)
            => src.GetMethods(BF_All);

        /// <summary>
        /// Returns a filtered <see cref='Type'/> array of the nested types defined by the source
        /// </summary>
        /// <param name="src">The source types</param>
        /// <param name="filter">The filter to apply</param>
        [MethodImpl(Inline), Op]
        public static Type[] nested(Type src, ClrQuerySpec filter)
            => src.GetNestedTypes((BindingFlags)filter);

        /// <summary>
        /// Returns an unfiltered <see cref='TypeType'/> view of the nested types defined by the source
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<TypeView> vNested(Type src)
            => memory.recover<Type,TypeView>(@readonly(src.GetNestedTypes(BF_All)));

        [MethodImpl(Inline), Op]
        public static ClrArtifactSet<TypeView> sTypes(Assembly src)
            => memory.recover<Type,TypeView>(@readonly(src.Types()));



        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<V> view<S,V>(S[] src, V v = default)
            => memory.recover<S,V>(@readonly(src));

        [MethodImpl(Inline)]
        public static void EmitArtifacts<A>(ClrArtifactSet<A> src, FS.FilePath dst)
            where A : struct, IClrArtifact<A>
        {
            if(src.IsNonEmpty)
            {
                using var writer = dst.Writer();
                var count = src.Length;
                ref readonly var lead = ref src.First;
                for(var i=0u; i<count; i++)
                    writer.WriteLine(skip(lead, i));
            }
        }
    }
}