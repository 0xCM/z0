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
    public readonly partial struct ClrViews
    {
        static FieldView field => default;

        static MethodView method => default;

        static TypeView type => default;

        static ClrModule module => default;

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
        /// Defines a <see cref='ClrMethod'/> over the source
        /// </summary>
        /// <param name="src">The source module</param>
        [MethodImpl(Inline), Op]
        public static ClrMethod view(MethodInfo src)
            => src;

        /// <summary>
        /// Defines a <see cref='FieldView'/> over the source
        /// </summary>
        /// <param name="src">The source module</param>
        [MethodImpl(Inline), Op]
        public static ClrField view(FieldInfo src)
            => src;

        /// <summary>
        /// Defines a <see cref='ValueParamView'/> over the source
        /// </summary>
        /// <param name="src">The source module</param>

        [MethodImpl(Inline), Op]
        public static ValueParamView view(ParameterInfo src)
            => src;

        [MethodImpl(Inline), Op]
        public static ClrTypeCodes TypeCodes()
            => ClrTypeCodes.cached();

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

        /// <summary>
        /// Queries the host type for a <see cref='ClrInterfaceMap'/>
        /// </summary>
        /// <param name="host"></param>
        /// <param name="contract"></param>
        [MethodImpl(Inline), Op]
        public static ClrInterfaceMap iMap(Type host, Type contract)
            => @as<InterfaceMapping, ClrInterfaceMap>(host.InterfaceMap(contract));

        /// <summary>
        /// Provides a non-allocated <see cref='FieldView'> sequence that covers the fields defined by the source
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<FieldView> vFields(Type src)
            => View(ClrQuery.fields(src), field);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<MethodView> vMethods(Type src)
            => View(methods(src), method);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrModule> vModules(Assembly src)
            => View(src.Modules(), module);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<TypeView> vTypes(Assembly src)
            => View(src.Types(), type);

        [MethodImpl(Inline), Op]
        internal static ReadOnlySpan<V> View<S,V>(S[] src, V v = default)
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