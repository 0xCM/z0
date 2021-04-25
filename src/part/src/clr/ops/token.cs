//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static Root;

    partial struct Clr
    {
        [MethodImpl(Inline), Op]
        public static ClrToken token(Handle handle)
            => MetadataTokens.GetToken(handle);

        [MethodImpl(Inline), Op]
        public static ClrToken token(EntityHandle handle)
            => MetadataTokens.GetToken(handle);

        [MethodImpl(Inline), Op]
        public static ClrToken token(TableIndex table, uint row)
            => new ClrToken(((uint)table << 24) | (0xFFFFFF &  row));

        [MethodImpl(Inline), Op]
        public static ClrToken token(Type src)
            => new ClrToken(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ClrToken token<T>()
            => new ClrToken(typeof(T));

        [MethodImpl(Inline), Op]
        public static ClrToken token(FieldInfo src)
            => new ClrToken(src);

        [MethodImpl(Inline), Op]
        public static ClrToken token(PropertyInfo src)
            => new ClrToken(src);

        [MethodImpl(Inline), Op]
        public static ClrToken token(MethodInfo src)
            => new ClrToken(src);

        [MethodImpl(Inline), Op]
        public static ClrToken token(ParameterInfo src)
            => new ClrToken(src);

        [MethodImpl(Inline), Op]
        public static ClrToken token(Assembly src)
            => new ClrToken(src);

        [MethodImpl(Inline), Op]
        public static string @string(Module module, ClrToken token)
            => module.ResolveString((int)token);

        [MethodImpl(Inline), Op]
        public static BinaryCode sig(Module src, ClrToken token)
            => src.ResolveSignature((int)token);

        [MethodImpl(Inline), Op]
        public static MethodBase method(Module src, ClrToken token)
            => src.ResolveMethod((int)token);

        [MethodImpl(Inline), Op]
        public static MemberInfo member(Module src, ClrToken token)
            => src.ResolveMember((int)token);

        [MethodImpl(Inline), Op]
        public static FieldInfo field(Module src, ClrToken token)
            => src.ResolveField((int)token);

        [MethodImpl(Inline), Op]
        public static Type type(Module src, ClrToken token)
            => src.ResolveType((int)token);
    }
}