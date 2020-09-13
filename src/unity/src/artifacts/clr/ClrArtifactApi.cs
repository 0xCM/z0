//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static System.Runtime.InteropServices.MemoryMarshal;

    using static Konst;
    using static z;

    using A = ClrArtifacts;
    using S = System;
    using R = System.Reflection;
    using F = ReflectionFlags;

    [ApiHost("artifacts.clr.api")]
    public readonly struct ClrArtifactApi
    {
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> recover<S,T>(ReadOnlySpan<S> src)
            => CreateReadOnlySpan(ref @as<S,T>(first(src)), (int)((src.Length * size<S>())/size<T>()));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<A.Type> types(R.Assembly src)
            => @recover<S.Type,A.Type>(@readonly(src.Types()));

        [MethodImpl(Inline), Op]
        public static A.Module module(R.Module src)
            => src;

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<A.Module> modules(R.Assembly src)
            => src.Modules.Map(module);

        [MethodImpl(Inline), Op]
        public static A.Module manifest(R.Assembly src)
            => module(src.ManifestModule);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<A.Field> fields(S.Type src)
            => @recover<R.FieldInfo, A.Field>(@readonly(src.GetFields(F.BF_All)));
    }
}