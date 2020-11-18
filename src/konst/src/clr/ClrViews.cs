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
    using static ReflectionFlags;

    /// <summary>
    /// Defines the primary interface for clr artifact interrogation
    /// </summary>
    [ApiHost("reflex.views")]
    public readonly partial struct ClrViews
    {
        static FieldView field => default;

        static MethodView method => default;

        static TypeView type => default;

        static ModuleView module => default;

        [MethodImpl(Inline), Op]
        public static ModuleView vManifest(Assembly src)
            => view(src.ManifestModule);

        /// <summary>
        /// Defines a <see cref='ModuleView'/> over the source
        /// </summary>
        /// <param name="src">The source module</param>
        [MethodImpl(Inline), Op]
        public static ModuleView view(Module src)
            => src;

        /// <summary>
        /// Defines a <see cref='MethodView'/> over the source
        /// </summary>
        /// <param name="src">The source module</param>
        [MethodImpl(Inline), Op]
        public static MethodView view(MethodInfo src)
            => src;

        /// <summary>
        /// Defines a <see cref='FieldView'/> over the source
        /// </summary>
        /// <param name="src">The source module</param>
        [MethodImpl(Inline), Op]
        public static FieldView view(FieldInfo src)
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
        public static ReadOnlySpan<ModuleView> vModules(Assembly src)
            => View(ClrQuery.modules(src), module);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<TypeView> vTypes(Assembly src)
            => View(src.Types(), type);

        [MethodImpl(Inline), Op]
        static ReadOnlySpan<V> View<S,V>(S[] src, V v = default)
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

        public static void EmitTypes(IWfShell wf, Assembly src, FS.FilePath dst)
        {
            var types = sTypes(src);
            var count = types.Length;
            if(count != 0)
            {
                using var writer = dst.Writer();
                ref readonly var lead = ref types.First;
                for(var i=0; i<count; i++)
                {
                    ref readonly var type = ref skip(lead,i);
                    writer.WriteLine(string.Format("{0,-16} | {1}", type.Key, type.Name));
                }
            }
        }
    }
}