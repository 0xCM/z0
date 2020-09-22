//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Buffers;
    using System.Reflection;
    using static System.Runtime.InteropServices.MemoryMarshal;

    using static Konst;
    using static z;

    using S = System;
    using R = System.Reflection;
    using F = ReflectionFlags;

    [ApiHost]
    public readonly partial struct ClrArtifacts
    {
        [MethodImpl(Inline), Op]
        public static ArtifactToken<ClrArtifactKind,ApiArtifactKey> identify(FieldInfo src)
            => (ClrArtifactKind.Field, src.MetadataToken);

        [MethodImpl(Inline)]
        static ReadOnlySpan<T> recover<S,T>(ReadOnlySpan<S> src)
            => CreateReadOnlySpan(ref @as<S,T>(first(src)), (int)((src.Length * size<S>())/size<T>()));

        [MethodImpl(Inline), Op]
        public static ClrArtifactSet<TypeView> types(R.Assembly src)
            => @recover<S.Type,TypeView>(@readonly(src.Types()));

        [MethodImpl(Inline), Op]
        public static ModuleView module(Module src)
            => src;

        [MethodImpl(Inline), Op]
        public static MethodView method(MethodInfo src)
            => src;

        [MethodImpl(Inline), Op]
        public static FieldView field(FieldInfo src)
            => src;

        [MethodImpl(Inline), Op]
        public static ValueParamView field(ParameterInfo src)
            => src;

        [MethodImpl(Inline)]
        public static ClrArtifactRef<A> reference<A>(A src)
            where A : struct, IClrArtifact<A>
                => src;

        [MethodImpl(Inline), Op]
        public static FieldTable table(FieldInfo src)
        {
            var a = field(src);
            var dst = new FieldTable();
            dst.Key = reference(a);
            dst.DeclaringType = a.DeclaringType.Id;
            dst.DataType = a.FieldType.Id;
            dst.Attributes = a.Attributes;
            dst.Address = a.Address;
            dst.IsStatic = a.IsStatic;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ModuleView> modules(Assembly src)
            => src.Modules.Map(module);

        [MethodImpl(Inline), Op]
        public static ModuleView manifest(Assembly src)
            => module(src.ManifestModule);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<FieldView> fields(Type src)
            => @recover<R.FieldInfo, FieldView>(@readonly(src.GetFields(F.BF_All)));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<MethodView> methods(Type src)
            => @recover<R.MethodInfo, MethodView>(@readonly(src.GetMethods(F.BF_All)));

        [MethodImpl(Inline), Op]
        public static string format(in ClrArtifactRef src)
            => text.format(RenderPatterns.PSx3, src.Kind, src.Id, src.Name);
    }
}