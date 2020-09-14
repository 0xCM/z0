//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Buffers;
    using static System.Runtime.InteropServices.MemoryMarshal;

    using static Konst;
    using static z;

    using S = System;
    using R = System.Reflection;
    using F = ReflectionFlags;

    [ApiHost("artifacts.clr.api")]
    public readonly partial struct ClrArtifacts
    {
        [MethodImpl(Inline)]
        static ReadOnlySpan<T> recover<S,T>(ReadOnlySpan<S> src)
            => CreateReadOnlySpan(ref @as<S,T>(first(src)), (int)((src.Length * size<S>())/size<T>()));

        [MethodImpl(Inline), Op]
        public static Artifacts<Type> types(R.Assembly src)
            => @recover<S.Type,Type>(@readonly(src.Types()));

        [MethodImpl(Inline), Op]
        public static Module module(R.Module src)
            => src;

        [MethodImpl(Inline), Op]
        public static Method method(R.MethodInfo src)
            => src;

        [MethodImpl(Inline), Op]
        public static Field field(R.FieldInfo src)
            => src;

        [MethodImpl(Inline), Op]
        public static ValueParam field(R.ParameterInfo src)
            => src;

        [MethodImpl(Inline)]
        public static ClrArtifactRef<A> reference<A>(A src)
            where A : struct, IClrArtifact<A>
                => src;

        [MethodImpl(Inline), Op]
        public static FieldTable table(R.FieldInfo src)
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
        public static ReadOnlySpan<Module> modules(R.Assembly src)
            => src.Modules.Map(module);

        [MethodImpl(Inline), Op]
        public static Module manifest(R.Assembly src)
            => module(src.ManifestModule);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Field> fields(S.Type src)
            => @recover<R.FieldInfo, Field>(@readonly(src.GetFields(F.BF_All)));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Method> methods(S.Type src)
            => @recover<R.MethodInfo, Method>(@readonly(src.GetMethods(F.BF_All)));

        [MethodImpl(Inline), Op]
        public static string format(in ClrArtifactRef src)
            => text.format(RenderPatterns.PSx3, src.Kind, src.Id, src.Name);
    }
}